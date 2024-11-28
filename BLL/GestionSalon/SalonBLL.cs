using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class SalonBLL
    {
        private readonly SalonDAL _salonDAL;

        public SalonBLL()
        {
            _salonDAL = new SalonDAL();
        }

        // Método para insertar un salón
        public async Task InsertarAsync(Salon salon)
        {
            if (string.IsNullOrEmpty(salon.NombreSalon))
            {
                throw new ArgumentException("El nombre del salón es obligatorio.");
            }

            if (salon.GradoId_FK <= 0)
            {
                throw new ArgumentException("El ID del grado es obligatorio.");
            }

            await _salonDAL.InsertarAsync(salon);
        }

        // Método para actualizar un salón
        public async Task ActualizarAsync(Salon salon)
        {
            if (salon.SalonId <= 0)
            {
                throw new ArgumentException("El ID del salón es obligatorio.");
            }

            if (string.IsNullOrEmpty(salon.NombreSalon))
            {
                throw new ArgumentException("El nombre del salón es obligatorio.");
            }

            if (salon.GradoId_FK <= 0)
            {
                throw new ArgumentException("El ID del grado es obligatorio.");
            }

            await _salonDAL.ActualizarAsync(salon);
        }

        // Método para obtener un salón por ID
        public async Task<Salon> TraerPorIDAsync(int salonId)
        {
            if (salonId <= 0)
            {
                throw new ArgumentException("El ID del salón es obligatorio.");
            }

            return await _salonDAL.TraerPorIDAsync(salonId);
        }

        // Método para obtener todos los salones
        public async Task<List<Salon>> TraerTodosAsync()
        {
            return await _salonDAL.TraerTodosAsync();
        }
    }
}
