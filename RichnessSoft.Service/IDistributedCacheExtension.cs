using Hyperion;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service
{
    public static class IDistributedCacheExtension
    {
        public static async Task SetObjectAsync<T>(this IDistributedCache cache, string id, T value, double lifespan = 14400, bool sliding = false) where T : class
        {
            // Serialization
            var serializer = new Serializer(new SerializerOptions(preserveObjectReferences: true));
            await using var mem = new MemoryStream();
            serializer.Serialize(value, mem);
            var toWrite = mem.ToArray();
            // Caching
            if (sliding)
            {
                await cache.SetAsync(id, toWrite, new DistributedCacheEntryOptions()
                {
                    SlidingExpiration = System.TimeSpan.FromSeconds(lifespan)
                });
            }
            else
            {
                await cache.SetAsync(id, toWrite, new DistributedCacheEntryOptions()
                {
                    AbsoluteExpirationRelativeToNow = System.TimeSpan.FromSeconds(lifespan)
                });
            }
        }
        public static void SetObject<T>(this IDistributedCache cache, string id, T value, double lifespan = 14400, bool sliding = false) where T : class
        {
            // Serialization
            var serializer = new Serializer(new SerializerOptions(preserveObjectReferences: true));
            using var mem = new MemoryStream();
            serializer.Serialize(value, mem);
            var toWrite = mem.ToArray();
            // Caching
            if (sliding)
            {
                cache.Set(id, toWrite, new DistributedCacheEntryOptions()
                {
                    SlidingExpiration = System.TimeSpan.FromSeconds(lifespan)
                });
            }
            else
            {
                cache.Set(id, toWrite, new DistributedCacheEntryOptions()
                {
                    AbsoluteExpirationRelativeToNow = System.TimeSpan.FromSeconds(lifespan)
                });
            }
        }

        public static async Task<T> GetObjectAsync<T>(this IDistributedCache cache, string id) where T : class
        {
            var bytes = await cache.GetAsync(id);
            if (bytes == null) return default(T);
            var serializer = new Serializer(new SerializerOptions(preserveObjectReferences: true));
            await using var mem = new MemoryStream(bytes);
            var value = serializer.Deserialize<T>(mem);
            return value;
        }
        public static T GetObject<T>(this IDistributedCache cache, string id) where T : class
        {
            var bytes = cache.Get(id);
            if (bytes == null) return default(T);
            var serializer = new Serializer(new SerializerOptions(preserveObjectReferences: true));
            using var mem = new MemoryStream(bytes);
            var value = serializer.Deserialize<T>(mem);
            return value;
        }

        public static async Task RemoveAsync(this IDistributedCache cache, string id)
        {
            await cache.RemoveAsync(id);
        }
        public static void Remove(this IDistributedCache cache, string id)
        {
            cache.Remove(id);
        }
    }
}
