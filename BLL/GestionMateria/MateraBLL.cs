using DAL;
using Entity.GestionMateria;

namespace BLL
{
    public class MateriaBLL
    {
        private readonly MateriaDAL _materiaDAL;

        public MateriaBLL()
        {
            _materiaDAL = new MateriaDAL();
        }

        public async Task<bool> InsertarMateriaAsync(Materia materia)
        {
            if (string.IsNullOrWhiteSpace(materia.NombreMateria))
            {
                Console.WriteLine("El nombre de la materia es obligatorio.");
                return false;
            }

            return await _materiaDAL.InsertarMateriaAsync(materia);
        }

        public async Task<bool> ActualizarMateriaAsync(Materia materia)
        {
            if (materia.MateriaId <= 0)
            {
                Console.WriteLine("El ID de la materia es obligatorio.");
                return false;
            }

            return await _materiaDAL.ActualizarMateriaAsync(materia);
        }

        public async Task<Materia> TraerMateriaPorIdAsync(int materiaId)
        {
            if (materiaId <= 0)
            {
                Console.WriteLine("El ID de la materia no es válido.");
                return null;
            }

            return await _materiaDAL.TraerMateriaPorIdAsync(materiaId);
        }

        public async Task<List<Materia>> TraerTodasLasMateriasAsync()
        {
            return await _materiaDAL.TraerTodasLasMateriasAsync();
        }

        public async Task<List<Materia>> TraerMateriasPorSalonAsync(int salonId)
        {
            if (salonId <= 0)
            {
                Console.WriteLine("El ID del salón no es válido.");
                return null;
            }

            return await _materiaDAL.TraerMateriasPorSalonAsync(salonId);
        }
    }
}
