using System;
using System.Collections.Generic;
using System.Text;

namespace RichnessSoft.Common
{
    public static class GbDocRefType
    {
        public static class BANK
        {
            //// <summary>
            /// เช็ค                                                                                             
            /// </summary>
            public const string CHEQUE = "CQE";
            public const string CHEQUE_GROUP = "BK";
            //// <summary>
            /// ใบนำฝาก                                                                                             
            /// </summary>
            public const string DEPOSIT_SLIP = "PIN";
            public const string DEPOSIT_SLIP_GROUP = "BK";
            //// <summary>
            /// ใบโอนเงินระหว่างธนาคาร
            /// </summary>
            public const string BANK_TRANSFER = "TRF";
            public const string BANK_TRANSFER_GROUP = "CQ";

        }
        public static class GL
        {
            //// <summary>
            /// ใบสำคัญการลงบัญชี
            /// </summary>
            public const string VOUCHER = "VC";
            public const string VOUCHER_GROUP = "GL";
        }
        public static class INVENTORY
        {
            //// <summary>
            /// ใบปรับยอด                                                                                             
            /// </summary>
            public const string ADJUST_INVENTORY = "AJ";
            public const string ADJUST_INVENTORY_GROUP = "AJ";
            //// <summary>
            /// ใบโอนระหว่างสาขา                                                                                              
            /// </summary>
            public const string BRANCH_TRANSFER = "BTF";
            public const string BRANCH_TRANSFER_GROUP = "TF";
            //// <summary>
            /// ใบขอโอนสินค้าระหว่างสาขา                                                                                             
            /// </summary>
            public const string BRANCH_TRANSFER_REQUEST = "BTR";
            public const string BRANCH_TRANSFER_REQUEST_GROUP = "RQ";
            //// <summary>
            /// ใบตรวจนับสต๊อก                                                                                             
            /// </summary>
            public const string CHECK_INVENTORY = "CK";
            public const string CHECK_INVENTORY_GROUP = "AJ";
            //// <summary>
            /// ใบส่งสินค้าชั่วคราว                                                                                             
            /// </summary>
            public const string DELIVERY_ORDER = "DO";
            public const string DELIVERY_ORDER_GROUP = "DO";
            //// <summary>
            /// ใบรับสินค้าชั่วคราว                                                                                              
            /// </summary>
            public const string GOODS_RECEIVED = "GR";
            public const string GOODS_RECEIVED_GROUP = "DO";
            //// <summary>
            /// ใบยืมสินค้า                                                                                             
            /// </summary>
            public const string BORROWING_NOTE_FROM_LOAN = "LB";
            public const string BORROWING_NOTE_FROM_LOAN_GROUP = "LO";
            //// <summary>
            /// ใบคืนสินค้าจากการยืม                                                                                             
            /// </summary>
            public const string RETURN_NOTE_TO_LOAN = "LR";
            public const string RETURN_NOTE_TO_LOAN_GROUP = "LO";
            //// <summary>
            /// ใบขอยืมสินค้า                                                                                             
            /// </summary>
            public const string BORROWING_FORM = "RL";
            public const string BORROWING_FORM_GROUP = "RQ";
            //// <summary>
            /// ใบโอนระหว่างคลัง                                                                                             
            /// </summary>
            public const string WAREHOUSE_TRANSFER = "WTF";
            public const string WAREHOUSE_TRANSFER_GROUP = "TF";
            //// <summary>
            /// ใบขอโอนสินค้าระหว่างคลัง                                                                                             
            /// </summary>
            public const string WAREHOUSE_TRANSFER_REQUSET = "WTR";
            public const string WAREHOUSE_TRANSFER_REQUSET_GROUP = "RQ";


        }
        public static class PURCHASE
        {
            //// <summary>
            /// ใบแจ้งหนี้ เงินมัดจำจ่ายล่วงหน้า 
            /// </summary>
            public const string INVOICE_ADVANCE_DEPOSIT = "ADP";
            public const string INVOICE_ADVANCE_DEPOSIT_GROUP = "BT";
            //// <summary>
            ///ลดหนี้ ซื้อเชื่อ(ภาษียังไม่ถึงกำหนด)
            /// </summary>
            public const string SERVICE_CREDIT_NOTE_BUY = "BCN";
            public const string SERVICE_CREDIT_NOTE_BUY_GROUP = "BS";
            //// <summary>
            /// เพิ่มหนี้ ซื้อเชื่อ(ภาษียังไม่ถึงกำหนด)
            /// </summary>
            public const string SERVICE_DEBIT_NOTE_BUY = "BDN";
            public const string SERVICE_DEBIT_NOTE_BUY_GROUP = "BS";
            //// <summary>
            /// ซื้อเชื่อ(ภาษียังไม่ถึงกำหนด) 
            /// </summary>
            public const string SERVICE_INVOICE_BUY = "BIV";
            public const string SERVICE_INVOICE_BUY_GROUP = "BS";
            //// <summary>
            /// ลดหนี้ ซื้อเชื่อ
            /// </summary>
            public const string PURCHASE_CREDIT_NOTE = "CNB";
            public const string PURCHASE_CREDIT_NOTE_GROUP = "BT";
            //// <summary>
            /// เพิ่มหนี้ ซื้อเชื่อ
            /// </summary>
            public const string PURCHASE_DEBIT_NOTE = "DNB";
            public const string PURCHASE_DEBIT_NOTE_GROUP = "BT";
            //// <summary>
            /// แจ้งหนี้ ซื้อเชื่อ
            /// </summary>
            public const string PURCHASE_TAX_INVOICE = "IVB";
            public const string PURCHASE_TAX_INVOICE_GROUP = "BT";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่าย บริษัทหักบุคคลธรรมดายื่น ภ.ง.ด. 1ก
            /// </summary>
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND1_KOR = "P1K";
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND1_KOR_GROUP = "WH";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่าย บริษัทหักบุคคลธรรมดายื่น ภ.ง.ด. 1ก พิเศษ
            /// </summary>
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND1_KOR_SPECIAL = "P1S";
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND1_KOR_SPECIAL_GROUP = "WH";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่าย บริษัทหักบุคคลธรรมดายื่น ภ.ง.ด. 2ก
            /// </summary>
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND2_KOR = "P2K";
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND2_KOR_GROUP = "WH";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่าย บริษัท หักบุคคลธรรมดายื่น ภ.ง.ด. 3ก
            /// </summary>
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND3_KOR = "P3K";
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND3_KOR_GROUP = "WH";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่าย บริษัท หักนิติบุคคลยื่น ภ.ง.ด. 53
            /// </summary>
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_CORPORATE_PND53 = "P53";
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_CORPORATE_PND53_GROUP = "WH";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่าย บริษัท หักนิติบุคคลยื่น ภ.ง.ด. 54
            /// </summary>
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_CORPORATE_PND54 = "P54";
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_CORPORATE_PND54_GROUP = "WH";
            //// <summary>
            /// ใบวางบิล
            /// </summary>
            public const string BILLING = "PBL";
            public const string BILLING_GROUP = "PL";
            //// <summary>
            /// ใบเสร็จรับเงิน(ซื้อสด)
            /// </summary>
            public const string TAX_INVOICE_RECEIPT_CASH_BUY = "PCI";
            public const string TAX_INVOICE_RECEIPT_CASH_BUY_GROUP = "BC";
            //// <summary>
            ///ลดหนี้(ซื้อสด)
            /// </summary>
            public const string TAX_INVOICE_CREDIT_NOTE_CASH_BUY = "PCN";
            public const string TAX_INVOICE_CREDIT_NOTE_CASH_BUY_GROUP = "BC";
            //// <summary>
            /// เพิ่มหนี้(ซื้อสด)
            /// </summary>
            public const string TAX_INVOICE_DEBIT_NOTE_CASH_BUY = "PDN";
            public const string TAX_INVOICE_DEBIT_NOTE_CASH_BUY_GROUP = "BC";
            //// <summary>
            /// ใบเสร็จ/ใบกำกับภาษี จ่ายเงินมัดจำล่วงหน้า
            /// </summary>
            public const string RECEIPT_TAX_INVOICE_DEPOSIT_ADVANCE = "PDP";
            public const string RECEIPT_TAX_INVOICE_DEPOSIT_ADVANCE_GROUP = "PM";
            //// <summary>
            /// ใบเสร็จ/ใบกำกับภาษี
            /// </summary>
            public const string RECEIPT_TAX_INVOICE = "PIV";
            public const string RECEIPT_TAX_INVOICE_GROUP = "PM";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่าย บริษัทหักบุคคลธรรมดายื่น ภ.ง.ด. 1
            /// </summary>
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND1 = "PN1";
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND1_GROUP = "WH";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่าย บริษัทหักบุคคลธรรมดายื่น ภ.ง.ด. 2
            /// </summary>
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND2 = "PN2";
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND2_GROUP = "WH";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่าย บริษัท หักบุคคลธรรมดายื่น ภ.ง.ด. 3
            /// </summary>
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND3 = "PN3";
            public const string WITHHOLDING_TAX_DEDUCT_COMPANY_INDIVIDUAL_PND3_GROUP = "WH";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่าย(กรณีเราเป็นผู้จ่าย/ผู้หักภาษี)
            /// </summary>
            public const string WITHHOLDING_TAX_NOTE_PAY = "PND";
            public const string WITHHOLDING_TAX_NOTE_PAY_GROUP = "WH";
            //// <summary>
            /// ใบสั่งซื้อ
            /// </summary>
            public const string PURCHASE_ORDER = "PO";
            public const string PURCHASE_ORDER_GROUP = "PO";
            //// <summary>
            /// ใบเตรียมจ่ายชำระ(ก่อนรับใบเสร็จ/ใบกำกับภาษี)
            /// </summary>
            public const string PAYMENT_PREPARATION_BEFORE_RECEIPT_TAX_INVOICE = "PPI";
            public const string PAYMENT_PREPARATION_BEFORE_RECEIPT_TAX_INVOICE_GROUP = "PP";
            //// <summary>
            /// ใบเตรียมจ่ายชำระ(ก่อนรับใบเสร็จ)
            /// </summary>
            public const string PAYMENT_PREPARATION_BEFORE_RECEIPT = "PPR";
            public const string PAYMENT_PREPARATION_BEFORE_RECEIPT_GROUP = "PP";
            //// <summary>
            /// ใบขอซื้อ
            /// </summary>
            public const string PURCHASE_REQUEST = "PR";
            public const string PURCHASE_REQUEST_GROUP = "PO";
            //// <summary>
            /// ใบเสร็จรับเงิน
            /// </summary>
            public const string RECEIPT = "PRE";
            public const string RECEIPT_GROUP = "PM";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่ายกระทำการแทน บริษัท หักบุคคลธรรมดา ยื่นภงด.3
            /// </summary>
            public const string TAX_WITHHOLDING_COMPANY_FILED_INDIVIDUAL_INCOME_PND3 = "WT3";
            public const string TAX_WITHHOLDING_COMPANY_FILED_INDIVIDUAL_INCOME_PND3_GROUP = "WH";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่ายกระทำการแทน บริษัท หักนิติบุคคล ยื่นภงด.53 
            /// </summary>
            public const string TAX_WITHHOLDING_COMPANY_FILED_INDIVIDUAL_INCOME_PND53 = "WT5";
            public const string TAX_WITHHOLDING_COMPANY_FILED_INDIVIDUAL_INCOME_PND53_GROUP = "WH";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่ายอื่นๆ(หักภาษี ณ ที่จ่ายไว้)
            /// </summary>
            public const string TAX_WITHHOLDING_OTHERS = "WTO";
            public const string TAX_WITHHOLDING_OTHERS_GROUP = "WH";
        }
        public static class SALE
        {
            //// <summary>
            /// ลดหนี้ ขายเชื่อ
            /// </summary>
            public const string TAX_INVOICE_CREDIT_NOTE_CREDIT_SELL = "CNS";
            public const string TAX_INVOICE_CREDIT_NOTE_CREDIT_SELL_GROUP = "ST";
            //// <summary>
            /// เพิ่มหนี้ ขายเชื่อ
            /// </summary>
            public const string TAX_INVOICE_DEBIT_NOTE_CREDIT_SELL = "DNS";
            public const string TAX_INVOICE_DEBIT_NOTE_CREDIT_SELL_GROUP = "ST";
            //// <summary>
            /// เงินมัดจำรับล่วงหน้า
            /// </summary>
            public const string TAX_INVOICE_DEPOSIT_RECEIVED_ADVANCE = "DPR";
            public const string TAX_INVOICE_DEPOSIT_RECEIVED_ADVANCE_GROUP = "ST";
            //// <summary>
            /// ใบแจ้งหนี้ ขายเชื่อ 
            /// </summary>
            public const string TAX_INVOICE_INVOICE_CREDIT_SELL = "IVS";
            public const string TAX_INVOICE_INVOICE_CREDIT_SELL_GROUP = "ST";
            //// <summary>
            /// ใบเสนอราคา สินค้า/บริการ
            /// </summary>
            public const string QUOTATION = "QT";
            public const string QUOTATION_GROUP = "SO";
            //// <summary>
            /// ใบรับวางบิล
            /// </summary>
            public const string BILLING_RECEIPT = "RBL";
            public const string BILLING_RECEIPT_GROUP = "RL";
            //// <summary>
            /// ใบเสร็จรับเงิน ขายสด
            /// </summary>
            public const string TAX_INVOICE_RECEIPT_CASH_SALE = "RCI";
            public const string TAX_INVOICE_RECEIPT_CASH_SALE_GROUP = "SC";
            //// <summary>
            /// ลดหนี้ ขายสด
            /// </summary>
            public const string TAX_INVOICE_CREDIT_NOTE_CASH_SALE = "RCN";
            public const string TAX_INVOICE_CREDIT_NOTE_CASH_SALE_GROUP = "SC";
            //// <summary>
            /// เพิ่มหนี้ ขายสด
            /// </summary>
            public const string TAX_INVOICE_DEBIT_NOTE_CASH_SALE = "RDN";
            public const string TAX_INVOICE_DEBIT_NOTE_CASH_SALE_GROUP = "SC";
            //// <summary>
            ///  เงินมัดจำรับ
            /// </summary>
            public const string RECEIPT_TAX_INVOICE_DEPOSIT_RECEIVED = "RDP";
            public const string RECEIPT_TAX_INVOICE_DEPOSIT_RECEIVED_GROUP = "RE";
            //// <summary>
            /// ใบเสร็จ/ใบกำกับภาษี
            /// </summary>
            public const string RECEIPT_TAX_INVOICE = "RIV";
            public const string RECEIPT_TAX_INVOICE_GROUP = "RE";
            //// <summary>
            /// ใบเสร็จ/ใบกำกับภาษี(พิมพ์ก่อนการรับเงิน)
            /// </summary>
            public const string RECEIPT_TAX_INVOICE_PRE_PAID = "RPI";
            public const string RECEIPT_TAX_INVOICE_PRE_PAID_GROUP = "RP";
            //// <summary>
            /// ใบเสร็จ(เพิ่มก่อนการรับเงิน)
            /// </summary>
            public const string RECEIPT_PRE_PAID = "RPR";
            public const string RECEIPT_PRE_PAID_GROUP = "RP";
            //// <summary>
            /// ใบเสร็จรับเงิน
            /// </summary>
            public const string RECEIPT = "RRE";
            public const string RECEIPT_GROUP = "RE";
            //// <summary>
            /// ลดหนี้ ขายเชื่อ(ภาษียังไม่ถึงกำหนด)
            /// </summary>
            public const string INVOICE_CREDIT_NOTE_TAX_NOT_DUE = "SCN";
            public const string INVOICE_CREDIT_NOTE_TAX_NOT_DUE_GROUP = "SS";
            //// <summary>
            /// เพิ่มหนี้ ขายเชื่อ(ภาษียังไม่ถึงกำหนด)
            /// </summary>
            public const string INVOICE_DEBIT_NOTE_TAX_NOT_DUE = "SDN";
            public const string INVOICE_DEBIT_NOTE_TAX_NOT_DUE_GROUP = "SS";
            //// <summary>
            /// ขายเชื่อ(ภาษียังไม่ถึงกำหนด)
            /// </summary>
            public const string CREDIT_SALE_INVOICE_TAX_NOT_DUE = "SIV";
            public const string CREDIT_SALE_INVOICE_TAX_NOT_DUE_GROUP = "SS";
            //// <summary>
            /// ใบรับคำสั่งซื้อ สินค้า/บริการ
            /// </summary>
            public const string SALE_ORDER = "SO";
            public const string SALE_ORDER_GROUP = "SO";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่าย บริษัทถูกหัก ไม่นำส่งแต่ไว้ตรวจสอบรายการ
            /// </summary>
            public const string COMPANY_TAX_WITHHOLDING_DEDUCTED_NOT_REMITTED_CHECK_LIST = "WHC";
            public const string COMPANY_TAX_WITHHOLDING_DEDUCTED_NOT_REMITTED_CHECK_LIST_GROUP = "WH";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่าย(กรณีเราเป็นผู้รับ/ถูกหักภาษี)
            /// </summary>
            public const string WITHHOLDING_TAX_CASE_RECIPIENT_TAXED = "WHN";
            public const string WITHHOLDING_TAX_CASE_RECIPIENT_TAXED_GROUP = "WH";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่ายอื่นๆ(ถูกหักภาษี ณ ที่จ่าย)
            /// </summary>
            public const string OTHER_WITHHOLDING_TAX = "WHO";
            public const string OTHER_WITHHOLDING_TAX_GROUP = "WH";
            //// <summary>
            /// ใบภาษีหัก ณ ที่จ่าย บุคคลธรรมดาถูกหัก ไม่ต้องนำส่ง
            /// </summary>
            public const string WITHHOLDING_TAX_NOTE_PERSONA_NOT_SUBMIT = "WHP";
            public const string WITHHOLDING_TAX_NOTE_PERSONA_NOT_SUBMIT_GROUP = "WH";
        }

