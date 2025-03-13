using Event_.Domains;

namespace webapi_Event.Interfaces
{
    public interface IPresencaEventoRepository
    {
        void PresencaEventos(PresencaEventos novoPresencaEvento);

        List<PresencaEventos> Listar();

        void Deletar(Guid id);

        void Atualizar(PresencaEventos presencaEvento);
    }
}
