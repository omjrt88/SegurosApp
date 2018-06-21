namespace SegurosApp.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SegurosApp.DAL.InsuranceContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SegurosApp.DAL.InsuranceContext context)
        {
            ///  This method will be called after migrating to the latest version.

            ///  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            ///  to avoid creating duplicate seed data.
        }
    }
}
