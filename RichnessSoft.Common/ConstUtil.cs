using System;
using System.Collections.Generic;

namespace RichnessSoft.Common
{
    public class ConstUtil : ConstUtilBase
    {
        public static class Payment_Stat
        {
            //**	Payment.Stat
            public const string gc_STAT_WAIT = " "; // 
            public const string gc_STAT_PASSED = "P"; // 
            public const string gc_STAT_CHQ_SPRING = "R"; // 
            /// <summary>
            ///  เช็ค สถานะ Cancle
            /// </summary>
            public const string gc_STAT_CHQ_CANCEL = "C"; // เช็ค สถานะ Cancle
            public static List<cPaymentStat> GetPaymentStat()
            {
                return new List<cPaymentStat>()
            {
                new cPaymentStat() { Code = Payment_Stat.gc_STAT_WAIT , Name = "ว่าง", name2 = "EMPTY" },
                new cPaymentStat() { Code = Payment_Stat.gc_STAT_PASSED , Name = "ผ่าน", name2 = "PASSED" },
                new cPaymentStat() { Code = Payment_Stat.gc_STAT_CHQ_SPRING , Name = "คืน", name2 = "RETURN" }
            };
            }
        }

        public class VENDORTYPE
        {
            public const string Individual = "I";
            public const string Corporation = "C";
        }
        public class CUSTTYPE
        {
            public const string Individual = "I";
            public const string Corporation = "C";
        }
        public static class ACTIVE
        {
            public const string YES = "Y";
            public const int YES_2 = 1;
            public const string NO = "N";
            public const int NO_2 = 0;

            public static List<cActive> GetActiveData()
            {
                return new List<cActive>()
            {
                new cActive() { code = ConstUtil.ACTIVE.YES , name = "ใช่" , name2 = "YES"},
                new cActive() { code = ConstUtil.ACTIVE.NO , name = "ไม่ใช่" , name2 = "NO"}
            };
            }
        }
        public class HEADOFFICE
        {
            public const string YES = "Y";
            public const string NO = "N";
        }
        public class VATISOUT
        {
            public const string IN = "I";
            public const string OUT = "O";
        }
        public class VATTYPE
        {
            public const string VAT_0 = "2";
            public const string VAT_7 = "1";
            public const string VAT_10 = "3";
            public const string TAX_EXEMPT = "4";
        }
        public class SOURCEIMAGE
        {
            public const string PRODUCT = "PRODUCT";
            public const string VENDOR = "VENDOR";
            public const string CUSTOMER = "CUSTOMER";
            public const string SALE_PERSON = "SALE_PERSON";
            public const string QUOATATION = "QUOATATION";
            public const string SALEORDER = "SALEORDER";
            public const string INVOICE = "INV";
            public const string BILL = "BILL";
            public const string PRE_RECEIPT = "PRECV";
            public const string RECEIPT = "RECV";
        }
        public class DATA_SOURCE
        {
            public const string SALES = "SALE";
            public const string PURCHASE = "PURC";
            public const string PRODUCT = "PROD";
            public const string COMPANY = "CORP";
            public const string SALEORDER = "SO";
            public const string GL_AUTO = "AT";
            public const string GL_MANUAL = "M";
        }
        public class CREDIT_TYPE
        {
            public const string INCREASE = "I";
            public const string REDUCTION = "R";
            public static List<cCreditType> GetCreditType()
            {
                return new List<cCreditType>()
                {
                    new cCreditType() { Code = ConstUtil.CREDIT_TYPE.INCREASE, Name = "เพิ่ม" , name2 = "INCREASE"},
                    new cCreditType() { Code = ConstUtil.CREDIT_TYPE.REDUCTION , Name = "ลด" , name2 = "REDUCTION"}
                };
            }
        }
        public class REFTYPE
        {
            public const string CUSTOMER = "C";
            public const string PRODUCT = "P";
            public const string VENDOR = "V";
        }
        public class PDTYPE_FLAG
        {
            public const string PRODUCT = "P";
            public const string SERVICE = "S";
        }

