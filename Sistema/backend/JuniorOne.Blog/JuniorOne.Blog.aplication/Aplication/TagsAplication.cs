using AutoMapper;
using JuniorOne.Blog.Aplication.Interface;
using JuniorOne.Blog.Aplication.ViewModel;
using JuniorOne.Blog.Domain.Interfaces;
using JuniorOne.Blog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace JuniorOne.Blog.Aplication.Aplication
{
    public class TagsAplication : ITagsAplication
    {
        private readonly ITagRepositorie _repo;
        private readonly IMapper _mapper;

        public TagsAplication(ITagRepositorie repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public TagsViewModel Delete(int id)
        {
            return _mapper.Map<TagsViewModel>(_repo.Delete(id));
        }

        public IEnumerable<TagsViewModel> Index()
        {
            return _mapper.Map<IEnumerable<TagsViewModel>>(_repo.Index());
        }

        public bool Save(TagsViewModel entity)
        {
            return _repo.Save(_mapper.Map<Tag>(entity));
        }

        public TagsViewModel Select(int id)
        {
            return _mapper.Map<TagsViewModel>(_repo.Select(id));
        }

        public bool Update(TagsViewModel entity)
        {
            return _repo.Update(_mapper.Map<Tag>(entity));
        }
    }
}
