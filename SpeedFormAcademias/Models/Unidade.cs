using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpeedFormAcademias.Models;

[Table("Unidade")]
public class Unidade
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(100, ErrorMessage = "O nome deve possuir no máximo 100 caracteres")]
    public string Nome { get; set; }

    [StringLength(500)]
    public string Localizacao { get; set; }

    [StringLength(500)]
    public string LocalizacaoFoto { get; set; }

    public ICollection<UnidadeFoto> Fotos { get; set; }
}
