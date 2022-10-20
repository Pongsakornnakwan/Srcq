using System;

namespace RichnessSoft.Common
{
    public class RefUtil  
    {
        public const string gc_RUNVAL_STR = "?";
        public static void gmQtyPriceStd(double nQtyInUm, double nPriceInUm, double nUmQty, ref double outQtyStd)
        {
            double outPriceStd = 0;
            gmQtyPriceStd(nQtyInUm, nPriceInUm, nUmQty, ref outQtyStd, ref outPriceStd);
        }
        public static void gmQtyPriceStd(decimal nQtyInUm, decimal nPriceInUm, decimal nUmQty, ref decimal outQtyStd)
        {
            decimal outPriceStd = 0;
            gmQtyPriceStd(nQtyInUm, nPriceInUm, nUmQty, ref outQtyStd, ref outPriceStd);
        }
        public static void gmQtyPriceStd(double nQtyInUm, double nPriceInUm, double nUmQty, ref double outQtyStd, ref double outPriceStd)
        {
            if (nUmQty == 0)
            {
                nUmQty = 1;
            }
            outQtyStd = nQtyInUm * nUmQty;
            outPriceStd = nPriceInUm / nUmQty;
        }
        public static void gmQtyPriceStd(decimal nQtyInUm, decimal nPriceInUm, decimal nUmQty, ref decimal outQtyStd, ref decimal outPriceStd)
        {
            if (nUmQty == 0)
            {
                nUmQty = 1;
            }
            outQtyStd = decimal.Multiply(nQtyInUm, nUmQty);// 
            outPriceStd = decimal.Divide(nPriceInUm, nUmQty); //หาร
        }
        public static double gmCalDiscAmtFromDiscStr(string inDiscStr, double inAmt, double inQty, double inFullQty)
        {
            return UtilHelper.gmDoubleParse(gmCalDiscAmtFromDiscStr(inDiscStr, Convert.ToDecimal(inAmt), Convert.ToDecimal(inQty), Convert.ToDecimal(inFullQty)), 0);
        }
        public static decimal gmCalDiscAmtFromDiscStr(string inDiscStr, decimal inAmt, decimal inQty, decimal inFullQty)
        {
            string sFilterStr = "";
            string sCut = "";
            decimal nCrAmt = 0;
            decimal nDiscAmt = 0;
            decimal nPriceKe = 0;
            decimal nCrDiscAmt = 0;
            int nRoundAt = 2;
            int nRoundPriceAt = 4;

            sFilterStr = StrUtil.xChrTran(inDiscStr, "0123456789+%@.", "");
            inDiscStr = StrUtil.xChrTran(inDiscStr, sFilterStr, "");
            sCut = StrUtil.CutStr(ref inDiscStr, "+");
            if (sCut.Trim() == string.Empty)
            {
                sCut = inDiscStr;
            }
            nPriceKe = decimal.Round(decimal.Round((inQty == 0) ? 0 : (inAmt / inQty), nRoundPriceAt + 2, MidpointRounding.AwayFromZero), nRoundPriceAt, MidpointRounding.AwayFromZero);
            while (sCut.Trim() != string.Empty)
            {
                nCrAmt = inAmt - nDiscAmt;
                if (sCut.Contains("%") == true)
                {
                    /// กรณีคีย์ส่วนลดที่ Item 
                    /// จำนวน 10 ชิ้น ราคา 100 บาท ลด @2% ==> 10 * ( 100 - 100 * 2% ) = 10 * 98 = 980
                    if (sCut.Contains("@") && inQty != 0)
                    {
                        nCrDiscAmt = decimal.Round(decimal.Round(decimal.Multiply(nPriceKe, decimal.Divide(Convert.ToDecimal(StrUtil.xChrTran(sCut, "@%", "")), 100)), 6, MidpointRounding.AwayFromZero) * inQty, 6, MidpointRounding.AwayFromZero);
                    }
                    else
                    {
                        /// จำนวน 10 ชิ้น ราคา 100 บาท ลด 2% ==> ( 10 * 100 )  - ( 10*100*2%) = 1000 - 20 = 980
                        nCrDiscAmt = decimal.Round(decimal.Multiply(nCrAmt, decimal.Divide(Convert.ToDecimal(StrUtil.xChrTran(sCut, "%", "")), 100)), 6, MidpointRounding.AwayFromZero);
                    }
                }
                else if (sCut.Contains("@") == true)
                {
                    nCrDiscAmt = decimal.Round(decimal.Multiply(inQty, Convert.ToDecimal(StrUtil.xChrTran(sCut, "@", ""))), 6, MidpointRounding.AwayFromZero);
                }
                else
                {
                    nCrDiscAmt = Convert.ToDecimal(sCut);
                    if (inQty != inFullQty && inFullQty != 0)
                    {
                        nCrDiscAmt = decimal.Round(decimal.Divide(decimal.Multiply(nCrDiscAmt, inQty), inFullQty), nRoundAt, MidpointRounding.AwayFromZero);
                    }
                }
                nDiscAmt = nDiscAmt + nCrDiscAmt;
                sCut = StrUtil.CutStr(ref inDiscStr, "+");
            }
            return decimal.Round(nDiscAmt, nRoundAt, MidpointRounding.AwayFromZero);
        }
        public static string gmGenRefNo(string sRefNo, string sRefType, string sBookCode, string sCode, string sBranch)
        {
            string sRetValue = "";
            if (sRefNo.Trim().Length == 0 && (sCode.Trim().Length != 0 && sCode.Trim().EndsWith(gc_RUNVAL_STR) == false))
            {
                string sPreFix = sRefNo + sBookCode.Trim() + "/";
                sRetValue = sPreFix + sCode;
            }
            else
            {
                sRetValue = sRefNo;
            }
            return sRetValue;
        }
        public static double gmQtyInUm2(double inQtyInUm1, double inUmQty1, double inUmQty2)
        {
            return inQtyInUm1 * inUmQty1 / inUmQty2;
        }
        public static decimal gmQtyInUm2(decimal inQtyInUm1, decimal inUmQty1, decimal inUmQty2)
        {
            return decimal.Divide(decimal.Multiply(inQtyInUm1, inUmQty1), inUmQty2);
        }
    }
}
