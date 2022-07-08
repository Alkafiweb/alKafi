using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class OfficeInfo
    {
        public int Id { get; set; }
        public string LNameAr { get; set; }
        public string LNameEn { get; set; }
        public string AdressAr { get; set; }
        public string AdressEn { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public byte[] Logo { get; set; }
        public string OwnernameAr { get; set; }
        public string OwnernameEn { get; set; }
        public string OwnerSefaAr { get; set; }
        public string OwnerSefaEn { get; set; }
        public string Email { get; set; }
        public string Tarkhees { get; set; }
        public string DistAr { get; set; }
        public string DistEn { get; set; }
        public string OriginAr { get; set; }
        public string OriginEn { get; set; }
        public string StreatAr { get; set; }
        public string StreatEn { get; set; }
        public string Websiturl { get; set; }
        public string ArivalSms { get; set; }
        public string NewAqedSms { get; set; }
        public bool NewAqedFlag { get; set; }
        public string SafaraLoc { get; set; }
        public string Taxnum { get; set; }
        public string Sejel { get; set; }
        public string Vochournote { get; set; }
        public double? Taxvalue { get; set; }
        public string HeaderImg { get; set; }
        public string FooterImg { get; set; }
        public string SmsUser { get; set; }
        public string SmsPass { get; set; }
        public string SmsSender { get; set; }
        public string LicNum { get; set; }
        public string LicDate { get; set; }
        public string SejelNum { get; set; }
        public string SejelDate { get; set; }
        public string SejelAddress { get; set; }
        public string OfficePox { get; set; }
        public string OfficeMail { get; set; }
        public int? MusanedAccount { get; set; }
        public int? MusanedToOurAccount { get; set; }
        public DateTime? Closedate { get; set; }
        public int? CloseUser { get; set; }
        public string SmsUrl { get; set; }
        public string SmsOkCode { get; set; }
        public string SmsCheckbalance { get; set; }
    }
}
