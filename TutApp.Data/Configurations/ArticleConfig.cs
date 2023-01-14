using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tut.Model.SiteDbContext;
using TutApp.Data.Models;

namespace TutApp.Data.Configurations
{
    public class ArticleConfig : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(
                new Article
                {
                    Id = 1,
                    Title= "איך להשתמש ב-Github?",
                    Content = "*",
                    Created = new DateTime(2021, 12, 6, 0, 0, 0),
                    category = CategoryTypes.Programming,
                    Stars = 5,
                    Views = 35643,

                    ImageId = 1,
                    UserId = "24d6f228-0992-4755-8a17-670efb9d10e0"
                },
                new Article
                {
                    Id = 2,
                    Title = "מה זה תכנות מונחה עצמים?",
                    Content = "*",
                    Created = new DateTime(2021, 6, 11, 0, 0, 0),
                    category = CategoryTypes.Programming,
                    Stars = 3,
                    Views = 324576,

                    ImageId = 2,
                    UserId = "24d6f228-0992-4755-8a17-670efb9d10e0"
                },
                new Article
                {
                    Id = 3,
                    Title = "מבוא לאנגולר",
                    Content = "*",
                    Created = new DateTime(2021, 8, 4, 0, 0, 0),
                    category = CategoryTypes.Programming,
                    Stars = 4,
                    Views = 15643,

                    ImageId = 3,
                    UserId = "917d992e-763c-4560-be77-96b1ebca3654"
                },
                new Article
                {
                    Id = 4,
                    Title = "תכנות אסינכרוני ב-JS",
                    Content = "*",
                    Created = new DateTime(2022, 1, 14, 0, 0, 0),
                    category = CategoryTypes.Programming,
                    Stars = 5,
                    Views = 152643,

                    ImageId = 4,
                    UserId = "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89"
                },
                new Article
                {
                    Id = 5,
                    Title = "10 טיפים לבית החכם",
                    Content = "*",
                    Created = new DateTime(2021, 5, 26, 0, 0, 0),
                    category = CategoryTypes.IOT,
                    Stars = 4,
                    Views = 354342,

                    ImageId = 5,
                    UserId = "24d6f228-0992-4755-8a17-670efb9d10e0"
                },
                new Article
                {
                    Id = 6,
                    Title = "איך לתכנת את שואב הדייסון שלכם?",
                    Content = "*",
                    Created = new DateTime(2022, 6, 9, 0, 0, 0),
                    category = CategoryTypes.IOT,
                    Stars = 2,
                    Views = 3453,

                    ImageId = 6,
                    UserId = "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89"
                },
                new Article
                {
                    Id = 7,
                    Title = "התקנת מנעול חכם לבית",
                    Content = "*",
                    Created = new DateTime(2022, 10, 10, 0, 0, 0),
                    category = CategoryTypes.IOT,
                    Stars = 1,
                    Views = 5685,

                    ImageId = 7,
                    UserId = "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89"
                },
                new Article
                {
                    Id = 8,
                    Title = "5 מוצרים חכמים לכל בית",
                    Content = "*",
                    Created = new DateTime(2020, 12, 20, 0, 0, 0),
                    category = CategoryTypes.IOT,
                    Stars = 0,
                    Views = 124,

                    ImageId = 8,
                    UserId = "917d992e-763c-4560-be77-96b1ebca3654"
                },
                new Article
                {
                    Id = 9,
                    Title = "איך להתקין חוסם פרסומות בדפדפן?",
                    Content = "*",
                    Created = new DateTime(2022, 11, 16, 0, 0, 0),
                    category = CategoryTypes.Internet,
                    Stars = 5,
                    Views = 34564536,

                    ImageId = 9,
                    UserId = "917d992e-763c-4560-be77-96b1ebca3654"
                },
                new Article
                {
                    Id = 10,
                    Title = "מה זה קוד 404?",
                    Content = "*",
                    Created = new DateTime(2022, 2, 15, 0, 0, 0),
                    category = CategoryTypes.Internet,
                    Stars = 3,
                    Views = 45643,

                    ImageId = 10,
                    UserId = "917d992e-763c-4560-be77-96b1ebca3654"
                },
                new Article
                {
                    Id = 11,
                    Title = "7 טיפים לגלישה בטוחה באינטרנט",
                    Content = "*",
                    Created = new DateTime(2021, 1, 1, 0, 0, 0),
                    category = CategoryTypes.Internet,
                    Stars = 1,
                    Views = 356,

                    ImageId = 11,
                    UserId = "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89"
                },
                new Article
                {
                    Id = 12,
                    Title = "המדריך המלא ל-Gmail",
                    Content = "*",
                    Created = new DateTime(2022, 11, 16, 0, 0, 0),
                    category = CategoryTypes.Internet,
                    Stars = 2,
                    Views = 27643,

                    ImageId = 12,
                    UserId = "24d6f228-0992-4755-8a17-670efb9d10e0"
                },
                new Article
                {
                    Id = 13,
                    Title = "איך לעשות רקע שקוף לתמונה?",
                    Content = "*",
                    Created = new DateTime(2021, 1, 1, 0, 0, 0),
                    category = CategoryTypes.Design,
                    Stars = 5,
                    Views = 4565468,

                    ImageId = 13,
                    UserId = "917d992e-763c-4560-be77-96b1ebca3654"
                },
                new Article
                {
                    Id = 14,
                    Title = "המדריך המלא ל-Gimp",
                    Content = "*",
                    Created = new DateTime(2021, 12, 6, 0, 0, 0),
                    category = CategoryTypes.Design,
                    Stars = 4,
                    Views = 25643,

                    ImageId = 14,
                    UserId = "917d992e-763c-4560-be77-96b1ebca3654"
                },
                new Article
                {
                    Id = 15,
                    Title = "המדריך המלא ל-PhotoShop",
                    Content = "*",
                    Created = new DateTime(2021, 5, 26, 0, 0, 0),
                    category = CategoryTypes.Design,
                    Stars = 5,
                    Views = 5675656,

                    ImageId = 15,
                    UserId = "8bb44c37-2465-4d1c-ba34-85ef3c0a3d89"
                },
                new Article
                {
                    Id = 16,
                    Title = "איך ליצור תמונות מונפשות?",
                    Content = "*",
                    Created = new DateTime(2020, 12, 20, 0, 0, 0),
                    category = CategoryTypes.Design,
                    Stars = 0,
                    Views = 22643,

                    ImageId = 16,
                    UserId = "24d6f228-0992-4755-8a17-670efb9d10e0"
                });
        }
    }
}
