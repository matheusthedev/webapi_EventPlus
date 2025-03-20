using Event_.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi_Event.Interfaces;

namespace webapi_Event.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TipoUsuarioController : ControllerBase
    {
        private readonly ITiposUsuariosRepository _tipoUsuarioRepository;
        public TipoUsuarioController(ITiposUsuariosRepository tipoUsuarioRepository)
        {
            _tipoUsuarioRepository = tipoUsuarioRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<TiposUsuarios> listaDeTiposUsuario = _tipoUsuarioRepository.Listar();

                return Ok(listaDeTiposUsuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        

        [HttpPost]
        public IActionResult Post(TiposUsuarios novoTipoUsuario)
        {
            try
            {
                _tipoUsuarioRepository.Cadastrar(novoTipoUsuario);

                return Created();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("BuscarPorId/{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                TiposUsuarios tipoBuscado = _tipoUsuarioRepository.BuscarPorId(id);

                return Ok(tipoBuscado);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _tipoUsuarioRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut("{id}")]

        public IActionResult Put(Guid id, TiposUsuarios tipoUsuario)
        {
            try
            {
                _tipoUsuarioRepository.Atualizar(id, tipoUsuario);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
