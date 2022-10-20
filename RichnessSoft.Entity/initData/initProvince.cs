using RichnessSoft.Entity.Class;
using RichnessSoft.Entity.Context;
using RichnessSoft.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichnessSoft.Entity.initData
{
    public static class initProvince
    {
        public static void InitializeAsync(RicnessDbContext context
            , RichnessLogDbContext contextlog
            , SuperAdminDefaultOptions superAdminDefaultOptions)
        {
            List<PostalProvince> ListPostalProvince = new List<PostalProvince>()
            {
                new PostalProvince { code = "10" , name1 = "กรุงเทพมหานคร", name2 = "Bangkok", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "11" , name1 = "สมุทรปราการ", name2 = "Samut Prakan", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "12" , name1 = "นนทบุรี", name2 = "Nonthaburi", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "13" , name1 = "ปทุมธานี", name2 = "Pathum Thani", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "14" , name1 = "พระนครศรีอยุธยา", name2 = "Phra Nakhon Si Ayutthaya", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "15" , name1 = "อ่างทอง", name2 = "Ang Thong", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "16" , name1 = "ลพบุรี", name2 = "Loburi", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "17" , name1 = "สิงห์บุรี", name2 = "Sing Buri", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "18" , name1 = "ชัยนาท", name2 = "Chai Nat", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "19" , name1 = "สระบุรี", name2 = "Saraburi", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "20" , name1 = "ชลบุรี", name2 = "Chon Buri", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "21" , name1 = "ระยอง", name2 = "Rayong", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "22" , name1 = "จันทบุรี", name2 = "Chanthaburi", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "23" , name1 = "ตราด", name2 = "Trat", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "24" , name1 = "ฉะเชิงเทรา", name2 = "Chachoengsao", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "25" , name1 = "ปราจีนบุรี", name2 = "Prachin Buri", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "26" , name1 = "นครนายก", name2 = "Nakhon Nayok", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "27" , name1 = "สระแก้ว", name2 = "Sa Kaeo", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "30" , name1 = "นครราชสีมา", name2 = "Nakhon Ratchasima", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "31" , name1 = "บุรีรัมย์", name2 = "Buri Ram", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "32" , name1 = "สุรินทร์", name2 = "Surin", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "33" , name1 = "ศรีสะเกษ", name2 = "Si Sa Ket", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "34" , name1 = "อุบลราชธานี", name2 = "Ubon Ratchathani", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "35" , name1 = "ยโสธร", name2 = "Yasothon", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "36" , name1 = "ชัยภูมิ", name2 = "Chaiyaphum", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "37" , name1 = "อำนาจเจริญ", name2 = "Amnat Charoen", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "38" , name1 = "บึงกาฬ", name2 = "buogkan", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "39" , name1 = "หนองบัวลำภู", name2 = "Nong Bua Lam Phu", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "40" , name1 = "ขอนแก่น", name2 = "Khon Kaen", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "41" , name1 = "อุดรธานี", name2 = "Udon Thani", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "42" , name1 = "เลย", name2 = "Loei", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "43" , name1 = "หนองคาย", name2 = "Nong Khai", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "44" , name1 = "มหาสารคาม", name2 = "Maha Sarakham", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "45" , name1 = "ร้อยเอ็ด", name2 = "Roi Et", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "46" , name1 = "กาฬสินธุ์", name2 = "Kalasin", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "47" , name1 = "สกลนคร", name2 = "Sakon Nakhon", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "48" , name1 = "นครพนม", name2 = "Nakhon Phanom", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "49" , name1 = "มุกดาหาร", name2 = "Mukdahan", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "50" , name1 = "เชียงใหม่", name2 = "Chiang Mai", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "51" , name1 = "ลำพูน", name2 = "Lamphun", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "52" , name1 = "ลำปาง", name2 = "Lampang", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "53" , name1 = "อุตรดิตถ์", name2 = "Uttaradit", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "54" , name1 = "แพร่", name2 = "Phrae", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "55" , name1 = "น่าน", name2 = "Nan", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "56" , name1 = "พะเยา", name2 = "Phayao", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "57" , name1 = "เชียงราย", name2 = "Chiang Rai", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "58" , name1 = "แม่ฮ่องสอน", name2 = "Mae Hong Son", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "60" , name1 = "นครสวรรค์", name2 = "Nakhon Sawan", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "61" , name1 = "อุทัยธานี", name2 = "Uthai Thani", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "62" , name1 = "กำแพงเพชร", name2 = "Kamphaeng Phet", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "63" , name1 = "ตาก", name2 = "Tak", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "64" , name1 = "สุโขทัย", name2 = "Sukhothai", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "65" , name1 = "พิษณุโลก", name2 = "Phitsanulok", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "66" , name1 = "พิจิตร", name2 = "Phichit", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "67" , name1 = "เพชรบูรณ์", name2 = "Phetchabun", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "70" , name1 = "ราชบุรี", name2 = "Ratchaburi", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "71" , name1 = "กาญจนบุรี", name2 = "Kanchanaburi", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "72" , name1 = "สุพรรณบุรี", name2 = "Suphan Buri", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "73" , name1 = "นครปฐม", name2 = "Nakhon Pathom", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "74" , name1 = "สมุทรสาคร", name2 = "Samut Sakhon", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "75" , name1 = "สมุทรสงคราม", name2 = "Samut Songkhram", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "76" , name1 = "เพชรบุรี", name2 = "Phetchaburi", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "77" , name1 = "ประจวบคีรีขันธ์", name2 = "Prachuap Khiri Khan", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "80" , name1 = "นครศรีธรรมราช", name2 = "Nakhon Si Thammarat", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "81" , name1 = "กระบี่", name2 = "Krabi", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "82" , name1 = "พังงา", name2 = "Phangnga", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "83" , name1 = "ภูเก็ต", name2 = "Phuket", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "84" , name1 = "สุราษฎร์ธานี", name2 = "Surat Thani", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "85" , name1 = "ระนอง", name2 = "Ranong", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "86" , name1 = "ชุมพร", name2 = "Chumphon", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "90" , name1 = "สงขลา", name2 = "Songkhla", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "91" , name1 = "สตูล", name2 = "Satun", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "92" , name1 = "ตรัง", name2 = "Trang", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "93" , name1 = "พัทลุง", name2 = "Phatthalung", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "94" , name1 = "ปัตตานี", name2 = "Pattani", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "95" , name1 = "ยะลา", name2 = "Yala", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now },
                new PostalProvince { code = "96" , name1 = "นราธิวาส", name2 = "Narathiwat", countrycode  = "TH", createatutc = DateTime.Now, updateatutc = DateTime.Now }
            };
            context.AddRange(ListPostalProvince.ToArray());
            context.SaveChanges();
        }
    }
}
