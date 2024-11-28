using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.GestionNotas
{
    public class Notas
    {
        public int NotaId { get; set; }
        public decimal Nota { get; set; }
        public int MateriaId { get; set; }
        public int PeriodoId { get; set; }
        public string NumeroIdentificacion { get; set; }
    }
}
