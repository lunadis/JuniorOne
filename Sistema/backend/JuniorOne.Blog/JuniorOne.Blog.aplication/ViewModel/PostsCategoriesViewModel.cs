using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorOne.Blog.Aplication.ViewModel
{
    public class PostsCategoriesViewModel
    {
        public int Id { get; set; }

        public int IdPost { get; set; }
        public PostViewModel Post { get; set; }

        public int IdCategory { get; set; }
        public CategoryViewModel Category { get; set; }
    }
}
