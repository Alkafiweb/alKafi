using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class OfficeTbl
    {
        public OfficeTbl()
        {
            OfficeDiscountPayments = new HashSet<OfficeDiscountPayment>();
            OfficeMoneyTbls = new HashSet<OfficeMoneyTbl>();
            OfficePayments = new HashSet<OfficePayment>();
            RecruitmenterTbls = new HashSet<RecruitmenterTbl>();
        }

        public int Id { get; set; }
        public string OfficeName { get; set; }
        public bool? IsBlacklist { get; set; }
        public string OfficeAddress { get; set; }
        public string OfficeDist { get; set; }
        public string OfficeStreat { get; set; }
        public string OfficePhones { get; set; }
        public string OfficeNote { get; set; }
        public string Trkhees { get; set; }
        public string Email { get; set; }
        public string OfficeNameAr { get; set; }
        public string OfficeAddressAr { get; set; }
        public string OfficeDistAr { get; set; }
        public string OfficeStreatAr { get; set; }
        public string Aqentname { get; set; }
        public int? OfaccId { get; set; }

        public virtual ICollection<OfficeDiscountPayment> OfficeDiscountPayments { get; set; }
        public virtual ICollection<OfficeMoneyTbl> OfficeMoneyTbls { get; set; }
        public virtual ICollection<OfficePayment> OfficePayments { get; set; }
        public virtual ICollection<RecruitmenterTbl> RecruitmenterTbls { get; set; }
    }
}
