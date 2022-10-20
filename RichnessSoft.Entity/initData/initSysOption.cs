using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RichnessSoft.Entity.initData
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
            SysOption s = new SysOption();
            s.code = "01";
            s.companyid = initCompany.companyid;
            s.branchid = initBranch.branchid;
            s.startaccountdate = new DateTime(DateTime.Now.Year, 1, 1);
            s.endaccountdate = new DateTime(DateTime.Now.Year, 12, 31);
            s.carryingamountdate = (new DateTime(DateTime.Now.Year, 1, 1)).AddDays(-1);
            s.startsystemdate = new DateTime(DateTime.Now.Year, 1, 1);
            s.postaccount = "A";
            s.vattype = "1";
            s.vatisout = "O";
            s.taxapproveno = "";
            s.taxapprovedate = null;
            s.taxpayname = "";
            s.taxpayposition = "";
            s.inputitemqty = 14;
            s.inputitemqtydecimal = 2;
            s.inputprice = 14;
            s.inputpricedecimal = 2;
            s.inputitemamt = 14;
            s.inputitemamtdecimal = 2;
            s.inputvat = 14;
            s.inputvatdecimal = 2;
            s.reportitemqty = 14;
            s.reportitemqtydecimal = 2;
            s.reportprice = 14;
            s.reportpricedecimal = 2;
            s.reportitemamt = 14;
            s.reportitemamtdecimal = 2;
            s.reportvat = 14;
            s.reportvatdecimal = 2;
            s.sectionid = initSection.Section.id;
            s.projectid = initProject.listData[0].id;
            s.buywarehouseid = initWarehouse.listData[0].id;
            s.salewarehouseid = initWarehouse.listData[0].id;
            s.revalueaccountbookid = initAccBook.listData[0].id;
            s.assetaccountbookid = initAccBook.listData[0].id;
            s.insuranaccountbookid = initAccBook.listData[0].id;
            s.stockcounting = ConstUtil.STOCK_COUNTING.NEGATIVE;
            s.controllot = ConstUtil.CONFIRM.NO;
            s.controlserial = ConstUtil.CONFIRM.NO;
            s.fgcost = ConstUtil.COST_TYPE.COST_TYPE_FIFO;
            s.rmcost = ConstUtil.COST_TYPE.COST_TYPE_FIFO;
            s.cscost = ConstUtil.COST_TYPE.COST_TYPE_FIFO;
            s.fgglpost = ConstUtil.COST_ACCOUNT.COST_ACCOUNT_PERIODIC;
            s.rmglpost = ConstUtil.COST_ACCOUNT.COST_ACCOUNT_PERIODIC;
            s.csglpost = ConstUtil.COST_ACCOUNT.COST_ACCOUNT_PERIODIC;
            s.selectbuyprice = ConstUtil.SELECT_BUY_PRICE.G_SELECT_BUY_DOC_REF;
            s.selectsaleprice = ConstUtil.SELECT_SALE_PRICE.G_SELECT_SALE_DOC_REF;
            s.costcnbuy = ConstUtil.COS_CN_BUY_ORDER.GC_IS_BY_CN_INVOICE;
            s.costcnsale = ConstUtil.COS_CN_BUY_ORDER.GC_IS_BY_CN_INVOICE;
            s.costproductzero = ConstUtil.COST_QTY_ZERO.GC_USE_COSET_BEFORE_ZERO;
            s.costcountstockdoc = ConstUtil.COST_QTY_ZERO.GC_USE_COSET_BEFORE_ZERO;
            s.costreturnwithdraw = ConstUtil.COST_QTY_ZERO.GC_USE_COSET_BEFORE_ZERO;
            s.glyearmode = ConstUtil.cYearMode.Year_Mode_CE;
            s.glformatdoc = ConstUtil.cFormatRunno.G_FORMAT_YYMM;
            s.glrundoclen = 5;
            s.glheadmessage = "";
            s.docyearmode = ConstUtil.cYearMode.Year_Mode_CE;
            s.docformatdoc = ConstUtil.cFormatRunno.G_FORMAT_YYMM;
            s.docrundoclen = 5;
            context.Add(s);
            context.SaveChanges();
        }
    }
}