        public class ORDER_APPROVE : cAPPROVE { }
        public class INV_APPROVE : cAPPROVE { }
        public class ORDER_DOC_STATUS : cStatus { }
        public class INV_STATUS
        {
            public const string DELIVERY = "DELI";
            public const string PAID = "PAID";
            public const string BILL = "BILL";
            public const string CANCELED = "CANC";
            public const string NEW = "NEW";
            public const string PART = "PART";
        }
        public class STATUS_ITEM
        {
            /// <summary>
            /// รายการถูกตัดครบจำนวนแล้ว
            /// </summary>
            public const string FULL = "FULL";
            /// <summary>
            /// รายการยังไม่ถูกดึงไปใช้งาน            /// </summary>
            public const string NEW = "NEW";

            /// <summary>
            /// รายการถูกตัดไปบางส่วนแล้ว
            /// </summary>
            public const string SOME = "SOME";
            /// <summary>
            /// รายการถูกยกเลิก
            /// </summary>
            public const string CANCELED = "CANC";
        }
        public class BILL_ITEM_STATUS : STATUS_ITEM
        {
            /// <summary>
            /// รายการถูกปิด
            /// </summary>
            public const string CLOSED = "CLOS";
        }
        public class BILL_STATUS
        {
            public const string NEW = "NEW";
            public const string PART = "PART";
            public const string PAID = "PAID";
            public const string CANCELED = "CANC";
            public const string CLOSED = "CLOS";
        }
        public class RECEIPT_STATUS
        {
            public const string NEW = "NEW";
            public const string CANCELED = "CANC";
            public const string PAID = "PAID";
        }
        public class BILPAY_STATUS
        {
            public const string NEW = "NEW";
            public const string CANCELED = "CANC";
            public const string PAID = "PAID";
        }
        public class RECEIPT_ITEMREF_TYPE
        {
            public const string WITHHOLDING_TAX = "TAX";
            public const string PAYMENT = "PAY";
        }
        public class WHT_STATUS : cStatus { }
        public class ORDER_DOC_STEP : cStep { }
        public class INV_STEP : cStep { }
        public static class VALUE_ADDED_TAX
        {
            public const string INCLUDED = "I";
            public const string EXCLUDED = "O";
            public const string EXEMPTION = "E";
            public static List<value_added_tax> GetValueAddedTaxData()
            {
                return new List<value_added_tax>()
            {
                new value_added_tax() { code = ConstUtil.VALUE_ADDED_TAX.EXCLUDED , name = "แยกนอก", name2 = "EXCLUDED" },
                new value_added_tax() { code = ConstUtil.VALUE_ADDED_TAX.INCLUDED , name = "รวมใน", name2 = "INCLUDED" }
            };
            }
        }
        public static class ORDER_SET
        {
            public const string PRODUCT = "P";
            public const string SET = "S";
            public static List<cProductSet> GetProductSetData()
            {
                return new List<cProductSet>()
            {
                new cProductSet() { code = ConstUtil.ORDER_SET.PRODUCT, name = "สินค้า" , name2 = "Product"},
                new cProductSet() { code = ConstUtil.ORDER_SET.SET , name = "ชุดสินค้า" , name2 = "Product Set"}
            };
            }
        }
        public class STOCK_COUNTING
        {
            /// <summary>
            /// ตามบริษัท
            /// </summary>
            public const string COMPANY = "C";
            /// <summary>
            /// ไม่ให้ติดลบ
            /// </summary>
            public const string UN_NEGATIVE = "1";
            /// <summary>
            /// ติดลบได้
            /// </summary>
            public const string NEGATIVE = "2";
            /// <summary>
            /// ไม่นับสต๊อค
            /// </summary>
            public const string NO_COUNT_STOCK = "3";

