using Microsoft.EntityFrameworkCore;
using RichnessSoft.Common;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Service
{
    public interface IBilPayUtil
    {
        ResultModel gmMainFunc(string inProc, ref object param1, ref object param2, ref object param3, ref object param4, ref object param5, ref object param6, ref object param7, ref object param8, ref object param9, ref object param10);
    }
    public class BilPayUtil : IBilPayUtil
    {
        private readonly RicnessDbContext dbContext;
        private readonly Functional cFunc;
        public BilPayUtil(RicnessDbContext db, Functional functional)
        {
            dbContext = db;
            cFunc = functional;
        }
        public ResultModel gmMainFunc(string inProc, ref object param1, ref object param2, ref object param3, ref object param4, ref object param5, ref object param6, ref object param7, ref object param8, ref object param9, ref object param10)
        {
            ResultModel oResult = new() { Data = null, Message = "", Success = true };
            try
            {
                switch (inProc)
                {
                    case "ChkPayMentInRePayMnt":
                        oResult = iChkPayMentInRePayMnt(param1, ref param2, ref param3, param3);
                        break;
                    case "ยอดเงินมัดจำของInvที่ตัดชำระแล้วระบุPAYM":
                        oResult = iCPaymPaid(Convert.ToInt32(param1), Convert.ToInt32(param2), SysDef.BILPAY_MASTER.gc_BILPAY_MASTER_PINV);
                        break;
                    case "ยอดเงินมัดจำของOrdที่ตัดชำระแล้วระบุPAYM":    //&& ไม่ใช้ Payment เพราะ Ctrl+f แล้วเจอด้วย
                        oResult = iCPaymPaid(Convert.ToInt32(param1), Convert.ToInt32(param2), SysDef.BILPAY_MASTER.gc_BILPAY_MASTER_PORD);
                        break;
                    case "ยอดตัดชำระของPAYMที่Ord":
                        oResult = iCPaymPaid(0, Convert.ToInt32(param1), SysDef.BILPAY_MASTER.gc_BILPAY_MASTER_ORDERH);
                        break;
                    case "ยอดตัดชำระของPAYM(ระบุOrd)ที่Ord":
                        oResult = iCPaymPaid(Convert.ToInt32(param2), Convert.ToInt32(param1), SysDef.BILPAY_MASTER.gc_BILPAY_MASTER_ORDERH);
                        break;
                    case "ยอดตัดชำระของPAYMที่GLRef":
                        oResult = iCPaymPaid(0, Convert.ToInt32(param1), SysDef.BILPAY_MASTER.gc_BILPAY_MASTER_GLREF);
                        break;
                    case "ยอดตัดชำระของPAYM(ระบุGLRef)ที่GLRef":
                        oResult = iCPaymPaid(Convert.ToInt32(param2), Convert.ToInt32(param1), SysDef.BILPAY_MASTER.gc_BILPAY_MASTER_GLREF);
                        break;
                    case "DelOldPayment":
                        //llSucc = iDelOldPayment(param1, param2, param3, param4, param5, param6);
                        break;
                    case "ChkBforeDelPaymnt":
                        oResult = iChkBforeDelPaymnt(Convert.ToInt32(param1), Convert.ToInt32(param2), param3?.ToString() ?? "");
                        break;

                }
            }
            catch (Exception ex)
            {
                LogHelper.gmEventLog(LogHelper.FileFolder.SharedFile, LogHelper.LogType.Error, LogHelper.gmGetErrMsg(ex), string.Format("gmMainFunc.{0}", inProc), "");
                if (ex.InnerException is not null)
                {
                    oResult.Message = ex.InnerException.Message;
                }
                else
                {
                    oResult.Message = ex.Message;
                }
                oResult.Success = false;
            }
            return oResult;
        }
        private ResultModel iChkPayMentInRePayMnt(object tcinPayMent, ref object tcioRefCode, ref object tnioRefAmt, object tlinNotChkStepP)
        {
            ResultModel oResult = new ResultModel() { Data = null, Message = "", Success = false };
            //tcioRefCode = string.Empty;
            //tnioRefAmt = 0;
            //if (!UtilHelper.gmIsNullOrEmpty(tcinPayMent))
            //{
            //    if (tlinNotChkStepP == null)
            //    {
            //        tnioRefAmt = 0;
            //    }
            //    else if (tlinNotChkStepP.GetType() == typeof(bool))
            //    {
            //        XPQuery<FCR_REPAYMNT> Repayment = new XPQuery<FCR_REPAYMNT>(DataLayer.goDbDataSession);
            //        XPQuery<FCR_PAYMENT2> Payment = new XPQuery<FCR_PAYMENT2>(DataLayer.goDbDataSession);
            //        var list = from P in Payment
            //                   join R in Repayment on P.FCSKID equals R.FCPAYMENT
            //                   where P.FCSTEP != Payment_Stat.gc_STAT_CHQ_CANCEL && P.FCSTAT == " "
            //                   || P.FCSTEP == ConstUtil.Payment_Step.gc_STEP_TO_BANK && P.FCSTAT != Payment_Stat.gc_STAT_CHQ_SPRING
            //                   && P.FCSTAT != Payment_Stat.gc_STAT_PASSED
            //                   && R.FCCHILDPAY == tcinPayMent.ToString()
            //                   orderby P.FDDATE ascending
            //                   select new { FCCODE = P.FCCODE, FCSTEP = P.FCSTEP, FCSTAT = P.FCSTAT, FCPAYMENT = R.FCPAYMENT, FNREPAYAMT = R.FNREPAYAMT };
            //        int lnCnt = 0;
            //        llSucc = list.Count() > 0;
            //        if (llSucc)
            //        {
            //            foreach (var Chk_RePayMnt in list)
            //            {
            //                tcioRefCode = tcioRefCode + (lnCnt > 0 && !UtilHelper.gmIsNullOrEmpty(tcioRefCode) ? "," : "") + Chk_RePayMnt.FCCODE;
            //                tnioRefAmt = UtilHelper.gmDecimalParse(tnioRefAmt, 0) + UtilHelper.gmDecimalParse(Chk_RePayMnt.FNREPAYAMT, 0);
            //                lnCnt++;
            //            }
            //        }
            //        else
            //        {
            //            tcioRefCode = string.Empty;
            //        }
            //    }
            //}
            return oResult;
        }
        private ResultModel iCPaymPaid(int inRefLinkID, int inPaymentLinkID , string inBilPymType ="" )
        {
            ResultModel oResult = new ResultModel() { Data = 0, Message = "", Success = true };
            decimal lnSumPldAmt = 0M;
            if (dbContext is null) { return oResult; }
            if (UtilHelper.gmIsNullOrEmpty(inRefLinkID))
            {
                lnSumPldAmt = dbContext?.Bilpay?.AsNoTrackingWithIdentityResolution()?.Where(c => c.paymentid == inPaymentLinkID && c.doctype == inBilPymType)?.Sum(c => c.amount) ?? 0;
            }
            else
            {
                lnSumPldAmt = dbContext?.Bilpay?.AsNoTrackingWithIdentityResolution()?.Where(c => c.paymentid == inPaymentLinkID && c.doctype == inBilPymType && c.masterid == inRefLinkID)?.Sum(c => c.amount) ?? 0;
            }
            oResult.Data = lnSumPldAmt;
            return oResult;
        }
        private ResultModel iChkBforeDelPaymnt(int tcinMasterHLinkID , int tcinPaymntLinkID , string Module = "")
        {
            ResultModel oResult = new ResultModel() { Data = 0, Message = "", Success = true };
            IList<Bilpay> listBilpay = new List<Bilpay>();
            if (dbContext is null) { return oResult; }
            if (Module == ConstUtil.DATA_SOURCE.GL_MANUAL || Module == ConstUtil.DATA_SOURCE.GL_AUTO)
            {
                listBilpay = dbContext?.Bilpay?.AsNoTrackingWithIdentityResolution()?.Where(c => c.paymentid == tcinPaymntLinkID)?.ToList() ?? null;
                if (listBilpay is not null && listBilpay.Count > 0)
                {
                    oResult.Success = false;
                }
            }
            else
            {
                if (UtilHelper.gmIsNullOrEmpty(tcinMasterHLinkID) == false && UtilHelper.gmIsNullOrEmpty(tcinPaymntLinkID) == false)
                {
                    listBilpay = dbContext?.Bilpay?.AsNoTrackingWithIdentityResolution()?.Where(c => c.masterid != tcinMasterHLinkID && c.paymentid == tcinPaymntLinkID)?.ToList() ?? null;
                    if (listBilpay is not null && listBilpay.Count > 0)
                    {
                        oResult.Success = false;
                    }
                }
            }
            listBilpay = null;
            return oResult;
        }
    }
}
