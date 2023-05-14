using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutApp.Data.Models;

namespace TutApp.Data.Configurations
{
    public class ImageConfig : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image
                {
                    Id = 1,
                    Title = "Programming1",
                    Location = @"https://yehonatan.moravia.co.il/tut/assets/Images/programming1.jpg"
                },
                new Image
                {
                    Id = 2,
                    Title = "Programming2",
                    Location = @"https://yehonatan.moravia.co.il/tut/assets/Images/programming2.jpg"
                },
                new Image
                {
                    Id = 3,
                    Title = "Programming3",
                    Location = @"https://yehonatan.moravia.co.il/tut/assets/Images/programming3.jpg"
                },
                new Image
                {
                    Id = 4,
                    Title = "Programming4",
                    Location = @"https://yehonatan.moravia.co.il/tut/assets/Images/programming4.jpg"
                },
                new Image
                {
                    Id = 5,
                    Title = "Iot1",
                    Location = @"https://yehonatan.moravia.co.il/tut/assets/Images/iot1.jpg"
                },
                new Image
                {
                    Id = 6,
                    Title = "Iot2",
                    Location = @"https://yehonatan.moravia.co.il/tut/assets/Images/iot2.jpg"
                },
                new Image
                {
                    Id = 9,
                    Title = "Internet1",
                    Location = @"https://yehonatan.moravia.co.il/tut/assets/Images/internet1.jpg"
                },
                new Image
                {
                    Id = 10,
                    Title = "Internet2",
                    Location = @"https://yehonatan.moravia.co.il/tut/assets/Images/internet2.jpg"
                },
                new Image
                {
                    Id = 11,
                    Title = "Internet3",
                    Location = @"https://yehonatan.moravia.co.il/tut/assets/Images/internet3.jpg"
                },
                new Image
                {
                    Id = 13,
                    Title = "Design1",
                    Location = @"https://yehonatan.moravia.co.il/tut/assets/Images/design1.jpg"
                },
                new Image
                {
                    Id = 14,
                    Title = "Design2",
                    Location = @"https://yehonatan.moravia.co.il/tut/assets/Images/design2.jpg"
                });
        }
    }
}
