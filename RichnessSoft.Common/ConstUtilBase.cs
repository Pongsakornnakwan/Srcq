using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using BlazorInputFile;

namespace RichnessSoft.Common
{
    public class ConstUtilBase
    {
        public static readonly CultureInfo goLang = new CultureInfo("th-TH");
        public class ListData
        {
            public string Key { get; set; }
            public string KeyInt { get; set; }
            public string Value { get; set; }
            public string Value2 { get; set; }
        }
        public static List<value_added_tax> GetValueAddedTaxData()
        {
            return new List<value_added_tax>()
            {
                new value_added_tax() { code = ConstUtil.VALUE_ADDED_TAX.EXCLUDED , name = "แยกนอก", name2 = "EXCLUDED" },
                new value_added_tax() { code = ConstUtil.VALUE_ADDED_TAX.INCLUDED , name = "รวมใน", name2 = "INCLUDED" }
            };
        }
        public static List<cGLStatus> GetGLSatatus()
        {
            return new List<cGLStatus>()
            {
                new cGLStatus() { Code = GL_STATUS.ACCRUE , Name = "ค่าใช้จ่าย", name2 = "ACCRUE" },
                new cGLStatus() { Code = GL_STATUS.AUDIT , Name = "ปรับปรุง", name2 = "AUDIT" },
                new cGLStatus() { Code = GL_STATUS.CLOSED , Name = "ปิดบัญชี", name2 = "CLOSED" },
                new cGLStatus() { Code = GL_STATUS.ESTIMATE , Name = "ประมาณการ", name2 = "ESTIMATE" },
                new cGLStatus() { Code = GL_STATUS.NORMAL , Name = "ปกติ", name2 = "NORMAL" }
            };
        }
        public static List<cGLLock> GetGLLock()
        {
            return new List<cGLLock>()
            {
                new cGLLock() { Code = cLOCK.LOCK , Name = "LOCK", name2 = "LOCK" },
                new cGLLock() { Code = cLOCK.UNLOCK , Name = "UNLOCK", name2 = "UNLOCK" }
            };
        }
        public static List<cGLRefSystem> GetSystem()
        {
            return new List<cGLRefSystem>()
            {
                new cGLRefSystem() { Code = cSystem.SALE , Name = "ขาย", name2 = "SALE" },
                new cGLRefSystem() { Code = cSystem.PURCHASE , Name = "ซื้อ", name2 = "BUY" }
            };
        }
        public static List<cDepositWithdraw> GetDepositWithdraw()
        {
            return new List<cDepositWithdraw>()
            {
                new cDepositWithdraw() { Code = cDW.DEPOSIT , Name = "ฝาก", name2 = "Deposit" },
                new cDepositWithdraw() { Code = cDW.WITHDRAW , Name = "ถอน", name2 = "Withdraw" }
            };
        }
        public static List<cPaymentStep> GetPaymentStep()
        {
            return new List<cPaymentStep>()
            {
                new cPaymentStep() { Code = SysDef.Payment_Step.gc_STEP_ON_HAND , Name = "ยังไม่ชำระ", name2 = "ON HAND" },
                new cPaymentStep() { Code = SysDef.Payment_Step.gc_STEP_PAYIN , Name = "ชำระแล้ว", name2 = "PAYIN" }
            };
        }
        public static List<cPaymentStat> GetPaymentStat()
        {
            return new List<cPaymentStat>()
            {
                new cPaymentStat() { Code = SysDef.Payment_Stat.gc_STAT_WAIT , Name = "ว่าง", name2 = "EMPTY" },
                new cPaymentStat() { Code = SysDef.Payment_Stat.gc_STAT_PASSED , Name = "ผ่าน", name2 = "PASSED" },
                new cPaymentStat() { Code = SysDef.Payment_Stat.gc_STAT_CHQ_SPRING , Name = "คืน", name2 = "RETURN" }
            };
        }
        public static List<cTaxDedutionCond> GetTaxDeductionCond()
        {
            return new List<cTaxDedutionCond>()
            {
                new cTaxDedutionCond() { Code = cTaxDeduction.WITHHOLDING , Name = "หัก ณ ที่จ่าย", name2 = "Withholding" },
                new cTaxDedutionCond() { Code = cTaxDeduction.ISSUED , Name = "ออกภาษีให้", name2 = "Issue Tax" }
            };
        }
        public static List<cWithholdingSection> GetcWithholdingSection()
        {
            return new List<cWithholdingSection>()
            {
                new cWithholdingSection() { Code = "1" , Name = "มาตรา 3 เตรส", name2 = "มาตรา 3 เตรส" },
                new cWithholdingSection() { Code = "2" , Name = "เงินได้ตามมาตรา 40(1) เงินเดือนค่าจ้าง ฯลฯ กรณีทั่วไป", name2 = "เงินได้ตามมาตรา 40(1) เงินเดือนค่าจ้าง ฯลฯ กรณีทั่วไป" },
                new cWithholdingSection() { Code = "3" , Name = "มาตรา 40(1) เงินเดือน ค่าจ้าง ฯลฯ กรณีได้รับอนุมัติจากกรมสรรพากรให้หักในอัตราร้อยละ 3", name2 = "มาตรา 40(1) เงินเดือน ค่าจ้าง ฯลฯ กรณีได้รับอนุมัติจากกรมสรรพากรให้หักในอัตราร้อยละ 3" },
                new cWithholdingSection() { Code = "4" , Name = "มาตรา 40(1)(2) กรณีนายจ้างจ่ายให้ครั้งเดียวเพราะเหตุออกจากงาน", name2 = "มาตรา 40(1)(2) กรณีนายจ้างจ่ายให้ครั้งเดียวเพราะเหตุออกจากงาน" },
                new cWithholdingSection() { Code = "5" , Name = "มาตรา 40(2) กรณีผู้รับเงินได้เป็นผู้อยู่ในประเทศไทย", name2 = "มาตรา 40(2) กรณีผู้รับเงินได้เป็นผู้อยู่ในประเทศไทย" },
                new cWithholdingSection() { Code = "6" , Name = "มาตรา 40(2) กรณีผู้รับเงินได้มิได้เป็นผู้อยู่ในประเทศไทย", name2 = "มาตรา 40(2) กรณีผู้รับเงินได้มิได้เป็นผู้อยู่ในประเทศไทย" },
                new cWithholdingSection() { Code = "7" , Name = "มาตรา 40(3)", name2 = "มาตรา 40(3)" }
            };
        }
        public static List<cActive> GetActiveData()
        {
            return new List<cActive>()
            {
                new cActive() { code = ConstUtil.ACTIVE.YES , name = "ใช่" , name2 = "YES"},
                new cActive() { code = ConstUtil.ACTIVE.NO , name = "ไม่ใช่" , name2 = "NO"}
            };
        }
        public static List<cProductSet> GetProductSetData()
        {
            return new List<cProductSet>()
            {
                new cProductSet() { code = ConstUtil.ORDER_SET.PRODUCT, name = "สินค้า" , name2 = "Product"},
                new cProductSet() { code = ConstUtil.ORDER_SET.SET , name = "ชุดสินค้า" , name2 = "Product Set"}
            };
        }
        public static List<cTypeVAT> GetTypeVatData()
        {
            return new List<cTypeVAT>()
            {
                new cTypeVAT() { code = ConstUtil.TYPE_VAT.VALUE_ADDED_TAX_2, name = "ภาษี" , name2 = "VAT"},
                new cTypeVAT() { code = ConstUtil.TYPE_VAT.EXEMPT_TAX_2 , name = "ยกเว้นภาษี" , name2 = "NONE"}
            };
        }
        public static List<cConfirm> GetConfrimData()
        {
            return new List<cConfirm>()
            {
                new cConfirm() { Code = "Y", Name = "ใช่" , name2 = "YES"},
                new cConfirm() { Code = "N" , Name = "ไม่ใช่" , name2 = "NO"}
            };
        }
        public static List<cAcPayee> GetAcPayee()
        {
            return new List<cAcPayee>()
            {
                new cAcPayee() { Code = SysDef.Payment_AcPayee.gc_ACPAYEE_INTO_ACCOUNT, Name = "เข้าบัญชี" , name2 = "Into Account"},
                new cAcPayee() { Code = SysDef.Payment_AcPayee.gc_ACPAYEE_PAYEE_ONLY , Name = "A/C PAYEE ONLY" , name2 = "A/C PAYEE ONLY"}
            };
        }
        public static List<cBearer> GetBearer()
        {
            return new List<cBearer>()
            {
                new cBearer() { Code = SysDef.Payment_Bearer.gc_BEARER_CROSSED_CHEQUE, Name = "ขีดหรือผู้ถือออก" , name2 = "Crossed Cheque"},
                new cBearer() { Code = SysDef.Payment_Bearer.gc_BEARER_UNCROSSED_CHEQUE, Name = "ไม่ขีด" , name2 = "Uncrossed Cheque"}
            };
        }
        public static List<cInvFindReferType> GetInvFindReferType()
        {
            return new List<cInvFindReferType>()
            {
                new cInvFindReferType() { Code = "D", Name = "สินค้าค้างส่ง" , name2 = "Delivery Order"},
                new cInvFindReferType() { Code = "A", Name = "รวมทั้งบิล" , name2 = "All Bill"}
            };
        }
        public static List<cSaleHistory> GetSaleHistory()
        {
            return new List<cSaleHistory>()
            {
                new cSaleHistory() { Code = SysDef.SaleHistory.gc_SALE_HISTORY_CUSTOMER , Name = "ลูกค้า", name2 = "CUSTOMER" },
                new cSaleHistory() { Code = SysDef.SaleHistory.gc_SALE_HISTORY_PRODUCT , Name = "สินค้า", name2 = "PRODUCT" }
            };
        }