            public static List<ListData> GetControlStock = new List<ListData>() {
                new ListData(){ Key= COMPANY, Value="ตามบริษัท",Value2 ="Company"},
                new ListData(){ Key= UN_NEGATIVE, Value="ไม่ให้ติดลบ",Value2 ="UN_NEGATIVE"},
                new ListData(){ Key= NEGATIVE, Value="ติดลบได้",Value2 ="NEGATIVE"},
                new ListData(){ Key= NO_COUNT_STOCK, Value="ไม่นับสต๊อค",Value2 ="NO_COUNT_STOCK"}
            };
        }
        /// <summary>
        /// ประเภทภาษี
        /// </summary>
        public static class TYPE_VAT
        {
            /// <summary>
            /// สินค้ามีภาษี (INT)
            /// </summary>
            public const Int32 VALUE_ADDED_TAX = 0;
            /// <summary>
            /// สินค้ามีภาษี (String)
            /// </summary>
            public const string VALUE_ADDED_TAX_2 = "0";
            /// <summary>
            /// สินค้ายกเว้นภาษี (INT)
            /// </summary>
            public const Int32 EXEMPT_TAX = 1;
            /// <summary>
            /// สินค้ายกเว้นภาษี (String)
            /// </summary>
            public const string EXEMPT_TAX_2 = "1";
            /// <summary>
            /// สินค้าภาษีหัก ณ ที่จ่าย (INT)
            /// </summary>
            public const Int32 WITHHOLDING_TAX = 2;
            /// <summary>
            /// สินค้าภาษีหัก ณ ที่จ่าย (String)
            /// </summary>
            public const string WITHHOLDING_TAX_2 = "2";
            public static List<cTypeVAT> GetTypeVatData()
            {
                return new List<cTypeVAT>()
            {
                new cTypeVAT() { code = ConstUtil.TYPE_VAT.VALUE_ADDED_TAX_2, name = "ภาษี" , name2 = "VAT"},
                new cTypeVAT() { code = ConstUtil.TYPE_VAT.EXEMPT_TAX_2 , name = "ยกเว้นภาษี" , name2 = "NONE"}
            };
            }
        }
        public class PRICELIST_TYPE
        {
            public const string CUSTOMER = "C";
            public const string VENDER = "V";
        }
        /// <summary>
        /// ราคาซื้อ
        /// </summary>
        public class PURCHASE_PRICE
        {
            /// <summary>
            /// S = ราคามาตรฐาน
            /// </summary>
            public const string STD_PRICE = "S";
            /// <summary>
            /// M = ราคาต่ำสุด
            /// </summary>
            public const string MIN_PRICE = "M";
            /// <summary>
            ///  L = ราคาล่าสุดตามผู้ขาย
            /// </summary>
            public const string LAST_PRICE_VENDOR = "L";
        }
        /// <summary>
        /// ราคาขาย
        /// </summary>
        public class SALES_PRICE
        {
            /// <summary>
            /// S = ราคามาตรฐาน
            /// </summary>
            public const string STD_PRICE = "S";
            /// <summary>
            /// M = ราคาต่ำสุด
            /// </summary>
            public const string MIN_PRICE = "M";
            /// <summary>
            ///  L = ราคาล่าสุดตามลูกค้า
            /// </summary>
            public const string LAST_PRICE_CUSTOMER = "L";
        }
        /// <summary>
        /// SYSTEM (TABLE : DOCTYPE)
        /// </summary>
        public class SYSTEM
        {
            /// <summary>
            /// ระบบ ธนาคาร
            /// </summary>
            public const string BANK = "BANK";
            /// <summary>
            /// ระบบ บัญชีแยกประเภท
            /// </summary>
            public const string GL = "GL";
            /// <summary>
            ///  ระบบ คลัง
            /// </summary>
            public const string INVENTORY = "INVENTORY";
            /// <summary>
            ///  ระบบ ซื้อ
            /// </summary>
            public const string PURCHASE = "PURCHASE";
            /// <summary>
            ///  ระบบ ขาย
            /// </summary>
            public const string SALE = "SALE";
        }
        /// <summary>
        /// Confirm
        /// </summary>
        public class CONFIRM
        {
            public const string YES = "Y";
            public const string NO = "N";

