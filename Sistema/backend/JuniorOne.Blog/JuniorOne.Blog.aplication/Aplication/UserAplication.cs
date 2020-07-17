using AutoMapper;
using JuniorOne.Blog.Aplication.Interface;
using JuniorOne.Blog.Aplication.ViewModel;
using JuniorOne.Blog.Domain.Interfaces;
using JuniorOne.Blog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace JuniorOne.Blog.Aplication.Aplication
{
    public class UserAplication : IUserAplication
    {
        private readonly IUserRepositorie _repo;
        private readonly IMapper _mapper;

        public UserAplication(IUserRepositorie repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public UserViewModel Delete(int id)
        {
            return _mapper.Map<UserViewModel>(_repo.Delete(id));
        }

        public IEnumerable<UserViewModel> Index()
        {
            return _mapper.Map<IEnumerable<UserViewModel>>(_repo.Index());
        }

        public bool Save(UserViewModel entity)
        {
            return _repo.Save(_mapper.Map<User>(entity));
        }

        public UserViewModel Select(int id)
        {
            return _mapper.Map<UserViewModel>(_repo.Select(id));
        }

        public bool Update(UserViewModel entity)
        {
            return _repo.Update(_mapper.Map<User>(entity));
        }
    }
}
