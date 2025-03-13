using api_filmes_senai.Context;
using Event_.Domains;
using webapi_Event.Interfaces;

namespace webapi_Event.Repositories
{
    public class TiposEventoRepository : ITipoEventoRepository
    {
        private readonly EventoContext _context;
        public TiposEventoRepository(EventoContext context)
        {
            _context = context;
        }
        public void Atualizar(Guid id, TipoEvento tiposEvento)
        {
            try
            {
                TipoEvento tipoBuscado = _context.TipoEventos.Find(id)!;
                if (tipoBuscado != null) 
                {
                    tipoBuscado.TituloTipoEvento = tiposEvento.TituloTipoEvento;
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TipoEvento BuscarPorId(Guid id)
        {
            try
            {
                TipoEvento tipoBuscado = _context.TipoEventos.Find(id)!;

                return tipoBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(TipoEvento novoTipoEvento)
        {
            try
            {
                _context.TipoEventos.Add(novoTipoEvento);

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
                TipoEvento tipoBuscado = _context.TipoEventos.Find(id)!;

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

        public List<TipoEvento> Listar()
        {
            try
            {
                List<TipoEvento> listaDeTipos = _context.TipoEventos.ToList();

                return listaDeTipos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
