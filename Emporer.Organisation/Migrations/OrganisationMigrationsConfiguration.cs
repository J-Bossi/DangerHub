using System.ComponentModel.Composition;
using OpenResKit.DomainModel;

namespace OpenResKit.Organisation.Migrations
{
	using System.Data.Entity.Migrations;


  [Export]  
	internal sealed class OrganisationMigrationsConfiguration : DbMigrationsConfiguration<DomainModelContext>
    {
		
		[ImportingConstructor]
		public OrganisationMigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
						}

		protected override void Seed(DomainModelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
