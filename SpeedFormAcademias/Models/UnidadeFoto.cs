using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpeedFormAcademias.Models;

[Table("UnidadeFoto")]
public class UnidadeFoto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Unidade")]
    [Required(ErrorMessage = "Por favor, informe a Unidade")]
    public int UnidadeId { get; set; }
    [ForeignKey("UnidadeId")]
    public Unidade Unidade { get; set; }

    [Required(ErrorMessage = "Por favor, faça o upload da Foto")]
    [StringLength(300)]
    public string ArquivoFoto { get; set; }
    
    [Display(Name = "Foto Destaque?")]
    public bool Destaque { get; set; } = false;
}