using System;
using System.Collections.Generic;
using System.Text;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initBook
    {
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions
            , string strBranchCode
            ,string strWarehouseCode,string SectionCode , string VatTypeCode)
        {
            bool bHasData = false;
            try
            {
                List<docType> docTypes = context.docType.Where(c => string.IsNullOrEmpty(c.Formula) == false).OrderBy(c => c.Formula).ToList();
                foreach (docType oDocType in docTypes)
                {
                    book RBook = context.book.Where(c => c.branchCode == strBranchCode && c.docTypeCode == oDocType.Code).FirstOrDefault();
                    if (RBook != null) { continue; }
                    book QBook = new book() { code = "001"
                        , docTypeCode = oDocType.Code
                        , CorpCode = initCompany.gstrDefaultCorpCode
                        , branchCode = strBranchCode
                        , name = oDocType.Name
                        , name2 = oDocType.Name2
                        ,prefixRunNo = ""
                        ,yearRunNo = "en-US",
                        docFormatRunNo = "yyMM",
                        doclenRunNo = 5
                        ,docStartRunNo = ""
                        ,warehouseCode = strWarehouseCode
                        ,sectionCode = SectionCode
                        ,vatTypeCode= VatTypeCode
                        , CreateAtUtc = DateTime.UtcNow 
                        , UpdateAtUtc = DateTime.UtcNow 
                        , CreateBy = "System" };
                    context.Add(QBook);
                    bHasData = true;
                }
                if (bHasData)
                {
                   context.SaveChanges();
                }
            }
            catch (Exception) { }
            finally {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
