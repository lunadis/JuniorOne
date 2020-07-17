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
    public class PostsCategoriesAplication : IPostsCategoriesAplication
    {
        private readonly IPostsCategoriesRepositories _repo;
        private readonly IMapper _mapper;

        public PostsCategoriesAplication(IPostsCategoriesRepositories repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public PostsCategoriesViewModel Delete(int id)
        {
            return _mapper.Map<PostsCategoriesViewModel>(_repo.Delete(id));
        }

        public IEnumerable<PostsCategoriesViewModel> Index()
        {
            return _mapper.Map<IEnumerable<PostsCategoriesViewModel>>(_repo.Index());
        }

        public bool Save(PostsCategoriesViewModel entity)
        {
          return  _repo.Save(_mapper.Map<PostsCategories>(entity));
        }

        public PostsCategoriesViewModel Select(int id)
        {
            return _mapper.Map<PostsCategoriesViewModel>(_repo.Select(id));
        }

        public bool Update(PostsCategoriesViewModel entity)
        {
            return _repo.Update(_mapper.Map<PostsCategories>(entity));
        }
    }
}
