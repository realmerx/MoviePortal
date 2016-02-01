namespace MVCmovie.Migrations
{
  using Models;
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;

  internal sealed class Configuration : DbMigrationsConfiguration<MVCmovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

    protected override void Seed(MVCmovie.Models.MovieDBContext context)
    {
      context.Movies.AddOrUpdate(i => i.Title,
          new Movie
          {
            Title = "Batman",
            ReleaseDate = DateTime.Parse("2016-1-11"),
            Genre = "Action",
            Rating = "10/10",
            Price = 7.99M
          },

           new Movie
           {
             Title = "PowerRangers ",
             ReleaseDate = DateTime.Parse("1999-5-20"),
             Genre = "Comedy",
             Rating = "5/10",
             Price = 8.99M
           },

           new Movie
           {
             Title = "Bad Movie",
             ReleaseDate = DateTime.Parse("2000-1-01"),
             Genre = "Real",
             Rating = "0/10",
             Price = 9.99M
           },

         new Movie
         {
           Title = "Saw",
           ReleaseDate = DateTime.Parse("2006-4-15"),
           Genre = "Horror",
           Rating = "6/10",
           Price = 3.99M
         }
     );

    }
  }
}
