namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (1, 'Hangover', 6/10/2009, 4/5/2016, 5, 7)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (2, 'Die Hard', 22/7/1988, 10/2/2018, 2, 5)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (3, 'The Terminator', 26/10/1984, 20/10/2019, 7, 5)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (4, 'Toy Story', 22/11/1995, 27/7/2021, 10, 13)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (5, 'Titanic', 19/12/1997, 16/3/2023, 8, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
