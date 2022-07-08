using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class OfficeRequirmentVw
    {
        public int Id { get; set; }
        public string JobEn { get; set; }
        public string AirportEn { get; set; }
        public string OwnernameEn { get; set; }
        public string Phone { get; set; }
        public string IdNum { get; set; }
        public string Visano { get; set; }
        public int RecCount { get; set; }
        public int NationalityId { get; set; }
        public int JobId { get; set; }
        public int? OfficerequirmentId { get; set; }
        public string LastStatus { get; set; }
        public bool IsReturned { get; set; }
        public string Officesend { get; set; }
    }
}
