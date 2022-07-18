using alKafi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alKafi.ViewModels
{
    public class EditAqed
    {
        public AqedTbl aqedTbl { get; set; }
        public CustomerTbl customerTbl { get; set; }
        public OfficeTbl officeTbl { get; set; }
        public List<JobTbl> jobTbl { get; set; }
        public NationalityTbl nationalityTbl { get; set; }
        public RecruitmenterTbl recruitmenterTbl { get; set; }
        public Payment payment { get; set; }
        public AqedNotesTbl notesTbl { get; set; }
        public StatusNameTbl StatusNameTbl { get; set; }
    }
}
