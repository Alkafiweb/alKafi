using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alKafi.ViewModels
{
    public class custPriceViewModel
    {
        public int Id { get; set; }
        public string Nationality { get; set; }
        public int NatId { get; set; }
        public int JobId { get; set; }
        public int RelId { get; set; }
        public string Job { get; set; }
        public string Relejon { get; set; }
        public decimal Price { get; set; }
        public decimal? Visaprice { get; set; }

        public custPriceViewModel(int id, int Natid, int Jobid ,int Relid, string Nat ,string job , string Rel, decimal price , decimal? visaP)
        {
            this.Id = id;
            this.Job = job;
            this.Nationality = Nat;
            this.Price = price;
            this.Relejon = Rel;
            this.Visaprice = visaP;
            this.JobId = Jobid;
            this.NatId = Natid;
            this.RelId = Relid;
        }
    }
}
