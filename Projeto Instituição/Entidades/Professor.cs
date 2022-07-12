using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoInstituição.Entidades
{
    public class Professor
    {
        [Key]
        public int? Id { get; set; }

        public string Nome { get; set; }

        public string Materias { get; set; }

        public int instId { get; set; }

        public Instituicao instituicao { get; set; }    
    }
}
 