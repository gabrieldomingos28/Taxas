using Microsoft.AspNetCore.Mvc;
using Teste.Granito.Calculo.API.Domain.Interfaces;

namespace Teste.Granito.Calculo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        [HttpPost]
        public async Task<double> CalcularJuros([FromServices]ICalculoService calculoService, double valorInicial, int meses)
        {
            double jurosCompostos = await calculoService.CalcularJuros(valorInicial, meses);

            return jurosCompostos;
        }
    }
}
