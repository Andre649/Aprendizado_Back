using Microsoft.AspNetCore.Mvc;
using MisterChurras.Calculator;

namespace MisterChurras.API.Controllers
{
    [ApiController]
    [Route("api/churrasco")]
    public class ChurrascoController : ControllerBase
    {
        private readonly CalculadoraService _servico;

        public ChurrascoController()
        {
            _servico = new CalculadoraService();
        }

        [HttpGet("calcular")]
        public ActionResult<ResultadoChurrasco> Calcular(
            [FromQuery] int adultos, 
            [FromQuery] int criancas)
        {
            if (adultos < 0 || criancas < 0)
            {
                return BadRequest("Apenas números positivos!");
            }

            ResultadoChurrasco resultado = _servico.Calcular(adultos, criancas);
            return Ok(resultado);
        }
    }
}