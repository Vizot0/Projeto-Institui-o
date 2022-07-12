using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoInstituição.Entidades
{
    public class Instituicao
    {
        [Key]
        public int instId { get; set; }

        public string Nome { get; set; }

        public string Cidade { get; set; }
    }
}
