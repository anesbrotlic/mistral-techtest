using System;
using System.Linq;
using AutoMapper;
using MovieApp.Entities.Entities;
using MovieApp.Models;

namespace MovieApp.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieModel>()
                .ForMember(d => d.Actors,
s => s.MapFrom(m => string.Join(',', m.MovieActors.Select(ma => ma.Actor.Name).ToList())))
                .ForMember(d => d.AvgRate, s => s.MapFrom(m1 => Decimal.Round((decimal)m1.MovieRatings.Average(m => m.Rating), 1)))
                .ForMember(d => d.RateByUser, s => s.MapFrom(m => 0))
                .ForMember(d=>d.ReleaseDate,s=>s.MapFrom(m=>m.ReleaseDate.ToShortDateString()))
                .ForMember(d=>d.Description,s=>s.MapFrom(m=>m.Description.Length>200?m.Description.Substring(0,200)+"...":m.Description));


            CreateMap<Movie, MovieDetailModel>()
                .ForMember(d => d.Actors, s => s.MapFrom(m => m.MovieActors.Select(ma => new ActorModel { Id = ma.Actor.Id, Name = ma.Actor.Name, ProfileImgPath = ma.Actor.ProfileImgPath }).ToList()))
                .ForMember(d => d.AvgRate, s => s.MapFrom(m => Decimal.Round((decimal)m.MovieRatings.Average(mr => mr.Rating), 1)))
                .ForMember(d => d.RateByUser, s => s.MapFrom(m => 0))
                .ForMember(d=>d.ReleaseDate,s=>s.MapFrom(m=>m.ReleaseDate.ToShortDateString()));


            CreateMap<Actor, ActorDetailsModel>()
                .ForMember(d => d.MoviesOfActor,
                    s => s.MapFrom(
                        a => a.MovieActors.Select(ma =>
                            new MovieModel2
                            {
                                Id = ma.Movie.Id,
                                Title = ma.Movie.Title,
                                ReleaseDate = ma.Movie.ReleaseDate.Year.ToString()
                            }).ToList()));

        }
    }
}