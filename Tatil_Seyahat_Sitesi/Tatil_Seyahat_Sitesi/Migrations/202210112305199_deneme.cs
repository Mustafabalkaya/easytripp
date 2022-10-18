namespace Tatil_Seyahat_Sitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tavsiyelers", "tavsiye_aciklama", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tavsiyelers", "tavsiye_aciklama");
        }
    }
}