            public static List<ListData> LISTCONFIRM = new List<ListData>() {
                new ListData(){ Key= YES, Value="YES",Value2 ="YES"},
                new ListData(){ Key= NO, Value="NO",Value2 ="NO"}};
        }

        public class DOCTYPECONFIRM
        {
            public const string YES = "YES";
            public const string NO = "NO";

            public static List<ListData> LISTCONFIRM = new List<ListData>() {
                new ListData(){ Key= YES, Value="YES",Value2 ="YES"},
                new ListData(){ Key= NO, Value="NO",Value2 ="NO"}};
        }
        public class AUTO_INCREMENT
        {
            public int LAST_ID { get; set; } = -1;
        }
        public class PAY_GROUP
        {
            //**	PayType.Group ,Payment.PayGroup
            public const string gc_PAYGROUP_CHEQUE = "Q"; // 
            public const string gc_PAYGROUP_CASH = "C"; // 
            public const string gc_PAYGROUP_TRAN = "T"; //
            /// <summary>
            /// Interest & Bank Charge
            /// </summary>
            public const string gc_PAYGROUP_INTEREST = "I"; // Interest & Bank Charge
            /// <summary>
            /// Auto create
            /// </summary>
            public const string gc_PAYGROUP_AUTO = "A"; // Auto create
            /// <summary>
            /// Bank Guarantee
            /// </summary>
            public const string gc_PAYGROUP_GUARANTEE = "G"; // Bank Guarantee
        }

        public class PAYTYPE_TYPE
        {
            /// <summary>
            /// ชนิดการชำระเงิน
            /// </summary>
            public const string gc_PAYTYPE_TYPE_1 = "1"; // ชนิดการชำระเงิน
            /// <summary>
            /// สาเหตุการคืนเช็ค
            /// </summary>
            public const string gc_PAYTYPE_TYPE_2 = "2"; // สาเหตุการคืนเช็ค
            /// <summary>
            /// Bank Guarantee
            /// </summary>
            public const string gc_PAYTYPE_BG = "BG"; // Bank Guarantee
        }
        public class PAYTYPE_IO
        {
            //**	PayMent.Inout
            /// <summary>
            /// เช็ครับเข้าบริษัท
            /// </summary>
            public const string gc_PAY_IN = "I"; // เช็ครับเข้าบริษัท
            /// <summary>
            /// เช็คออกบริษัท
            /// </summary>    
            public const string gc_PAY_OUT = "O";
        }
        public static class Payment_Step
        {
            //**	Payment.Step
            /// <summary>
            ///  ยังไม่ ..
            /// </summary>
            public const string gc_STEP_ON_HAND = "O"; // ยังไม่ ..
            /// <summary>
            ///  เอาเช็ครับ ฝากเข้า ธนาคารแล้ว หรือเอาเงินเข้าสำหรับเช็คใบนี้แล้ว
            /// </summary>
            public const string gc_STEP_PAYIN = "P"; // เอาเช็ครับ ฝากเข้า ธนาคารแล้ว หรือเอาเงินเข้าสำหรับเช็คใบนี้แล้ว

            public static List<cPaymentStep> GetPaymentStep()
            {
                return new List<cPaymentStep>()
            {
                new cPaymentStep() { Code = gc_STEP_ON_HAND , Name = "ยังไม่ชำระ", name2 = "ON HAND" },
                new cPaymentStep() { Code = gc_STEP_PAYIN , Name = "ชำระแล้ว", name2 = "PAYIN" }
            };
            }
        }
        public static class Payment_AcPayee
        {
            //**	Payment.AcPayee
            /// <summary>
            ///  เข้าบัญชี
            /// </summary>
            public const string gc_ACPAYEE_INTO_ACCOUNT = "A";
            /// <summary>
            ///  A/C PAYEE ONLY
            /// </summary>
            public const string gc_ACPAYEE_PAYEE_ONLY = "P";

