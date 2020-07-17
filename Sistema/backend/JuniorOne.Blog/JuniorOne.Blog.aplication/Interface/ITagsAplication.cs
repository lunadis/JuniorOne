using JuniorOne.Blog.Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorOne.Blog.Aplication.Interface
{
    public interface ITagsAplication
    {
        bool Save(TagsViewModel entity);

        bool Update(TagsViewModel entity);

        TagsViewModel Select(int id);

        TagsViewModel Delete(int id);

        IEnumerable<TagsViewModel> Index();
    }
}
