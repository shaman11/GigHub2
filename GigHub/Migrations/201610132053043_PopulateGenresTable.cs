namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'skramz')");
            Sql( "INSERT INTO Genres (Id, Name) VALUES (2, 'power violence')");
            Sql( "INSERT INTO Genres (Id, Name) VALUES (3, 'black metal')");
            Sql( "INSERT INTO Genres (Id, Name) VALUES (4, 'melodic hardcore')");
            Sql( "INSERT INTO Genres (Id, Name) VALUES (0, 'math rock')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (0,1,2,3,4)");
        }
    }
}
