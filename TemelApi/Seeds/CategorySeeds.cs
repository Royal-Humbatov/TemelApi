using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemelApi.Models;

namespace TemelApi.Seeds
{
    public class CategorySeeds : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(

                new Category
                {
                    Id = 1,
                    Name = "Car",
                    Description = "Beatiful Car",
                },

                 new Category
                 {
                     Id = 2,
                     Name = "Cup",
                     Description = "Perfect Cup",
                 }


                );
        }
    }
}
