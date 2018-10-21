namespace HospitalPrivadoHP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RolID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "RolID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "RolID");
        }
    }
}
