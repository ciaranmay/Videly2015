namespace Vidley2015.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedcustomermodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribedToNewsLetter");
        }
    }
}