            public static List<cAcPayee> GetAcPayee()
            {
                return new List<cAcPayee>()
            {
                new cAcPayee() { Code = Payment_AcPayee.gc_ACPAYEE_INTO_ACCOUNT, Name = "เข้าบัญชี" , name2 = "Into Account"},
                new cAcPayee() { Code = Payment_AcPayee.gc_ACPAYEE_PAYEE_ONLY , Name = "A/C PAYEE ONLY" , name2 = "A/C PAYEE ONLY"}
            };
            }
        }

        public static class Payment_Bearer
        {
            //**	Payment.OrderBearer
            /// <summary>
            ///  ขีดหรือผู้ถือออก
            /// </summary>
            public const string gc_BEARER_CROSSED_CHEQUE = "C";
            /// <summary>
            ///  ไม่ขีด
            /// </summary>
            public const string gc_BEARER_UNCROSSED_CHEQUE = "U";

            public static List<cBearer> GetBearer()
            {
                return new List<cBearer>()
            {
                new cBearer() { Code = Payment_Bearer.gc_BEARER_CROSSED_CHEQUE, Name = "ขีดหรือผู้ถือออก" , name2 = "Crossed Cheque"},
                new cBearer() { Code = Payment_Bearer.gc_BEARER_UNCROSSED_CHEQUE, Name = "ไม่ขีด" , name2 = "Uncrossed Cheque"}
            };
            }
        }

        public static class SaleHistory
        {
            /// <summary>
            ///  ประวัติการขายตามลูกค้า
            /// </summary>
            public const string gc_SALE_HISTORY_CUSTOMER = "C";
            /// <summary>
            ///  ประวัติการขายตามสินค้า
            /// </summary>
            public const string gc_SALE_HISTORY_PRODUCT = "P";

            public static List<cSaleHistory> GetSaleHistory()
            {
                return new List<cSaleHistory>()
            {
                new cSaleHistory() { Code = SaleHistory.gc_SALE_HISTORY_CUSTOMER , Name = "ลูกค้า", name2 = "CUSTOMER" },
                new cSaleHistory() { Code = SaleHistory.gc_SALE_HISTORY_PRODUCT , Name = "สินค้า", name2 = "PRODUCT" }
            };
            }
        }

        public static class cYearMode
        {
            public const string Year_Mode_CE = "en-US";
            public const string Year_Mode_BE = "th-TH";
            public static List<ListData> ListYearMode = new List<ListData>() {
                new ListData(){ Key= "en-US", Value="ค.ศ.",Value2 ="th-TH"},
                new ListData(){ Key= "th-TH", Value="พ.ศ.",Value2 ="en-US"}};
        }

        public static class cFormatRunno
        {
            public const string G_FORMAT_YYYY = "yyyy";
            public const string G_FORMAT_YYYYMM = "yyyyMM";
            public const string G_FORMAT_YYYYMMDD = "yyyyMMdd";
            public const string G_FORMAT_YYMMDD = "yyMMdd";
            public const string G_FORMAT_YYMM = "yyMM";
            public const string G_FORMAT_YY = "yy";
            public const string G_FORMAT_MMYYYY = "MMyyyy";
            public const string G_FORMAT_MMYY = "MMyy";
            public const string G_FORMAT_MM = "MM";

            public static List<ListData> ListFormatRunno = new List<ListData>() {
                new ListData(){ Key= G_FORMAT_YYYY, Value="YYYY"},
                new ListData(){ Key= G_FORMAT_YYYYMM, Value="YYYYMM"},
                new ListData(){ Key= G_FORMAT_YYYYMMDD, Value="YYYYMMDD"},
                new ListData(){ Key= G_FORMAT_YYMMDD, Value="YYMMDD"},
                new ListData(){ Key= G_FORMAT_YYMM, Value="YYMM"},
                new ListData(){ Key= G_FORMAT_YY, Value="YY"},
                new ListData(){ Key= G_FORMAT_MMYYYY, Value="MMYYYY"},
                new ListData(){ Key= G_FORMAT_MMYY, Value="MMYY"},
                new ListData(){ Key= G_FORMAT_MM, Value="MM"}
        };
        }

