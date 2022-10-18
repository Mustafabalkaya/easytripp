namespace Tatil_Seyahat_Sitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plajs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        plaj_link = c.String(),
                        plaj_aciklama = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Plajs");
        }
    }
}
