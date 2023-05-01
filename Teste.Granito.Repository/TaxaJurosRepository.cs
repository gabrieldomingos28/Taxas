using Teste.Granito.Domain;
using Teste.Granito.Domain.Interfaces;

namespace Teste.Granito.Repository
{
    public class TaxaJurosRepository : ITaxaJurosRepository
    {
        private readonly DataBaseContext _context;

        public TaxaJurosRepository(DataBaseContext context)
        {
            _context = context;
        }
        public void Criar(Taxa taxa)
        {
           _context.Taxas.Add(taxa);
           _context.SaveChanges();
        }

        public Taxa Get()
        {
            return _context
                   .Taxas
                   .FirstOrDefault(); 
        }
    }
}
