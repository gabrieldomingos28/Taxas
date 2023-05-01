namespace Teste.Granito.Domain.Interfaces.Services
{
    public interface ITaxaJurosService
    {
        void Criar(double taxaJuros);
        Taxa GetTaxa();
       
    }
}
