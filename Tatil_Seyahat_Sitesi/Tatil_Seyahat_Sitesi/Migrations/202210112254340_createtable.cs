namespace Tatil_Seyahat_Sitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tavsiyelers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tavsiye_otel = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tavsiyelers");
        }
    }
}
