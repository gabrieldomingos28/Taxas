using Teste.Granito.Domain;
using Teste.Granito.Domain.Interfaces;
using Teste.Granito.Domain.Interfaces.Services;

namespace Teste.Granito.Services
{
    public class TaxaJurosServices : ITaxaJurosService
    {
        private readonly ITaxaJurosRepository _taxaJurosRepository;
        public TaxaJurosServices(ITaxaJurosRepository taxaJurosRepository)
        {
            _taxaJurosRepository = taxaJurosRepository;
        }
        public void Criar(double taxaJuros)
        {
            _taxaJurosRepository.Criar(new Taxa() { TaxaJuros = taxaJuros });
        }

        public Taxa GetTaxa() => _taxaJurosRepository.Get();

     
    }
}