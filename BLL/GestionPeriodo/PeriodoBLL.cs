using System;
using System.Threading.Tasks;
using ENTITY;
using DAL;
using Entity.GestionPeriodo;
using System.Data;

namespace BLL
{
    public class PeriodoBLL
    {
        private readonly PeriodoDAL _periodoDAL;

        public PeriodoBLL()
        {
            _periodoDAL = new PeriodoDAL();
        }

        // Llamada para insertar un periodo
        public async Task InsertarPeriodoAsync(Periodo periodo)
        {
            if (periodo == null)
            {
                throw new ArgumentNullException(nameof(periodo), "El objeto Periodo no puede ser nulo.");
            }

            if (periodo.IdPeriodo <= 0)
            {
                throw new ArgumentException("El ID del periodo debe ser mayor que cero.");
            }

            // Aquí podrías agregar más validaciones de negocio, si las hay.

            await _periodoDAL.InsertarPeriodoAsync(periodo);
        }

        // Llamada para actualizar un periodo
        public async Task ActualizarPeriodoAsync(Periodo periodo)
        {
            if (periodo == null)
            {
                throw new ArgumentNullException(nameof(periodo), "El objeto Periodo no puede ser nulo.");
            }

            if (periodo.IdPeriodo <= 0)
            {
                throw new ArgumentException("El ID del periodo debe ser mayor que cero.");
            }

            // Aquí podrías agregar más validaciones de negocio, si las hay.

            await _periodoDAL.ActualizarPeriodoAsync(periodo);
        }

        // Llamada para obtener todos los periodos
        public async Task<DataTable> TraerTodosPeriodosAsync()
        {
            return await _periodoDAL.TraerTodosPeriodosAsync();
        }

        // Llamada para obtener un periodo por ID
        public async Task<Periodo> TraerPeriodoPorIdAsync(int idPeriodo)
        {
            if (idPeriodo <= 0)
            {
                throw new ArgumentException("El ID del periodo debe ser mayor que cero.");
            }

            return await _periodoDAL.TraerPeriodoPorIdAsync(idPeriodo);
        }
    }
}
