using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqerdPrintView
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string Nationality { get; set; }
        public string CusOld { get; set; }
        public string IdNum { get; set; }
        public string SakanType { get; set; }
        public int? KidsNum { get; set; }
        public string OwnerAddressAr { get; set; }
        public string Phone { get; set; }
        public string OtherPhone { get; set; }
        public string Email { get; set; }
        public string CusJop { get; set; }
        public int OwnerChildNum { get; set; }
        public DateTime AqedDate { get; set; }
        public string AqedDateH { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public string Job { get; set; }
        public string JobEn { get; set; }
        public string NationalName { get; set; }
        public string CountryName { get; set; }
        public string Relegion { get; set; }
        public string RelegionEn { get; set; }
        public bool? HasExper { get; set; }
        public string Airport { get; set; }
        public string AirportEn { get; set; }
        public string SevenCond { get; set; }
        public string EightCond { get; set; }
        public byte[] FourteenCond { get; set; }
        public double Salary { get; set; }
        public string RecName { get; set; }
        public string Passportno { get; set; }
        public DateTime? Passportsdate { get; set; }
        public string Passportplace { get; set; }
        public DateTime? Passportedate { get; set; }
        public string VisaSource { get; set; }
        public string Rcphone { get; set; }
        public double TotalAmount { get; set; }
        public string Visano { get; set; }
    }
}
