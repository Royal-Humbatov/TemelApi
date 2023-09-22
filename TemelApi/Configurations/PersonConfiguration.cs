using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemelApi.Models;

namespace TemelApi.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder) 
        {
            builder.HasKey(x => x.Id);  
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Age).IsRequired();  
            builder.Property(x => x.Description).HasMaxLength(50).IsRequired(); 
            builder.Property(x => x.Surname).HasMaxLength(50).IsRequired(); 
        }

    }
}
