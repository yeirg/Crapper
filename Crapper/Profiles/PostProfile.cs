﻿using AutoMapper;
using Crapper.DTOs.Post;
using Crapper.Models;

namespace Crapper.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<PostCreateDto, Post>();
            CreateMap<Post, PostDto>();
        }
    }
}