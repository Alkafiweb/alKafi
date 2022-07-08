using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class RecStatusUpVw
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string IdNum { get; set; }
        public string Job { get; set; }
        public string SName { get; set; }
        public DateTime? DoneDate { get; set; }
        public string RecName { get; set; }
        public bool IsDone { get; set; }
        public int StatusId { get; set; }
    }
}
