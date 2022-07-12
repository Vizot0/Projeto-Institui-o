using ProjetoInstituição.Entidades;
using System.Collections.Generic;

namespace ProjetoInstituição.Models
  
{
    public class InstituicaoModel : Instituicao
    {
        public List<Instituicao> ListaInstituicao { get; set; }
    }
}
