using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Granito.Domain.Interfaces
{
    public interface ITaxaJurosRepository
    {
        void Criar(Taxa taxa);
        Taxa Get();
    }
}
