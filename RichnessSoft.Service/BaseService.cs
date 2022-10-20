using Hyperion.Internal;
using RichnessSoft.Common;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RichnessSoft.Service
{
    public class BaseService
    {
        public void AddLog<T>(T NewData)
        {
            using(RichnessLogDbContext db = new RichnessLogDbContext())
            {
                string jData = JsonSerializer.Serialize(NewData);
                Erp_Log erp_Log = new Erp_Log();
                erp_Log.data_new = jData;
                erp_Log.logtype = gbVar.ModeInsert;
                erp_Log.updateatutc = DateTime.Now;
                erp_Log.createatutc = DateTime.Now;
                try
                {
                    erp_Log.user_code = GetPropValue(NewData, "createby").ToString();
                    erp_Log.doc_no = GetPropValue(NewData, "code").ToString();
                    erp_Log.companyid = Convert.ToInt32(GetPropValue(NewData, "companyid").ToString());
                    erp_Log.value_id = Convert.ToInt32(GetPropValue(NewData, "id").ToString());
                }
                catch (Exception)
                {}
                db.Set<Erp_Log>().Add(erp_Log);
                db.SaveChanges();
            }
        }

        public void DeleteLog<T>(T NewData)
        {
            using (RichnessLogDbContext db = new RichnessLogDbContext())
            {
                string jData = JsonSerializer.Serialize(NewData);
                Erp_Log erp_Log = new Erp_Log();
                erp_Log.data_new = jData;
                erp_Log.logtype = gbVar.ModeDelete;
                erp_Log.updateatutc = DateTime.UtcNow;
                try
                {
                    erp_Log.user_code = GetPropValue(NewData, "createby").ToString();
                    erp_Log.doc_no = GetPropValue(NewData, "code").ToString();
                    erp_Log.companyid = Convert.ToInt32(GetPropValue(NewData, "companyid").ToString());
                    erp_Log.value_id = Convert.ToInt32(GetPropValue(NewData, "id").ToString());
                    erp_Log.doc_date = Convert.ToDateTime(GetPropValue(NewData, "docdate").ToString());
                    erp_Log.old_doc_date = erp_Log.doc_date;

                }
                catch (Exception)
                { }
                db.Set<Erp_Log>().Add(erp_Log);
                db.SaveChanges();
            }
        }

        public void UpdateLog<T>(T Old_data, T NewData)
        {
            using (RichnessLogDbContext db = new RichnessLogDbContext())
            {
                string jOldData = JsonSerializer.Serialize(Old_data);
                string jnewData = JsonSerializer.Serialize(NewData);
                Erp_Log erp_Log = new Erp_Log();
                erp_Log.data_old = jOldData;
                erp_Log.data_new = jnewData;
                erp_Log.logtype = gbVar.ModeEdit;
                erp_Log.updateatutc = DateTime.Now;
                try
                {
                    erp_Log.user_code = GetPropValue(NewData, "updateby")?.ToString() ??"";
                    erp_Log.doc_no = GetPropValue(NewData, "code")?.ToString();
                    erp_Log.old_doc_no = GetPropValue(Old_data, "code")?.ToString();
                    erp_Log.companyid = Convert.ToInt32(GetPropValue(NewData, "companyid")?.ToString());
                    erp_Log.value_id = Convert.ToInt32(GetPropValue(NewData, "id")?.ToString());
                    erp_Log.doc_date = Convert.ToDateTime(GetPropValue(NewData, "docdate")?.ToString());
                    erp_Log.old_doc_date = Convert.ToDateTime(GetPropValue(Old_data, "docdate")?.ToString());
                }
                catch (Exception)
                { }
                db.Set<Erp_Log>().Add(erp_Log);
                db.SaveChanges();
            }
        }

        public object GetPropValue(object src, string propName)
        {
            object r =new object();
            try
            {
                r = src.GetType().GetProperty(propName).GetValue(src, null) ?? null;
            }
            catch (Exception)
            { }
            return r; 
        }
    }
}
