using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model
{
    public class TreeViewModel
    {
        public string id { get; set; }
        public string description { get; set; }
        public bool hasChildren { get; set; }
    }
}