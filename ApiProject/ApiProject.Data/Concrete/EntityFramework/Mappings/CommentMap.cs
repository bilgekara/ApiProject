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
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).IsRequired();
            builder.Property(c => c.Text).HasMaxLength(1000);
            builder.HasOne<Photo>(c => c.Photo).WithMany(p => p.Comments).HasForeignKey(c => c.PhotoId);
            // ortak özellikler
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);

            builder.ToTable("Comments");

            builder.HasData(   // veri tabanına ilk verileri ekliyoruz
                new Comment
                {
                    Id = 1,
                    PhotoId = 1,
                    Text =
                        "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır." +
                        " Ancak bunların büyük bir çoğunluğu mizah katılarak veya " +
                        "rastgele sözcükler eklenerek değiştirilmişlerdir. " +
                        "Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına" +
                        " utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. " ,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    Note = "Resim 1 Yorumu",
                },
                new Comment
                {
                    Id = 2,
                    PhotoId = 2,
                    Text =
                        "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır." +
                        " Ancak bunların büyük bir çoğunluğu mizah katılarak veya " +
                        "rastgele sözcükler eklenerek değiştirilmişlerdir. " +
                        "Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına" +
                        " utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. ",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    Note = "Resim 2 Yorumu",
                },
                new Comment
                {
                    Id = 3,
                    PhotoId = 3,
                    Text =
                        "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır." +
                        " Ancak bunların büyük bir çoğunluğu mizah katılarak veya " +
                        "rastgele sözcükler eklenerek değiştirilmişlerdir. " +
                        "Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına" +
                        " utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. ",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    Note = "Resim 3 Yorumu",
                }

            );
        }
    }
}
