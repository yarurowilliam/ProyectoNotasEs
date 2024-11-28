using DAL;
using System;
using System.Data;
using System.Threading.Tasks;

namespace BLL
{
    public class DocenteMateriaBLL
    {
        private readonly DocenteMateriaDAL _docenteMateriaDAL;

        public DocenteMateriaBLL(string connectionString)
        {
            _docenteMateriaDAL = new DocenteMateriaDAL(connectionString);
        }

        public async Task InsertarAsync(string docenteNumeroIdentificacion, int materiaId)
        {
            await _docenteMateriaDAL.InsertarAsync(docenteNumeroIdentificacion, materiaId);
        }

        public async Task ActualizarAsync(string docenteNumeroIdentificacion, int materiaId, int nuevoMateriaId)
        {
            await _docenteMateriaDAL.ActualizarAsync(docenteNumeroIdentificacion, materiaId, nuevoMateriaId);
        }

        public async Task<DataTable> TraerMateriasPorDocenteAsync(string docenteNumeroIdentificacion)
        {
            return await _docenteMateriaDAL.TraerMateriasPorDocenteAsync(docenteNumeroIdentificacion);
        }

        public async Task<DataTable> TraerDocentesPorMateriaAsync(int materiaId)
        {
            return await _docenteMateriaDAL.TraerDocentesPorMateriaAsync(materiaId);
        }

        public async Task<DataTable> ConsultarAsync()
        {
            return await _docenteMateriaDAL.ConsultarAsync();
        }
    }
}
