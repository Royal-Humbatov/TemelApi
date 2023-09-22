using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemelApi.Models;

namespace TemelApi.Seeds
{
    public class PersonSeeds : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(

                new Person
                {
                    Id = 1,
                    Name = "Royal",
                    Surname = "Humbetov",
                    Age = 21,
                    Description = "Hello World"
                },

                new Person
                {
                    Id = 2,
                    Name = "Xeyal",
                    Surname = "Humbetli",
                    Age = 18,
                    Description = "Salamlar"
                }
                );
        }
    }
}
