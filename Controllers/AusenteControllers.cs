using Microsoft.AspNetCore.Mvc;
using miguelprovaapi.Repository;
using miguelprovaapi.Models;

namespace miguelprovaapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AusenteController : ControllerBase
    {
        private readonly IAusenteRepository _repository;

        public AusenteController(IAusenteRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("Registrar")]
        public IActionResult RegistrarAusente(Ausente dadosAusente)
        {
            bool sucesso = _repository.RegistrarAusente(dadosAusente);

            if(!sucesso)
                return BadRequest($"Eleitor Ausente com o cpf {dadosAusente.cpf} ja registrado.");

            return Ok($"Eleitor Ausente registrado!");
        }

        [HttpGet]
        [Route("ListarAusentes")]
        public IActionResult ListarAusente(Ausente dados)
        {
            return Ok(_repository.ListarAusente());  
        }

        
    }
}
