using RichnessSoft.Common;
using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;


namespace RichnessSoft.Entity.initData
{
    public static class initBank
    {
        public static List<Bank> listData;
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            listData = new List<Bank>()
            {
                new Bank { companyid = initCompany.companyid , code = "BOT", name1 = "ธนาคารแห่งประเทศไทย", name2 = "BANK OF THAILAND", botcode = "001", swicfcode = "BOTHTHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now , active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "BBL", name1 = "กรุงเทพ", name2 = "BANGKOK BANK", botcode = "002", swicfcode = "BKKBTHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "KBANK", name1 = "กสิกรไทย", name2 = "KASINKORN BANK", botcode = "004", swicfcode = "KASITHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "KTB", name1 = "กรุงไทย", name2 = "KRUNG THAI BANK", botcode = "006", swicfcode = "KRTHTHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "TMB", name1 = "ทหารไทย", name2 = "TMB BANK", botcode = "011", swicfcode = "TMBKTHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "SCB", name1 = "ไทยพาณิชย์", name2 = "THE SIAM COMMERCIAL BANK", botcode = "014", swicfcode = "SICOTHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "BAY", name1 = "กรุงศรีอยุธยา", name2 = "BANK OF AYUDHYA", botcode = "025", swicfcode = "AYUDTHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "KKP", name1 = "เกียรตินาคินภัทร", name2 = "KIATNAKIN PHATRA BANK", botcode = "069", swicfcode = "KIFITHB1", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "CIMBT", name1 = "ซีไอเอ็มบีไทย", name2 = "CIMB THAI BANK", botcode = "022", swicfcode = "UBOBTHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "TISCO", name1 = "ทิสโก้", name2 = "TISCO BANK", botcode = "067", swicfcode = "TFPCTHB1", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "TBANK", name1 = "ธนชาต", name2 = "THANACHAR BANK", botcode = "065", swicfcode = "THBKTHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "UOBT", name1 = "ยูโอบี", name2 = "UOB BANK", botcode = "024", swicfcode = "UOVBTHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "TCD", name1 = "ไทยเครดิต", name2 = "THAI CREDIT RETAIL BANK", botcode = "071", swicfcode = "THCETHB1", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "LHFG", name1 = "แลนด์แอนด์ เฮ้าส์", name2 = "CHAROEN POKPHAND GROUP", botcode = "073", swicfcode = "LAHRTHB1", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "ICBCT", name1 = "ไอซีบีซี (ไทย)", name2 = "ICBC THAI BANK", botcode = "070", swicfcode = "ICBKTHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "SME", name1 = "พัฒนาวิสาหกิจขนาดกลางและขนาดย่อมแห่งประเทศไทย", name2 = "SME BANK", botcode = "098", swicfcode = "-", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "BAAC", name1 = "เพื่อการเกษตรและสหกรณ์การเกษตร", name2 = "BANK FOR AGRICULTURE AND AGRICULTURAL COOPERATIVES", botcode = "034", swicfcode = "BAABTHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "EXIM", name1 = "เพื่อการส่งออกและนำเข้าแห่งประเทศไทย", name2 = "EXPORT-IMPORT BANK OF THAILAND", botcode = "035", swicfcode = "-", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "GSB", name1 = "ออมสิน", name2 = "GOVERNMENT SAVINGS BANK", botcode = "030", swicfcode = "GSBATHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "GHB", name1 = "อาคารสงเคราะห์", name2 = "GOVERNMENT HOUSING BANK", botcode = "033", swicfcode = "-", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
                new Bank { companyid = initCompany.companyid , code = "ISBT", name1 = "อิสลามแห่งประเทศไทย", name2 = "ISLAMIC BANK OF THAILAND", botcode = "066", swicfcode = "TIBTTHBK", createatutc = DateTime.Now, updateatutc = DateTime.Now,active = ConstUtil.ACTIVE.YES},
            };
            context.AddRange(listData.ToArray());
            context.SaveChanges();
            //BookBank
            List<BookBank> listBookBank = new List<BookBank>()
            {
                new BookBank { companyid = initCompany.companyid , code = "01", name1 = "<ไม่ระบุบัญชีธนาคาร>", name2 = "<Book Bank Not Define>",bookno="-", createatutc = DateTime.Now, updateatutc = DateTime.Now, active = ConstUtil.ACTIVE.YES,bankid=listData[1].id }
            };
            foreach (var item in listBookBank)
            {
                context.Add(item);
            }
            context.SaveChanges();
        }
    }
}
