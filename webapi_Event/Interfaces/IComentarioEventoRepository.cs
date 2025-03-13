using Event_.Domains;
using EventPLUS.Domains;

namespace webapi_Event.Interfaces
{
    public interface IComentarioEventoRepository
    {
        void Cadastrar(Comentario novoComentario);

        List<Comentario> Listar();

        void Deletar(Guid id);

        Comentario BuscarPorIdUsuario(Guid idUsuario, Guid IdEvento);

    }
}
