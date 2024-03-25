using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRN_Manager
{
    public class Grn
    {
        public string number { get; set; }
        public string date { get; set; }
        public string supplier { get; set; }
        public List<GrnItem> items { get; set; }
    }
}
