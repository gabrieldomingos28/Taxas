using Microsoft.AspNetCore.Mvc;
using Teste.Granito.Domain.Interfaces.Services;

namespace Teste.Granito.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TaxasJurosController : ControllerBase
{
    [HttpGet(Name = "GetTaxasJuros")]
    public IActionResult GetTaxasJuros([FromServices]ITaxaJurosService taxaJurosService)
    {
        var taxa = taxaJurosService.GetTaxa();
        
        return Ok(new {
            taxaJuros = taxa.TaxaJuros
        });
    }
}