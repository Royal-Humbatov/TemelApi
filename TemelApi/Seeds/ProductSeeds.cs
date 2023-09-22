using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemelApi.Models;

namespace TemelApi.Seeds
{
    public class ProductSeeds : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(

                new Product
                {
                    Id = 1,
                    ProductName = "Test",
                    ProductDescription = "humbatov",
                },

                new Product
                {
                    Id = 2,
                    ProductName = "AJHCBSIUDV",
                    ProductDescription = "EOFVJE9IO",
                }

                );
        }
    }
}
