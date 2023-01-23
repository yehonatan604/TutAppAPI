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
                    Location = "/assets/Images/programming1.png"
                },
                new Image
                {
                    Id = 2,
                    Title = "Programming2",
                    Location = "/assets/Images/programming2.png"
                },
                new Image
                {
                    Id = 3,
                    Title = "Programming3",
                    Location = "/assets/Images/programming3.png"
                },
                new Image
                {
                    Id = 4,
                    Title = "Programming4",
                    Location = "/assets/Images/programming4.png"
                },
                new Image
                {
                    Id = 5,
                    Title = "Iot1",
                    Location = "/assets/Images/iot1.png"
                },
                new Image
                {
                    Id = 6,
                    Title = "Iot2",
                    Location = "/assets/Images/iot2.png"
                },
                new Image
                {
                    Id = 9,
                    Title = "Internet1",
                    Location = "/assets/Images/internet1.png"
                },
                new Image
                {
                    Id = 10,
                    Title = "Internet2",
                    Location = "/assets/Images/internet2.png"
                },
                new Image
                {
                    Id = 11,
                    Title = "Internet3",
                    Location = "/assets/Images/internet3.png"
                },
                new Image
                {
                    Id = 13,
                    Title = "Design1",
                    Location = "/assets/Images/design1.png"
                },
                new Image
                {
                    Id = 14,
                    Title = "Design2",
                    Location = "/assets/Images/design2.png"
                });
        }
    }
}
