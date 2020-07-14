using JuniorOne.Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JuniorOne.Blog.Data.Map
{
    public class PostsTagsMap : IEntityTypeConfiguration<PostsTags>
    {
        public void Configure(EntityTypeBuilder<PostsTags> builder)
        {
            throw new NotImplementedException();
        }
    }
}
