using ApiProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Data.Concrete.EntityFramework.Mappings
{
    public class PhotoMap : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Title).HasMaxLength(100);
            builder.Property(p => p.Title).IsRequired(true);
            builder.Property(p => p.Date).IsRequired();
            builder.Property(p => p.ViewCount).IsRequired();
            builder.Property(p => p.CommentCount).IsRequired();
            builder.Property(p => p.SeoAuthor).IsRequired();
            builder.Property(p => p.SeoAuthor).HasMaxLength(50);
            builder.Property(p => p.SeoDescription).HasMaxLength(150);
            builder.Property(p => p.SeoDescription).IsRequired();
            builder.Property(p => p.SeoTags).IsRequired();
            builder.Property(p => p.SeoTags).HasMaxLength(70);
            builder.HasOne<User>(p => p.User).WithMany(u => u.Photos).HasForeignKey(p => p.UserId);
            // ortak ozellikler
            builder.Property(p => p.CreatedDate).IsRequired();
            builder.Property(p => p.IsActive).IsRequired();
            builder.Property(p => p.IsDeleted).IsRequired();
            builder.Property(p => p.Note).HasMaxLength(500);

            builder.ToTable("Photos");

            builder.HasData(
                new Photo
                {
                    Id = 1,
                    Title = "Resim 1 title",
                    SeoDescription = "istanbul manzarasi",
                    SeoTags = "manzara, istanbul, kule",
                    SeoAuthor = "Bilgenur Kara",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    Note = "istanbul manzarasi",
                    UserId = 1,
                    ViewCount = 100,
                    CommentCount = 1
                },
                new Photo
                {
                    Id = 2,
                    Title = "Resim 2 title",
                    SeoDescription = "partide eglence",
                    SeoTags = "parti, birthday, people",
                    SeoAuthor = "Bilgenur Kara",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    Note = "partide egleniyoruz",
                    UserId = 1,
                    ViewCount = 100,
                    CommentCount = 1
                },
                new Photo
                {
                    Id = 3,
                    Title = "Resim 3 title",
                    SeoDescription = "architectural design",
                    SeoTags = "architect, home, design",
                    SeoAuthor = "Bilgenur Kara",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    Note = "architectural design",
                    UserId = 1,
                    ViewCount = 100,
                    CommentCount = 1
                }
            );
        }
    }
}
