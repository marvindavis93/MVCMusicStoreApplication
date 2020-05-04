namespace EventApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "EventStartTime", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "EventEndTime", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "EventEndTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Events", "EventStartTime", c => c.DateTime(nullable: false));
        }
    }
}
