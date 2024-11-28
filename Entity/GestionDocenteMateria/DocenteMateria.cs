using Entity.GestionMateria;
using Entity;

namespace ENTITY
{
    public class DocenteMateria
    {
        public string DocenteNumeroIdentificacion { get; set; }
        public int MateriaId { get; set; }

        public Docente Docente { get; set; }

        public Materia Materia { get; set; }
    }
}
