using api_filmes_senai.Context;
using Event_.Domains;
using Microsoft.EntityFrameworkCore;
using webapi_Event.Interfaces;

namespace webapi_Event.Repositories
{
    public class TiposUsuariosRepositoty : ITiposUsuariosRepository
    {
        private readonly EventoContext _context;
        public TiposUsuariosRepositoty(EventoContext context)
        {
            _context = context;
        }
        public void Atualizar(Guid id, TiposUsuarios tiposUsuarios)
        {
            try
            {
                TipoEvento tipoBuscado = _context.TipoEventos.Find(id)!;
                if (tipoBuscado != null)
                {
                    tipoBuscado.TituloTipoEvento = tiposUsuarios.TituloTipoUsuario;
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TiposUsuarios BuscarPorId(Guid id)
        {
            try
            {
                TiposUsuarios tipoBuscado = _context.TiposUsuario.Find(id)!;

                return tipoBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(TiposUsuarios novoTipoUsuario)
        {
            try
            {
                _context.TiposUsuario.Add(novoTipoUsuario);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                TiposUsuarios tipoBuscado = _context.TiposUsuario.Find(id)!;

                if (tipoBuscado != null)
                {
                    _context.Remove(tipoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TiposUsuarios> Listar()
        {
            try
            {
                List<TiposUsuarios> listaDeTipos = _context.TiposUsuario.ToList();

                return listaDeTipos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
