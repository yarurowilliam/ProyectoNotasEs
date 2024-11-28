using System.Collections.Generic;
using System.Threading.Tasks;
using DAL;
using DAL.GestionDocente;
using Entity;
using Entity.GestionAcudiente;


namespace BLL
{
    public class AcudienteBLL
    {
        private readonly AcudienteDAL _acudienteDAL;

        public AcudienteBLL()
        {
            _acudienteDAL = new AcudienteDAL();
        }

        public async Task<bool> InsertarAcudienteAsync(Acudiente acudiente)
        {
            return await _acudienteDAL.InsertarAcudienteAsync(acudiente);
        }

        public async Task<bool> ModificarDocenteAsync(Acudiente acudiente)
        {
            try
            {
                return await _acudienteDAL.ModificarAcudienteAsync(acudiente);
            }
            
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al modificar el acudiente.", ex);
            }
        }

        public async Task<Acudiente> TraerAcudientePorIDAsync(int idAcudiente)
        {
            return await _acudienteDAL.TraerAcudientePorIDAsync(idAcudiente);
        }

        public async Task<Acudiente> TraerPorIDAsync(int filtroNumeroIdentificacion)
        {
            try
            {
                var acudiente = await _acudienteDAL.TraerAcudientePorIDAsync(filtroNumeroIdentificacion);
                if (acudiente == null)
                {
                    throw new ApplicationException($"No se encontró un acudiente con el número de identificación: {filtroNumeroIdentificacion}");
                }

                return acudiente;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al consultar el acudiente.", ex);
            }
        }

        public async Task<List<Acudiente>> TraerTodosAcudientesAsync()
        {
            return await _acudienteDAL.TraerTodosAcudientesAsync();
        }

        public async Task<List<Acudiente>> TraerTodosAsync()
        {
            try
            {
                var docentes = await _acudienteDAL.TraerTodosAcudientesAsync();
                if (docentes == null || docentes.Count == 0)
                {
                    throw new ApplicationException("No se encontraron acudientes registrados.");
                }

                return docentes;
            }
            catch (DocenteException ex)
            {
                throw new ApplicationException($"Error al consultar los acudientes: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrió un error inesperado al consultar los acudientes.", ex);
            }
        }
    }
}
