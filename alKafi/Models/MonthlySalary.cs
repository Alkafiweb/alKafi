using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class MonthlySalary
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int DateId { get; set; }
        public decimal Salary { get; set; }
        public decimal? AdditionalPay { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? HandDate { get; set; }
        public decimal InsurancePay { get; set; }
        public int AccountId { get; set; }

        public virtual EmployeeTbl Emp { get; set; }
    }
}
