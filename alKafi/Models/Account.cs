using System;
using System.Collections.Generic;

#nullable disable

namespace alKafi.Models
{
    public partial class Account
    {
        public Account()
        {
            AqedMoneys = new HashSet<AqedMoney>();
            EmpBenefits = new HashSet<EmpBenefit>();
            GeneralSalesTbls = new HashSet<GeneralSalesTbl>();
            IncomeTbls = new HashSet<IncomeTbl>();
            KafalaMoneys = new HashSet<KafalaMoney>();
            MouqebMoneys = new HashSet<MouqebMoney>();
            OfficeDiscountPayments = new HashSet<OfficeDiscountPayment>();
            OfficePayments = new HashSet<OfficePayment>();
            Payments = new HashSet<Payment>();
            SolafTbls = new HashSet<SolafTbl>();
            TfweedMasareefTbls = new HashSet<TfweedMasareefTbl>();
            TfweedMoneys = new HashSet<TfweedMoney>();
            TransferAccountFromAccountNavigations = new HashSet<TransferAccount>();
            TransferAccountToAccountNavigations = new HashSet<TransferAccount>();
        }

        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public bool? IsActive { get; set; }
        public string Notice { get; set; }

        public virtual ICollection<AqedMoney> AqedMoneys { get; set; }
        public virtual ICollection<EmpBenefit> EmpBenefits { get; set; }
        public virtual ICollection<GeneralSalesTbl> GeneralSalesTbls { get; set; }
        public virtual ICollection<IncomeTbl> IncomeTbls { get; set; }
        public virtual ICollection<KafalaMoney> KafalaMoneys { get; set; }
        public virtual ICollection<MouqebMoney> MouqebMoneys { get; set; }
        public virtual ICollection<OfficeDiscountPayment> OfficeDiscountPayments { get; set; }
        public virtual ICollection<OfficePayment> OfficePayments { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<SolafTbl> SolafTbls { get; set; }
        public virtual ICollection<TfweedMasareefTbl> TfweedMasareefTbls { get; set; }
        public virtual ICollection<TfweedMoney> TfweedMoneys { get; set; }
        public virtual ICollection<TransferAccount> TransferAccountFromAccountNavigations { get; set; }
        public virtual ICollection<TransferAccount> TransferAccountToAccountNavigations { get; set; }
    }
}
