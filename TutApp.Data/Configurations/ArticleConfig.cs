using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tut.Data.SiteDbContext;
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
                    Stars = 0,
                    Views = 0,

                    ImageId = 1,
                    UserEmail = "al@email.com"
                },
                new Article
                {
                    Id = 2,
                    Title = "מה זה תכנות מונחה עצמים?",
                    Content = "*",
                    Created = new DateTime(2021, 6, 11, 0, 0, 0),
                    category = CategoryTypes.Programming,
                    Stars = 0,
                    Views = 0,

                    ImageId = 2,
                    UserEmail = "al@email.com"
                },
                new Article
                {
                    Id = 3,
                    Title = "מבוא לאנגולר",
                    Content = "*",
                    Created = new DateTime(2021, 8, 4, 0, 0, 0),
                    category = CategoryTypes.Programming,
                    Stars = 0,
                    Views = 0,

                    ImageId = 3,
                    UserEmail = "abed@email.com"
                },
                new Article
                {
                    Id = 4,
                    Title = "תכנות אסינכרוני ב-JS",
                    Content = "*",
                    Created = new DateTime(2022, 1, 14, 0, 0, 0),
                    category = CategoryTypes.Programming,
                    Stars = 0,
                    Views = 0,

                    ImageId = 4,
                    UserEmail = "erik@email.com"
                },
                new Article
                {
                    Id = 5,
                    Title = "10 טיפים לבית החכם",
                    Content = "*",
                    Created = new DateTime(2021, 5, 26, 0, 0, 0),
                    category = CategoryTypes.IOT,
                    Stars = 0,
                    Views = 0,

                    ImageId = 5,
                    UserEmail = "al@email.com"
                },
                new Article
                {
                    Id = 6,
                    Title = "איך לתכנת את שואב הדייסון שלכם?",
                    Content = "*",
                    Created = new DateTime(2022, 6, 9, 0, 0, 0),
                    category = CategoryTypes.IOT,
                    Stars = 0,
                    Views = 0,

                    ImageId = 6,
                    UserEmail = "erik@email.com"
                },
                new Article
                {
                    Id = 7,
                    Title = "התקנת מנעול חכם לבית",
                    Content = "*",
                    Created = new DateTime(2022, 10, 10, 0, 0, 0),
                    category = CategoryTypes.IOT,
                    Stars = 0,
                    Views = 0,

                    ImageId = 5,
                    UserEmail = "erik@email.com"
                },
                new Article
                {
                    Id = 8,
                    Title = "5 מוצרים חכמים לכל בית",
                    Content = "*",
                    Created = new DateTime(2020, 12, 20, 0, 0, 0),
                    category = CategoryTypes.IOT,
                    Stars = 0,
                    Views = 0,

                    ImageId = 6,
                    UserEmail = "abed@email.com"
                },
                new Article
                {
                    Id = 9,
                    Title = "איך להתקין חוסם פרסומות בדפדפן?",
                    Content = "*",
                    Created = new DateTime(2022, 11, 16, 0, 0, 0),
                    category = CategoryTypes.Internet,
                    Stars = 0,
                    Views = 0,

                    ImageId = 9,
                    UserEmail = "abed@email.com"
                },
                new Article
                {
                    Id = 10,
                    Title = "מה זה קוד 404?",
                    Content = "*",
                    Created = new DateTime(2022, 2, 15, 0, 0, 0),
                    category = CategoryTypes.Internet,
                    Stars = 0,
                    Views = 0,

                    ImageId = 10,
                    UserEmail = "abed@email.com"
                },
                new Article
                {
                    Id = 11,
                    Title = "7 טיפים לגלישה בטוחה באינטרנט",
                    Content = "*",
                    Created = new DateTime(2021, 1, 1, 0, 0, 0),
                    category = CategoryTypes.Internet,
                    Stars = 0,
                    Views = 0,

                    ImageId = 11,
                    UserEmail = "erik@email.com"
                },
                new Article
                {
                    Id = 12,
                    Title = "המדריך המלא ל-Gmail",
                    Content = "*",
                    Created = new DateTime(2022, 11, 16, 0, 0, 0),
                    category = CategoryTypes.Internet,
                    Stars = 0,
                    Views = 0,

                    ImageId = 10,
                    UserEmail = "al@email.com"
                },
                new Article
                {
                    Id = 13,
                    Title = "איך לעשות רקע שקוף לתמונה?",
                    Content = "*",
                    Created = new DateTime(2021, 1, 1, 0, 0, 0),
                    category = CategoryTypes.Design,
                    Stars = 0,
                    Views = 0,

                    ImageId = 13,
                    UserEmail = "abed@email.com"
                },
                new Article
                {
                    Id = 14,
                    Title = "המדריך המלא ל-Gimp",
                    Content = "*",
                    Created = new DateTime(2021, 12, 6, 0, 0, 0),
                    category = CategoryTypes.Design,
                    Stars = 0,
                    Views = 0,

                    ImageId = 14,
                    UserEmail = "abed@email.com"
                },
                new Article
                {
                    Id = 15,
                    Title = "המדריך המלא ל-PhotoShop",
                    Content = "*",
                    Created = new DateTime(2021, 5, 26, 0, 0, 0),
                    category = CategoryTypes.Design,
                    Stars = 0,
                    Views = 0,

                    ImageId = 13,
                    UserEmail = "erik@email.com"
                },
                new Article
                {
                    Id = 16,
                    Title = "איך ליצור תמונות מונפשות?",
                    Content = "*",
                    Created = new DateTime(2020, 12, 20, 0, 0, 0),
                    category = CategoryTypes.Design,
                    Stars = 0,
                    Views = 0,

                    ImageId = 14,
                    UserEmail = "al@email.com"
                });
        }
    }
}
