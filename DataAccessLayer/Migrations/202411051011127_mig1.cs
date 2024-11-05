namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "WriteId", c => c.Int());
            CreateIndex("dbo.Contents", "WriteId");
            AddForeignKey("dbo.Contents", "WriteId", "dbo.Writers", "WriteId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "WriteId", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "WriteId" });
            DropColumn("dbo.Contents", "WriteId");
        }
    }
}
