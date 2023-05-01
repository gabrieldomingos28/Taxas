namespace Teste.Granito.Calculo.API.Domain.Interfaces
{
    public interface ICalculoService
    {
        Task<double> CalcularJuros(double valorInicial, int meses);
    }
}
