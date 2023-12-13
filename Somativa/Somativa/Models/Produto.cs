using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Somativa.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        [Required(ErrorMessage = "O Campo Nome Está Inválido!!!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo Estoque Está Inválido!!!")]
        public int Estoque { get; set; }
        [DisplayName("Preço")]
        [Required(ErrorMessage = "O Campo Preço Está Inválido!!!")]
        public decimal Preco {  get; set; }
        [DisplayName("Categoria")]
        [Required(ErrorMessage = "O Campo Categoria Está Inválido!!!")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set;}
        [DisplayName("Fornecedor")]
        [Required(ErrorMessage = "O Campo Fornecedor Está Inválido!!!")]
        public Guid FornecedorId { get; set; } 
        public Fornecedor? Fornecedor { get; set; }
    }
}
