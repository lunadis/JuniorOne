using AutoMapper;
using JuniorOne.Blog.Aplication.Interface;
using JuniorOne.Blog.Aplication.ViewModel;
using JuniorOne.Blog.Domain.Interfaces;
using JuniorOne.Blog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorOne.Blog.Aplication.Aplication
{
    public class PostsTagsAplication : IPostsTagsAplication
    {
        private readonly IPostsTagsReporitoires _repo;
        private readonly IMapper _mapper;

        public PostsTagsAplication(IPostsTagsReporitoires repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public PostsTagsViewModel Delete(int id)
        {
            return _mapper.Map<PostsTagsViewModel>(_repo.Delete(id));
        }

        public IEnumerable<PostsTagsViewModel> Index()
        {
            return _mapper.Map<IEnumerable<PostsTagsViewModel>>(_repo.Index());
        }

        public bool Save(PostsTagsViewModel entity)
        {
            return _repo.Save(_mapper.Map<PostsTags>(entity));
        }

        public PostsTagsViewModel Select(int id)
        {
            return _mapper.Map<PostsTagsViewModel>(_repo.Select(id));
        }

        public bool Update(PostsTagsViewModel entity)
        {
            return _repo.Update(_mapper.Map<PostsTags>(entity));
        }
    }
}
