using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.initData
{
    public static class initUser
    {
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            User profile = new User();
            profile.firstname = superAdminDefaultOptions.UserName;
            profile.lastname = superAdminDefaultOptions.UserName;
            profile.username = superAdminDefaultOptions.UserName;
            profile.email = superAdminDefaultOptions.Email;
            profile.password = CommonFunc.EncryptData(superAdminDefaultOptions.Password);
            try
            {
                context.Add(profile);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($" exception : {ex}");
            }

        }
    }
}
