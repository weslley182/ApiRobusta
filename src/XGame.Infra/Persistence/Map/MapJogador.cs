using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using XGame.Domain.Entities;

namespace XGame.Infra.Persistence.Map
{
    public class MapJogador: EntityTypeConfiguration<Jogador>
    {
        public MapJogador()
        {
            ToTable("Jogador");

            Property(p => p.Email.Endereco)
                .HasMaxLength(200)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UK_JOGADOR_EMAIL") { IsUnique = true })).HasColumnName("Email");

            Property(j => j.Nome.PrimeiroNome)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("PrimeiroNome");

            Property(j => j.Nome.UltimoNome)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("UltimoNome");

            Property(j => j.Senha).IsRequired();
            Property(j => j.Status).IsRequired();
        }
    }
}
