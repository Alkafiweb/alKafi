using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class AqedTa3jeerTbl
    {
        public AqedTa3jeerTbl()
        {
            AqedNotesTajeerTbls = new HashSet<AqedNotesTajeerTbl>();
        }

        public int Id { get; set; }
        public int RecTId { get; set; }
        public int CId { get; set; }
        public DateTime AqedDate { get; set; }
        public double SaatAmal { get; set; }
        public string KhedmaPeriod { get; set; }
        public decimal MonthTklofa { get; set; }
        public DateTime AqedFrom { get; set; }
        public DateTime AqedTo { get; set; }
        public decimal SalaryAfterKafala { get; set; }
        public decimal KafalaMoney { get; set; }
        public string IltzamatTarafOne1 { get; set; }
        public string IltzamatTarafOne2 { get; set; }
        public string IltzamatTarafTwo1 { get; set; }
        public string IltzamatTarafTwo2 { get; set; }
        public bool IsEnd { get; set; }
        public int AqedSourceId { get; set; }
        public bool IsWakeel { get; set; }
        public bool AqedType { get; set; }
        public string WakeelName { get; set; }
        public int Usrname { get; set; }
        public int? BillCostId { get; set; }
        public int? BillCurnceyId { get; set; }
        public int? MuaqpId { get; set; }
        public decimal? MouqebMoney { get; set; }
        public int? BillMainId { get; set; }
        public int? BillDeleteId { get; set; }
        public TimeSpan? StartHour { get; set; }
        public decimal? HourPrince { get; set; }
        public bool? IsKafala { get; set; }
        public DateTime? KafalaDate { get; set; }

        public virtual CustomerTbl CIdNavigation { get; set; }
        public virtual ICollection<AqedNotesTajeerTbl> AqedNotesTajeerTbls { get; set; }
    }
}
