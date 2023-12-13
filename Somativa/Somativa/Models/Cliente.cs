using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Somativa.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        [DisplayName("Nome do Cliente")]
        [Required(ErrorMessage = "O Campo Nome Está Inválido!!!")]
        public string Nome { get; set; }
        [DisplayName("Endereço")]
        [Required(ErrorMessage = "O Endereço Nome Está Inválido!!!")]

        public string Endereco { get; set; }
        [Required(ErrorMessage = "O Campo Telefone Está Inválido!!!")]

        public string Telefone { get; set; }
        [DisplayName("CPF")]
        [Required(ErrorMessage = "O Campo CPF Está Inválido!!!")]

        public string Cpf { get; set; }
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "O Campo E-mail Está Inválido!!!")]

        public string Email { get; set; }
        [Required(ErrorMessage = "O Campo Nascimento Está Inválido!!!")]

        public DateTime Nascimento { get; set; }
        public IEnumerable<Venda>? Venda { get; set; }
    }
}
