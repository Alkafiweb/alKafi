using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class TransferAccount
    {
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public double Amount { get; set; }
        public DateTime TDate { get; set; }
        public string Note { get; set; }
        public string PNote { get; set; }
        public string WhoHand { get; set; }

        public virtual Account FromAccountNavigation { get; set; }
        public virtual Account ToAccountNavigation { get; set; }
    }
}
