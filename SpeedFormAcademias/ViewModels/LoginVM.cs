using System.ComponentModel.DataAnnotations;

namespace SpeedFormAcademias.ViewModels;

public class LoginVM
{
    [Display(Name = "Email ou nome de Usuário")]
    [Required(ErrorMessage = "Por favor, informe seu email ou nome de usuário")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua Senha de Acesso")]
    public string Senha { get; set; }

    [Display(Name = "Manter Conectado?")]
    public bool Lembrar { get; set; } = false;
    public string UrlRetorno { get; set; }
}