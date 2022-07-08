using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class CustomerTbl
    {
        public CustomerTbl()
        {
            AqedTa3jeerTbls = new HashSet<AqedTa3jeerTbl>();
            KafalaTbls = new HashSet<KafalaTbl>();
        }

        public int Id { get; set; }
        public string CName { get; set; }
        public string IdNum { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public string HomePhone { get; set; }
        public string Pox { get; set; }
        public string Postmail { get; set; }
        public string OtherPhone { get; set; }
        public string Notes { get; set; }
        public string IdPlace { get; set; }
        public bool IsBlacklist { get; set; }
        public string OwnerAddressAr { get; set; }
        public string OwnerAddressEn { get; set; }
        public string OwnerStreetAr { get; set; }
        public string OwnerStreetEn { get; set; }
        public string OwnerReginAr { get; set; }
        public string OwnerReginEn { get; set; }
        public string OwnerMadinaAr { get; set; }
        public string OwnerMadinaEn { get; set; }
        public string OwnerStatusAr { get; set; }
        public string OwnerStatusEn { get; set; }
        public int OwnerChildNum { get; set; }
        public string OwnernameEn { get; set; }
        public int OwnerAge { get; set; }
        public string Custnote { get; set; }
        public string Email { get; set; }
        public int? IdCN { get; set; }
        public string BulldingNo { get; set; }
        public string IdExpdate { get; set; }
        public string IdPlaceOfIssued { get; set; }
        public string IdPlaceOfBirthdate { get; set; }
        public string IdDateofbirth { get; set; }
        public string FiilingNo { get; set; }
        public string FillingPlace { get; set; }
        public string IdDated { get; set; }
        public int? KidsNum { get; set; }
        public string SakanType { get; set; }
        public bool? Issickpeople { get; set; }
        public bool? Isoldpeoplr { get; set; }
        public string Visanum { get; set; }
        public string CusJop { get; set; }
        public string CusOld { get; set; }
        public string CusWifeOld { get; set; }
        public string CusSonOld { get; set; }
        public int? CusAccId { get; set; }

        public virtual ICollection<AqedTa3jeerTbl> AqedTa3jeerTbls { get; set; }
        public virtual ICollection<KafalaTbl> KafalaTbls { get; set; }
    }
}
