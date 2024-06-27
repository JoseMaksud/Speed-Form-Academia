using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpeedFormAcademias.Models;

[Table("Modalidade")]
public class Modalidade
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(100, ErrorMessage = "O nome deve possuir no máximo 100 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição Resumida")]
    [StringLength(1000, ErrorMessage = "A Descrição Resumida deve possuir no máximo 1000 caracteres")]
    public string Descricao { get; set; }

    [StringLength(300)]
    public string Imagem { get; set; }
}
