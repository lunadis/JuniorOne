using JuniorOne.Blog.Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorOne.Blog.Aplication.Interface
{
    public interface IUserAplication
    {
        bool Save(UserViewModel entity);

        bool Update(UserViewModel entity);

        UserViewModel Select(int id);

        UserViewModel Delete(int id);

        IEnumerable<UserViewModel> Index();
    }
}
