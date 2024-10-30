namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Western')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Mystery')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Science fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Historical')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Animated')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'Documentary')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (13, 'Family')");
        }
        
        public override void Down()
        {
        }
    }
}
