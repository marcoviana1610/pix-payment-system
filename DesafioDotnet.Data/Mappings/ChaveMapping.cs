using DesafioDotnet.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioDotnet.Data.Mappings
{
    public class ChaveMapping : IEntityTypeConfiguration<ChaveModel>
    {
        public void Configure(EntityTypeBuilder<ChaveModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(t => t.Descricao)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.ToTable("Chaves");
        }
    }
}
