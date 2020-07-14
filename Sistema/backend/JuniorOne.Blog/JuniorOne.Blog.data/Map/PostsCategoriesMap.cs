using JuniorOne.Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace JuniorOne.Blog.Data.Map
{
    public class PostsCategoriesMap : IEntityTypeConfiguration<PostsCategories>
    {
        public void Configure(EntityTypeBuilder<PostsCategories> builder)
        {
            throw new NotImplementedException();
        }
    }
}
