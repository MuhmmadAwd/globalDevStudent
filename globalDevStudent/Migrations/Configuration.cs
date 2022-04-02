namespace globalDevStudent.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<globalDevStudent.GlobalDev.GlobalDevContxt>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "globalDevStudent.GlobalDev.GlobalDevContxt";
        }

        protected override void Seed(globalDevStudent.GlobalDev.GlobalDevContxt context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
