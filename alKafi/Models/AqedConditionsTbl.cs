using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqedConditionsTbl
    {
        public int Id { get; set; }
        public int AqedId { get; set; }
        public int AqedConditionId { get; set; }
        public bool IsChoose { get; set; }
    }
}
