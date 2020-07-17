using JuniorOne.Blog.Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorOne.Blog.Aplication.Interface
{
    public interface IPostsCategoriesAplication
    {
        bool Save(PostsCategoriesViewModel entity);

        bool Update(PostsCategoriesViewModel entity);

        PostsCategoriesViewModel Select(int id);

        PostsCategoriesViewModel Delete(int id);

        IEnumerable<PostsCategoriesViewModel> Index();
    }
}
