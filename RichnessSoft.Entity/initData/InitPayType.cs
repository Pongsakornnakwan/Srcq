using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RichnessSoft.Entity.initData
{
    public static class InitPayType
    {
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            IList<PayType> listData = new List<PayType>()
            {
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_CM, name1 ="ค่าธรรมเนียม", name2="Fee" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_INTEREST , inout = SysDef.PayType_IO.gc_PAY_OUT , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_COU , name1 ="คูปองส่วนลด", name2="discount Coupons" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_CASH, inout = SysDef.PayType_IO.gc_PAY_IN , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_CR, name1 ="เช็คคืน", name2="Returned Cheque" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_CHEQUE , inout = SysDef.PayType_IO.gc_PAY_IN , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_INW, name1 ="ดอกเบี้ย", name2="Interest" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_INTEREST , inout = SysDef.PayType_IO.gc_PAY_IN , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_LC, name1 ="เล็ตเตอร์ออฟเครดิต", name2="Letter Of Credit" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_TRAN, inout = SysDef.PayType_IO.gc_PAY_EMPTY , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_OCI, name1 ="เงินเกิน", name2="Excess Money" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_CASH , inout = SysDef.PayType_IO.gc_PAY_IN , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_OCL, name1 ="เงินขาด", name2="Lack Of Money" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_CASH , inout = SysDef.PayType_IO.gc_PAY_IN , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_RF, name1 ="Refer", name2="Refer" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_AUTO , inout = SysDef.PayType_IO.gc_PAY_EMPTY, isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_ATS , name1 ="รายการบัญชีอัตโนมัติ", name2="Automatic Transaction" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_TRAN , inout = SysDef.PayType_IO.gc_PAY_EMPTY , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_CD, name1 ="บัตรเครดิต", name2="Credit Card" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_TRAN , inout = SysDef.PayType_IO.gc_PAY_EMPTY, isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_BB, name1 ="ฝากโดยเช็ค เงินตราตปท.", name2="Input check into the bank foreign currency deposit" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_CHEQUE , inout = SysDef.PayType_IO.gc_PAY_IN , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.NO, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_BG, name1 ="Bank Guarantee", name2="Bank Guarantee" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_GUARANTEE , inout = SysDef.PayType_IO.gc_PAY_OUT , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.NO, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_CL , name1 ="ฝากโดยเช็คธนาคารอื่น", name2="Other bank cheque deposit" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_CHEQUE, inout = SysDef.PayType_IO.gc_PAY_IN , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.NO, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_DD , name1 ="ฝากโดยดราฟท์", name2="Draft deposit" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_CHEQUE, inout = SysDef.PayType_IO.gc_PAY_IN , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.NO, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_MO , name1 ="ธนาณัติ", name2="Money Order" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_CASH, inout = SysDef.PayType_IO.gc_PAY_EMPTY , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.NO, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_PC , name1 ="ฝากโดยเงินสด", name2="cash deposit" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_TRAN, inout = SysDef.PayType_IO.gc_PAY_IN , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.NO, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_TRD , name1 ="ฝากโดยการโอน", name2="Transfer deposit" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_TRAN, inout = SysDef.PayType_IO.gc_PAY_IN , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.NO, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_HC , name1 ="ฝากโดยเช็ค (เช็ครับ)", name2="Cheque deposit (Received cheque)" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_CHEQUE, inout = SysDef.PayType_IO.gc_PAY_IN , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.NO, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_CHI , name1 ="เงินสดรับ", name2="cash received entry" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_CASH, inout = SysDef.PayType_IO.gc_PAY_IN , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.NO, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_CC , name1 ="ฝากโดยเช็คเรียกเก็บ", name2="Call cheque deposit" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_CHEQUE, inout = SysDef.PayType_IO.gc_PAY_IN , isdeposit = ConstUtil.CONFIRM.YES , iswithdraw = ConstUtil.CONFIRM.NO, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_CG , name1 ="ถอนเงินผ่านเคลียริ่ง", name2="Clearing withdraw" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_TRAN, inout = SysDef.PayType_IO.gc_PAY_OUT , isdeposit = ConstUtil.CONFIRM.NO , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_CS , name1 ="ถอนเงินสด", name2="cash withdraw" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_TRAN, inout = SysDef.PayType_IO.gc_PAY_OUT , isdeposit = ConstUtil.CONFIRM.NO , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_OV , name1 ="ค่า OV", name2="OV" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_EMPTY, inout = SysDef.PayType_IO.gc_PAY_EMPTY , isdeposit = ConstUtil.CONFIRM.NO , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_TRW , name1 ="ถอนโดยการโอน", name2="Transfer withdraw" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_TRAN, inout = SysDef.PayType_IO.gc_PAY_OUT , isdeposit = ConstUtil.CONFIRM.NO , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_CW , name1 ="ถอนโดยเช็ค (เช็คจ่าย)", name2="Cheque withdraw (Paid cheque)" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_CHEQUE, inout = SysDef.PayType_IO.gc_PAY_OUT , isdeposit = ConstUtil.CONFIRM.NO , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
                new PayType() { code = SysDef.PayType.gc_PAYTYPE_CHO , name1 ="เงินสดจ่าย", name2="cash paid entry" , active = ConstUtil.ACTIVE.YES , group= SysDef.PayGroup.gc_PAYGROUP_CASH, inout = SysDef.PayType_IO.gc_PAY_OUT , isdeposit = ConstUtil.CONFIRM.NO , iswithdraw = ConstUtil.CONFIRM.YES, createatutc = DateTime.Now , createby="system" },
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
        }
    }
}
