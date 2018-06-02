namespace e_market.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Korisnik", "Ime", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Korisnik", "Ime", c => c.String());
        }
    }
}
