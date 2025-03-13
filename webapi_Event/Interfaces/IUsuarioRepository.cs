using Event_.Domains;

namespace webapi_Event.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuarios novoUsuario);

        Usuarios BuscarPorId(Guid id);

        Usuarios BuscarPorEmailESenha(string email, string senha);
    }
}
