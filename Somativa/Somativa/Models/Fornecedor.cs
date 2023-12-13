using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Somativa.Models
{
    public class Fornecedor
    {        
        public Guid FornecedorId { get; set; }
        [Required(ErrorMessage = "O Campo Nome Está Inválido!!!")]

        public string Nome { get; set; }
        [DisplayName("CNPJ")]
        [Required(ErrorMessage = "O Campo CNPJ Está Inválido!!!")]

        public string Cnpj { get; set; }
        public IEnumerable<Produto>? Produtos { get; set; }
    }
}
