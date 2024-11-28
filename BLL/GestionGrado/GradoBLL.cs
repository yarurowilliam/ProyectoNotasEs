using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class GradoBLL
    {
        private readonly GradoDAL gradoDAL;

        public GradoBLL()
        {
            gradoDAL = new GradoDAL();
        }

        public async Task InsertarAsync(string nombreGrado)
        {
            if (string.IsNullOrEmpty(nombreGrado))
            {
                throw new ArgumentException("El nombre del grado es obligatorio.");
            }

            await gradoDAL.InsertarAsync(nombreGrado);
        }

        public async Task ActualizarAsync(int gradoId, string nombreGrado)
        {
            if (gradoId <= 0)
            {
                throw new ArgumentException("ID de grado inválido.");
            }

            if (string.IsNullOrEmpty(nombreGrado))
            {
                throw new ArgumentException("El nombre del grado es obligatorio.");
            }

            await gradoDAL.ActualizarAsync(gradoId, nombreGrado);
        }

        public async Task<List<(int GradoId, string NombreGrado)>> TraerTodosAsync()
        {
            return await gradoDAL.TraerTodosAsync();
        }

        public async Task<(int GradoId, string NombreGrado)> TraerPorIdAsync(int gradoId)
        {
            return await gradoDAL.TraerPorIdAsync(gradoId);
        }
    }
}
