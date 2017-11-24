using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class DataReference
    {
        public DataReference()
        {
            value = Guid.Empty;
            description = "";
        }

        public DataReference(Guid value)
        {
            this.value = value;
            this.description = value.ToString();
        }

        public DataReference(Guid value, string description)
        {
            this.value = value;
            this.description = description;
        }

        public Guid value { get; set; }

        public string description { get; set; }
    }
}