        //CCCC
        public class cBase
        {
            public string Code { get; set; } = string.Empty;
            public string Name { get; set; } = string.Empty;
            public string name2 { get; set; } = string.Empty;
            public string ExpName => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : Name;
        }
        public class cBase2
        {
            public string code { get; set; } = string.Empty;
            public string name { get; set; } = string.Empty;
            public string name2 { get; set; } = string.Empty;
            public string ExpName => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? name2 : name;
        }
        public class value_added_tax : cBase2 { }
        public class cTaxDedutionCond : cBase { }
        public class cWithholdingSection : cBase { }
        public class cGLStatus : cBase { }
        public class cConfirm : cBase { }
        public class cGLLock : cBase { }
        public class cGLRefSystem : cBase { }
        public class cActive : cBase2 { }
        public class cProductSet : cBase2 { }
        public class cTypeVAT : cBase2 { }
        public class cDepositWithdraw : cBase { }
        public class cPaymentStat : cBase { }
        public class cPaymentStep : cBase { }
        public class cAcPayee : cBase { }
        public class cBearer : cBase { }
        public class cInvFindReferType : cBase { }
        public class cSaleHistory : cBase { }
        public class cLot
        {
            public int Id { get; set; } = 0;
            public string Lot { get; set; } = string.Empty;
        }
        public class cGLBookKeeping : cBase { }
        public class cCreditType : cBase { }
        public class cRetProduct : cBase { }

