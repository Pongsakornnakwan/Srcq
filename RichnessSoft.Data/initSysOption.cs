using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Data
{
    public static class initSysOption
    {

        /// <summary>
        /// ไม่ระบุ
        /// </summary>
        public const string gstrGradeDefaultCode = "00";
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            sysOption s = new sysOption();
            s.code = "01";
            s.companyCode = initCompany.gstrDefaultCorpCode;
            s.branchCode = "01";
            s.StartAccountDate = new DateTime(DateTime.Now.Year, 1, 1);
            s.EndAccountDate = new DateTime(DateTime.Now.Year, 12, 31);
            s.CarryingAmountDate = (new DateTime(DateTime.Now.Year, 1, 1)).AddDays(-1);
            s.StartSystemDate = new DateTime(DateTime.Now.Year, 1, 1);
            s.PostAccount = "A";
            s.VatType = "1";
            s.VatInOut = "O";
            s.TaxApproveNo = "";
            s.TaxApproveDate = null;
            s.TaxPayName = "";
            s.TaxPayPosition = "";
            s.InputItemQty = 14;
            s.InputItemQtyDecimal = 2;
            s.InputPrice = 14;
            s.InputPriceDecimal = 2;
            s.InputItemAmt = 14;
            s.InputItemAmtDecimal = 2;
            s.InputVat = 14;
            s.InputVatDecimal = 2;
            s.ReportItemQty = 14;
            s.ReportItemQtyDecimal = 2;
            s.ReportPrice = 14;
            s.ReportPriceDecimal = 2;
            s.ReportItemAmt = 14;
            s.ReportItemAmtDecimal = 2;
            s.ReportVat = 14;
            s.ReportVatDecimal = 2;
            s.SectionCode = initSection.gstrSectDefaultCode;
            s.ProjectCode = initProject.gstrProjDefaultCode;
            s.BuyWarehouse = initWarehouse.gstrWarehouseMainCode;
            s.SaleWarehouse = initWarehouse.gstrWarehouseMainCode;
            s.RevalueAccountBook = "JV";
            s.AssetAccountBook = "JV";
            s.InsuranAccountBook = "JV";
            s.StockCounting = ConstUtil.STOCK_COUNTING.NEGATIVE;
            s.ControlLot = ConstUtil.CONFIRM.NO;
            s.ControlSerial = ConstUtil.CONFIRM.NO;
            s.FGCost = ConstUtil.COST_TYPE.COST_TYPE_FIFO;
            s.RMCost = ConstUtil.COST_TYPE.COST_TYPE_FIFO;
            s.CSCost = ConstUtil.COST_TYPE.COST_TYPE_FIFO;
            s.FGGLPost = ConstUtil.COST_ACCOUNT.COST_ACCOUNT_PERIODIC;
            s.RMGLPost = ConstUtil.COST_ACCOUNT.COST_ACCOUNT_PERIODIC;
            s.CSGLPost = ConstUtil.COST_ACCOUNT.COST_ACCOUNT_PERIODIC;
            s.SelectBuyPrice = ConstUtil.SELECT_BUY_PRICE.G_SELECT_BUY_DOC_REF;
            s.SelectSalePrice = ConstUtil.SELECT_SALE_PRICE.G_SELECT_SALE_DOC_REF;
            s.CostCNBuy = ConstUtil.COS_CN_BUY_ORDER.GC_IS_BY_CN_INVOICE;
            s.CostCNSale = ConstUtil.COS_CN_BUY_ORDER.GC_IS_BY_CN_INVOICE;
            s.CostProductZero = ConstUtil.COST_QTY_ZERO.GC_USE_COSET_BEFORE_ZERO;
            s.CostCountStockDoc = ConstUtil.COST_QTY_ZERO.GC_USE_COSET_BEFORE_ZERO;
            s.CostReturnWithdraw = ConstUtil.COST_QTY_ZERO.GC_USE_COSET_BEFORE_ZERO;
            s.GLyearMode = ConstUtil.cYearMode.Year_Mode_CE;
            s.GLFormatDoc = ConstUtil.cFormatRunno.G_FORMAT_YYMM;
            s.GLRunDocLen = 5;
            s.GLHeadmessage = "";
            s.DocyearMode = ConstUtil.cYearMode.Year_Mode_CE;
            s.DocFormatDoc = ConstUtil.cFormatRunno.G_FORMAT_YYMM;
            s.DocRunDocLen = 5;
            context.Add(s);
            context.SaveChanges();
        }
    }
}
;