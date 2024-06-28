using System.ComponentModel.DataAnnotations;

namespace ProjectProAuto.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage="Digite o CPF")]
        public string Login {  get; set; }
        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }
    }
}
