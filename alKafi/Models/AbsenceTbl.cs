using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AbsenceTbl
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime AbsenceFromDate { get; set; }
        public DateTime AbsenceToDate { get; set; }
        public string Reason { get; set; }

        public virtual EmployeeTbl Emp { get; set; }
    }
}