        public static class COST_TYPE
        {
            public const string COST_TYPE_FIFO = "F";
            public const string COST_TYPE_AVERAGE = "A";

            public static List<ListData> LIST_COST_TYPE = new List<ListData>
            {
                new ListData(){ Key = "F" , Value = "FIFO" },
                new ListData(){ Key = "A" , Value = "AVERAGE" }
            };
        }

        public static class COST_ACCOUNT
        {
            public const string COST_ACCOUNT_PERIODIC = "PD";
            public const string COST_ACCOUNT_PERPETUAL = "PT";
            public static List<ListData> LIST_COST_ACCOUNT = new List<ListData>
            {
                new ListData(){ Key = "PD" , Value = "PERIODIC" },
                new ListData(){ Key = "PT" , Value = "PERPETUAL" }
            };
        }

        public static class SELECT_BUY_PRICE
        {
            public const string G_SELECT_BUY_DOC_REF = "0";
            public const string G_SELECT_BUY_PRODUCT = "1";

            public static List<ListData> LIST_SELECT_BUY_PRICE = new List<ListData>
            {
                new ListData(){ Key = "0" , Value = "ตามเอกสารอ้างอิง" },
                new ListData(){ Key = "1" , Value = "ตามฐานข้อมูลสินค้า" }
            };
        }

        public static class SELECT_SALE_PRICE
        {
            public const string G_SELECT_SALE_DOC_REF = "0";
            public const string G_SELECT_SALE_PRODUCT = "1";

            public static List<ListData> LIST_SELECT_SALE_PRICE = new List<ListData>
            {
                new ListData(){ Key = "0" , Value = "ตามเอกสารอ้างอิง" },
                new ListData(){ Key = "1" , Value = "ตามฐานข้อมูลสินค้า" }
            };
        }
        public static class COS_CN_BUY_ORDER
        {
            //Invoice , ตามที่ป้อน , ตามสินค้าคงเหลือ , ทุนมาตรฐาน
            public static string GC_IS_BY_CN_INVOICE = "0";
            public static string GC_IS_BY_CN_KEY = "1";
            public static string GC_IS_BY_CN_REM = "2";
            public static string GC_IS_BY_CN_STDCOST = "3";

            public static List<ListData> ListVal = new List<ListData>() {
                new ListData(){ Key = "0",Value = "ตาม Invoice"},
                new ListData(){ Key = "1",Value = "ตามที่ป้อน"},
                new ListData(){ Key = "2",Value = "ตามสินค้าคงเหลือ"},
                new ListData(){ Key = "3",Value = "ทุนมาตรฐาน"},
            };
        }

        public static class COST_QTY_ZERO
        {
            public static string GC_USE_COSET_BEFORE_ZERO = "0";
            public static string GC_USE_COSET_NEWT_LOT = "1";
            public static string GC_USE_COSET_KEYIN = "2";

            public static List<ListData> ListVal = new List<ListData>() {
                new ListData(){ Key = "0",Value = "ใช้ทุนก่อนติดลบ"},
                new ListData(){ Key = "1",Value = "ใช้ทุนรับเข้าถัดไป"},
                new ListData(){ Key = "2",Value = "ตามที่ป้อน"}
            };
        }

        public static class BookKeeping
        {
            public const string AUTO = "Y";
            public const string MANUAL = "M";
            public const string UNPOST = "N";

            public static List<cGLBookKeeping> GetGLBookKeeping()
            {
                return new List<cGLBookKeeping>()
                {
                    new cGLBookKeeping() { Code = "Y", Name = "ลงบัญชี Auto" , name2 = "Auto"},
                    new cGLBookKeeping() { Code = "M", Name = "บันทึกบัญชีเอง" , name2 = "Munal"},
                    new cGLBookKeeping() { Code = "N" , Name = "ไม่ลงบัญชี" , name2 = "NO"}
                };
            }
        }

