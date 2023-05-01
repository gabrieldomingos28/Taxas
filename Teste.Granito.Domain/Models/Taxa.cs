using System.ComponentModel.DataAnnotations;

namespace Teste.Granito.Domain
{
    public class Taxa
    {
        [Key]
        public int Id { get; set; }
        public double TaxaJuros { get; set; }
    }
}