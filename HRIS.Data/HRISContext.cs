using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data
{
    public partial class HRISContext
    {
        static HRISContext()
        {
            System.Data.Entity.Database.SetInitializer<HRISContext>(null);
        }
    }
}
