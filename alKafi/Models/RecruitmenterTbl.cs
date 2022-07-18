using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace alKafi.Models
{
    public partial class RecruitmenterTbl
    {
        public RecruitmenterTbl()
        {
            Arrivals = new HashSet<Arrival>();
        }

        public int Id { get; set; }
        [DisplayName("الجنسية")]
        public int? NationalityId { get; set; }
        [DisplayName("الديانة")]
        public int? RelegionId { get; set; }

        [DisplayName("العمر")]
        public int? Age { get; set; }
        [DisplayName("خبرة سابقة")]
        public bool? HasExper { get; set; }
        [DisplayName("المكتب")]
        public int? OfficeTbl { get; set; }
        
        public bool IsChoosed { get; set; }

        [DisplayName("الاسم")]
        public string RecName { get; set; }

        public string RecMobiile { get; set; }
        public string CvFileName { get; set; }
        [DisplayName("معرفة مسبقا")]
        public bool? IsDef { get; set; }
        public int? AqedId { get; set; }
        public string SendDate { get; set; }
        public decimal? OfficePrice { get; set; }
        public string Address { get; set; }
        [DisplayName("رقم الجواز")]
        public string Passportno { get; set; }
        public DateTime? Passportsdate { get; set; }
        public string Passportplace { get; set; }
        public DateTime? Passportedate { get; set; }
        public string Nameofaqareb { get; set; }
        public string Phone { get; set; }
        public string RecStatusAr { get; set; }
        public string RecStatusEn { get; set; }
        public int TransmitId { get; set; }
        [DisplayName("رقم السيرة")]
        public string Cvno { get; set; }
        public string RecNotes { get; set; }
        public string BanknameAr { get; set; }
        public string BanknameEn { get; set; }
        public string Bankaccount { get; set; }
        public string BankaddressAr { get; set; }
        public string BankaddressEn { get; set; }
        public string RecNameAr { get; set; }
        public string PassportplaceAr { get; set; }
        public string NameofaqarebAr { get; set; }
        public string AqarebselaAr { get; set; }
        public string AqarebselaEn { get; set; }
        public string AqarebAddress { get; set; }
        public string AqarebAddressAr { get; set; }
        public string RecAddressAr { get; set; }

        [DisplayName("العمل")]
        public int JobId { get; set; }
        public int PriceUs { get; set; }
        public DateTime? SelectedDate { get; set; }

        
        public bool? IsOffical { get; set; }
        public bool? IsReplace { get; set; }
        public bool? IsReturn { get; set; }
        public bool? IsBlacklist { get; set; }
        public string Personouside { get; set; }
        public string Personcode { get; set; }
        public string Education { get; set; }
        public string University { get; set; }
        public string Courses { get; set; }
        public bool? Rsa1 { get; set; }
        public bool? Rsa2 { get; set; }
        public bool? Rsa3 { get; set; }
        public bool? Rsa4 { get; set; }
        public bool? Rsa5 { get; set; }
        public bool? Rsa6 { get; set; }
        public bool? Rsa7 { get; set; }
        public string Interview1 { get; set; }
        public string Interview11 { get; set; }
        public string Interview12 { get; set; }
        public string Interview13 { get; set; }
        public string Interview14 { get; set; }
        public string Interview15 { get; set; }
        public string Interview16 { get; set; }
        public string Interview17 { get; set; }
        public string Interview18 { get; set; }
        public string Strimg { get; set; }
        [DisplayName("حجز")]
        public bool? WedCk { get; set; }
        [DisplayName("عرض ")]
        public bool? WebShow { get; set; }

        public virtual JobTbl Job { get; set; }
        public virtual NationalityTbl Nationality { get; set; }
        public virtual OfficeTbl OfficeTblNavigation { get; set; }
        public virtual RelegionTbl Relegion { get; set; }
        public virtual RecruitmenterTa3jeerTbl RecruitmenterTa3jeerTbl { get; set; }
        public virtual ICollection<Arrival> Arrivals { get; set; }
    }
}
