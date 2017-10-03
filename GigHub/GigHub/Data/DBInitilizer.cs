using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using GigHub.Models;

namespace GigHub.Data
{
    internal class DBInitilizer
    {
        internal static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Genres.Any())
            {
                return;
            }

            var genres = new Genre[]
            {
                new Genre{ ID = 1,Name="JAZZ"},
                new Genre{ ID = 2, Name = "Blues"},
                new Genre{ ID = 3, Name = "Rock"},
                new Genre{ ID = 4, Name = "Country"}

            };

            foreach (Genre g in genres)
            {
                context.Genres.Add(g);
            }

            context.SaveChanges();
        }
    }
}