using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sd_final
{
    class Inc_View_Item
    {
        public long id{get;set;}
        public string status{get;set;}
        public Nullable<DateTime> reg_date { get; set; }
        public string uinfo{get;set;}
        public string simptoms{get;set;}
        public string cat{get;set;}
        public Nullable<DateTime> res_date { get; set; }
        public Nullable<DateTime> close_date { get; set; }
        public string problem{get;set;}
        public Nullable<long> prior { get; set; }        
    }
}
