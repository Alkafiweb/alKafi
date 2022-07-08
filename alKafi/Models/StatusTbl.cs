using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class StatusTbl
    {
        public int Id { get; set; }
        public int RecId { get; set; }
        public int StatusId { get; set; }
        public DateTime StatusDate { get; set; }
        public int? UserId { get; set; }
        public DateTime? DoneDate { get; set; }
        public bool IsDone { get; set; }
        public bool IsUp { get; set; }
        public string Notice { get; set; }

        public virtual StatusNameTbl Status { get; set; }
    }
}
