using Microsoft.AspNetCore.Mvc;
using PROVA_H1.Repository;
using PROVA_H1.Models;
using PROVA_H1.Validation;

namespace PROVA_H1.Controllers
{
    [ApiController]
    [Route("API/ConvidadoController")]
    public class ConvidadoController : ControllerBase
    {


        private readonly IConvidadoRepository _convidadoRepository;
        public ConvidadoController(IConvidadoRepository convidadoRepository)
        {
            _convidadoRepository = convidadoRepository;
        }


        [HttpPost]
        [Route("ReceberDados")]
        public IActionResult ReceberDados(Convidado convidado)
        {
            _convidadoRepository.InserirDados(new Convidado()
            {
                Nome = convidado.Nome,
                Idade = convidado.Idade,
                Carne = convidado.Carne,
                Bebida = convidado.Bebida
            }
             );
            return Ok($"{convidado.Nome}, Você está convidado para o churras!");
        }


        [HttpGet]
        [Route("ObterConvidado")]
        public IActionResult ObterConvidado()
        {
            return Ok(_convidadoRepository.GetDados());
        }
    }
}
