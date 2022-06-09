using ExoAPI.Interfaces;
using ExoAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExoAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _iUsuariorepository;

        public UsuarioController(IUsuarioRepository usuariorepository)
        {
            _iUsuariorepository = usuariorepository;
        }

        [HttpGet]  
        public IActionResult Listar()
        {
            try
            {
                return Ok(_iUsuariorepository.Listar());
            }
            catch (Exception)
            {

                throw new Exception("Usuários não podem ser listados");
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Usuario usuarioEncontrado = _iUsuariorepository.BuscarPorId(id);

                if (usuarioEncontrado == null)
                {
                    return NotFound();
                }
                return Ok(usuarioEncontrado);
            }
            catch (Exception)
            {

                throw new Exception("Usuário não foi encontrado");
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            try
            {
                _iUsuariorepository.Cadastrar(usuario);

                return StatusCode(201);
            }
            catch (Exception)
            {

                throw new Exception("Usuário não foi cadastrado");
            }
        }

        [HttpPut("{id}")]
        public IActionResult Alterar(int id, Usuario usuario)
        {
            try
            {
                _iUsuariorepository.Atualizar(id, usuario);

                return Ok();
            }
            catch (Exception)
            {

                throw new Exception("Usuário não foi atualizado");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _iUsuariorepository.Deletar(id);

                return Ok();
            }
            catch (Exception)
            {

                throw new Exception("Usuário não foi deletado");
            }
        }
    }
}