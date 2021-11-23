﻿// <auto-generated />
using System;
using ApiProject.Data.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiProject.Data.Migrations
{
    [DbContext(typeof(ApiProjectContext))]
    [Migration("20211123102333_UpdateCreate")]
    partial class UpdateCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiProject.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("PhotoId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 11, 23, 13, 23, 32, 190, DateTimeKind.Local).AddTicks(6070),
                            IsActive = true,
                            IsDeleted = false,
                            Note = "Resim 1 Yorumu",
                            PhotoId = 1,
                            Text = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. "
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2021, 11, 23, 13, 23, 32, 190, DateTimeKind.Local).AddTicks(6093),
                            IsActive = true,
                            IsDeleted = false,
                            Note = "Resim 2 Yorumu",
                            PhotoId = 2,
                            Text = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. "
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2021, 11, 23, 13, 23, 32, 190, DateTimeKind.Local).AddTicks(6097),
                            IsActive = true,
                            IsDeleted = false,
                            Note = "Resim 3 Yorumu",
                            PhotoId = 3,
                            Text = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. "
                        });
                });

            modelBuilder.Entity("ApiProject.Entities.Concrete.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PathName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoAuthor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CommentCount = 1,
                            CreatedDate = new DateTime(2021, 11, 23, 13, 23, 32, 187, DateTimeKind.Local).AddTicks(1233),
                            Date = new DateTime(2021, 11, 23, 13, 23, 32, 186, DateTimeKind.Local).AddTicks(9231),
                            IsActive = true,
                            IsDeleted = false,
                            Note = "istanbul manzarasi",
                            SeoAuthor = "Bilgenur Kara",
                            SeoDescription = "istanbul manzarasi",
                            SeoTags = "manzara, istanbul, kule",
                            Title = "Resim 1 title",
                            UserId = 1,
                            ViewCount = 100
                        },
                        new
                        {
                            Id = 2,
                            CommentCount = 1,
                            CreatedDate = new DateTime(2021, 11, 23, 13, 23, 32, 187, DateTimeKind.Local).AddTicks(3326),
                            Date = new DateTime(2021, 11, 23, 13, 23, 32, 187, DateTimeKind.Local).AddTicks(3324),
                            IsActive = true,
                            IsDeleted = false,
                            Note = "partide egleniyoruz",
                            SeoAuthor = "Bilgenur Kara",
                            SeoDescription = "partide eglence",
                            SeoTags = "parti, birthday, people",
                            Title = "Resim 2 title",
                            UserId = 1,
                            ViewCount = 100
                        },
                        new
                        {
                            Id = 3,
                            CommentCount = 1,
                            CreatedDate = new DateTime(2021, 11, 23, 13, 23, 32, 187, DateTimeKind.Local).AddTicks(3331),
                            Date = new DateTime(2021, 11, 23, 13, 23, 32, 187, DateTimeKind.Local).AddTicks(3330),
                            IsActive = true,
                            IsDeleted = false,
                            Note = "architectural design",
                            SeoAuthor = "Bilgenur Kara",
                            SeoDescription = "architectural design",
                            SeoTags = "architect, home, design",
                            Title = "Resim 3 title",
                            UserId = 1,
                            ViewCount = 100
                        });
                });

            modelBuilder.Entity("ApiProject.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 11, 23, 13, 23, 32, 192, DateTimeKind.Local).AddTicks(1354),
                            Description = "Admin Rolü, Tüm Haklara Sahiptir.",
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Admin",
                            Note = "Admin Rolüdür."
                        });
                });

            modelBuilder.Entity("ApiProject.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Note")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2021, 11, 23, 13, 23, 32, 208, DateTimeKind.Local).AddTicks(330),
                            Description = "İlk Admin Kullanıcı",
                            Email = "karabilgenur@gmail.com",
                            FirstName = "Bilgenur",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Kara",
                            Note = "Admin Kullanıcısı",
                            PasswordHash = new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 },
                            Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU",
                            RoleId = 1,
                            UserName = "bilgeli"
                        });
                });

            modelBuilder.Entity("ApiProject.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("ApiProject.Entities.Concrete.Photo", "Photo")
                        .WithMany("Comments")
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("ApiProject.Entities.Concrete.Photo", b =>
                {
                    b.HasOne("ApiProject.Entities.Concrete.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApiProject.Entities.Concrete.User", b =>
                {
                    b.HasOne("ApiProject.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ApiProject.Entities.Concrete.Photo", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("ApiProject.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ApiProject.Entities.Concrete.User", b =>
                {
                    b.Navigation("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
