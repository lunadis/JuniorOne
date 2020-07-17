using JuniorOne.Blog.Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorOne.Blog.Aplication.Interface
{
    public interface IPostsTagsAplication
    {
        bool Save(PostsTagsViewModel entity);

        bool Update(PostsTagsViewModel entity);

        PostsTagsViewModel Select(int id);

        PostsTagsViewModel Delete(int id);

        IEnumerable<PostsTagsViewModel> Index();
    }
}
