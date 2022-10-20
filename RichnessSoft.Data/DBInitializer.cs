using RichnessSoft.Entity.Class;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class DBinitializer
    {
        private static Stopwatch stopwatch;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {

            try
            {
                stopwatch = new Stopwatch();
                stopwatch.Start();
                context.Database.EnsureCreated();
                contextlog.Database.EnsureCreated();
                if (context.company.Any())
                {
                    return; //if user is not empty, DB has been seed
                }
                initUser.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initMenu.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initDocType.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initSubDisrict.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initDisrict.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initProvince.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initCountry.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initCompany.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initBranch.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                
                initSection.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initDepartment.InitializeAsync(context, contextlog, superAdminDefaultOptions, initSection.gstrSectDefaultCode);
                initplans.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initProject.InitializeAsync(context, contextlog, superAdminDefaultOptions, initplans.gstrplansDefaultCode);
                initUnit.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initProductGrp.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initProductType.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initProduct.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initProductSet.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initService.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initAccBook.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initAccChart.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initAccRole.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initSaleMan.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initSaleTeam.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initWarehouseType.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initWarehouse.InitializeAsync(context, contextlog, superAdminDefaultOptions, initWarehouseType.gstrWarehouseType_Purchase);
                initShelf.InitializeAsync(context, contextlog, superAdminDefaultOptions, initWarehouse.gstrWarehouseMainCode);
                initBook.InitializeAsync(context, contextlog, superAdminDefaultOptions, initBranch.gstrBranchCode,initWarehouse.gstrWarehouseMainCode,initSection.gstrSectDefaultCode,initVAT.gstrVAT_1);

                initCustGrp.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initCustomer.InitializeAsync(context, contextlog, superAdminDefaultOptions, initCustGrp.gstrCustGrpCode);
                initVendorGrp.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initVendor.InitializeAsync(context, contextlog, superAdminDefaultOptions, initVendorGrp.gstrVendorGrpCode);
                initColor.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initSize.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initModel.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initBrand.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initSaleArea.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initSegmentation.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initVAT.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initCategory.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initFormat.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initDesign.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initGrade.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initWeight.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initShhipping.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initMOP.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initBank.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initCurrency.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initMember.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                InitPayType.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                InitDescription.InitializeAsync(context, contextlog, superAdminDefaultOptions);
                initSysOption.InitializeAsync(context, contextlog, superAdminDefaultOptions);

                if (stopwatch is not null)
                {
                    stopwatch.Stop();
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Generated Database Elapsed : " + stopwatch.Elapsed);
                    Console.WriteLine("-----------------");
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("SQL Error : " + e.Message);
                Console.WriteLine("-----------------");
            }
            catch (Exception ex2)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Error : " + ex2.Message);
                Console.WriteLine("-----------------");
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
