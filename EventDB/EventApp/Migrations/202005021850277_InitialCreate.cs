namespace EventApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        RecordId = c.Int(nullable: false, identity: true),
                        CartId = c.String(),
                        OrderId = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        EventId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecordId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventsId = c.Int(nullable: false, identity: true),
                        EventTitle = c.String(nullable: false, maxLength: 50),
                        EventDescription = c.String(maxLength: 150),
                        EventStartTime = c.DateTime(nullable: false),
                        EventStartDate = c.DateTime(nullable: false),
                        EventEndTime = c.DateTime(nullable: false),
                        EventEndDate = c.DateTime(nullable: false),
                        City = c.String(),
                        State = c.String(),
                        EventType = c.String(),
                        OrganizerName = c.String(nullable: false),
                        OrganizerContactInfo = c.String(),
                        MaxTickets = c.Int(nullable: false),
                        AvaliableTickets = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EventsId);
            
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        EventTypeId = c.Int(nullable: false, identity: true),
                        EventTypeName = c.String(),
                    })
                .PrimaryKey(t => t.EventTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EventTypes");
            DropTable("dbo.Events");
            DropTable("dbo.Carts");
        }
    }
}
