namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMovieDates : DbMigration
    {
        public override void Up()
        { 
            Sql("UPDATE Movies SET ReleaseDate = '10/6/2009', DateAdded = '5/4/2016' WHERE Id = 1");
            Sql("UPDATE Movies SET ReleaseDate = '7/22/1988', DateAdded = '2/10/2018' WHERE Id = 2");
            Sql("UPDATE Movies SET ReleaseDate = '10/26/1984', DateAdded = '10/20/2019' WHERE Id = 3");
            Sql("UPDATE Movies SET ReleaseDate = '11/22/1995', DateAdded = '7/27/2021' WHERE Id = 4");
            Sql("UPDATE Movies SET ReleaseDate = '12/19/1997', DateAdded = '3/16/2023' WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
