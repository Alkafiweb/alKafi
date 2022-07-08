using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AccountVw
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string Notice { get; set; }
        public double? Total { get; set; }
    }
}
