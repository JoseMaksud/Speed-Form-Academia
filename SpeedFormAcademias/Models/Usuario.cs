using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace SpeedFormAcademias.Models;

[Table("Usuario")]
public class Usuario
{
    [Key]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public IdentityUser ContaUsuario { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }
}
