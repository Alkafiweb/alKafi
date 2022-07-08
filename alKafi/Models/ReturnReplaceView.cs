using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class ReturnReplaceView
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string Visano { get; set; }
        public string RecName { get; set; }
        public string RecNotes { get; set; }
        public DateTime? Arrdate { get; set; }
        public DateTime? Arrretdate { get; set; }
        public string Phone { get; set; }
        public bool? IsReplace { get; set; }
        public bool? IsReturn { get; set; }
        public DateTime Visadate { get; set; }
        public int NationalityId { get; set; }
        public DateTime AqedDate { get; set; }
    }
}
