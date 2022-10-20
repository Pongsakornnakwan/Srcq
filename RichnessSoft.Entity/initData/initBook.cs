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
    public static class initBook
    {
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            bool bHasData = false;
            try
            {
                List<DocType> docTypes = context.DocType.OrderBy(c => c.code).ToList();
                foreach (DocType oDocType in docTypes)
                {
                    Book RBook = context.Book.Where(c => c.code == oDocType.code).FirstOrDefault();
                    if (RBook != null) { continue; }
                    Book QBook = new Book()
                    {
                        code = "001"
                        ,doctype = oDocType.code
                        ,companyid = initCompany.companyid
                        ,branchid = initBranch.branchid
                        ,name1 = oDocType.name1
                        ,name2 = oDocType.name2
                        ,prefixrunno = ""
                        ,yearrunno = "en-US"
                        ,docformatrunno = "yyMM"
                        ,doclenrunno = 5
                        ,docstartrunno = 0
                        ,warehouseid = initWarehouse.listData[0].id
                        ,sectionid = initSection.Section.id
                        ,vattype = "1"
                        ,createatutc = DateTime.UtcNow
                        ,updateatutc = DateTime.UtcNow
                        ,createby = "system"
                    };
                    context.Add(QBook);
                    bHasData = true;
                }
                if (bHasData)
                {
                    context.SaveChanges();
                }
            }
            catch (Exception) { }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
