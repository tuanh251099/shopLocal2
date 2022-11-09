using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using shopLocal.Data.Entities;
using shopLocal.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopLocal.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is the home page shopLocal" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword shopLocal" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description shopLocal" }
                );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id="vi-VN", Name="Tiếng Việt", IsDefault = true},
                new Language() { Id="en-US", Name="English",IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                                              
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                }
                );
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() { Id=1, CategoryId = 1, Name = "Áo Nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam ", SeoTitle = "Áo thời trang nam" },
                new CategoryTranslation() { Id=2, CategoryId = 1, Name = "Man Shirt", LanguageId = "en-US", SeoAlias = "man-shirt", SeoDescription = "shirt for man", SeoTitle = "shirt for man" },
                new CategoryTranslation() { Id=3, CategoryId=2, Name = "Áo nữ", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ ", SeoTitle = "Áo thời trang nữ" },
                new CategoryTranslation() { Id=4, CategoryId=2, Name = "Woman Shirt", LanguageId = "en-US", SeoAlias = "Woman-shirt", SeoDescription = "shirt for woman", SeoTitle = "shirt for woman" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id=1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                }
                );

            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation() { Id=1, ProductId=1, Name = "Áo Nam trắng", LanguageId = "vi-VN", SeoAlias = "ao-nam-trang", SeoDescription = "Sản phẩm áo thời trang nam trắng ", SeoTitle = "Áo thời trang nam màu trắng", Details = "Mô tả sản phẩm", Description = "" },
                 new ProductTranslation() { Id=2, ProductId=1, Name = "Man Shirt White", LanguageId = "en-US", SeoAlias = "man-shirt-white", SeoDescription = "white shirt for man", SeoTitle = "white shirt for man", Details = "Description of the product", Description = "" }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId=1 }
                );
            
            var roleId= Guid.NewGuid();
            var adminId = Guid.NewGuid();
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id= roleId,
                Name= "admin",
                NormalizedName = "admin",
                Description = "Adminnistrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName= "admin",
                NormalizedUserName= "admin",
                Email="tuanh.99.2510@gmail.com",
                NormalizedEmail="ta25@gmial.com",
                EmailConfirmed=true,
                PasswordHash = hasher.HashPassword(null, "Abc123"),
                SecurityStamp= String.Empty,
                FirstName= "Tuan",
                LastName="Anh",
                Dob = new DateTime(1999,10,25)
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
                {
                RoleId = roleId,
                UserId = adminId
                });
        }

        
    }
}