        //// <summary>
        /// ลงรายวันทั่วไป
        /// </summary>
        public const string GENERAL_JOURNAL = "GL";
        //// <summary>
        /// ภาษีหัก ณ ที่จ่าย
        /// </summary>
        public const string WITHHOLDING_TAX = "WH";

        public static class GbAccRole
        {
            /// <summary>
            /// เงินบริจาค 
            /// </summary> 
            public const string gc_ACLINK_DONATION = "00001";
            /// <summary>
            /// ค่ารับรอง 
            /// </summary> 
            public const string gc_ACLINK_CERTIFICATION = "00002";
            /// <summary>
            /// ภาษีซื้อขอคืนไม่ได้ 
            /// </summary> 
            public const string gc_ACLINK_PURCH_VAT_NOT_RETURN = "00003";
            /// <summary>
            /// ภาษีซื้อไม่ขอคืน 
            /// </summary> 
            public const string gc_ACLINK_PURCH_VAT_NOT_REFUND = "00004";
            /// <summary>
            /// ค่าใช้จ่ายต้องห้าม 2 
            /// </summary> 
            public const string gc_ACLINK_EXP_TAX2 = "00005";
            /// <summary>
            /// ค่าใช้จ่ายต้องห้าม 3 
            /// </summary> 
            public const string gc_ACLINK_EXP_TAX3 = "00006";
            /// <summary>
            /// ที่ดิน 
            /// </summary> 
            public const string gc_ACLINK_LAND = "00007";
            /// <summary>
            /// อาคาร 
            /// </summary> 
            public const string gc_ACLINK_BUILDING = "00008";
            /// <summary>
            /// อุปกรณ์สำนักงาน 
            /// </summary> 
            public const string gc_ACLINK_OFFICE_EQUIPMENT = "00009";
            /// <summary>
            /// เครื่องจักร 
            /// </summary> 
            public const string gc_ACLINK_MACHINE = "00010";
            /// <summary>
            /// วัสดุประกอบคงคลัง 
            /// </summary> 
            public const string gc_ACLINK_RM_INV = "00011";
            /// <summary>
            /// อะไหล่ 
            /// </summary> 
            public const string gc_ACLINK_SPARE = "00012";
            /// <summary>
            /// วัสดุปะผิวคงคลัง 
            /// </summary> 
            public const string gc_ACLINK_LABEL = "00013";
            /// <summary>
            /// วัสดุหีบห่อคงคลัง 
            /// </summary> 
            public const string gc_ACLINK_PACKAGE = "00014";
            /// <summary>
            /// วัสดุสิ้นเปลืองคงคลัง 
            /// </summary> 
            public const string gc_ACLINK_OFFICE_SUPPLY = "00015";
            /// <summary>
            /// ซื้อวัตถุดิบ 
            /// </summary> 
            public const string gc_ACLINK_BUY_RAW_MAT = "00016";
            /// <summary>
            /// ขาดทุนจากการขายสินทรัพย์ 
            /// </summary> 
            public const string gc_ACLINK_LOSS_ASSET = "00017";
            /// <summary>
            /// ซื้อสินค้ากึ่งสำเร็จรูป 
            /// </summary> 
            public const string gc_ACLINK_SEMI = "00018";
            /// <summary>
            /// ซื้อวัสดุหีบห่อ 
            /// </summary> 
            public const string gc_ACLINK_PACKING_RM = "00019";
            /// <summary>
            /// ซื้อวัสดุปะผิว 
            /// </summary> 
            public const string gc_ACLINK_PATCH_RM = "00020";
            /// <summary>
            /// ซื้อวัสดุประกอบ 
            /// </summary> 
            public const string gc_ACLINK_COMPO = "00021";
            /// <summary>
            /// ซื้อวัสดุสิ้นเปลือง 
            /// </summary> 
            public const string gc_ACLINK_BUY_SUPPLIES = "00022";
            /// <summary>
            /// ลูกหนี้บัตรเครดิต 
            /// </summary> 
            public const string gc_ACLINK_CREDIT_CARD_AR = "00023";
            /// <summary>
            /// คูปอง 
            /// </summary> 
            public const string gc_ACLINK_COUPON = "00024";
            /// <summary>
            /// เงินเกิน 
            /// </summary> 
            public const string gc_ACLINK_OVER = "00025";
            /// <summary>
            /// ค่าคอมมิชชั่น 
            /// </summary> 
            public const string gc_ACLINK_COMMISSION = "00026";
            /// <summary>
            /// ธนาณัติ 
            /// </summary> 
            public const string gc_ACLINK_MONEY_ORDER = "00027";
            /// <summary>
            /// กำไรจากการปริวรรตเงินตรา 
            /// </summary> 
            public const string gc_ACLINK_PROFIT_EXCHANGE = "00028";
            /// <summary>
            /// ขาดทุนจากการปริวรรตเงินตรา 
            /// </summary> 
            public const string gc_ACLINK_LOSS_EXCHANGE = "00029";
            /// <summary>
            /// เงินเดือน 
            /// </summary> 
            public const string gc_ACLINK_SALARY = "00030";
            /// <summary>
            /// เงินประกันสังคม 
            /// </summary> 
            public const string gc_ACLINK_SOCIAL = "00031";
            /// <summary>
            /// เงินกองทุนสำรองเลี้ยงชีพ 
            /// </summary> 
            public const string gc_ACLINK_FUND = "00032";
            /// <summary>
            /// ธนาคารเพื่อจ่ายเงินเดือน 
            /// </summary> 
            public const string gc_ACLINK_BANK_SALARY = "00033";
            /// <summary>
            /// ค่าจ้างชั่วคราว 
            /// </summary> 
            public const string gc_ACLINK_WAGE = "00034";
            /// <summary>
            /// ค่าตอบแทนค้างจ่าย 
            /// </summary> 
            public const string gc_ACLINK_EXPENSE_CREDIT = "00035";
            /// <summary>
            /// บัญชีเจ้าหนี้เงินมัดจำ 
            /// </summary> 
            public const string gc_ACLINK_AP_DEPOSIT = "AP_DEPOSIT";
            /// <summary>
            /// เจ้าหนี้เงินประกันผลงาน 
            /// </summary> 
            public const string gc_ACLINK_AP_PERMO_INSUR = "AP_Reten";
            /// <summary>
            /// บัญชีเจ้าหนี้การค้า 
            /// </summary> 
            public const string gc_ACLINK_AP1 = "AP1";
            /// <summary>
            /// บัญชีลูกหนี้เงินมัดจำ 
            /// </summary> 
            public const string gc_ACLINK_AR_DEPOSIT = "AR_DEPOSIT";
            /// <summary>
            /// ลูกหนี้เงินประกันผลงาน 
            /// </summary> 
            public const string gc_ACLINK_AR_RETENTION = "AR_Reten";
            /// <summary>
            /// บัญชีลูกหนี้การค้า 
            /// </summary> 
            public const string gc_ACLINK_AR1 = "AR1";
            /// <summary>
            /// สินทรัพย์ 
            /// </summary> 
            public const string gc_ACLINK_ASSET_AMT = "Asset";
            /// <summary>
            /// ค่าธรรมเนียมธนาคาร  
            /// </summary> 
            public const string gc_ACLINK_BANK_FEE = "BankFee";
            /// <summary>
            /// บัญชีซื้อสด 
            /// </summary> 
            public const string gc_ACLINK_BUY_CASH = "BuyCash";
            /// <summary>
            /// ซื้อเพื่อคำนวณต้นทุนขาย1 
            /// </summary> 
            public const string gc_ACLINK_BUY_COST1 = "BuyCost1";
            /// <summary>
            /// ซื้อเพื่อคำนวณต้นทุนขาย2 
            /// </summary> 
            public const string gc_ACLINK_BUY_COST2 = "BuyCost2";
            /// <summary>
            /// ซื้อเพื่อคำนวณต้นทุนขาย3 
            /// </summary> 
            public const string gc_ACLINK_BUY_COST3 = "BuyCost3";
            /// <summary>
            /// ซื้อเพื่อคำนวณต้นทุนขาย4 
            /// </summary> 
            public const string gc_ACLINK_BUY_COST4 = "BuyCost4";
            /// <summary>
            /// ซื้อเพื่อคำนวณต้นทุนขาย5 
            /// </summary> 
            public const string gc_ACLINK_BUY_COST5 = "BuyCost5";
            /// <summary>
            /// บัญชีซื้อเชื่อ 
            /// </summary> 
            public const string gc_ACLINK_BUY_CRED = "BuyCred";
            /// <summary>
            /// บัญชีเงินสด 
            /// </summary> 
            public const string gc_ACLINK_CASH = "Cash";
            /// <summary>
            /// บัญชีเงินสดจ่าย(ตอนจ่ายให้จ/น) 
            /// </summary> 
            public const string gc_ACLINK_PAY_CASH = "CashPay";
            /// <summary>
            /// บัญชีเงินสดรับ(ตอนรับชำระเงิน) 
            /// </summary> 
            public const string gc_ACLINK_RECE_CASH = "CashRcv";
            /// <summary>
            /// เช็คจ่าย 
            /// </summary> 
            public const string gc_ACLINK_PAY_CHEQUE = "ChqPay";
            /// <summary>
            /// เช็ครับ 
            /// </summary> 
            public const string gc_ACLINK_RECE_CHEQUE = "ChqRcp";
            /// <summary>
            /// ค่าใช้จ่ายภาษีเงินได้นิติบุคคล 
            /// </summary> 
            public const string gc_ACLINK_COINCTAEXP = "CoIncTaExp";
            /// <summary>
            /// ต้นทุนขาย 
            /// </summary> 
            public const string gc_ACLINK_SELL_COST = "CostSold";
            /// <summary>
            /// ค่าเผื่อหนี้สงสัยจะสูญ 
            /// </summary> 
            public const string gc_ACLINK_DEBTALLOW = "DebtAllow";
            /// <summary>
            /// หนี้สงสัยจะสูญ 
            /// </summary> 
            public const string gc_ACLINK_DEBTALLOW2 = "DebtAllow2";
            /// <summary>
            /// ค่าใช้จ่ายทางตรง 
            /// </summary> 
            public const string gc_ACLINK_DIRECT_EXPENSE = "DirExp";
            /// <summary>
            /// ค่าแรงทางตรง 
            /// </summary> 
            public const string gc_ACLINK_DIRLABOR = "DirLabor";
            /// <summary>
            /// ส่วนลดจ่าย 
            /// </summary> 
            public const string gc_ACLINK_PAY_DISC = "DiscRcp";
            /// <summary>
            /// ส่วนลดรับ 
            /// </summary> 
            public const string gc_ACLINK_RECE_DISC = "DispPay";
            /// <summary>
            /// ค่าใช้จ่ายต้นทุนทางการเงิน 
            /// </summary> 
            public const string gc_ACLINK_EXP_COSTMONEY = "FinCostExp";
            /// <summary>
            /// คชจ.ที่เป็นต้นทุนขาย 01 
            /// </summary> 
            public const string gc_ACLINK_EXP_COST01 = "Freight01";
            /// <summary>
            /// คชจ.ที่เป็นต้นทุนขาย 02 
            /// </summary> 
            public const string gc_ACLINK_EXP_COST02 = "Freight02";
            /// <summary>
            /// คชจ.ที่เป็นต้นทุนขาย 03 
            /// </summary> 
            public const string gc_ACLINK_EXP_COST03 = "Freight03";
            /// <summary>
            /// คชจ.ที่เป็นต้นทุนขาย 04 
            /// </summary> 
            public const string gc_ACLINK_EXP_COST04 = "Freight04";
            /// <summary>
            /// คชจ.ที่เป็นต้นทุนขาย 05 
            /// </summary> 
            public const string gc_ACLINK_EXP_COST05 = "Freight05";
            /// <summary>
            /// คชจ.ที่เป็นต้นทุนขาย 06 
            /// </summary> 
            public const string gc_ACLINK_EXP_COST06 = "Freight06";
            /// <summary>
            /// คชจ.ที่เป็นต้นทุนขาย 07 
            /// </summary> 
            public const string gc_ACLINK_EXP_COST07 = "Freight07";
            /// <summary>
            /// คชจ.ที่เป็นต้นทุนขาย 08 
            /// </summary> 
            public const string gc_ACLINK_EXP_COST08 = "Freight08";
            /// <summary>
            /// คชจ.ที่เป็นต้นทุนขาย 09 
            /// </summary> 
            public const string gc_ACLINK_EXP_COST09 = "Freight09";
            /// <summary>
            /// คชจ.ที่เป็นต้นทุนขาย 10 
            /// </summary> 
            public const string gc_ACLINK_EXP_COST10 = "Freight10";
            /// <summary>
            /// สินค้าสำเร็จรูป 
            /// </summary> 
            public const string gc_ACLINK_FINISH = "GoodsAmt";
            /// <summary>
            /// ค่าใช้จ่ายทางอ้อม 
            /// </summary> 
            public const string gc_ACLINK_INDIRECT_EXPENSE = "InDirExp";
            /// <summary>
            /// ค่าแรงทางอ้อม 
            /// </summary> 
            public const string gc_ACCLINK_INDIRECT_WAGES = "InDirLabor";
            /// <summary>
            /// หนี้สิน 
            /// </summary> 
            public const string gc_ACLINK_DEBT = "Liability";
            /// <summary>
            /// บัญชีภาษีซื้อไม่ถึงกำหนด 
            /// </summary> 
            public const string gc_ACLINK_PURCH_VAT_NDUE = "NDueVBuy";
            /// <summary>
            /// บัญชีภาษีขายไม่ถึงกำหนด 
            /// </summary> 
            public const string gc_ACLINK_SALE_VAT_NDUE = "NDueVSell";
            /// <summary>
            /// ชำระอื่นๆ 1 
            /// </summary> 
            public const string gc_ACLINK_OTHER_PAYMENT1 = "OthPay01";
            /// <summary>
            /// ชำระอื่นๆ 2 
            /// </summary> 
            public const string gc_ACLINK_OTHER_PAYMENT2 = "OthPay02";
            /// <summary>
            /// ชำระอื่นๆ 3 
            /// </summary> 
            public const string gc_ACLINK_OTHER_PAYMENT3 = "OthPay03";
            /// <summary>
            /// ชำระอื่นๆ 4 
            /// </summary> 
            public const string gc_ACLINK_OTHER_PAYMENT4 = "OthPay04";
            /// <summary>
            /// ชำระอื่นๆ 5 
            /// </summary> 
            public const string gc_ACLINK_OTHER_PAYMENT5 = "OthPay05";
            /// <summary>
            /// บัญชีกำไร-ขาดทุน 
            /// </summary> 
            public const string gc_ACLINK_PL = "P/LAcct";
            /// <summary>
            /// บัญชีกำไร-ขาดทุนสะสม 
            /// </summary> 
            public const string gc_ACLINK_PL_ACCM = "P/LSum";
            /// <summary>
            /// เงินมัดจำจ่ายล่วงหน้า 
            /// </summary> 
            public const string gc_ACLINK_PLEDGE_PAY = "PayPledge";
            /// <summary>
            /// ดอกเบี้ยจ่าย 
            /// </summary> 
            public const string gc_ACLINK_PURCH_INTEREST = "PInterest";
            /// <summary>
            /// กำไรขาดทุนจากการขายสินทรัพย์ 
            /// </summary> 
            public const string gc_ACLINK_PL_ASSET = "PLAsset";
            /// <summary>
            /// สินค้าส่งคืนและส่วนลด 
            /// </summary> 
            public const string gc_ACLINK_DISCOUNT_PAY = "PRetAllowa";
            /// <summary>
            /// ต้นทุนการผลิต 
            /// </summary> 
            public const string gc_ACLINK_PROCESS_COST = "ProcCost";
            /// <summary>
            /// ค่าบริการ 
            /// </summary> 
            public const string gc_ACLINK_PURCH_SERVICE_CASH = "PSrvCash";
            /// <summary>
            /// ค่าบริการ-เชื่อ 
            /// </summary> 
            public const string gc_ACLINK_PURCH_SERVICE_CRED = "PSrvCred";
            /// <summary>
            /// วัตถุดิบ 
            /// </summary> 
            public const string gc_ACLINK_RAW_MAT = "RawAmt";
            /// <summary>
            /// เงินมัดจำรับล่วงหน้า 
            /// </summary> 
            public const string gc_ACLINK_PLEDGE_REC = "RecPledge";
            /// <summary>
            /// รายได้ 
            /// </summary> 
            public const string gc_ACLINK_INCOME = "Revenues";
            /// <summary>
            /// บัญชีขายสด 
            /// </summary> 
            public const string gc_ACLINK_SELL_CASH = "SellCash";
            /// <summary>
            /// บัญชีขายเชื่อ 
            /// </summary> 
            public const string gc_ACLINK_SELL_CRED = "SellCred";
            /// <summary>
            /// ค่าใช้จ่าย 
            /// </summary> 
            public const string gc_ACLINK_EXPENSE = "SellExp";
            /// <summary>
            /// สินค้ากึ่งสำเร็จ 
            /// </summary> 
            public const string gc_ACLINK_SEMI_FG = "SemiAmt";
            /// <summary>
            /// ทุน 
            /// </summary> 
            public const string gc_ACLINK_CAPITAL = "Share";
            /// <summary>
            /// ดอกเบี้ยรับ 
            /// </summary> 
            public const string gc_ACLINK_SALE_INTEREST = "SInterest";
            /// <summary>
            /// สินค้ารับคืนและส่วนลด 
            /// </summary> 
            public const string gc_ACLINK_DISCOUNT_RET_PD = "SRetAllowa";
            /// <summary>
            /// รายได้จากบริการ 
            /// </summary> 
            public const string gc_ACLINK_SALE_SERVICE_CASH = "SSrvCash";
            /// <summary>
            /// รายได้จากบริการค้างรับ 
            /// </summary> 
            public const string gc_ACLINK_SALE_SERVICE_CRED = "SSrvCred";
            /// <summary>
            /// วัสดุสิ้นเปลืองใช้ไป 
            /// </summary> 
            public const string gc_ACLINK_OFFICE_SUPPLY_USED = "SupplyUsed";
            /// <summary>
            /// ภาษีหัก ณ ที่จ่าย บุคคลธรรมดา ภงด.1 ค้างจ่าย (นำส่ง) 
            /// </summary> 
            public const string gc_ACLINK_PURCH_TAX1_CREDIT = "Tax1CPay";
            /// <summary>
            /// ภาษีหัก ณ ที่จ่าย บุคคลธรรมดา ภงด.1 (นำส่ง) 
            /// </summary> 
            public const string gc_ACLINK_PURCH_TAX1 = "Tax1Pay";
            /// <summary>
            /// ภาษีหัก ณ ที่จ่าย บุคคลธรรมดา ภงด.2 ค้างจ่าย (นำส่ง) 
            /// </summary> 
            public const string gc_ACLINK_PURCH_TAX2_CREDIT = "Tax2CPay";
            /// <summary>
            /// ภาษีหัก ณ ที่จ่าย บุคคลธรรมดา ภงด.2 (นำส่ง) 
            /// </summary> 
            public const string gc_ACLINK_PURCH_TAX2 = "Tax2Pay";
            /// <summary>
            /// ภาษีหัก ณ ที่จ่าย บุคคลธรรมดา 
            /// </summary> 
            public const string gc_ACLINK_PURCH_TAX3 = "Tax3Pay";
            /// <summary>
            /// ภาษีหัก ณ ที่จ่าย บุคคลธรรมดา ค้างจ่าย 
            /// </summary> 
            public const string gc_ACLINK_PURCH_TAX3_CREDIT = "Tax3Pay2";
            /// <summary>
            /// ภาษีเงินได้บุคคลธรรมดาหัก ณ ที่จ่าย 
            /// </summary> 
            public const string gc_ACLINK_SALE_TAX3 = "Tax3Rcp";
            /// <summary>
            /// ภาษีหัก ณ ที่จ่าย นิติบุคคล 
            /// </summary> 
            public const string gc_ACLINK_PURCH_TAX5 = "Tax5Pay";
            /// <summary>
            /// ภาษีหัก ณ ที่จ่าย นิติบุคคล ค้างจ่าย 
            /// </summary> 
            public const string gc_ACLINK_PURCH_TAX5_CREDIT = "Tax5Pay2";
            /// <summary>
            /// ภาษีเงินได้นิติบุคคลหัก ณ ที่จ่าย 
            /// </summary> 
            public const string gc_ACLINK_SALE_TAX5 = "Tax5Rcp";
            /// <summary>
            /// ค่าใช้จ่ายต้องห้าม 
            /// </summary> 
            public const string gc_ACLINK_EXP_TAX = "TaxExp";
            /// <summary>
            /// บัญชีภาษีซื้อ 
            /// </summary> 
            public const string gc_ACLINK_PURCH_VAT = "VATBuy";
            /// <summary>
            /// บัญชีภาษีขาย 
            /// </summary> 
            public const string gc_ACLINK_SALE_VAT = "VATSell";
            /// <summary>
            /// สินค้าระหว่างทำ 
            /// </summary> 
            public const string gc_ACLINK_PD_INPROCESS = "WIPAmt";
            /// <summary>
            /// ค่าใช้จ่ายในการผลิตและการดำเนินงานโรงงาน 
            /// </summary> 
            public const string gc_ACLINK_PD_COST = "WorkExp";
            /// <summary>
            /// ลูกหนี้สรรพากร 
            /// </summary> 
            public const string gc_ACLINK_DEBTOR_GOV = "00036";
            /// <summary>
            /// เจ้้าหนี้สรรพากร 
            /// </summary> 
            public const string gc_ACLINK_CREDITOR_GOV = "00037";
            /// <summary>
            /// ATS-รายการบัญชีอัตดนมัติ 
            /// </summary> 
            public const string gc_ACLINK_AUTO_ACC = "00038";
            /// <summary>
            /// BB-ฝากโดยเช็ค เงินตรา ตปท. 
            /// </summary> 
            public const string gc_ACLINK_TRD_NAT = "00039";
            /// <summary>
            /// BG-Bank Guarantee 
            /// </summary> 
            public const string gc_ACLINK_BANK_GA = "00040";
            /// <summary>
            /// CC-ฝากโดยเช็คเรียกเก็บ 
            /// </summary> 
            public const string gc_ACLINK_DEP_CHEQUE = "00041";
            /// <summary>
            /// CD-บัตรเครดิต 
            /// </summary> 
            public const string gc_ACLINK_DEP_CLEARING = "00042";
            /// <summary>
            /// CG-ถอนเงินผ่านเคลียริ่ง 
            /// </summary> 
            public const string gc_ACLINK_WITHD_CLEARING = "00043";
            /// <summary>
            /// CL-ฝากโดยเช็คธนาคารอื่น 
            /// </summary> 
            public const string gc_ACLINK_DEP_OTH_CHQ = "00044";
            /// <summary>
            /// CR-เช็คคืน 
            /// </summary> 
            public const string gc_ACLINK_RET_CHEQUE = "00045";
            /// <summary>
            /// CS-ถอนเงินสด 
            /// </summary> 
            public const string gc_ACLINK_WITHD_CASH = "00046";
            /// <summary>
            /// DD-ฝากโดยดราฟท์ 
            /// </summary> 
            public const string gc_ACLINK_DEP_DARTF = "00047";
            /// <summary>
            /// INW-ดอกเบี้ย 
            /// </summary> 
            public const string gc_ACLINK_INTEREST = "00048";
            /// <summary>
            /// LC-เล็ตเตอร์ออฟเครดิต 
            /// </summary> 
            public const string gc_ACLINK_LET_OF_CREDIT = "00049";
            /// <summary>
            /// OV-ค่า OV 
            /// </summary> 
            public const string gc_ACLINK_OV = "00050";
            /// <summary>
            /// PC-ฝากโดยเงินสด 
            /// </summary> 
            public const string gc_ACLINK_DEP_CASH = "00051";
            /// <summary>
            /// RF-Refer 
            /// </summary> 
            public const string gc_ACLINK_REFER = "00052";
        }

    }
}
