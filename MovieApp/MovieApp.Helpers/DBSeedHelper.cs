using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MovieApp.Entities.Entities;
using Newtonsoft.Json;

namespace MovieApp.Helpers
{
    public static class DBSeedHelper
    {
        private static string CurrentDirectory = Directory.GetCurrentDirectory();
        private static string JsonFilesLocation = Path.GetFullPath(Path.Combine(CurrentDirectory, @"..\\MovieApp.Database\\"));
        private static string MovieImagesDirectoryLocation = CurrentDirectory + "\\Images\\Movies\\";
        private static string ActorsImagesDirectoryLocation = CurrentDirectory + "\\Images\\Actors\\";
        private static string ImagesDownloadURL = "https://image.tmdb.org/t/p/w500/";



        public static List<Actor> GetActors()
        {
            dynamic array = ReadJSONFile("Actors.json");

            var actorsList = new List<Actor>();
            for (int i = 0; i < array.Count; i++)
                actorsList.Add(new Actor
                {
                    Id = i+1,
                    Name = array[i].name,
                    ProfileImgPath = array[i].profile_path?.ToString()??""
                });


            DownloadActorPhotos(actorsList).Wait();

            foreach (var actor in actorsList)
            {
                if (!String.IsNullOrEmpty(actor.ProfileImgPath))
                    actor.ProfileImgPath = "Images/Actors" + actor.ProfileImgPath;
            }

            return actorsList;
        }

        private static async Task DownloadActorPhotos(List<Actor> list)
        {
            using (WebClient client = new WebClient())
            {
                foreach (var actor in list)
                {
                    if (!String.IsNullOrEmpty(actor.ProfileImgPath))
                        client.DownloadFile(new Uri(ImagesDownloadURL + actor.ProfileImgPath), ActorsImagesDirectoryLocation + actor.ProfileImgPath);
                }
            }
        }


        public static List<Movie> GetMovies()
        {
            dynamic array = ReadJSONFile("Movies.json");

            var movieList = new List<Movie>();

            for (int i = 0; i < array.Count; i++)
            {
                movieList.Add(new Movie
                {
                    Id = i+1,
                    Description = array[i].overview,
                    ReleaseDate = array[i].release_date,
                    Title = array[i].title,
                    CoverImgPath = array[i].poster_path?.ToString()??""
                });
            }

            DownloadMoviePhotos(movieList).Wait();

            foreach (var movie in movieList)
            {
                if (!String.IsNullOrEmpty(movie.CoverImgPath))
                    movie.CoverImgPath = "Images/Movies" + movie.CoverImgPath;
            }

            return movieList;
        }

        private static async Task DownloadMoviePhotos(List<Movie> list)
        {
            using (WebClient client = new WebClient())
            {
                foreach (var movie in list)
                {
                    if(!String.IsNullOrEmpty(movie.CoverImgPath))
                        client.DownloadFile(new Uri(ImagesDownloadURL + movie.CoverImgPath), MovieImagesDirectoryLocation + movie.CoverImgPath);
                }

            }
        }

        private static dynamic ReadJSONFile(string fileName)
        {

            string json = "";

            using (StreamReader r = new StreamReader(JsonFilesLocation + fileName))
            {
                json = r.ReadToEnd();
            }

            return JsonConvert.DeserializeObject(json);
        }
    }
}
