using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class SolafTbl
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public decimal Amount { get; set; }
        public DateTime SDate { get; set; }
        public decimal Permonth { get; set; }
        public decimal Balance { get; set; }
        public string Notes { get; set; }
        public bool? IsActive { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual EmployeeTbl Emp { get; set; }
    }
}
