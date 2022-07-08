using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class EmployerinformationrequestVw
    {
        public int AqedId { get; set; }
        public string Visano { get; set; }
        public string AqedDateH { get; set; }
        public string CName { get; set; }
        public string IdNum { get; set; }
        public string Phonesnumber { get; set; }
        public string Othernumbers { get; set; }
        public int OwnerChildNum { get; set; }
        public int? KidsNum { get; set; }
        public string Housetype { get; set; }
        public bool? Issickpeople { get; set; }
        public bool? Isoldpeoplr { get; set; }
        public string Address1 { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public double Salary1 { get; set; }
        public string SevenCond { get; set; }
        public string NationalNameEn { get; set; }
        public string RelegionEn { get; set; }
        public string JobEn { get; set; }
        public string Airport { get; set; }
        public double TotalAmount { get; set; }
    }
}
