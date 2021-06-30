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
    public class GrupoUsuarioMap : IEntityTypeConfiguration<GrupoUsuariosEntity>
    {
        public void Configure(EntityTypeBuilder<GrupoUsuariosEntity> builder)
        {

            builder.ToTable("CIRC_SECU_GRUS_GRUPO_USUARIOS", "CIRCUITOS");

            builder.HasKey(x => x.UID).HasName("PK_GRUS");

            builder.Property(x => x.UID)
                   .HasColumnName("UID_GRUS")
                   .HasColumnType("VARCHAR(32)")
                   .IsRequired();

            builder.Property(x => x.Nombre)
                    .HasColumnName("NOMBRE_GRUS")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(255);

            builder.Property(x => x.Descripcion)
                    .HasColumnName("DESCRIPCION_GRUS")
                    .HasColumnType("TEXT");

            builder.Property(x => x.EntryDate)
                .HasColumnName("INSERTADO")
                .HasColumnType("DATETIME");

            builder.Property(x => x.UpdateDate)
                .HasColumnName("ACTUALIZADO")
                .HasColumnType("DATETIME");

            builder.Property(x => x.DeleteDate)
                .HasColumnName("BORRADO")
                .HasColumnType("DATETIME");

            builder.HasMany(x => x.usuariosGrupo)
                    .WithOne(p => p.Grupo)
                    .HasForeignKey("FK_GRUS_RGRUS");
        }
    }
}
