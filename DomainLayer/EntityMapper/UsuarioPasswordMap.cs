using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper
{
    public class UsuarioPasswordMap : IEntityTypeConfiguration<UsuarioPasswordEntity>
    {
        public void Configure(EntityTypeBuilder<UsuarioPasswordEntity> builder)
        {
            builder.ToTable("CIRC_SECU_USPS_USUARIOS_PASSWORD", "CIRCUITOS");

            builder.HasKey(x => x.UID)
                   .HasName("PK_USPS");

            builder.Property(x => x.UID)
                    .HasColumnName("UID_USPS")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(32);

            builder.Property(x => x.Password)
                    .HasColumnName("PASSWORD_USPS")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(255);

            builder.Property(x => x.EntryDate)
               .HasColumnName("INSERTADO")
               .HasColumnType("DATETIME");

            builder.Property(x => x.UpdateDate)
                .HasColumnName("ACTUALIZADO")
                .HasColumnType("DATETIME");

            builder.Property(x => x.DeleteDate)
                .HasColumnName("BORRADO")
                .HasColumnType("DATETIME");

            builder.HasOne(x => x.Usuario)
                    .WithMany(p => p.passwords)
                    .HasForeignKey("FK_USPS_USUA");
        }
    }
}
