using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Serialization
{ 
    class YearLimit: Attribute
    {
        public int LimitYear { get; set; }
        
        public YearLimit(int year)
        {
            LimitYear = year;
        }
    }
}
