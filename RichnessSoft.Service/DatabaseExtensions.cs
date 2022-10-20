using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service
{
    public static class DatabaseExtensions
    {
        public static CustomTypeSqlQuery<T> SqlQuery<T>(
               this DatabaseFacade database,
               string sqlQuery, params DbParameter[] aDbParameter) where T : class
        {
            return new CustomTypeSqlQuery<T>()
            {
                DatabaseFacade = database,
                SQLQuery = sqlQuery,
                aDbParameter = aDbParameter
            };
        }
    }
}
