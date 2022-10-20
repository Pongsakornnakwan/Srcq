using System;
using System.Collections.Generic;
using System.Text;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System.Linq;
using RichnessSoft.Common;
using System.Threading.Tasks;

namespace RichnessSoft.Data
{
    public static class initUser
    {
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            user profile = new user();
            profile.firstName = superAdminDefaultOptions.UserName;
            profile.lastName = superAdminDefaultOptions.UserName;
            profile.userName = superAdminDefaultOptions.UserName;
            profile.email = superAdminDefaultOptions.Email;
            profile.password = CommonFunc.EncryptData(superAdminDefaultOptions.Password);
            try
            {
                context.Add(profile);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Exception : {ex}");
            }
            
        }
    }
}
