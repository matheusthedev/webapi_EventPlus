using Event_.Domains;

namespace webapi_Event.Interfaces
{
    public interface IEventoRepository
    {
        void Cadastrar(Evento novoEvento);

        List<Evento> Listar();

        void Deletar(Guid id);

        Evento BuscarPorId(Guid id);

        void Atualizar(Guid id, Evento evento); 

        List<Evento> ListarProximosEventos();

        List<Evento> ListarPorId(Guid id, Evento evento);

    }
}
