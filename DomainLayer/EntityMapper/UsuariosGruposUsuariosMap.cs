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
    public class UsuariosGruposUsuariosMap : IEntityTypeConfiguration<UsuarioGrupoUsuarioEntity>
    {
        void IEntityTypeConfiguration<UsuarioGrupoUsuarioEntity>.Configure(EntityTypeBuilder<UsuarioGrupoUsuarioEntity> builder)
        {

            builder.ToTable("CIRC_SECU_RGRUS_GRUS_USUA", "CIRCUITOS");

            builder.HasKey(x => new { x.UidUsuario, x.UidGrupoUsuario })
                    .HasName("PK_GRUS");

            builder.Property(x => x.UidUsuario)
                .HasColumnName("UID_USUA")
                .HasColumnType("VARCHAR(32)")
                .IsRequired();

            builder.Property(x => x.UidGrupoUsuario)
                .HasColumnName("UID_GRUS")
                .HasColumnType("VARCHAR(32)")
                .IsRequired();

            builder.HasOne(x => x.Usuario)
                .WithMany(p => p.gruposUsuario)
                .HasForeignKey("FK_USUA_RGRUS");

            builder.HasOne(x => x.Grupo)
                   .WithMany(p => p.usuariosGrupo)
                   .HasForeignKey("FK_GRUS_RGRUS");

        }
    }
}
