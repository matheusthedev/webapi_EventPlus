using api_filmes_senai.Context;
using Event_.Domains;
using Microsoft.EntityFrameworkCore;
using webapi_Event.Interfaces;
using webapi_Event.Utils;

namespace webapi_Event.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EventoContext _context;
        public UsuarioRepository(EventoContext context)
        {
            _context = context;
        }
        public Usuarios BuscarPorEmailESenha(string email, string senha)
        {
            try
            {
                Usuarios usuarioBuscado = _context.Usuario.FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Usuarios BuscarPorId(Guid id)
        {
            try
            {
                Usuarios tipoBuscado = _context.Usuario.Find(id)!;

                return tipoBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuarios novoUsuario)
        {
            try
            {
                _context.Usuario.Add(novoUsuario);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
