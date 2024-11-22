using SpeedFormAcademias.Models;
using System.Collections.Generic;

namespace SpeedFormAcademias.ViewModels
{
    public class DetailsUnidadeViewModel
    {
        public string Nome { get; set; }
        public List<UnidadeFoto> Fotos { get; set; }
        public string LocalizacaoFoto { get; set; }
    }
}
