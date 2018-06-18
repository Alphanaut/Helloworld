namespace Registration.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedAddressType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddressTypes", "Position", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AddressTypes", "Position");
        }
    }
}
