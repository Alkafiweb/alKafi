using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class StatusView
    {
        public int Id { get; set; }
        public string FourteenCond { get; set; }
        public string CName { get; set; }
        public string Visano { get; set; }
        public string IdNum { get; set; }
        public string NationalName { get; set; }
        public string CountryName { get; set; }
        public string UserName { get; set; }
        public string IdDateofbirth { get; set; }
        public string Phone { get; set; }
        public string RecName { get; set; }
        public string Passportno { get; set; }
        public string Officename { get; set; }
        public int? AqedSource { get; set; }
        public bool IsEnd { get; set; }
        public bool IsVip { get; set; }
        public bool IsDefined { get; set; }
        public int UserId { get; set; }
        public bool IsReturned { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsWakeel { get; set; }
        public bool IsPayedForVisa { get; set; }
        public bool IsNone { get; set; }
        public bool Ckvisa { get; set; }
        public bool IsAqed { get; set; }
        public string ChvisaDate { get; set; }
        public bool Ckarrivel { get; set; }
        public bool Ckstat { get; set; }
        public DateTime AqedDate { get; set; }
        public bool Ckticket { get; set; }
        public string CkticketDate { get; set; }
    }
}