        public static class GroupAcchart
        {
            public static List<ListData> getGroupAcchart()
            {
                return new List<ListData>()
                {
                new ListData() { Key = "1",Value = "สินทรัพย์"},
                new ListData() { Key = "2",Value = "หนี้สิน"},
                new ListData() { Key = "3",Value = "ทุน"},
                new ListData() { Key = "4",Value = "รายได้"},
                new ListData() { Key = "5",Value = "ค่าใช้จ่าย"}
            };
            }
        }

        public static class AcountType
        {
            public static List<ListData> Get()
            {
                return new List<ListData>()
                {
                new ListData() { Key = "บัญชี",Value = "บัญชี",Value2="DETAIL"},
                new ListData() { Key = "กลุ่ม",Value = "กลุ่ม",Value2="GENERAL"},
            };
            }

        }



        public static class Product_TYPE
        {
            /// <summary>
            /// เบี้ยประกันภัย
            /// </summary>
            public const string gc_Type_Insurance = "I";
            /// <summary>
            /// ค่าใช้จ่ายอื่นๆ 
            /// </summary>
            public const string gc_Type_Other_Expenses = "E";
            /// <summary>
            /// รายได้อื่นๆ 
            /// </summary>
            public const string gc_Type_Other_Income = "R";
            /// <summary>
            /// วัสดุสิ้นเปลือง 
            /// </summary>
            public const string gc_Type_Consumables = "C";
            /// <summary>
            ///  สินทรัพย์   
            /// </summary>
            public const string gc_Type_Asset = "A";
            /// <summary>
            /// วัตถุดิบ 
            /// </summary>
            public const string gc_Type_Material = "M";
            /// <summary>
            /// สินค้าสำเร็จรูป 
            /// </summary>
            public const string gc_Type_Finished_Product = "F";
        }

        public static List<cActive> goListActive => GetActiveData();
        public static List<value_added_tax> goListValueAddedTax => GetValueAddedTaxData();
        public static List<cProductSet> goListProductSet => GetProductSetData();
        public static List<cTypeVAT> goListTypeVAT => GetTypeVatData();
        public static List<cGLStatus> goListGLStatus => GetGLSatatus(); //GL_STATUS.GetGLSatatus();
        public static List<cGLLock> goListGLLock => GetGLLock(); //cLOCK.GetGLLock();
        public static List<cGLRefSystem> goListSystem => GetSystem();
        public static List<cConfirm> goListConfirm => GetConfrimData();
        public static List<cTaxDedutionCond> goListTaxDeductionCond => GetTaxDeductionCond();
        public static List<cWithholdingSection> goListWithholdingSection => GetcWithholdingSection();
        public static IList<cDepositWithdraw> goListDepositWithdraw => GetDepositWithdraw();
        public static IList<cPaymentStep> goListPaymentStep => GetPaymentStep();
        public static IList<cPaymentStat> goListPaymentStat => GetPaymentStat();
        public static IList<cAcPayee> goListAcPayee => GetAcPayee();
        public static IList<cBearer> goListBearer => GetBearer();
        public static IList<cInvFindReferType> goListInvFindReferType => GetInvFindReferType();
        public static IList<cSaleHistory> goListSaleHistory => GetSaleHistory();
        public static IList<cGLBookKeeping> goListGLBookKeeping => BookKeeping.GetGLBookKeeping();


        public static class RetProduct
        {
            public const string YES = "Y";
            public const string NO = "N";
            public static List<cRetProduct> gaRetProduct => new List<cRetProduct>()
                {
                    new cRetProduct() { Code = YES , Name = "ต้องการคืนสินค้า" , name2 = "Return product"},
                    new cRetProduct() { Code = NO , Name = "ลดจำนวนเงินไม่คืนสินค้า" , name2 = "Reduce quantity of non-return"}
                };
        }
        public static List<ListData> goGroupAcchart => GroupAcchart.getGroupAcchart();
        public static List<ListData> goAccountType => AcountType.Get();
    }
}
