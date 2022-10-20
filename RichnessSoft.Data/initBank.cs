using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initBank
    {
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<bank> listData = new List<bank>()
            {
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "BOT", name = "ธนาคารแห่งประเทศไทย", name2 = "BANK OF THAILAND", bot_code = "001", swicf_Code = "BOTHTHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "BBL", name = "กรุงเทพ", name2 = "BANGKOK BANK", bot_code = "002", swicf_Code = "BKKBTHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "KBANK", name = "กสิกรไทย", name2 = "KASINKORN BANK", bot_code = "004", swicf_Code = "KASITHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "KTB", name = "กรุงไทย", name2 = "KRUNG THAI BANK", bot_code = "006", swicf_Code = "KRTHTHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "TMB", name = "ทหารไทย", name2 = "TMB BANK", bot_code = "011", swicf_Code = "TMBKTHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "SCB", name = "ไทยพาณิชย์", name2 = "THE SIAM COMMERCIAL BANK", bot_code = "014", swicf_Code = "SICOTHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "BAY", name = "กรุงศรีอยุธยา", name2 = "BANK OF AYUDHYA", bot_code = "025", swicf_Code = "AYUDTHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "KKP", name = "เกียรตินาคินภัทร", name2 = "KIATNAKIN PHATRA BANK", bot_code = "069", swicf_Code = "KIFITHB1", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "CIMBT", name = "ซีไอเอ็มบีไทย", name2 = "CIMB THAI BANK", bot_code = "022", swicf_Code = "UBOBTHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "TISCO", name = "ทิสโก้", name2 = "TISCO BANK", bot_code = "067", swicf_Code = "TFPCTHB1", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "TBANK", name = "ธนชาต", name2 = "THANACHAR BANK", bot_code = "065", swicf_Code = "THBKTHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "UOBT", name = "ยูโอบี", name2 = "UOB BANK", bot_code = "024", swicf_Code = "UOVBTHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "TCD", name = "ไทยเครดิต", name2 = "THAI CREDIT RETAIL BANK", bot_code = "071", swicf_Code = "THCETHB1", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "LHFG", name = "แลนด์แอนด์ เฮ้าส์", name2 = "CHAROEN POKPHAND GROUP", bot_code = "073", swicf_Code = "LAHRTHB1", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "ICBCT", name = "ไอซีบีซี (ไทย)", name2 = "ICBC THAI BANK", bot_code = "070", swicf_Code = "ICBKTHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "SME", name = "พัฒนาวิสาหกิจขนาดกลางและขนาดย่อมแห่งประเทศไทย", name2 = "SME BANK", bot_code = "098", swicf_Code = "-", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "BAAC", name = "เพื่อการเกษตรและสหกรณ์การเกษตร", name2 = "BANK FOR AGRICULTURE AND AGRICULTURAL COOPERATIVES", bot_code = "034", swicf_Code = "BAABTHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "EXIM", name = "เพื่อการส่งออกและนำเข้าแห่งประเทศไทย", name2 = "EXPORT-IMPORT BANK OF THAILAND", bot_code = "035", swicf_Code = "-", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "GSB", name = "ออมสิน", name2 = "GOVERNMENT SAVINGS BANK", bot_code = "030", swicf_Code = "GSBATHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "GHB", name = "อาคารสงเคราะห์", name2 = "GOVERNMENT HOUSING BANK", bot_code = "033", swicf_Code = "-", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
                new bank { CorpCode = initCompany.gstrDefaultCorpCode , code = "ISBT", name = "อิสลามแห่งประเทศไทย", name2 = "ISLAMIC BANK OF THAILAND", bot_code = "066", swicf_Code = "TIBTTHBK", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now},
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();                
            //BookBank
            List<bookBank> listBookBank = new List<bookBank>()
            {
                new bookBank { CorpCode = initCompany.gstrDefaultCorpCode , code = "01", name = "<ไม่ระบุบัญชีธนาคาร>", name2 = "<Book Bank Not Define>",book_No="-", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now, active = ConstUtil.ACTIVE.YES }
            };
            foreach (var item in listBookBank)
            {
                context.Add(item);
            }
            context.SaveChanges();
        }
    }
}
