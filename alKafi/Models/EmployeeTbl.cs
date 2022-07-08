using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class EmployeeTbl
    {
        public EmployeeTbl()
        {
            AbsenceTbls = new HashSet<AbsenceTbl>();
            EmployeeContracts = new HashSet<EmployeeContract>();
            MonthlySalaries = new HashSet<MonthlySalary>();
            SolafTbls = new HashSet<SolafTbl>();
        }

        public int Id { get; set; }
        public string EmpName { get; set; }
        public string EmpSex { get; set; }
        public string EmpNational { get; set; }
        public string EmpDegree { get; set; }
        public string EmpPosition { get; set; }
        public DateTime? PassportEndDate { get; set; }
        public DateTime? IqamaEndDate { get; set; }
        public DateTime? InsuranceEndDate { get; set; }
        public decimal? EmpSalary { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }
        public string Empno { get; set; }
        public string EmpId { get; set; }
        public decimal? SolfaAmount { get; set; }
        public int? EmpaccId { get; set; }

        public virtual ICollection<AbsenceTbl> AbsenceTbls { get; set; }
        public virtual ICollection<EmployeeContract> EmployeeContracts { get; set; }
        public virtual ICollection<MonthlySalary> MonthlySalaries { get; set; }
        public virtual ICollection<SolafTbl> SolafTbls { get; set; }
    }
}
