using System;
using System.Data;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class EstudianteSalonBLL
    {
        // Método para insertar la relación estudiante-salón
        public  async Task InsertarEstudianteSalonAsync(string numeroIdentificacion, int salonId)
        {
            try
            {
                // Validación de entrada
                if (string.IsNullOrWhiteSpace(numeroIdentificacion) || salonId <= 0)
                {
                    throw new ArgumentException("Número de identificación y salón son obligatorios.");
                }

                // Llamar al método de la DAL para insertar la relación
                await EstudianteSalonDAL.InsertarAsync(numeroIdentificacion, salonId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar: {ex.Message}");
                throw;
            }
        }

        // Método para actualizar la relación entre estudiante y salón
        public  async Task ActualizarEstudianteSalonAsync(string numeroIdentificacion, int salonId, int nuevoSalonId)
        {
            try
            {
                // Validación de entrada
                if (string.IsNullOrWhiteSpace(numeroIdentificacion) || salonId <= 0 || nuevoSalonId <= 0)
                {
                    throw new ArgumentException("Los campos Número de Identificación, Salón y Nuevo Salón son obligatorios.");
                }

                // Llamar al método de la DAL para actualizar la relación
                await EstudianteSalonDAL.ActualizarAsync(numeroIdentificacion, salonId, nuevoSalonId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar: {ex.Message}");
                throw;
            }
        }

        // Método para obtener los estudiantes de un salón
        public  async Task<DataTable> TraerEstudiantesPorSalonAsync(int salonId)
        {
            try
            {
                // Validación de entrada
                if (salonId <= 0)
                {
                    throw new ArgumentException("El ID del salón es obligatorio.");
                }

                // Llamar al método de la DAL para traer los estudiantes
                return await EstudianteSalonDAL.TraerEstudiantesPorSalonAsync(salonId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener estudiantes: {ex.Message}");
                throw;
            }
        }
    }
}
