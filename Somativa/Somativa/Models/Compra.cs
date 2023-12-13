using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Somativa.Models
{
    public class Compra
    {
        public Guid CompraId { get; set; }
        [DisplayName("Nota Fiscal")]
        [Required(ErrorMessage = "O Campo Nota Está Inválido!!!")]
        public int Nota { get; set; }
        [DisplayName("Data e hora")]
        [Required(ErrorMessage = "O Campo Data e Hora Está Inválido!!!")]

        public DateTime DataHora { get; set; }
        public IEnumerable<CompraItem>? CompraItems { get; set; }
    }
}
