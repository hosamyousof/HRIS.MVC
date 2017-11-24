using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Model.Sys
{
    [Serializable]
    public class ReferenceModel
    {
        public ReferenceModel()
        {
            value = 0;
            description = "";
        }

        public ReferenceModel(int value)
        {
            this.value = value;
            this.description = value.ToString();
        }

        public ReferenceModel(int value, string description)
        {
            this.value = value;
            this.description = description;
        }

        public int value { get; set; }

        public string description { get; set; }

    }
}
