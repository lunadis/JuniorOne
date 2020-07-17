using JuniorOne.Blog.Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorOne.Blog.Aplication.Interface
{
    public interface IPostAplication
    {
        bool Save(PostViewModel entity);

        bool Update(PostViewModel entity);

        PostViewModel Select(int id);

        PostViewModel Delete(int id);

        IEnumerable<PostViewModel> Index();
    }
}
