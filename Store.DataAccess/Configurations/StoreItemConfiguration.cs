using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.DataAccess.Entites;
using Store.Domain.Models;

namespace Store.DataAccess.Configurations
{
    internal class StoreItemConfiguration : IEntityTypeConfiguration<StoreItemEntity>
    {
        public void Configure(EntityTypeBuilder<StoreItemEntity> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(Item.NAME_MAX_LENGHT);

            builder.Property(i => i.Discription)
                .IsRequired()
                .HasMaxLength(Item.DESCRIPTION_MAX_LENGHT);

            builder.Property(i => i.Price)
                .IsRequired();
        }
    }
}
