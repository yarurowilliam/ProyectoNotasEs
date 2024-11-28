using DAL;
using DAL.GestionDocente;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class EstudianteBLL
{
    private readonly EstudianteDAL _estudianteDAL;

    public EstudianteBLL()
    {
        _estudianteDAL = new EstudianteDAL(OracleConnectionString.CadenaConexion);
    }

    public async Task<bool> InsertarEstudianteAsync(Estudiante estudiante)
    {
        try
        {
            await _estudianteDAL.InsertarEstudianteAsync(estudiante);
            return true;
        }
        catch (Exception ex)
        {
            // Registrar el error o manejar lógica adicional
            throw new ApplicationException($"Error al insertar el estudiante: {ex.Message}", ex);
        }
    }

    public async Task<bool> DesactivarEstudianteAsync(string numeroIdentificacion)
    {
        try
        {
            await _estudianteDAL.DesactivarEstudianteAsync(numeroIdentificacion);
            return true;
        }
        catch (Exception ex)
        {
            throw new ApplicationException($"Error al desactivar el estudiante: {ex.Message}", ex);
        }
    }

    public async Task<bool> ModificarEstudianteAsync(Estudiante estudiante)
    {
        try
        {
            await _estudianteDAL.ActualizarEstudianteAsync(estudiante);
            return true;
        }
        catch (Exception ex)
        {
            throw new ApplicationException($"Error al modificar el estudiante: {ex.Message}", ex);
        }
    }

    public async Task<Estudiante> TraerPorIDAsync(string numeroIdentificacion)
    {
        try
        {
            var estudiante = await _estudianteDAL.ObtenerEstudiantePorIdentificacionAsync(numeroIdentificacion);
            if (estudiante == null)
            {
                throw new ApplicationException($"No se encontró un estudiante con el número de identificación: {numeroIdentificacion}");
            }

            return estudiante;
        }
        catch (Exception ex)
        {
            throw new ApplicationException($"Error al consultar el estudiante: {ex.Message}", ex);
        }
    }

    public async Task<List<Estudiante>> TraerTodosAsync()
    {
        try
        {
            var estudiantes = await _estudianteDAL.ObtenerTodosLosEstudiantesAsync();
            if (estudiantes == null || estudiantes.Count == 0)
            {
                throw new ApplicationException("No se encontraron estudiantes registrados.");
            }

            return estudiantes;
        }
        catch (Exception ex)
        {
            throw new ApplicationException($"Error al consultar los estudiantes: {ex.Message}", ex);
        }
    }
}
