using System.Collections.Generic;

namespace RichnessSoft.Common
{
    public class SysDef
    {
        /// <summary>
        /// wait for loading 
        /// </summary>
        public const int gnTheadForSleep = 500; //milisecond
        public class PayType
        {
            
            /// <summary>
            /// ทำรายการบัญชีอัตโนมัติ
            /// </summary>
            public const string gc_PAYTYPE_ATS = "ATS"; // ทำรายการบัญชีอัตโนมัติ
            /// <summary>
            /// บัตรเครดิต
            /// </summary>
            public const string gc_PAYTYPE_CD = "CD "; // บัตรเครดิต
            /// <summary>
            /// ถอนเงินผ่านเคลียริ่ง
            /// </summary>
            public const string gc_PAYTYPE_CG = "CG "; // ถอนเงินผ่านเคลียริ่ง
            /// <summary>
            /// ถอนโดยเช็ค
            /// </summary>
            public const string gc_PAYTYPE_CW = "CW "; // ถอนโดยเช็ค
            /// <summary>
            /// ฝากโดยเช็ค เงินตราตปท.
            /// </summary>
            public const string gc_PAYTYPE_BB = "BB "; // ฝากโดยเช็ค เงินตราตปท.
            /// <summary>
            /// ฝากโดยเช็คธนาคารอื่น
            /// </summary>
            public const string gc_PAYTYPE_CL = "CL "; // ฝากโดยเช็คธนาคารอื่น
            /// <summary>
            /// ฝากโดยเช็คธนาคาร
            /// </summary>
            public const string gc_PAYTYPE_HC = "HC "; // ฝากโดยเช็คธนาคาร
            /// <summary>
            /// ค่าธรรมเนียม
            /// </summary>
            public const string gc_PAYTYPE_CM = "CM "; // ค่าธรรมเนียม
            /// <summary>
            /// เช็คคืน
            /// </summary>
            public const string gc_PAYTYPE_CR = "CR "; // เช็คคืน
            /// <summary>
            /// ถอนเงินสด
            /// </summary>
            public const string gc_PAYTYPE_CS = "CS "; // ถอนเงินสด
            /// <summary>
            /// ฝากโดยดราฟท์
            /// </summary>
            public const string gc_PAYTYPE_DD = "DD "; // ฝากโดยดราฟท์
            /// <summary>
            /// ดอกเบี้ย
            /// </summary>
            public const string gc_PAYTYPE_INW = "INW"; // ดอกเบี้ย
            /// <summary>
            /// เล็ตเตอร์ออฟเครดิต
            /// </summary>
            public const string gc_PAYTYPE_LC = "LC "; // เล็ตเตอร์ออฟเครดิต
            /// <summary>
            /// ฝากโดยเงินสด
            /// </summary>
            public const string gc_PAYTYPE_PC = "PC "; // ฝากโดยเงินสด
            /// <summary>
            /// ฝากโดยการโอน
            /// </summary>
            public const string gc_PAYTYPE_TRD = "TRD"; // ฝากโดยการโอน
            /// <summary>
            /// ถอนโดยการโอน
            /// </summary>
            public const string gc_PAYTYPE_TRW = "TRW"; // ถอนโดยการโอน
            /// <summary>
            /// เงินสดรับ
            /// </summary>
            public const string gc_PAYTYPE_CHI = "CHI"; // เงินสดรับ
            /// <summary>
            /// เงินสดจ่าย
            /// </summary>
            public const string gc_PAYTYPE_CHO = "CHO"; // เงินสดจ่าย
            /// <summary>
            /// Refer ไปดูที่ payment ของเอกสารใบอื่น (ใช้ที่ใบเสร็จของ สวนจิตร)
            /// </summary>
            public const string gc_PAYTYPE_RF = "RF "; // Refer ไปดูที่ payment ของเอกสารใบอื่น (ใช้ที่ใบเสร็จของ สวนจิตร)
            /// <summary>
            /// ค่า OV
            /// </summary>
            public const string gc_PAYTYPE_OC = "OV "; // ค่า OV
            /// <summary>
            /// เงินเกิน
            /// </summary>
            public const string gc_PAYTYPE_OCI = "OCI"; // เงินเกิน
            /// <summary>
            /// เงินขาด
            /// </summary>
            public const string gc_PAYTYPE_OCL = "OCL"; // เงินขาด
            /// <summary>
            /// Coupon
            /// </summary>
            public const string gc_PAYTYPE_COU = "COU"; // Coupon
            /// <summary>
            /// ธนาณัติ Money Order
            /// </summary>
            public const string gc_PAYTYPE_MO = "MO "; // ธนาณัติ Money Order
            /// <summary>
            /// ฝากโดยเช็คเรียกเก็บ
            /// </summary>
            public const string gc_PAYTYPE_CC = "CC "; // ฝากโดยเช็คเรียกเก็บ
            /// <summary>
            /// ใบเสร็จรับเงินจากใบหักเงินประกันผลงาน (ซื้อ)
            /// </summary>
            public const string gc_PAYTYPE_RP = "RP"; //  ใบเสร็จรับเงินจากใบหักเงินประกันผลงาน (ซื้อ)
            /// <summary>
            /// ใบเสร็จรับเงินจากใบหักเงินประกันผลงาน (ขาย)
            /// </summary>
            public const string gc_PAYTYPE_RS = "RS"; //  ใบเสร็จรับเงินจากใบหักเงินประกันผลงาน (ขาย)
                                                      //2016-06-07 BY SEK
            /// <summary>
            /// Bank Guarantee
            /// </summary>
            public const string gc_PAYTYPE_BG = "BG"; // Bank Guarantee
            /// <summary>
            /// ค่า OV
            /// </summary>
            public const string gc_PAYTYPE_OV = "OV"; // ค่า OV
        }
        public class PayGroup
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
            /// <summary>
            /// Not Specifield
            /// </summary>
            public const string gc_PAYGROUP_EMPTY = "-"; // Not Specifield
        }
        public class PayType_Type
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
        public class PayType_IO
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
            /// <summary>
            /// Not Specifield
            /// </summary>
            public const string gc_PAY_EMPTY = "-"; // Not Specifield    
        }
        public class Payment_Stat
        {
            //**	Payment.Stat
            public const string gc_STAT_WAIT = " "; // 
            public const string gc_STAT_PASSED = "P"; // 
            public const string gc_STAT_CHQ_SPRING = "R"; // 
            /// <summary>
            ///  เช็ค สถานะ Cancle
            /// </summary>
            public const string gc_STAT_CHQ_CANCEL = "C"; // เช็ค สถานะ Cancle
        }
        public class Payment_Step
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
        }
        public class Description_Type
        {
            //**	Payment.DescriptionCode
            /// <summary>
            ///  สาเหตุเช็คคืน
            /// </summary>
            public const string gc_RTYPE_RETRUN_CHEQUE = "CHQ";
            /// <summary>
            ///  สาเหตุในการยกเลิกใบกำกับภาษีเดิม
            /// </summary>
            public const string gc_RTYPE_RETRUN_TAX_INV = "TAX";
            /// <summary>
            ///  สาเหตุในการคืนสินค้า
            /// </summary>
            public const string gc_RTYPE_RETRUN_PROD_INV = "PRD";
        }
        /// <summary>
        /// ประวัติการขาย
        /// </summary>
        public class SaleHistory
        {
            /// <summary>
            ///  ประวัติการขายตามลูกค้า
            /// </summary>
            public const string gc_SALE_HISTORY_CUSTOMER = "C";
            /// <summary>
            ///  ประวัติการขายตามสินค้า
            /// </summary>
            public const string gc_SALE_HISTORY_PRODUCT = "P";
        }
        /// <summary>
        /// ขีดคร่อม
        /// </summary>
        public class Payment_AcPayee
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
        }
        /// <summary>
        /// ขีดหรือผู้ถือ
        /// </summary>
        public class Payment_Bearer
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
        }

        public class BookBank_Type
        {
            //**	BankAcct.Type
            public const string gc_BANKACCT_TYPE_CURRENT = "C"; // 
            public const string gc_BANKACCT_TYPE_SAVING = "S"; // 
            public const string gc_BANKACCT_TYPE_FIX = "F"; // 
            public const string gc_BANKACCT_TYPE_GUARANTEE = "G"; // 

            /// <summary>
            /// บัญชีกระแสรายวัน
            /// </summary>
            public const string gc_BANKACCT_TYPE_NAME_CURRENT = "บัญชีกระแสรายวัน"; // 
            /// <summary>
            /// Current account
            /// </summary>
            public const string gc_BANKACCT_TYPE_NAME_CURRENT2 = "Current account"; // 
            /// <summary>
            /// บัญชีออมทรัพย์
            /// </summary>
            public const string gc_BANKACCT_TYPE_NAME_SAVING = "บัญชีออมทรัพย์"; //
            /// <summary>
            /// Savings account
            /// </summary>
            public const string gc_BANKACCT_TYPE_NAME_SAVING2 = "Savings account"; //
            /// <summary>
            /// บัญชีประจำ
            /// </summary>
            public const string gc_BANKACCT_TYPE_NAME_FIX = "บัญชีประจำ"; // 
            /// <summary>
            /// Fixed account
            /// </summary>
            public const string gc_BANKACCT_TYPE_NAME_FIX2 = "Fixed account"; // 
            /// <summary>
            /// หนังสือค้ำประกันของธนาคาร
            /// </summary>
            public const string gc_BANKACCT_TYPE_NAME_GUARANTEE = "หนังสือค้ำประกันของธนาคาร"; // 
            /// <summary>
            /// Bank Guarantee
            /// </summary>
            public const string gc_BANKACCT_TYPE_NAME_GUARANTEE2 = "Bank Guarantee"; // 
        }

        public class BILPAY_MASTER
        {
            /// <summary>
            /// Bill การชำระเงิน , Inv เงินมัดจำ (BilPay.fcOfMaster จะว่าง)
            /// </summary>
            public const string gc_BILPAY_MASTER_GLREF = "G";
            /// <summary>
            /// เงินมัดจำของ Order (BilPay.fcOfMaster จะว่าง)
            /// </summary>
            public const string gc_BILPAY_MASTER_ORDERH = "O";
            /// <summary>
            /// การชำระเงิน Prcvh (BilPay.fcOfMaster จะว่าง)
            /// </summary>
            public const string gc_BILPAY_MASTER_PRCVH = "P";
            /// <summary>
            /// การชำระเงินเอกสารใบหักเงินประกัน (BilPay.fcOfMaster จะว่าง)
            /// </summary>
            public const string gc_BILPAY_MASTER_GLREF_RENTEN = "R";
            //**	BilPay.MType Extend	
            /// <summary>
            /// PB ตัดเงินมัดจำของ Inv (BilPay.fcMasterH = Inv , BilPay.fcOfMaster = PB , BilPay.MType = M)
            /// </summary>
            public const string gc_BILPAY_MASTER_MINV = "M";
            /// <summary>
            /// Bill ตัดเงินมัดจำของ Inv (BilPay.fcMasterH = Inv , BilPay.fcOfMaster = ใบเสร็จ)
            /// </summary>    
            public const string gc_BILPAY_MASTER_PINV = "P";
            /// <summary>
            /// Inv ตัดเงินมัดจำของ Order (BilPay.fcMasterH = Order , BilPay.fcOfMaster = Inv)
            /// </summary>   
            public const string gc_BILPAY_MASTER_PORD = "Q";
            //**	BilPay.MType CU	
            /// <summary>
            /// (BilPay.fcMasterH = ใบภาษีหัก ณ ที่จ่าย)
            /// </summary>   
            public const string gc_BILPAY_MASTER_WHT = "T";
            /// <summary>
            /// (BilPay.fcMasterH = ใบการจ่ายเงินชดเชยเงินสดย่อย)
            /// </summary>  
            public const string gc_BILPAY_MASTER_PETRETH_E4 = "4";
            /// <summary>
            /// (BilPay.fcMasterH = ใบเบิกจ่ายเงินสดย่อย )
            /// </summary>  
            public const string gc_BILPAY_MASTER_PETTYWD_E1 = "1";
            /// <summary>
            /// (BilPay.fcMasterH = ใบเบิกจ่ายเงินทดรองจ่าย )
            /// </summary>  
            public const string gc_BILPAY_MASTER_PETTYWD_E5 = "5";
        }

        public class IOTYPE
        {
            /// <summary>
            /// รับเข้า
            /// </summary>
            public const string gc_IOTYPE_I = "I";
            /// <summary>
            /// ส่งออก
            /// </summary>
            public const string gc_IOTYPE_O = "O";
        }
        public class CreateApp
        {
            public const string gc_APP_GL = "GL";
            public const string gc_APP_INVOICE = "INV";
            public const string gc_APP_MASTER = "MAS";
            public const string gc_APP_SALE_ORDER = "SO";
            public const string gc_APP_PURCHASE_ORDER = "PO";
            public const string gc_APP_BILL = "BILL";
            public const string gc_APP_PRE_RECEIPT = "PREC";
            public const string gc_APP_RECEIPT = "REC";
        }
        public enum P_Step { ORDER = 0 , INVOICE = 1};
        public enum S_Step { ORDER = 0 , INVOICE = 1};
        public class ListData
        {
            public string Key { get; set; }
            public string KeyInt { get; set; }
            public string Value { get; set; }
            public string Value2 { get; set; }
        }

        public static List<ListData> ListYearMode = new List<ListData>() {
                new ListData(){ Key= "en-US", Value="ค.ศ.",Value2 ="th-TH"},
                new ListData(){ Key= "th-TH", Value="พ.ศ.",Value2 ="en-US"}};

        public static List<ListData> ListFormatRunno = new List<ListData>() {
                new ListData(){ Key= "yyyy", Value="YYYY"},
                new ListData(){ Key= "yyyyMM", Value="YYYYMM"},
                new ListData(){ Key= "yyyyMMdd", Value="YYYYMMDD"},
                new ListData(){ Key= "yyMMdd", Value="YYMMDD"},
                new ListData(){ Key= "yyMM", Value="YYMM"},
                new ListData(){ Key= "yy", Value="YY"},
                new ListData(){ Key= "MMyyyy", Value="MMYYYY"},
                new ListData(){ Key= "MMyy", Value="MMYY"},
                new ListData(){ Key= "MM", Value="MM"}
        };
        public class DOC_GROUP
        {
            /// <summary>
            /// AJ
            /// </summary>
            public const string AJ = "AJ";
            /// <summary>
            /// BC
            /// </summary>
            public const string BC = "BC";
            /// <summary>
            /// BK
            /// </summary>
            public const string BK = "BK";
            /// <summary>
            /// BS
            /// </summary>
            public const string BS = "BS";
            /// <summary>
            /// BT
            /// </summary>
            public const string BT = "BT";
            /// <summary>
            /// CQ
            /// </summary>
            public const string CQ = "CQ";
            /// <summary>
            /// DO
            /// </summary>
            public const string DO = "DO";
            /// <summary>
            /// GL
            /// </summary>
            public const string GL = "GL";
            /// <summary>
            /// LO
            /// </summary>
            public const string LO = "LO";
            /// <summary>
            /// PL
            /// </summary>
            public const string PL = "PL";
            /// <summary>
            /// PM
            /// </summary>
            public const string PM = "PM";
            /// <summary>
            /// PO
            /// </summary>
            public const string PO = "PO";
            /// <summary>
            /// PP
            /// </summary>
            public const string PP = "PP";
            /// <summary>
            /// RE
            /// </summary>
            public const string RE = "RE";
            /// <summary>
            /// RL
            /// </summary>
            public const string RL = "RL";
            /// <summary>
            /// RP
            /// </summary>
            public const string RP = "RP";
            /// <summary>
            /// RQ
            /// </summary>
            public const string RQ = "RQ";
            /// <summary>
            /// SC
            /// </summary>
            public const string SC = "SC";
            /// <summary>
            /// SO
            /// </summary>
            public const string SO = "SO";
            /// <summary>
            /// SS
            /// </summary>
            public const string SS = "SS";
            /// <summary>
            /// ST
            /// </summary>
            public const string ST = "ST";
            /// <summary>
            /// TF
            /// </summary>
            public const string TF = "TF";
            /// <summary>
            /// WH
            /// </summary>
            public const string WH = "WH";
        }

        public class SystemType
        {
            /// <summary>
            /// งานซื้อมาขายไป
            /// </summary>
            public const string CASH = "C";
            /// <summary>
            /// งานบริการ
            /// </summary>
            public const string SERVICE = "S";
        }
        public class CalFlag
        {
            /// <summary>
            /// รับเข้า
            /// </summary>
            public const int ADD = 1;
            /// <summary>
            /// ตัดออก
            /// </summary>
            public const int SUBSTRACT = -1;
            /// <summary>
            /// ไม่รับเข้าหรือตัดออก
            /// </summary>
            public const int NOTHING = 0;
        }
    }
}
