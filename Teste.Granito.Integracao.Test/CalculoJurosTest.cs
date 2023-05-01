using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Teste.Granito.Integracao.Test
{
    public class Tests
    {
        [Test]
        public async Task Calcular_Juros_Compostos()
        {
            await using var application = new ApiApplication();

            int meses = 5;
            double valorInicial = 100;

            var url = $"/api/CalculaJuros?valorInicial={valorInicial}&meses={meses}";

            var client = application.CreateClient();

            var result = await client.PostAsync(url,null);
            var valorFinal = JsonConvert.DeserializeObject<double>(result.Content.ReadAsStringAsync().Result);

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.IsNotNull(valorFinal);
            Assert.IsTrue(valorFinal == 105.10);
        }
    }
}