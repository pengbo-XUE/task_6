namespace assignment_2_task_6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MenuModels", "itemName", c => c.String(maxLength: 100));
            AlterColumn("dbo.MenuModels", "itemDescription", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MenuModels", "itemDescription", c => c.String());
            AlterColumn("dbo.MenuModels", "itemName", c => c.String());
        }
    }
}
