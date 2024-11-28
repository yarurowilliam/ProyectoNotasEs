using DAL.GestionDocente;
using Entity;

namespace BLL.GestionDocente;

public class DocenteBLL
{
    private readonly DocenteDAL _docenteDAL;

    public DocenteBLL()
    {
        _docenteDAL = new DocenteDAL();
    }

    public async Task<bool> InsertarDocenteAsync(Docente docente)
    {
        try
        {
            return await _docenteDAL.InsertarDocenteAsync(docente);
        }
        catch (DocenteException ex)
        {
            // Registrar el error o manejar lógica adicional
            throw new ApplicationException($"Error al insertar el docente: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            // Error genérico
            throw new ApplicationException("Ocurrió un error inesperado al insertar el docente.", ex);
        }
    }

    public async Task<bool> DesactivarDocenteAsync(string numeroIdentificacion)
    {
        try
        {
            return await _docenteDAL.DesactivarDocenteAsync(numeroIdentificacion);
        }
        catch (DocenteException ex)
        {
            throw new ApplicationException($"Error al desactivar el docente: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Ocurrió un error inesperado al desactivar el docente.", ex);
        }
    }

    public async Task<bool> ModificarDocenteAsync(Docente docente)
    {
        try
        {
            return await _docenteDAL.ModificarDocenteAsync(docente);
        }
        catch (DocenteException ex)
        {
            throw new ApplicationException($"Error al modificar el docente: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Ocurrió un error inesperado al modificar el docente.", ex);
        }
    }

    public async Task<Docente> TraerPorIDAsync(string numeroIdentificacion)
    {
        try
        {
            var docente = await _docenteDAL.TraerPorIDAsync(numeroIdentificacion);
            if (docente == null)
            {
                throw new ApplicationException($"No se encontró un docente con el número de identificación: {numeroIdentificacion}");
            }

            return docente;
        }
        catch (DocenteException ex)
        {
            throw new ApplicationException($"Error al consultar el docente: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Ocurrió un error inesperado al consultar el docente.", ex);
        }
    }

    public async Task<List<Docente>> TraerTodosAsync()
    {
        try
        {
            var docentes = await _docenteDAL.TraerTodosAsync();
            if (docentes == null || docentes.Count == 0)
            {
                throw new ApplicationException("No se encontraron docentes registrados.");
            }

            return docentes;
        }
        catch (DocenteException ex)
        {
            throw new ApplicationException($"Error al consultar los docentes: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Ocurrió un error inesperado al consultar los docentes.", ex);
        }
    }
}