        public class cLinkUpdate
        {
            public enum enumStatus { NEW = 1, SOME = 2, PAID = 3 };
            public class cItem
            {
                public string ItemLinkID { get; set; } = string.Empty;
                public decimal ItemPayAmount { get; set; } = 0;
                public decimal ItemBfVatAmount { get; set; } = 0;
                public decimal ItemVatAmount { get; set; } = 0;
                public enumStatus ItemStatus { get; set; } = enumStatus.NEW;
            }
            public string HeadLinkID { get; set; } = string.Empty;
            public string HeadDocType { get; set; } = string.Empty;
            public enumStatus HeadStatus => GetStatus();
            public decimal HeadPayAmount => ITEMS?.Sum(c => c.ItemPayAmount) ?? 0M;
            public List<cItem> ITEMS { get; set; } = new List<cItem>();

            private enumStatus GetStatus()
            {
                if (ITEMS is null || ITEMS.Count == 0) { return enumStatus.NEW; };
                int nTotal = ITEMS.Count;
                int nCountPaid = ITEMS?.Where(c => c.ItemStatus == enumStatus.PAID)?.Count() ?? 0;
                int nCountSome = ITEMS?.Where(c => c.ItemStatus == enumStatus.SOME)?.Count() ?? 0;
                int nCountNew = ITEMS?.Where(c => c.ItemStatus == enumStatus.NEW)?.Count() ?? 0;
                if (nCountPaid >= nTotal)
                {
                    return enumStatus.PAID;
                }
                else if (nCountSome > 0)
                {
                    return enumStatus.SOME;
                }
                else if (nCountNew > 0)
                {
                    if (nCountPaid > 0)
                    {
                        return enumStatus.SOME;
                    }
                    else
                    {
                        return enumStatus.NEW;
                    }
                }
                return enumStatus.NEW;
            }
        }
        public class cInvoicePayPartial
        {
            public int ReceiptRefID { get; set; } = 0;
            public string ReceiptRefLinkID { get; set; } = string.Empty;
            public string ReceiptHeadLinkID { get; set; } = string.Empty;
            public string ReceiptItemLinkID { get; set; } = string.Empty;
            public string InvoiceHeadLinkID { get; set; } = string.Empty;
            public string InvoiceHeadDocType { get; set; } = string.Empty;
            public string InvoiceHeadDocGroup { get; set; } = string.Empty;
            public string InvoiceItemLinkID { get; set; } = string.Empty;
            public string InvoiceItempstypeCode { get; set; } = string.Empty;
            public string InvoiceItemProductTypeCode { get; set; } = string.Empty;
            public string InvoiceItemProductFullName { get; set; } = string.Empty;
            public string InvoiceItemQtyUnitSell { get; set; } = string.Empty;
            public decimal InvoiceItemPrice { get; set; } = 0M;
            public decimal InvoiceItemPriceK { get; set; } = 0M;
            public decimal InvoiceItemDiscAmt { get; set; } = 0M;
            public decimal InvoiceItemDiscAmtK { get; set; } = 0M;
            public decimal InvoiceItemBfVatAmt { get; set; } = 0M;
            public decimal InvoiceItemBfVatAmtK { get; set; } = 0M;
            public decimal InvoiceItemVatAmt { get; set; } = 0M;
            public decimal InvoiceItemVatAmtK { get; set; } = 0M;
            public decimal InvoiceItemNetAmt { get; set; } = 0M;
            public decimal InvoiceItemNetAmtK { get; set; } = 0M;
            public string InvoiceItemTypeVatName { get; set; } = string.Empty;
            public decimal ReceiptRefBfCurrVatAmount { get; set; } = 0M;
            public decimal ReceiptRefBfStdVatAmount { get; set; } = 0M;
            public decimal ReceiptRefVatCurrAmount { get; set; } = 0M;
            public decimal ReceiptRefVatStdAmount { get; set; } = 0M;
        }
        //CCCC

