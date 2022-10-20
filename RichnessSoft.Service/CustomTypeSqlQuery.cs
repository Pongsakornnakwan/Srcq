using AutoMapper;
using AutoMapper.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service
{
    public class CustomTypeSqlQuery<T> where T : class
    {
        private IMapper _mapper;
        public DatabaseFacade DatabaseFacade { get; set; }
        public string SQLQuery { get; set; }
        public DbParameter[] aDbParameter { get; set; }

        public CustomTypeSqlQuery()
        {
            _mapper = new MapperConfiguration(cfg => {
                cfg.AddDataReaderMapping();
                cfg.CreateMap<IDataRecord, T>();
            }).CreateMapper();
        }

        public IList<T> ToList()
        {
            IList<T> results = new List<T>();
            var conn = DatabaseFacade.GetDbConnection();

            try
            {
                //await conn.OpenAsync();
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = SQLQuery;
                    command.Parameters.Clear();
                    if (aDbParameter != null && aDbParameter.Length > 0)
                    {
                        //command.Parameters.AddRange(aDbParameter);
                        foreach (DbParameter parameter in aDbParameter)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    DbDataReader reader;
                    try
                    {
                        reader = command.ExecuteReader();

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    if (reader.HasRows)
                        results = _mapper.Map<IDataReader, IEnumerable<T>>(reader)
                                         .ToList();
                    reader.Dispose();
                }
            }
            catch (Exception e)
            {
                var oEx = e;
            }
            finally
            {
                conn.Close();
            }
            return results;
        }

        public async Task<IList<T>> ToListAsync()
        {
            IList<T> results = new List<T>();
            var conn = DatabaseFacade.GetDbConnection();
            try
            {
                await conn.OpenAsync();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = SQLQuery;
                    if (aDbParameter != null && aDbParameter.Length > 0)
                    {
                        command.Parameters.AddRange(aDbParameter);
                    }
                    DbDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                        results = _mapper.Map<IDataReader, IEnumerable<T>>(reader)
                                         .ToList();
                    reader.Dispose();
                }
            }
            finally
            {
                conn.Close();
            }
            return results;
        }

        public T FirstOrDefault()
        {
            T result = null;
            var conn = DatabaseFacade.GetDbConnection();
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = SQLQuery;
                    command.Parameters.Clear();
                    if (aDbParameter != null && aDbParameter.Length > 0)
                    {
                        foreach (var item in aDbParameter)
                        {
                            var parameter = command.CreateParameter();
                            parameter.ParameterName = item.ParameterName;
                            parameter.Value = item.Value;
                            parameter.DbType = item.DbType;
                            command.Parameters.Add(parameter);
                        }
                    }
                    DbDataReader reader;
                    try
                    {
                        reader = command.ExecuteReader();
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                    if (reader.HasRows)
                    {
                        var results = _mapper.Map<IDataReader, IEnumerable<T>>(reader)
                                             .ToList();
                        result = results.FirstOrDefault();
                    }
                    reader.Dispose();
                }
            }
            catch (Exception e)
            {
                var xx = e;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public async Task<T> FirstOrDefaultAsync()
        {
            T result = null;
            var conn = DatabaseFacade.GetDbConnection();
            try
            {
                await conn.OpenAsync();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = SQLQuery;
                    if (aDbParameter != null && aDbParameter.Length > 0)
                    {
                        command.Parameters.AddRange(aDbParameter);
                    }
                    DbDataReader reader = await command.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        var results = _mapper.Map<IDataReader, IEnumerable<T>>(reader)
                                             .ToList();
                        result = results.FirstOrDefault();
                    }
                    reader.Dispose();
                }
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
