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

    [Display(Name = "Descrição Parte 1")]
    [StringLength(1000, ErrorMessage = "A Descrição Parte 1 deve possuir no máximo 1000 caracteres")]
    public string DescricaoPT1 { get; set; }

    [Display(Name = "Descrição Parte 2")]
    [StringLength(1000, ErrorMessage = "A Descrição Parte 2 deve possuir no máximo 1000 caracteres")]
    public string DescricaoPT2 { get; set; }

    [Display(Name = "Descrição Parte 3")]
    [StringLength(1000, ErrorMessage = "A Descrição Parte 3 deve possuir no máximo 1000 caracteres")]
    public string DescricaoPT3 { get; set; }

    [StringLength(300)]
    public string Imagem { get; set; }

    [StringLength(300)]
    public string Imagem2 { get; set; }
}
