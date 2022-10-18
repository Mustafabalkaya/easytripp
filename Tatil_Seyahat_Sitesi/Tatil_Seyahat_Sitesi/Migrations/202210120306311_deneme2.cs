namespace Tatil_Seyahat_Sitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ekleme_restaurant = c.String(),
                        ekleme_aciklama = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Restaurants");
        }
    }
}
