using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class FormModel
    {
        public string SubmitType { get; set; }

        public bool HasError { get; set; }
        public bool IsSuccess { get; set; }
    }
}
