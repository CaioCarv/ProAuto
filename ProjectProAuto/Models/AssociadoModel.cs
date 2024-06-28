using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectProAuto.Models
{
    public class AssociadoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o CPF")]
        [MaxLength(11)]
        [Display(Name = "CPF")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter exatamente 11 dígitos numéricos.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Digite a Placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Digite o Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Digite o Telefone")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O telefone informado não é válido, digite somente os números")]
        [Phone(ErrorMessage = "O telefone informado não é válido.")]
        public string Telefone { get; set; }

        public bool SenhaValida(string senha)
        {
            return Placa == senha;
        }
    }
}
