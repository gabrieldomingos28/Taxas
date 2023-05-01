using Newtonsoft.Json;
using Teste.Granito.Calculo.API.Domain.DTO;
using Teste.Granito.Calculo.API.Domain.Interfaces;

namespace Teste.Granito.Calculo.API.Services
{
    public class CalculoService : ICalculoService
    {
        private readonly IConfiguration _configuration;

        public CalculoService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<double> CalcularJuros(double valorInicial, int meses)
        {
            double taxaJuros = await GetTaxaJuros();
            double valorFinal = 0; 
            double exponencialJuros = Math.Pow((1+taxaJuros), meses);

            valorFinal = valorInicial * exponencialJuros;
            return Math.Round(valorFinal, 2);
        }

        private async Task<double> GetTaxaJuros()
        {
            TaxaJurosDTO taxaJuros = new TaxaJurosDTO();
            HttpClient client = new HttpClient();
            string url = _configuration.GetSection("Taxas:URL").Value;
            string endPoint = _configuration.GetSection("Taxas:GetTaxaJuros").Value;

            HttpResponseMessage response = await client.GetAsync($"{url}{endPoint}");
                if (response.IsSuccessStatusCode)
                {
                     string responseJson = await response.Content.ReadAsStringAsync();
                     taxaJuros = JsonConvert.DeserializeObject<TaxaJurosDTO>(responseJson);
                }

                return taxaJuros.taxaJuros;
            
        }
    }
}
