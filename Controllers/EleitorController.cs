using Microsoft.AspNetCore.Mvc;
using miguelprovaapi.Repository;
using miguelprovaapi.Models;

namespace miguelprovaapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EleitorController : ControllerBase
    {
        private readonly IEleitorRepository _repository;

        public EleitorController(IEleitorRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Cadastrar(EleitorDados dados)
        {
            bool sucesso = _repository.CadastrarEleitor(dados);

            if(!sucesso)
                return BadRequest($"Eleitor com o CPF: {dados.cpf} ja cadastrado.");

            return Ok($"Eleitor cadastrado!");
        }
 
        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar(EleitorDados dados)
        {
            return Ok(_repository.ListarEleitor());
        }

        
    }
}
