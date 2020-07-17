using AutoMapper;
using JuniorOne.Blog.Aplication.ViewModel;
using JuniorOne.Blog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace JuniorOne.Blog.Aplication.Mapper
{
    public class MapperConfig : Profile
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(X => X.AllowNullCollections = true);
        }

        public MapperConfig()
        {
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Post, PostViewModel>().ReverseMap();
            CreateMap<PostsCategories, PostsCategoriesViewModel>().ReverseMap();
            CreateMap<PostsTags, PostsTagsViewModel>().ReverseMap();
            CreateMap<Tag, TagsViewModel>().ReverseMap();
            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
}
