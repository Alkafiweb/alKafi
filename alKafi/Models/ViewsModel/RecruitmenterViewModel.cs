using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alKafi.Models
{
    public class RecruitmenterViewModel
    {
            public List<RecruitmenterTbl> RecruitmenterTbls { get; set; }
            public RecruitmenterTbl SelectedRecruitmenterTbl { get; set; }
            public string DisplayMode { get; set; }

        public RecruitmenterViewModel(List<RecruitmenterTbl> ListRec, RecruitmenterTbl selectedRec, string display)
        { RecruitmenterTbls = ListRec; SelectedRecruitmenterTbl = selectedRec; DisplayMode = display; }

    }
}
