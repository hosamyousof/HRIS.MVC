namespace HRIS.Data.Migrations
{
    using HRIS.Data.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HRIS.Data.HRISContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HRIS.Data.HRISContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            ////  to avoid creating duplicate seed data.
            //var company = new sys_Company()
            //{
            //    code = "TEST-001",
            //    businessName = "TEST Company",

            //};
            //context.sys_Companies.AddOrUpdate(company);

            this.AddEnumReference(context);



            //var user_admin = new sys_User()
            //{
            //    username = "admin",
            //    password = "JYZAJ9KCpK80FCErnsksqw==",
            //    hashKey = "29b373cae1fb59b32052386063fb100",
            //    vector = "R9_XFXT2U7CaaP_5",
            //    email = "mynrd@live.com",
            //    status = 1,
            //};
            //context.sys_Users.AddOrUpdate(user_admin);



            ////user_admin.updatedBy = user_admin.id;
            ////context.sys_Users.AddOrUpdate(user_admin);
        }

        private void AddEnumReference(HRISContext context)
        {
            //context.sys_EnumReferences.AddOrUpdate(new sys_EnumReference() { name = "",  });
        }
    }
}
