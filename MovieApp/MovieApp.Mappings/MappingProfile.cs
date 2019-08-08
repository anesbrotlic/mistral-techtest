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
s => s.MapFrom(m =>string.Join(',',m.MovieActors.Select(ma => ma.Actor.Name).ToList())))
                .ForMember(d=>d.AvgRate, s=>s.MapFrom(m1=>Decimal.Round((decimal)m1.MovieRatings.Average(m=>m.Rating),1)))
                .ForMember(d=>d.RateByUser,s=>s.MapFrom(m=>0));
                

            CreateMap<Movie, MovieDetailModel>()
                .ForMember(d => d.Actors, s => s.MapFrom(m => m.MovieActors.Select(ma => new ActorModel{Id = ma.Actor.Id,Name = ma.Actor.Name,ProfileImgPath = ma.Actor.ProfileImgPath}).ToList()))
                .ForMember(d => d.AvgRate, s => s.MapFrom(m => m.MovieRatings.Average(mr => mr.Rating)))
                .ForMember(d=>d.RateByUser,s=>s.MapFrom(m=>0));


        }
    }
}