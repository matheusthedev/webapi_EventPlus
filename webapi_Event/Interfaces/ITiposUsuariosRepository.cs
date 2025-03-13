using Event_.Domains;

namespace webapi_Event.Interfaces
{
    public interface ITiposUsuariosRepository
    {
        void Cadastrar(TiposUsuarios novoTipoUsuario);

        List<TiposUsuarios> Listar();

        void Deletar(Guid id);

        TiposUsuarios BuscarPorId(Guid id);

        void Atualizar(Guid id, TiposUsuarios tiposUsuarios);
    }
}
