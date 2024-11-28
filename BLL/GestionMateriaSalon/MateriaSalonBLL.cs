using System;
using System.Threading.Tasks;
using DAL;
using Entity;
using ENTITY;

namespace BLL
{
    public class MateriaSalonBLL
    {
        // Método para insertar una relación materia-salón
        public static async Task InsertarMateriaSalonAsync(MateriaSalon materiaSalon)
        {
            try
            {
                // Validación básica de los parámetros
                if (materiaSalon.MateriaId <= 0 || materiaSalon.SalonId <= 0)
                {
                    throw new ArgumentException("El ID de la materia y el salón deben ser mayores a cero.");
                }

                // Llamar a la DAL para insertar la relación
                await MateriaSalonDAL.InsertarAsync(materiaSalon);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la inserción: {ex.Message}");
            }
        }

        // Método para actualizar la relación materia-salón
        public static async Task ActualizarMateriaSalonAsync(MateriaSalon materiaSalon, int nuevoSalonId)
        {
            try
            {
                if (materiaSalon.MateriaId <= 0 || materiaSalon.SalonId <= 0 || nuevoSalonId <= 0)
                {
                    throw new ArgumentException("Los IDs de la materia, el salón y el nuevo salón deben ser mayores a cero.");
                }

                // Llamar a la DAL para actualizar la relación
                await MateriaSalonDAL.ActualizarAsync(materiaSalon, nuevoSalonId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la actualización: {ex.Message}");
            }
        }

        // Método para obtener las relaciones por MateriaId
        public static async Task TraerPorMateriaIdAsync(int materiaId)
        {
            try
            {
                if (materiaId <= 0)
                {
                    throw new ArgumentException("El ID de la materia debe ser mayor a cero.");
                }

                // Llamar a la DAL para traer las relaciones
                await MateriaSalonDAL.TraerPorMateriaIdAsync(materiaId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener datos por MateriaId: {ex.Message}");
            }
        }

        // Método para obtener las relaciones por SalonId
        public static async Task TraerPorSalonIdAsync(int salonId)
        {
            try
            {
                if (salonId <= 0)
                {
                    throw new ArgumentException("El ID del salón debe ser mayor a cero.");
                }

                // Llamar a la DAL para traer las relaciones
                await MateriaSalonDAL.TraerPorSalonIdAsync(salonId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener datos por SalonId: {ex.Message}");
            }
        }
    }
}
