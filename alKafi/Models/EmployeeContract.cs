using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class EmployeeContract
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Balance { get; set; }
        public bool Active { get; set; }

        public virtual EmployeeTbl Emp { get; set; }
    }
}
