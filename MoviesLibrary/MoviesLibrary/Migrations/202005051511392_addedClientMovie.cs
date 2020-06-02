namespace MoviesLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedClientMovie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieClients",
                c => new
                    {
                        Movie_Id = c.Int(nullable: false),
                        Client_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_Id, t.Client_Id })
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieClients", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.MovieClients", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.MovieClients", new[] { "Client_Id" });
            DropIndex("dbo.MovieClients", new[] { "Movie_Id" });
            DropTable("dbo.MovieClients");
        }
    }
}
