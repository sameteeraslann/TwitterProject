﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TwitterProject.Application.Models.DTOs;
using TwitterProject.Domain.Entities.Concrete;

namespace TwitterProject.Application.Mapper
{
   public class Mapping: Profile
    {
        public Mapping()
        {
            CreateMap<AppUser, RegisterDTO>().ReverseMap();
            CreateMap<AppUser, LoginDTO>().ReverseMap();
            CreateMap<AppUser, EditProfileDTO>().ReverseMap();
            CreateMap<AppUser, ProfileSummaryDTO>().ReverseMap();


            CreateMap<Follow, FollowDTO>().ReverseMap();
            CreateMap<Like, LikeDTO>().ReverseMap();
            CreateMap<Tweet, AddTweetDTO>().ReverseMap();


            CreateMap<Mention, AddMentionDTO>().ReverseMap();

        }
    }
}