        public class upload_files
        {
            public string LinkID => StrUtil.GetUniqueKey(25);
            public IFileListEntry FileListEntry { get; set; } = null;
            public string ImageBaseString { get; set; } = "";
            public MemoryStream memoryStream { get; set; }
            public string SourceName { get; set; } = string.Empty;
            public object StorageImageData { get; set; } = null;
        }
        /// <summary>
        /// รายละเอียดเอกสารที่อ้างถึง / ค้นเอกสารเดิม
        /// </summary>
        public class Order_doc_ref
        {
            /// <summary>
            /// ID
            /// </summary>
            public int doc_id { get; set; } = 0;
            /// <summary>
            /// สถานะเอกสาร
            /// </summary>
            public string doc_status { get; set; } = string.Empty;
            /// <summary>
            /// สถานะเอกสาร (Expression)
            /// </summary>
            public string doc_status_name { get; set; } = string.Empty;
            /// <summary>
            /// ประเภทเอกสาร
            /// </summary>
            public string doc_type { get; set; } = string.Empty;
            /// <summary>
            /// ประเภทเอกสาร (Formula)
            /// </summary>
            public string doc_type_formula { get; set; } = string.Empty;
            /// <summary>
            /// เล่มเอกสาร
            /// </summary>
            public string doc_book_code { get; set; } = string.Empty;
            /// <summary>
            /// เลขที่ภายใน
            /// </summary>
            public string doc_code { get; set; } = string.Empty;
            /// <summary>
            /// เลขที่เอกสาร
            /// </summary>
            public string doc_ref_no { get; set; } = string.Empty;
            /// <summary>
            /// วันที่เอกสาร
            /// </summary>
            public DateTime? doc_date { get; set; }
            /// <summary>
            /// มูลค่าสินค้า
            /// </summary>
            public decimal doc_amount { get; set; } = 0;
            /// <summary>
            /// ยอดชำระ
            /// </summary>
            public decimal doc_pay_amount { get; set; } = 0;
            /// <summary>
            /// เลขที่ voucher no
            /// </summary>
            public string doc_vourcher_no { get; set; } = string.Empty;
            /// <summary>
            /// ลูกค้า /ผู้ขาย
            /// </summary>
            public string customer_name { get; set; } = string.Empty;
            /// <summary>
            /// หน่วยเงิน
            /// </summary>
            public string currency_name { get; set; } = string.Empty;
            /// <summary>
            /// ลำดับการแสดง
            /// </summary>
            public string SEQ { get; set; } = "0000";
            /// <summary>
            /// Link UP/DOWN
            /// </summary>
            public bool IsLinkUp { get; set; } = true;

            public class cSEQ
            {
                public const int SEQ_QT = 0;
                public const int SEQ_SO = 1;
                public const int SEQ_INV = 2;
                public const int SEQ_INV_CR = 3;
                public const int SEQ_INV_DR = 3;
                public const int SEQ_BILL = 4;
                public const int SEQ_PRE_RECEIPT = 5;
                public const int SEQ_RECEIPT = 6;
            }
        }

        /// <summary>
        /// ค้นหา INVOICE แบบทั้งบิล
        /// </summary>
        public class Inv_find_refer_all_bill
        {
            /// <summary>
            /// ID
            /// </summary>
            public int ID { get; set; } = 0;
            /// <summary>
            /// สถานะเอกสาร
            /// </summary>
            public string Status { get; set; } = string.Empty;
            /// <summary>
            /// ประเภทเอกสาร
            /// </summary>
            public string DocType { get; set; } = string.Empty;
            /// <summary>
            /// ประเภทเอกสาร (Formula)
            /// </summary>
            public string DocTypeFormula { get; set; } = string.Empty;
            /// <summary>
            /// เล่มเอกสาร
            /// </summary>
            public string Book { get; set; } = string.Empty;
            /// <summary>
            /// เลขที่ภายใน
            /// </summary>
            public string Code { get; set; } = string.Empty;
            /// <summary>
            /// เลขที่เอกสาร
            /// </summary>
            public string RefNo { get; set; } = string.Empty;
            /// <summary>
            /// วันที่เอกสาร
            /// </summary>
            public DateTime? Date { get; set; }
            /// <summary>
            /// ลูกค้า /ผู้ขาย
            /// </summary>
            public string Coor { get; set; } = string.Empty;
            /// <summary>
            /// มูลค่าสินค้า
            /// </summary>
            public decimal Amount { get; set; } = 0;
            /// <summary>
            /// หน่วยเงิน
            /// </summary>
            public string Currency { get; set; } = string.Empty;
            /// <summary>
            /// มูลค่าเงินมัดจำทั้งหมด
            /// </summary>
            public decimal DepositAmount { get; set; } = 0;
            /// <summary>
            /// เงินมัดจำที่ใช้ไปแล้ว
            /// </summary>
            public decimal UsedAmount { get; set; } = 0;
            /// <summary>
            /// เงินมัดจำคงเหลือ
            /// </summary>
            public decimal BalanceAmount { get; set; } = 0;
        }

