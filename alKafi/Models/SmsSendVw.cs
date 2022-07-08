using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class SmsSendVw
    {
        public string CName { get; set; }
        public string Phone { get; set; }
        public int Id { get; set; }
        public string NationalNameEn { get; set; }
        public DateTime AqedDate { get; set; }
    }
}
