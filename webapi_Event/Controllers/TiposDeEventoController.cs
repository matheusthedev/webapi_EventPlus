using Event_.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi_Event.Interfaces;

namespace webapi_Event.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposDeEventoController : ControllerBase
    {
        private readonly ITipoEventoRepository _tipoDeEventoRepository;
        public TiposDeEventoController(ITipoEventoRepository tipoEventoRepository)
        {
            _tipoDeEventoRepository = tipoEventoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_tipoDeEventoRepository.Listar());

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(TipoEvento novoTipo) 
        {
            try
            {
                _tipoDeEventoRepository.Cadastrar(novoTipo);

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
                TipoEvento tipoBuscado = _tipoDeEventoRepository.BuscarPorId(id);

                return Ok(tipoBuscado);
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
