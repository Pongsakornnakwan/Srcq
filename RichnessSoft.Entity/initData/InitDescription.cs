using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RichnessSoft.Entity.initData
{
    public static class InitDescription
    {
        /// <summary>
        /// 00-ไม่ระบุ
        /// </summary>
        public const string gstrDefaultDesciptionCode = "00";
        public static void InitializeAsync(RicnessDbContext context
        , RichnessLogDbContext contextlog
        , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            IList<Descriptions> listData = new List<Descriptions>()
            {
                //สาเหตุเช็คคืน
                new Descriptions {companyid = initCompany.companyid,  code = gstrDefaultDesciptionCode, desc ="ไม่ระบุ", desc2 ="Not specified" , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "01", desc ="เงินในบัญชีไม่พอจ่าย", desc2 ="Not enough money in the account to pay." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "02", desc ="บัญชีปิดแล้ว", desc2 ="Account is closed." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "03", desc ="สั่งจ่ายจากจำนวนที่มีตราสารรอเรียกเก็บเงินอยู่ โปรดดิดต่อผู้สั่งจ่าย", desc2 ="Payable from the amount that the instrument is pending for billing. Please contact the payer." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "04", desc ="เช็คลงวันที่ล่วงหน้า", desc2 ="Advance dated cheque" , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "05", desc ="เช็คพ้นกำหนดจ่ายเงิน", desc2 ="Overdue cheque" , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "06", desc ="จำนวนเงินที่เป็นตัวอักษรและตัวเลขไม่ตรงกัน", desc2 ="Alphanumeric amounts do not match." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "07", desc ="โปรดให้ผู้สั่งจ่ายลงนามกำกับการแก้ไขตามเงื่อนไขที่ให้ไว้กับธนาคาร", desc2 ="Please allow the payer to sign for the amendment according to the conditions provided to the bank." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "08", desc ="ลายมือชื่อผู้สั่งจ่ายไม่ถูกต้องตามเงื่อนไขที่ให้ไว้กับธนาคาร", desc2 ="Payer signature is not correct according to the conditions given to the bank." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "09", desc ="โปรดประทับตราของผู้สั่งจ่ายตามตัวอย่างที่ให้ไว้กับธนาคาร", desc2 ="Please stamp the payer according to the sample provided to the bank." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "10", desc ="โปรดสลักหลังให้ครบถ้วนถูกต้อง", desc2 ="Please endorse it completely and correctly." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "11", desc ="มีคำสั่งให้ระงับการจ่าย", desc2 ="There is an order to suspend payment." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "12", desc ="เช็คชำรุด โปรดติดต่อผู้สั่งจ่าย", desc2 ="Cheque is damaged, please contact the payer." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "19", desc ="ผู้สั่งจ่ายถึงแก่กรรม", desc2 ="Payer passed away" , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                //สาเหตุในการยกเลิกใบกำกับภาษีเดิม
                new Descriptions {companyid = initCompany.companyid,  code = gstrDefaultDesciptionCode, desc ="ไม่ระบุ", desc2 ="Not specified" , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_TAX_INV, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "01", desc ="ออกใบกำกับภาษีผิด", desc2 ="Issuing wrong tax invoice" , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_TAX_INV, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                //สาเหตุการคืนสินค้า
                new Descriptions {companyid = initCompany.companyid,  code = gstrDefaultDesciptionCode, desc ="อื่นๆ", desc2 ="Other" , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_PROD_INV, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "01", desc ="เสียหาย – สินค้าเสียหายระหว่างการจัดส่ง", desc2 ="Damaged-Goods damaged during delivery." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_PROD_INV, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "02", desc ="ใช้การไม่ได้ – สินค้าไม่สามารถทำงานได้ตามที่อธิบายไว้ในข้อกำหนดของผู้ผลิต", desc2 ="Inoperable – Product does not perform as described in the manufacturer's specifications." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_PROD_INV, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "03", desc ="สินค้าไม่ถูกต้อง / ผิด – ไม่ใช่สินค้าที่ลูกค้าสั่งซื้อ (เช่น ผิดขนาด หรือผิดสี)", desc2 ="Incorrect / Wrong – Not product customer ordered (Ex : wrong size or color)." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_PROD_INV, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "04", desc ="ได้รับสินค้า / ชิ้นส่วนไม่ครบ – สินค้า / ชิ้นส่วน ที่ระบุไว้ในบรรจุภัณฑ์หายไป", desc2 ="Delivery / missing parts-products / parts listed in the package is missing." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_PROD_INV, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" },
                new Descriptions {companyid = initCompany.companyid,  code = "05", desc ="สินค้าไม่ตรงกับคุณสมบัติที่แจ้งไว้ – สินค้าไม่ตรงกับคุณสมบัติ, รายละเอียด, หรือรูปภาพที่ระบุไว้", desc2 ="Product does not meet qualifications stated-did not match its features, details, or stated." , dtype = SysDef.Description_Type.gc_RTYPE_RETRUN_PROD_INV, active = ConstUtil.ACTIVE.YES , createatutc = DateTime.Now , createby="system" }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
