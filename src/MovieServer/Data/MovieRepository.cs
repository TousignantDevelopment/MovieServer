using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieServer.Models;

namespace MovieServer.Data
{
    public class MovieRepository
    {
        private static Movie[] _movies = new Movie[]
        {
            new Movie()
            {
                MovieTitle = "The Amazing Spider-Man",
                MovieRating = 45,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Actors = new Actor[]
                {
                    new Actor() { Name = "Dan Slott", Character = "Script" },
                    new Actor() { Name = "Humberto Ramos", Character = "Pencils" },
                    new Actor() { Name = "Victor Olazaba", Character = "Inks" },
                    new Actor() { Name = "Edgar Delgado", Character = "Colors" },
                    new Actor() { Name = "Chris Eliopoulos", Character = "Letters" },


                },
                Favorite = false
            },
            new Movie()
                {
                    MovieTitle = "The Amazing Spider-Man",
                    MovieRating = 68,
                    DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                    Actors = new Actor[]
                    {
                        new Actor() { Name = "Dan Slott", Character = "Script" },
                        new Actor() { Name = "Marcos Martin", Character = "Pencils" },
                        new Actor() { Name = "Marcos Martin", Character = "Inks" },
                        new Actor() { Name = "Muntsa Vicente", Character = "Colors" },
                        new Actor() { Name = "Joe Caramagna", Character = "Letters" }
                    },
                    Favorite = false
                },
                new Movie()
                {
                    MovieTitle = "Bone",
                    MovieRating = 50,
                    DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                    Actors = new Actor[]
                    {
                        new Actor() { Name = "Jeff Smith", Character = "Script" },
                        new Actor() { Name = "Jeff Smith", Character = "Pencils" },
                        new Actor() { Name = "Jeff Smith", Character = "Inks" },
                        new Actor() { Name = "Jeff Smith", Character = "Letters" }
                    },
                    Favorite = false
                }
        };

        public Movie GetMovie(int id)
        {
            Movie movieToReturn = null;  

            foreach (var movie in _movies)
            {
                if (movie.Id == id)
                {
                    movieToReturn = movie;
                    break;
                }
            }

            return movieToReturn;
        }
    }
}