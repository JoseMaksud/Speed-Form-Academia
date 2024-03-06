namespace SpeedFormAcademias.Models;

public class Unidade
{
    public string Nome { get; set; }
    public string Localizacao { get; set; }
    public List<string> Imagem { get; set; }

    public Unidade()
    {
        Imagem = new List<string>();
    }
}