        /// <summary>
        /// ค้นหา INVOICE แบบสินค้าค้างส่ง
        /// </summary>
        public class Inv_find_refer_do
        {
            /// <summary>
            /// ID
            /// </summary>
            public string ID => string.Format("{0}-{1}", this.HeadID.ToString(), this.ItemID.ToString());
            /// <summary>
            /// HeadID ID
            /// </summary>
            public int HeadID { get; set; } = 0;
            /// <summary>
            /// เลขที่อ้างอิง
            /// </summary>
            public string RefNo { get; set; } = string.Empty;
            /// <summary>
            /// ItemID
            /// </summary>
            public int ItemID { get; set; } = 0;
            /// <summary>
            /// รหัสสินค้า
            /// </summary>
            public string ProductCode { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสินค้า
            /// </summary>
            public string ProductName { get; set; } = string.Empty;
            /// <summary>
            /// จำนวนคงค้าง
            /// </summary>
            public decimal DOQty { get; set; } = 0M;
            /// <summary>
            /// รหัสหน่วย
            /// </summary>
            public string UnitCode { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วย
            /// </summary>
            public string UnitName { get; set; } = string.Empty;
            /// <summary>
            /// วันที่ส่งของ
            /// </summary>
            public DateTime? DeliveryDate { get; set; } = null;
            /// <summary>
            /// ลูกค้า /ผู้ขาย
            /// </summary>
            public string CoorName { get; set; } = string.Empty;
            /// <summary>
            /// ประเภทเอกสาร
            /// </summary>
            public string HeadDocType { get; set; } = string.Empty;
        }

        public class Order_Items
        {
            public int Master_Id { get; set; } = 0;
            public int Child_Id { get; set; } = 0;
            public string Seq { get; set; } = "";
        }
        /// <summary>
        /// ตรวจสอบสินค้า
        /// </summary>
        public class Order_Prod_Inspection
        {
            /// <summary>
            /// รหัสสินค้า
            /// </summary>
            public string Prod_code { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสินค้า
            /// </summary>
            public string Prod_name { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสินค้า ภาษา 2
            /// </summary>
            public string Prod_name2 { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสินค้า (Lang)
            /// </summary>
            public string Exp_prod_name
            {
                get
                {
                    return goLang.Name != "en-US" ? this.Prod_name : Prod_name2;
                }
            }
            /// <summary>
            /// รหัสสินค้า - ชื่อสินค้า (Lang)
            /// </summary>
            public string Exp_full_prod
            {
                get
                {
                    return string.Format("{0}-{1}", Prod_code, (goLang.Name != "en-US" ? this.Prod_name : Prod_name2));
                }
            }
            /// <summary>
            /// รหัสหน่วยนับ
            /// </summary>
            public string Um_code { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วยนับ
            /// </summary>
            public string Um_name { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วยนับ ภาษา 2
            /// </summary>
            public string Um_name2 { get; set; } = string.Empty;
            /// <summary>
            /// หน่วยนับ
            /// </summary>
            public string Exp_um_name
            {
                get
                {
                    return goLang.Name == "en-US" ? Um_name2 : Um_name;
                }
            }
            /// <summary>
            /// คงเหลือ
            /// </summary>
            public decimal BalanceQty { get; set; } = 0M;
            /// <summary>
            /// PO ค้างส่ง
            /// </summary>
            public decimal POOverDueQty { get; set; } = 0M;
            /// <summary>
            /// จำนวน GRN
            /// </summary>
            public decimal GrnQty { get; set; } = 0M;
            /// <summary>
            /// ยอดจอง SO
            /// </summary>
            public decimal SO_BookingQty { get; set; } = 0M;
            /// <summary>
            /// ยอดพร้อมขาย
            /// </summary>
            public decimal SalesReadyQty { get; set; } = 0M;
            /// <summary>
            /// ราคาขายมาตรฐาน
            /// </summary>
            public decimal StdPrice { get; set; } = 0M;
        }
        /// <summary>
        /// คงเหลือตามคลัง
        /// </summary>
        public class Order_Stock_Bal
        {
            /// <summary>
            /// รหัสสาขา
            /// </summary>
            public string Branch_code { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสาขา
            /// </summary>
            public string Branch_name { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสาขา ภาษา 2
            /// </summary>
            public string Branch_name2 { get; set; } = string.Empty;
            /// <summary>
            /// สาขา
            /// </summary>
            public string Exp_full_branch_name
            {
                get
                {
                    return goLang.Name != "en-US" ? Branch_name : Branch_name2;
                }
            }
            /// <summary>
            /// รหัสคลังสินค้า
            /// </summary>
            public string Warehouse_code { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อคลังสินค้า
            /// </summary>
            public string Warehouse_name { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อคลังสินค้า ภาษา 2
            /// </summary>
            public string Warehouse_name2 { get; set; } = string.Empty;
            /// <summary>
            /// คลังสินค้า
            /// </summary>
            public string Exp_full_warehouse_name
            {
                get
                {
                    return goLang.Name == "en-US" ? Warehouse_name2 : Warehouse_name;
                }
            }
            /// <summary>
            /// คงเหลือ
            /// </summary>
            public decimal BalanceQty { get; set; } = 0M;
            /// <summary>
            /// Minimum
            /// </summary>
            public decimal MinimumQty { get; set; } = 0M;
            /// <summary>
            /// Maximum
            /// </summary>
            public decimal MaximumQty { get; set; } = 0M;
            /// <summary>
            /// Safety Stock
            /// </summary>
            public decimal SafetyStockQty { get; set; } = 0M;
        }
        /// <summary>
        /// ยอดค้างรับ/ส่ง
        /// </summary>
        public class DO_GRN_BALANCE
        {
            /// <summary>
            /// ID
            /// </summary>
            public string Id { get; set; } = string.Empty;
            /// <summary>
            /// ประเภทเอกสาร
            /// </summary>
            public string DocType { get; set; } = string.Empty;
            /// <summary>
            /// เล่ม
            /// </summary>
            public string BookCode { get; set; } = string.Empty;
            /// <summary>
            /// เลขที่เอกสาร
            /// </summary>
            public string DocCode { get; set; } = string.Empty;
            /// <summary>
            /// รหัสสินค้า
            /// </summary>
            public string ProductCode { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสินค้า
            /// </summary>
            public string ProductName { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสินค้า(Expr)
            /// </summary>
            public string ExpFullProductName => string.Format("{0}-{1}", ProductCode, ProductName);
            /// <summary>
            /// จำนวน
            /// </summary>
            public decimal Qty { get; set; } = 0M;
            /// <summary>
            /// รหัสหน่วยนับ
            /// </summary>
            public string UmSellCode { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วยนับ
            /// </summary>
            public string UmSellName { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วยนับ(Expr)
            /// </summary>
            public string ExpFullUmSellName => string.Format("{0}-{1}", UmSellCode, UmSellName);
            /// <summary>
            /// จำนวน : หน่วยขาย
            /// </summary>
            public string ExpQtyUmSell => string.Format("{0} : {1}", Qty.ToString("N0"), UmSellName);
            /// <summary>
            /// จำนวนมาตรฐาน
            /// </summary>
            public decimal QtyStd { get; set; } = 0M;
            /// <summary>
            /// หน่วยนับมาตรฐาน
            /// </summary>
            public string UmStdName { get; set; } = string.Empty;
            /// <summary>
            /// จำนวน : หน่วยมาตรฐาน
            /// </summary>
            public string ExpStdQtyPerUmStd => string.Format("{0} : {1}", QtyStd.ToString("N0"), UmStdName);
            /// <summary>
            /// Lot No.
            /// </summary>
            public string LotNo { get; set; } = string.Empty;
            /// <summary>
            /// ยอดค้างส่ง
            /// </summary>
            public decimal OBQty { get; set; } = 0M;
            /// <summary>
            /// วันที่ส่งสินค้า
            /// </summary>
            public DateTime? DeliveryDate { get; set; }
            /// <summary>
            /// รหัสลูกค้า/ผู้ขาย
            /// </summary>
            public string CoorCode { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อลูกค้า/ผู้ขาย
            /// </summary>
            public string CoorName { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อลูกค้า/ผู้ขาย(Expr)
            /// </summary>
            public string ExpFullCoorName => string.Format("{0}-{1}", CoorCode, CoorName);
        }
        /// <summary>
        /// ประวัติลูกค้า
        /// </summary>
        public class Order_Cust_History
        {
            /// <summary>
            /// ประเภทเอกสาร
            /// </summary>
            public string Doc_type { get; set; } = string.Empty;
            /// <summary>
            /// รหัสเล่มเอกสาร
            /// </summary>
            public string Book_code { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อเล่มเอกสาร
            /// </summary>
            public string Book_name { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อเล่มเอกสาร ภาษา 2
            /// </summary>
            public string Book_name2 { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อเล่มเอกสาร (Lang)
            /// </summary>
            public string Exp_book_name
            {
                get
                {
                    return goLang.Name == "en-US" ? Book_name2 : Book_name;
                }
            }
            /// <summary>
            /// วันที่เอกสาร
            /// </summary>
            public DateTime Doc_date { get; set; }
            /// <summary>
            /// เลขที่เอกสาร
            /// </summary>
            public string Doc_code { get; set; } = string.Empty;
            /// <summary>
            /// รหัสสินค้า
            /// </summary>
            public string Prod_code { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสินค้า
            /// </summary>
            public string Prod_name { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสินค้า ภาษา 2
            /// </summary>
            public string Prod_name2 { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสินค้า (Lang)
            /// </summary>
            public string Exp_prod_name
            {
                get
                {
                    return goLang.Name == "en-US" ? Prod_name2 : Prod_name;
                }
            }
            /// <summary>
            /// รหัสสินค้า - ชื่อสินค้า
            /// </summary>
            public string Exp_full_prod
            {
                get
                {
                    return string.Format("{0}-{1}", Prod_code, (goLang.Name == "en-US" ? Prod_name2 : Prod_name));
                }
            }
            /// <summary>
            /// Lot
            /// </summary>
            public string lot { get; set; } = string.Empty;
            /// <summary>
            /// รหัสหน่วยนับ
            /// </summary>
            public string Um_code { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วยนับ
            /// </summary>
            public string Um_name { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วยนับ ภาษา 2
            /// </summary>
            public string Um_name2 { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วยนับ (Lang)
            /// </summary>
            public string Exp_um_name
            {
                get
                {
                    return goLang.Name == "en-US" ? Um_name2 : Um_name;
                }
            }
            /// <summary>
            /// จำนวน
            /// </summary>
            public decimal Qty { get; set; } = 0M;
            /// <summary>
            /// ราคา:หน่วย
            /// </summary>
            public decimal Price { get; set; } = 0M;
            /// <summary>
            /// ส่วนลด
            /// </summary>
            public string DistStr { get; set; } = string.Empty;
            /// <summary>
            /// มูลค่าส่วนลด
            /// </summary>
            public decimal DistAmt { get; set; } = 0M;
        }
        /// <summary>
        /// ประวัติการขาย
        /// </summary>
        public class Sales_History
        {
            /// <summary>
            /// ID
            /// </summary>
            public string Id { get; set; } = string.Empty;
            /// <summary>
            /// ประเภทเอกสาร
            /// </summary>
            public string Doc_type { get; set; } = string.Empty;
            /// <summary>
            /// ประเภทเอกสาร(Formula)
            /// </summary>
            public string Doc_type_Formula { get; set; } = string.Empty;
            /// <summary>
            /// เล่มเอกสาร
            /// </summary>
            public string BookCode { get; set; } = string.Empty;
            /// <summary>
            /// เลขที่เอกสาร
            /// </summary>
            public string Doc_code { get; set; } = string.Empty;
            /// <summary>
            /// วันที่เอกสาร
            /// </summary>
            public DateTime? Doc_date { get; set; }
            /// <summary>
            /// รหัสสินค้า
            /// </summary>
            public string ProductCode { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสินค้า
            /// </summary>
            public string ProductName { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสินค้า(เต็ม)
            /// </summary>
            public string ExpFullProductName => string.Format("{0}-{1}", ProductCode, ProductName);
            /// <summary>
            /// จำนวน
            /// </summary>
            public decimal Qty { get; set; } = 0M;
            /// <summary>
            /// รหัสหน่วยนับ
            /// </summary>
            public string Um_code { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วยนับ
            /// </summary>
            public string Um_name { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วยนับ ภาษา 2
            /// </summary>
            public string Um_name2 { get; set; } = string.Empty;
            /// <summary>
            /// หน่วยนับ
            /// </summary>
            public string Exp_full_um_name => (gbVar.UserLang?.Name ?? "th-TH") == "en-US" ? Um_name2 : Um_name;

            /// <summary>
            /// จำนวน : หน่วยขาย
            /// </summary>
            public string ExpQtyUmSell => string.Format("{0} : {1}", Qty.ToString("N0"), Exp_full_um_name);
            /// <summary>
            /// จำนวนมาตรฐาน
            /// </summary>
            public decimal QtyStd { get; set; } = 0M;
            /// <summary>
            /// หน่วยนับมาตรฐาน
            /// </summary>
            public string UmStdName { get; set; } = string.Empty;
            /// <summary>
            /// จำนวน : หน่วยมาตรฐาน
            /// </summary>
            public string ExpQtyPerPrice => string.Format("{0} : {1}", QtyStd.ToString("N0"), UmStdName);
            /// <summary>
            /// ราคา:หน่วย
            /// </summary>
            public decimal Price { get; set; } = 0M;
            /// <summary>
            /// ส่วนลด
            /// </summary>
            public string DistStr { get; set; } = string.Empty;
            /// <summary>
            /// มูลค่าส่วนลด
            /// </summary>
            public decimal DistAmt { get; set; } = 0M;
            /// <summary>
            /// มูลค่า
            /// </summary>
            public decimal Amount { get; set; } = 0M;
            /// <summary>
            /// ประเภทภาษี
            /// </summary>
            public string ValueAddedTax { get; set; } = string.Empty;
            /// <summary>
            /// รหัสลูกค้า/ผู้ขาย
            /// </summary>
            public string Cust_vendor_code { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อลูกค้า/ผู้ขาย
            /// </summary>
            public string Cust_vendor_name { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อลูกค้า/ผู้ขาย ภาษา 2
            /// </summary>
            public string Cust_vendor_name2 { get; set; } = string.Empty;
            /// <summary>
            /// ลูกค้า/ผู้ขาย
            /// </summary>
            public string Exp_full_cust_vendor_name => (gbVar.UserLang?.Name ?? "th-TH") != "en-US" ? Cust_vendor_name ?? "" : Cust_vendor_name2 ?? "";
        }
        /// <summary>
        /// หมายเหตุ
        /// </summary>
        public class Order_Remark
        {
            /// <summary>
            /// หมายเหตุ 1
            /// </summary>
            public string remark01 { get; set; } = string.Empty;
            /// <summary>
            /// หมายเหตุ 2
            /// </summary>
            public string Cust_vendor_code { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อลูกค้า/ผู้ขาย
            /// </summary>
            public string Cust_vendor_name { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อลูกค้า/ผู้ขาย ภาษา 2
            /// </summary>
            public string Cust_vendor_name2 { get; set; } = string.Empty;
            /// <summary>
            /// ลูกค้า/ผู้ขาย
            /// </summary>
            public string Exp_full_cust_vendor_name
            {
                get
                {
                    return goLang.Name != "en-US" ? Cust_vendor_name : Cust_vendor_name2;
                }
            }
            /// <summary>
            /// วันที่เอกสาร
            /// </summary>
            public DateTime Doc_date { get; set; }
            /// <summary>
            /// เลขที่เอกสาร
            /// </summary>
            public string Doc_code { get; set; } = string.Empty;
            /// <summary>
            /// รหัสหน่วยนับ
            /// </summary>
            public string Um_code { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วยนับ
            /// </summary>
            public string Um_name { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วยนับ ภาษา 2
            /// </summary>
            public string Um_name2 { get; set; } = string.Empty;
            /// <summary>
            /// หน่วยนับ
            /// </summary>
            public string Exp_full_um_name
            {
                get
                {
                    return goLang.Name == "en-US" ? Um_name2 : Um_name;
                }
            }
            /// <summary>
            /// จำนวน
            /// </summary>
            public decimal Qty { get; set; } = 0M;
            /// <summary>
            /// ราคา:หน่วย
            /// </summary>
            public decimal Price { get; set; } = 0M;
            /// <summary>
            /// ส่วนลด
            /// </summary>
            public string DistStr { get; set; } = string.Empty;
            /// <summary>
            /// มูลค่าส่วนลด
            /// </summary>
            public decimal DistAmt { get; set; } = 0M;
        }

        /// <summary>
        /// Window Screen
        /// </summary>
        public class WindowScreen
        {
            /// <summary>
            /// ความกว้าง
            /// </summary>
            public int? Width { get; set; } = 0;
            /// <summary>
            /// ความสูง
            /// </summary>
            public int? Height { get; set; } = 0;
        }
        /// <summary>
        /// GL- STATUS
        /// </summary>
        public class GL_STATUS
        {
            /// <summary>
            /// ปกติ
            /// </summary>
            public const string NORMAL = "NOR";
            /// <summary>
            /// ปิดบัญชี
            /// </summary>
            public const string CLOSED = "CLO";
            /// <summary>
            /// ปรับปรุง
            /// </summary>
            public const string AUDIT = "AU";
            /// <summary>
            /// ค่าใช้จ่าย
            /// </summary>
            public const string ACCRUE = "ACC";
            /// <summary>
            /// ประมาณการ(ไม่ออกรายงาน GL)
            /// </summary>
            public const string ESTIMATE = "EST";
            /// <summary>
            /// ยกเลิกเอกสาร
            /// </summary>
            public const string CANCEL = "CAN";
        }
        /// <summary>
        /// GL- LOCK
        /// </summary>
        public class cLOCK
        {
            /// <summary>
            /// Lock
            /// </summary>
            public const string LOCK = "L";
            /// <summary>
            /// Un-Lock
            /// </summary>
            public const string UNLOCK = "U";
        }
        /// <summary>
        /// System
        /// </summary>
        public class cSystem
        {
            /// <summary>
            /// SALE
            /// </summary>
            public const string SALE = "SALE";
            /// <summary>
            /// PURCHASE
            /// </summary>
            public const string PURCHASE = "PURCHASE";
            /// <summary>
            /// INVENTORY
            /// </summary>
            public const string INVENTORY = "INVENTORY";
            /// <summary>
            /// GL
            /// </summary>
            public const string GL = "GL";
            /// <summary>
            /// BANK
            /// </summary>
            public const string BANK = "BANK";
        }
        /// <summary>
        /// Deposit/Withdraw
        /// </summary>
        public class cDW
        {
            /// <summary>
            /// Deposit
            /// </summary>
            public const string DEPOSIT = "D";
            /// <summary>
            /// Withdraw
            /// </summary>
            public const string WITHDRAW = "W";
        }
        /// <summary>
        /// เงื่อนไขการหักภาษี
        /// </summary>
        public class cTaxDeduction
        {
            /// <summary>
            /// หัก ณ ที่จ่าย
            /// </summary>
            public const string WITHHOLDING = "WHT";
            /// <summary>
            /// ออกให้
            /// </summary>
            public const string ISSUED = "ISU";
        }
        public class cAPPROVE
        {
            /// <summary>
            /// อนุมัติ
            /// </summary>
            public const string APPROVED = "A";
            /// <summary>
            /// ไม่อนุมัติ
            /// </summary>
            public const string REJECTED = "R";
            /// <summary>
            /// รออนุมัติ
            /// </summary>
            public const string WAIT_APPROVE = "W";
        }
        public class cStatus
        {
            public const string NEW = "NEW";
            public const string ORDER = "ORD";
            public const string CANCEL = "CAN";
            public const string SOME = "SOM";
            public const string INV = "INV";
            public const string PAID = "PAID";
        }
        public class cStep
        {
            public const string NORMAL = "N";
            public const string CLOSED = "C";
            public const string UNCLOSED = "U";
        }
        /// <summary>
        /// สินค้าคงคลัง
        /// </summary>
        public class Invoice_Inventory
        {
            /// <summary>
            /// ID
            /// </summary>
            public string Id { get; set; } = string.Empty;
            /// <summary>
            /// รหัสบริษัท
            /// </summary>
            public string CorpCode { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อบริษัท
            /// </summary>
            public string CorpName { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อบริษัท(เต็ม)
            /// </summary>
            public string ExpFullCorpName => string.Format("{0}-{1}", CorpCode, CorpName);
            /// <summary>
            /// รหัสสาขา
            /// </summary>
            public string BranchCode { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสาขา
            /// </summary>
            public string BranchName { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสาขา(เต็ม)
            /// </summary>
            public string ExpFullBranchName => string.Format("{0}-{1}", BranchCode, BranchName);
            /// <summary>
            /// รหัสเล่ม
            /// </summary>
            public string BookCode { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อเล่ม
            /// </summary>
            public string BooKName { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อเล่ม(เต็ม)
            /// </summary>
            public string ExpFullBookName => string.Format("{0}-{1}", BookCode, BooKName);
            /// <summary>
            /// รหัสคลัง
            /// </summary>
            public string WhCode { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อคลัง
            /// </summary>
            public string WhName { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อคลัง(เต็ม)
            /// </summary>
            public string ExpFullWhName => string.Format("{0}-{1}", WhCode, WhName);
            /// <summary>
            /// รหัสสินค้า
            /// </summary>
            public string ProductCode { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสินค้า
            /// </summary>
            public string ProductName { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อสินค้า(เต็ม)
            /// </summary>
            public string ExpFullProductName => string.Format("{0}-{1}", ProductCode, ProductName);
            /// <summary>
            /// รหัสหน่วยนับ
            /// </summary>
            public string UnitCode { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วยนับ
            /// </summary>
            public string UnitName { get; set; } = string.Empty;
            /// <summary>
            /// ชื่อหน่วยนับ(เต็ม)
            /// </summary>
            public string ExpFullUnitName => string.Format("{0}-{1}", UnitCode, UnitName);
            /// <summary>
            /// Safety Qty.
            /// </summary>
            public decimal SafetyQty { get; set; } = 0M;
            /// <summary>
            /// Minimum Qty.
            /// </summary>
            public decimal MinimumQty { get; set; } = 0M;
            /// <summary>
            /// Maximum Qty.
            /// </summary>
            public decimal MaximumQty { get; set; } = 0M;
            /// <summary>
            /// จำนวนคงเหลือ
            /// </summary>
            public decimal RemainQty { get; set; } = 0M;
            /// <summary>
            /// สินค้าค้างรับ
            /// </summary>
            public decimal TotalPOQty { get; set; } = 0M;
            /// <summary>
            /// ยอดจอง
            /// </summary>
            public decimal TotalSOQty { get; set; } = 0M;
            /// <summary>
            /// ยอดพร้อมขาย
            /// </summary>
            public decimal ReadySellQty => UtilHelper.gmRound(decimal.Subtract(RemainQty, TotalSOQty), 0, MidpointRounding.AwayFromZero);
            /// <summary>
            /// ราคามาตรฐาน
            /// </summary>
            public decimal StdPrice { get; set; } = 0M;
        }
    }
}
