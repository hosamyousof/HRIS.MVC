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
            //  to avoid creating duplicate seed data.

            //if (context.sys_Companies.Any()) return;

            //var user_admin = new sys_User()
            //{
                 
            //};
            //context.sys_Users.Add(user_admin);


        }
    }
}
