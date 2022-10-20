using Microsoft.EntityFrameworkCore.Metadata;
using RichnessSoft.Common;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using RichnessSoft.Service.Store;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static RichnessSoft.Service.DataHelper;

namespace RichnessSoft.Service
{
    public class ModelUtil
    {
        private readonly RicnessDbContext _context = default;
        private const int gnTaskDelay = 100;
        private ProfileStore profileStore;
        public enum enumGetMode { INSERT = 1, EDIT = 2, DELETE = 3 };
        public ModelUtil(RicnessDbContext context, ProfileStore store)
        {
            _context = context;
            profileStore = store;
        }

        public static string gmethDisplayVatType(int nVatType = 0)
        {
            string strRetValue;
            switch (nVatType)
            {
                case 0:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "vat" : "ภาษีมูลค่าเพิ่ม";
                    break;
                case 1:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "No vat" : "ภาษียกเว้น"; ;
                    break;
                case 2:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "Wht" : "ภาษีหัก ณ ที่จ่าย"; ;
                    break;
                default:
                    strRetValue = "";
                    break;
            }
            return strRetValue;
        }
        public static string gmethDisplayApprovedStatus(string strApprStat)
        {
            string strRetValue;
            switch (strApprStat)
            {
                case ConstUtil.ORDER_APPROVE.WAIT_APPROVE:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "WAIT" : "รออนุมัติ";
                    break;
                case ConstUtil.ORDER_APPROVE.REJECTED:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "REJECT" : "ไม่อนุมัติ"; ;
                    break;
                case ConstUtil.ORDER_APPROVE.APPROVED:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "APPROVED" : "อนุมัติ"; ;
                    break;
                default:
                    strRetValue = "";
                    break;
            }
            return strRetValue;
        }
        public static string gmethDisplayClosedStatus(string strCloseStat)
        {
            string strRetValue;
            switch (strCloseStat)
            {
                case ConstUtil.ORDER_DOC_STEP.CLOSED:
                    strRetValue = "C";
                    break;
                case ConstUtil.ORDER_DOC_STEP.UNCLOSED:
                    strRetValue = "U";
                    break;
                case ConstUtil.ORDER_DOC_STEP.NORMAL:
                    strRetValue = "";
                    break;
                default:
                    strRetValue = "";
                    break;
            }
            return strRetValue;
        }
        public static string gmethDisplayActive(int nActive = 0)
        {
            string strRetValue;
            switch (nActive)
            {
                case ConstUtil.ACTIVE.NO_2:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "No" : "ไม่ใช้งาน";
                    break;
                case ConstUtil.ACTIVE.YES_2:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "Yes" : "ใช้งาน"; ;
                    break;
                default:
                    strRetValue = "";
                    break;
            }
            return strRetValue;
        }
        public static string gmethDisplayActive(string strActive = "")
        {
            string strRetValue;
            switch (strActive)
            {
                case ConstUtil.ACTIVE.NO:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "No" : "ไม่ใช้งาน";
                    break;
                case ConstUtil.ACTIVE.YES:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "Yes" : "ใช้งาน"; ;
                    break;
                default:
                    strRetValue = "";
                    break;
            }
            return strRetValue;
        }
        public static string gmethDisplayDate(DateTime? oDate)
        {
            return gmethDisplayDate(oDate, "dd/MM/yyyy");
        }
        public static string gmethDisplayDate(DateTime? oDate, string format)
        {
            string strRetValue = "";
            if (oDate.HasValue)
            {
                strRetValue = oDate.Value.ToString(format);
            }
            return strRetValue;
        }
        public static string gmethDisplayNumber(decimal number)
        {
            return gmethDisplayNumber(number, "N2");
        }
        public static string gmethDisplayNumber(decimal number, string format)
        {
            return number.ToString(format);
        }
        public static Warehouse? gmethGetWarehouse(RicnessDbContext Db, int Id)
        {
            return gmethGetWarehouseAsync(Db, Id)?.Result;
        }
        public static Task<Warehouse> gmethGetWarehouseAsync(RicnessDbContext Db, int Id = 0)
        {
            return Db.Warehouse.Where(w => w.id == Id).SingleOrDefaultAsync();
        }
        public static UM? gmethGetUm(RicnessDbContext Db, int? Id)
        {
            return gmethGetUmAsync(Db, Id)?.Result;
        }
        public static Task<UM> gmethGetUmAsync(RicnessDbContext Db, int? Id)
        {
            return Db.UM.Where(w => w.id == Id).SingleOrDefaultAsync();
        }
        public static ProductUnit? gmethGetProductUnit(RicnessDbContext Db, int Id)
        {
            return gmethGetProductUnitAsync(Db, Id)?.Result;
        }
        public static Task<ProductUnit> gmethGetProductUnitAsync(RicnessDbContext Db, int Id)
        {
            return Db.ProductUnit.Where(w => w.id == Id).SingleOrDefaultAsync();
        }
        public static ProductUnit? gmethGetProductUnit(RicnessDbContext Db, int productid, int umid)
        {
            return gmethGetProductUnitAsync(Db, productid, umid)?.Result;
        }
        public static Task<ProductUnit> gmethGetProductUnitAsync(RicnessDbContext Db, int productid, int umid)
        {
            return Db.ProductUnit.Where(w => w.umid == umid && w.productid == productid).OrderBy(w => w.seq).SingleOrDefaultAsync();
        }
        public static ServiceUnit? gmethGetServiceUnit(RicnessDbContext Db, int Id)
        {
            return gmethGetServiceUnitAsync(Db, Id)?.Result;
        }
        public static Task<ServiceUnit> gmethGetServiceUnitAsync(RicnessDbContext Db, int Id)
        {
            return Db.ServiceUnit.Where(w => w.id == Id).SingleOrDefaultAsync();
        }
        public static ServiceUnit? gmethGetServiceUnit(RicnessDbContext Db, int serviceId, int umid)
        {
            return gmethGetServiceUnitAsync(Db, serviceId, umid)?.Result;
        }
        public static Task<ServiceUnit> gmethGetServiceUnitAsync(RicnessDbContext Db, int serviceId, int umid)
        {
            return Db.ServiceUnit.Where(w => w.umid == umid && w.ServiceId == serviceId).SingleOrDefaultAsync();
        }
        public static WarehouseType? gmethGetWarehouseType(RicnessDbContext Db, int Id)
        {
            return gmethGetWarehouseTypeAsync(Db, Id)?.Result;
        }
        public static Task<WarehouseType> gmethGetWarehouseTypeAsync(RicnessDbContext Db, int Id)
        {
            return Db.WarehouseType.Where(w => w.id == Id).SingleOrDefaultAsync();
        }
        public static Product? gmethGetProduct(RicnessDbContext Db, int Id)
        {
            return gmethGetProductAsync(Db, Id)?.Result;
        }
        public static Task<Product> gmethGetProductAsync(RicnessDbContext Db, int Id)
        {
            return Db.Product.Where(w => w.id == Id).SingleOrDefaultAsync();
        }
        public static string gmethGetPriceListStdUmPerUmRatio(RicnessDbContext Db, PriceList RPriceList)
        {
            string strUmStdName = "";
            string strUmName = "";
            Int32 qtyStd = RPriceList.qtystd;
            Int32 qtySale = RPriceList.qtysale;
            UM? RUmStd = gmethGetUm(Db, RPriceList.stdumid);
            if (RUmStd is not null)
            {
                strUmStdName = gbVar.UserLang.Name == "en-US" ? RUmStd.name2 : RUmStd.name1;
            }
            UM? RUm = gmethGetUm(Db, RPriceList.umid);
            if (RUm is not null)
            {
                strUmName = gbVar.UserLang.Name == "en-US" ? RUm.name2 : RUm.name1;
            }
            return string.Format("{0} {1} : {2} {3}", qtyStd.ToString("N0"), strUmStdName, qtySale.ToString("N0"), strUmName);
        }
        public static string gmethGetPriceListStdUmPerUmRatio(RicnessDbContext? Db, PricelistTrnD? Data)
        {
            string strUmStdName = "";
            string strUmName = "";
            if (Db is null || Data is null)
            {
                return string.Empty;
            }
            decimal qtyStd = Data.qtystd;
            decimal qtySale = Data.qtysale;

            UM? RUmStd = gmethGetUm(Db, Data.stdumid);
            if (RUmStd is not null)
            {
                strUmStdName = gbVar.UserLang.Name == "en-US" ? RUmStd.name2 : RUmStd.name1;
            }
            UM? RUm = gmethGetUm(Db, Data.umid);
            if (RUm is not null)
            {
                strUmName = gbVar.UserLang.Name == "en-US" ? RUm.name2 : RUm.name1;
            }
            return string.Format("{0} {1} : {2} {3}", qtyStd.ToString("N0"), strUmStdName, qtySale.ToString("N0"), strUmName);
        }
        public ResultType? gmGetMasterDataByCode<T>(RicnessDbContext Db, string code)
        {
            return gmGetDataByCodeAsync<T>(Db, code)?.Result;
        }
        public Task<ResultType> gmGetDataByCodeAsync<T>(RicnessDbContext Db, string code)
        {
            try
            {
                string tableName = "";
                var typeInfo = typeof(T).GetTypeInfo();
                IEntityType? oEntityType = null;
                if (code is null) { return null; }
                if (typeInfo is not null)
                {
                    oEntityType = Db.Model.FindEntityType(typeInfo);
                }
                if (oEntityType is not null)
                {
                    tableName = oEntityType.ClrType.Name;
                }
                string strSQL = string.Format("SELECT * FROM {0} WHERE companyid = @0 code = @1", tableName);
                var parameters = new[]{
                    new SqlParameter(){ ParameterName="@0", Value= profileStore.CurentCompany.id  , DbType = DbType.Int32 },
                    new SqlParameter(){ ParameterName="@1", Value= code , DbType = DbType.String }
                };
                return Task.FromResult(Db.Database.SqlQuery<ResultType>(strSQL, parameters).FirstOrDefault());
            }
            catch (Exception) { }
            return null;
        }
        public static string gmethDisplayOrderStatusName(string strDocStatus = "")
        {
            string strRetValue;
            switch (strDocStatus)
            {
                case ConstUtil.ORDER_DOC_STATUS.NEW:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "NEW" : "สร้างใหม่";
                    break;
                case ConstUtil.ORDER_DOC_STATUS.ORDER:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "ORDER" : "สั่งขายแล้ว"; ;
                    break;
                case ConstUtil.ORDER_DOC_STATUS.SOME:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "SOME" : "ตัดบางส่วน"; ;
                    break;
                case ConstUtil.ORDER_DOC_STATUS.CANCEL:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "CANCEL" : "ยกเลิก"; ;
                    break;
                case ConstUtil.ORDER_DOC_STATUS.INV:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "INVOICE" : "แจ้งหนี้แล้ว"; ;
                    break;
                case ConstUtil.ORDER_DOC_STATUS.PAID:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "PAID" : "ชำระครบแล้ว"; ;
                    break;
                default:
                    strRetValue = "";
                    break;
            }
            return strRetValue;
        }
        public static string gmethDisplayGLStatusName(string strDocStatus = "")
        {
            string strRetValue;
            switch (strDocStatus)
            {
                case ConstUtil.GL_STATUS.ACCRUE:
                    strRetValue = Lang.SysCode("ค่าใช้จ่าย", "ACCRUE");
                    break;
                case ConstUtil.GL_STATUS.AUDIT:
                    strRetValue = Lang.SysCode("ปรับปรุง", "AUDIT");
                    break;
                case ConstUtil.GL_STATUS.CLOSED:
                    strRetValue = Lang.SysCode("ปิดบัญชี", "CLOSED");
                    break;
                case ConstUtil.GL_STATUS.ESTIMATE:
                    strRetValue = Lang.SysCode("ประมาณการ", "ESTIMATE");
                    break;
                case ConstUtil.GL_STATUS.NORMAL:
                    strRetValue = Lang.SysCode("ปกติ", "NORMAL");
                    break;
                default:
                    strRetValue = "";
                    break;
            }
            return strRetValue;
        }
        public static string gmethDisplayOrderDocTypeName(string strDocType = "")
        {
            string strRetValue;
            switch (strDocType)
            {
                case GbDocRefType.SALE.QUOTATION:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "QUOTATION" : "ใบเสนอราคา";
                    break;
                case GbDocRefType.SALE.SALE_ORDER:
                    strRetValue = gbVar.UserLang.Name == "en-US" ? "SALE ORDER" : "ใบสั่งขาย"; ;
                    break;
                default:
                    strRetValue = "";
                    break;
            }
            return strRetValue;
        }
        public static async Task<List<ProductShelf>> gmethGetWarehouseByProductAsync(RicnessDbContext Db, int productid)
        {
            return await Db.ProductShelf.Where(c => c.productid == productid).OrderBy(c => c.seq).ToListAsync();
        }
        public static List<ProductShelf> gmethGetWarehouseByProduct(RicnessDbContext Db, int productid)
        {
            return Db.ProductShelf.Where(c => c.productid == productid).OrderBy(c => c.seq).ToList();
        }
        public static T? GetPropertyValue<T>(object src, string propName = "")
        {
            object? oResult = null;
            if (src is not null && UtilHelper.gmIsNullOrEmpty(src) == false)
            {
                PropertyInfo? prop = src.GetType().GetProperty(propName, BindingFlags.Public | BindingFlags.Instance);
                if (prop is not null)
                {
                    oResult = prop.GetValue(src) ?? default;
                }
            }
            return oResult is not null ? (T)oResult : default;
        }
        public static string GmethDisplayGLRefSystem(string strSystemType = "")
        {
            string strRetValue = "";
            if (strSystemType is null) { return strRetValue; }
            ConstUtilBase.cGLRefSystem? oResult = ConstUtil.goListSystem?.Where(c => c.Code == strSystemType)?.FirstOrDefault() ?? null;
            if (oResult is not null)
            {
                strRetValue = GetPropertyValue<string>(oResult, Lang.SysCode(nameof(ConstUtilBase.cGLRefSystem.Name), nameof(ConstUtilBase.cGLRefSystem.name2)));
            }
            return strRetValue ?? "";
        }
    }
}
