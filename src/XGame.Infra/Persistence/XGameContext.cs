using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using XGame.Domain.Entities;
using XGame.Infra.Persistence.Map;

namespace XGame.Infra.Persistence
{
    public class XGameContext: DbContext
    {
        public IDbSet<Jogador> Jogadores { get; set; }
        public IDbSet<Jogo> Jogos { get; set; }
        public IDbSet<Plataforma> Plataformas { get; set; }
        public XGameContext(): base("XGameConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Seta o schema default
            // modelBuilder.HasDefaultSchema("Apoio");

            //remove pluralização
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //remove esclusão em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //setar usar varchar so inves de nVarchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            //caso eu esqueça de informar o tamanho do campo, ira colocar varchar 100
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            //mapeia as entidades
            //modelBuilder.Configurations.Add(new MapJogador());
            //modelBuilder.Configurations.Add(new PlataformaMap());
            //modelBuilder.Configurations.Add(new JogoMap());

            //adiciona entidades mapeadas automatico via assembly
            modelBuilder.Configurations.AddFromAssembly(typeof(XGameContext).Assembly);

            //Adiciona entidades mapeadas via namespace
            //Assembly.GetExcecutingAssembly().GetType()
            //    .Where(typeof => typeof.Namespace == "XGame.Domain.Entities")
            //    .ToList()
            //    .ForEach(typeof =>
            //    {
            //        dynamic instance = Activator.CreateInstance(type);
            //        modelBuilder.Configurations.Add(instance);
            //    });

            base.OnModelCreating(modelBuilder);
        }
    }
}
