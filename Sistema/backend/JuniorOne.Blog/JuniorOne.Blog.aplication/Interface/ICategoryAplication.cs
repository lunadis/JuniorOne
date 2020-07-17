using JuniorOne.Blog.Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorOne.Blog.Aplication.Interface
{
    public interface ICategoryAplication
    {
        bool Save(CategoryViewModel entity);

        bool Update(CategoryViewModel entity);

        CategoryViewModel Select(int id);

        CategoryViewModel Delete(int id);

        IEnumerable<CategoryViewModel> Index();
    }
}
