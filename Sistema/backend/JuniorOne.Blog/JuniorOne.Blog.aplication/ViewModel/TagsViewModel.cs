using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorOne.Blog.Aplication.ViewModel
{
    public class TagsViewModel
    {
        public int Id { get; set; }
        public string TagName { get; set; }

        public IEnumerable<PostsTagsViewModel> PostsTags { get; set; }
    }
}
