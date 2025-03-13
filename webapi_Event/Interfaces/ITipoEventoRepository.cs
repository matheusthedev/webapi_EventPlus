using Event_.Domains;

namespace webapi_Event.Interfaces
{
    public interface ITipoEventoRepository
    {
        void Cadastrar(TipoEvento novoTipoEvento);

        List<TipoEvento> Listar();

        void Deletar(Guid id);

        TipoEvento BuscarPorId(Guid id);

        void Atualizar(Guid id, TipoEvento tiposEvento);

       
    }
}
