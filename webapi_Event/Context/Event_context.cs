using System.Collections.Generic;
using Event_.Domains;
using EventPLUS.Domains;
using Microsoft.EntityFrameworkCore;



namespace api_filmes_senai.Context
{
    public class EventoContext : DbContext
    {
        public EventoContext()
        {

        }

        public EventoContext(DbContextOptions<EventoContext> options) : base(options)
        {
        }

        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Instituicoes> Instituicao { get; set; }
        public DbSet<PresencaEventos> PresencaEvento { get; set; }
        public DbSet<TipoEvento> TipoEventos { get; set; }
        public DbSet<TiposUsuarios> TiposUsuario { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE36-S28\\SQLEXPRESS; Database=EventPlus; User Id=sa; Pwd=Senai@134; TrustServerCertificate=true;");
            }
        }
    }
}
