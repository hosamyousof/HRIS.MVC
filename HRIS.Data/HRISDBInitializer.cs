using HRIS.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Data
{
    internal class HRISDBInitializer : DropCreateDatabaseAlways<HRISContext>
    {
        protected override void Seed(HRISContext context)
        {
            var user_admin = new sys_User() { username = "admin", password = "JYZAJ9KCpK80FCErnsksqw==", hashKey = "29b373cae1fb59b32052386063fb100", vector = "R9_XFXT2U7CaaP_5", email = "mynrd@live.com", status = 1, };
            context.sys_Users.AddOrUpdate(user_admin);

            user_admin.updatedBy = user_admin.id;
            context.sys_Users.AddOrUpdate(user_admin);
            base.Seed(context);
        }
    }
}
