using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RichnessSoft.Data
{
    public class InitDescription
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
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = gstrDefaultDesciptionCode, Description ="ไม่ระบุ", Description2 ="Not specified" , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "01", Description ="เงินในบัญชีไม่พอจ่าย", Description2 ="Not enough money in the account to pay." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "02", Description ="บัญชีปิดแล้ว", Description2 ="Account is closed." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "03", Description ="สั่งจ่ายจากจำนวนที่มีตราสารรอเรียกเก็บเงินอยู่ โปรดดิดต่อผู้สั่งจ่าย", Description2 ="Payable from the amount that the instrument is pending for billing. Please contact the payer." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "04", Description ="เช็คลงวันที่ล่วงหน้า", Description2 ="Advance dated cheque" , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "05", Description ="เช็คพ้นกำหนดจ่ายเงิน", Description2 ="Overdue cheque" , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "06", Description ="จำนวนเงินที่เป็นตัวอักษรและตัวเลขไม่ตรงกัน", Description2 ="Alphanumeric amounts do not match." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "07", Description ="โปรดให้ผู้สั่งจ่ายลงนามกำกับการแก้ไขตามเงื่อนไขที่ให้ไว้กับธนาคาร", Description2 ="Please allow the payer to sign for the amendment according to the conditions provided to the bank." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "08", Description ="ลายมือชื่อผู้สั่งจ่ายไม่ถูกต้องตามเงื่อนไขที่ให้ไว้กับธนาคาร", Description2 ="Payer signature is not correct according to the conditions given to the bank." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "09", Description ="โปรดประทับตราของผู้สั่งจ่ายตามตัวอย่างที่ให้ไว้กับธนาคาร", Description2 ="Please stamp the payer according to the sample provided to the bank." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "10", Description ="โปรดสลักหลังให้ครบถ้วนถูกต้อง", Description2 ="Please endorse it completely and correctly." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "11", Description ="มีคำสั่งให้ระงับการจ่าย", Description2 ="There is an order to suspend payment." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "12", Description ="เช็คชำรุด โปรดติดต่อผู้สั่งจ่าย", Description2 ="Cheque is damaged, please contact the payer." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "19", Description ="ผู้สั่งจ่ายถึงแก่กรรม", Description2 ="Payer passed away" , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_CHEQUE, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                //สาเหตุในการยกเลิกใบกำกับภาษีเดิม
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = gstrDefaultDesciptionCode, Description ="ไม่ระบุ", Description2 ="Not specified" , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_TAX_INV, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "01", Description ="ออกใบกำกับภาษีผิด", Description2 ="Issuing wrong tax invoice" , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_TAX_INV, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                //สาเหตุการคืนสินค้า
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = gstrDefaultDesciptionCode, Description ="อื่นๆ", Description2 ="Other" , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_PROD_INV, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "01", Description ="เสียหาย – สินค้าเสียหายระหว่างการจัดส่ง", Description2 ="Damaged-Goods damaged during delivery." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_PROD_INV, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "02", Description ="ใช้การไม่ได้ – สินค้าไม่สามารถทำงานได้ตามที่อธิบายไว้ในข้อกำหนดของผู้ผลิต", Description2 ="Inoperable – Product does not perform as described in the manufacturer's specifications." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_PROD_INV, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "03", Description ="สินค้าไม่ถูกต้อง / ผิด – ไม่ใช่สินค้าที่ลูกค้าสั่งซื้อ (เช่น ผิดขนาด หรือผิดสี)", Description2 ="Incorrect / Wrong – Not product customer ordered (Ex : wrong size or color)." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_PROD_INV, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "04", Description ="ได้รับสินค้า / ชิ้นส่วนไม่ครบ – สินค้า / ชิ้นส่วน ที่ระบุไว้ในบรรจุภัณฑ์หายไป", Description2 ="Delivery / missing parts-products / parts listed in the package is missing." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_PROD_INV, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) },
                new Descriptions(context) {CorpCode = initCompany.gstrDefaultCorpCode,  Code = "05", Description ="สินค้าไม่ตรงกับคุณสมบัติที่แจ้งไว้ – สินค้าไม่ตรงกับคุณสมบัติ, รายละเอียด, หรือรูปภาพที่ระบุไว้", Description2 ="Product does not meet qualifications stated-did not match its features, details, or stated." , DType = SysDef.Description_Type.gc_RTYPE_RETRUN_PROD_INV, Active = ConstUtil.ACTIVE.YES , CreateAtUtc = DateTime.Now , CreateBy="System", LinkID = StrUtil.GetUniqueKey(25) }
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
