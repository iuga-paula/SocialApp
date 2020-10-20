namespace SocialApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makemessagecontentrequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "Content", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "Content", c => c.String());
        }
    }
}
