using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorOne.Blog.Aplication.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Registered_in { get; set; }
        public IEnumerable<PostViewModel> Posts { get; set; }
    }
}
