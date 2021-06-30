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
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioEntity>
    {
        void IEntityTypeConfiguration<UsuarioEntity>.Configure(EntityTypeBuilder<UsuarioEntity> builder)
        {

            builder.ToTable("CIRC_SECU_USUA_USUARIOS", "CIRCUITOS");

            builder.HasKey(x => x.UID)
                    .HasName("PK_USUA");

            builder.Property(x => x.UID)
                .ValueGeneratedOnAdd()
                .HasColumnName("UID")
                .HasColumnType("VARCHAR")
                .HasMaxLength(32);

            builder.Property(x => x.Nombre)
                .HasColumnName("NOMBRE_USUA")
                .HasColumnType("VARCHAR")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.Apellido1)
                .HasColumnName("APELLIDO1_USUA")
                .HasColumnType("VARCHAR")
                .HasMaxLength(255);

            builder.Property(x => x.Apellido2)
                .HasColumnName("APELLIDO2_USUA")
                .HasColumnType("VARCHAR")
                .HasMaxLength(255);

            builder.Property(x => x.Login)
                   .HasColumnName("LOGIN_USUA")
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

            builder
                .HasMany(c => c.gruposUsuario)
                .WithOne(p => p.Usuario)
                .HasForeignKey("FK_USUA_RGRUS");

            builder.HasMany(c => c.passwords)
                .WithOne(p => p.Usuario)
                .HasForeignKey("FK_USPS_USUA");
        }
    
            
    }
}
