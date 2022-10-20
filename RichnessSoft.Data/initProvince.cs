using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace RichnessSoft.Data
{
    public static class initProvince
    {
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<postalProvince> Listpostalprovince = new List<postalProvince>()
            {
                new postalProvince { code = "10" , name = "กรุงเทพมหานคร", name2 = "Bangkok", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "11" , name = "สมุทรปราการ", name2 = "Samut Prakan", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "12" , name = "นนทบุรี", name2 = "Nonthaburi", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "13" , name = "ปทุมธานี", name2 = "Pathum Thani", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "14" , name = "พระนครศรีอยุธยา", name2 = "Phra Nakhon Si Ayutthaya", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "15" , name = "อ่างทอง", name2 = "Ang Thong", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "16" , name = "ลพบุรี", name2 = "Loburi", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "17" , name = "สิงห์บุรี", name2 = "Sing Buri", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "18" , name = "ชัยนาท", name2 = "Chai Nat", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "19" , name = "สระบุรี", name2 = "Saraburi", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "20" , name = "ชลบุรี", name2 = "Chon Buri", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "21" , name = "ระยอง", name2 = "Rayong", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "22" , name = "จันทบุรี", name2 = "Chanthaburi", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "23" , name = "ตราด", name2 = "Trat", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "24" , name = "ฉะเชิงเทรา", name2 = "Chachoengsao", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "25" , name = "ปราจีนบุรี", name2 = "Prachin Buri", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "26" , name = "นครนายก", name2 = "Nakhon Nayok", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "27" , name = "สระแก้ว", name2 = "Sa Kaeo", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "30" , name = "นครราชสีมา", name2 = "Nakhon Ratchasima", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "31" , name = "บุรีรัมย์", name2 = "Buri Ram", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "32" , name = "สุรินทร์", name2 = "Surin", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "33" , name = "ศรีสะเกษ", name2 = "Si Sa Ket", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "34" , name = "อุบลราชธานี", name2 = "Ubon Ratchathani", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "35" , name = "ยโสธร", name2 = "Yasothon", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "36" , name = "ชัยภูมิ", name2 = "Chaiyaphum", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "37" , name = "อำนาจเจริญ", name2 = "Amnat Charoen", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "38" , name = "บึงกาฬ", name2 = "buogkan", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "39" , name = "หนองบัวลำภู", name2 = "Nong Bua Lam Phu", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "40" , name = "ขอนแก่น", name2 = "Khon Kaen", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "41" , name = "อุดรธานี", name2 = "Udon Thani", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "42" , name = "เลย", name2 = "Loei", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "43" , name = "หนองคาย", name2 = "Nong Khai", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "44" , name = "มหาสารคาม", name2 = "Maha Sarakham", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "45" , name = "ร้อยเอ็ด", name2 = "Roi Et", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "46" , name = "กาฬสินธุ์", name2 = "Kalasin", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "47" , name = "สกลนคร", name2 = "Sakon Nakhon", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "48" , name = "นครพนม", name2 = "Nakhon Phanom", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "49" , name = "มุกดาหาร", name2 = "Mukdahan", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "50" , name = "เชียงใหม่", name2 = "Chiang Mai", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "51" , name = "ลำพูน", name2 = "Lamphun", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "52" , name = "ลำปาง", name2 = "Lampang", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "53" , name = "อุตรดิตถ์", name2 = "Uttaradit", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "54" , name = "แพร่", name2 = "Phrae", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "55" , name = "น่าน", name2 = "Nan", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "56" , name = "พะเยา", name2 = "Phayao", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "57" , name = "เชียงราย", name2 = "Chiang Rai", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "58" , name = "แม่ฮ่องสอน", name2 = "Mae Hong Son", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "60" , name = "นครสวรรค์", name2 = "Nakhon Sawan", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "61" , name = "อุทัยธานี", name2 = "Uthai Thani", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "62" , name = "กำแพงเพชร", name2 = "Kamphaeng Phet", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "63" , name = "ตาก", name2 = "Tak", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "64" , name = "สุโขทัย", name2 = "Sukhothai", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "65" , name = "พิษณุโลก", name2 = "Phitsanulok", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "66" , name = "พิจิตร", name2 = "Phichit", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "67" , name = "เพชรบูรณ์", name2 = "Phetchabun", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "70" , name = "ราชบุรี", name2 = "Ratchaburi", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "71" , name = "กาญจนบุรี", name2 = "Kanchanaburi", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "72" , name = "สุพรรณบุรี", name2 = "Suphan Buri", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "73" , name = "นครปฐม", name2 = "Nakhon Pathom", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "74" , name = "สมุทรสาคร", name2 = "Samut Sakhon", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "75" , name = "สมุทรสงคราม", name2 = "Samut Songkhram", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "76" , name = "เพชรบุรี", name2 = "Phetchaburi", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "77" , name = "ประจวบคีรีขันธ์", name2 = "Prachuap Khiri Khan", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "80" , name = "นครศรีธรรมราช", name2 = "Nakhon Si Thammarat", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "81" , name = "กระบี่", name2 = "Krabi", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "82" , name = "พังงา", name2 = "Phangnga", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "83" , name = "ภูเก็ต", name2 = "Phuket", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "84" , name = "สุราษฎร์ธานี", name2 = "Surat Thani", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "85" , name = "ระนอง", name2 = "Ranong", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "86" , name = "ชุมพร", name2 = "Chumphon", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "90" , name = "สงขลา", name2 = "Songkhla", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "91" , name = "สตูล", name2 = "Satun", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "92" , name = "ตรัง", name2 = "Trang", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "93" , name = "พัทลุง", name2 = "Phatthalung", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "94" , name = "ปัตตานี", name2 = "Pattani", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "95" , name = "ยะลา", name2 = "Yala", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now },
                new postalProvince { code = "96" , name = "นราธิวาส", name2 = "Narathiwat", countryCode  = "TH", CreateAtUtc = DateTime.Now, UpdateAtUtc = DateTime.Now }
            };
            //foreach (postalProvince postalProvince in Listpostalprovince)
            //{
            //    context.Add(postalProvince);
            //}
            context.AddRange(Listpostalprovince.ToArray());
            context.SaveChanges();
        }
    }
}
