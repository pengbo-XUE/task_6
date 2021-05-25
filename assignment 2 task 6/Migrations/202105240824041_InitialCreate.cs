namespace assignment_2_task_6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        itemName = c.String(),
                        itemPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        itemDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MenuModels");
        }
    }
}
