namespace SpeedFormAcademias.Models;

public class Unidades
{
    public string Nome { get; set; }
    public string Localizacao { get; set; }
    public List<string> Imagem { get; set; }

    public Unidades()
    {
        Imagem = new List<string>();
    }
}
