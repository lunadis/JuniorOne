using AutoMapper;
using JuniorOne.Blog.Aplication.Interface;
using JuniorOne.Blog.Aplication.ViewModel;
using JuniorOne.Blog.Domain.Interfaces;
using JuniorOne.Blog.Domain.Models;
using System;
using System.Collections.Generic;

namespace JuniorOne.Blog.Aplication.Aplication
{
    public class CategoryAplication : ICategoryAplication
    {
        private readonly ICategoryRepositorie _repo;
        private readonly IMapper _mapper;

        public CategoryAplication(ICategoryRepositorie repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public CategoryViewModel Delete(int id)
        {
          return _mapper.Map<CategoryViewModel>(_repo.Delete(id));
        }

        public IEnumerable<CategoryViewModel> Index()
        {
            return _mapper.Map<IEnumerable<CategoryViewModel>>(_repo.Index());
        }

        public bool Save(CategoryViewModel entity)
        {
            return _repo.Save(_mapper.Map<Category>(entity));
        }

        public CategoryViewModel Select(int id)
        {
            return _mapper.Map<CategoryViewModel>(_repo.Select(id));
        }

        public bool Update(CategoryViewModel entity)
        {
            return _repo.Update(_mapper.Map<Category>(entity));
        }
    }
}
