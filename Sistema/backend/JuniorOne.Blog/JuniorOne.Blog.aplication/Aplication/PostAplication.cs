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
    public class PostAplication : IPostAplication
    {
        public readonly IPostRepositories _repo;
        public readonly IMapper _mapper;

        public PostAplication(IPostRepositories repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public PostViewModel Delete(int id)
        {
            return _mapper.Map<PostViewModel>(_repo.Delete(id));
        }

        public IEnumerable<PostViewModel> Index()
        {
            return _mapper.Map<IEnumerable<PostViewModel>>(_repo.Index());
        }

        public bool Save(PostViewModel entity)
        {
            return _repo.Save(_mapper.Map<Post>(entity));
        }

        public PostViewModel Select(int id)
        {
            return _mapper.Map<PostViewModel>(_repo.Select(id));
        }

        public bool Update(PostViewModel entity)
        {
            return _repo.Update(_mapper.Map<Post>(entity));
        }
    }
}
