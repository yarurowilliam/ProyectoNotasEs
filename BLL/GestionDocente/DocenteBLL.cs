using DAL.GestionDocente;
using DAL;
using Entity;
using System.Text.RegularExpressions;

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

        if (await _docenteDAL.ExisteDocenteAsync(docente.NumeroIdentificacion))
            throw new ArgumentException("Ya existe un docente con el mismo número de identificación.");

        // Validaciones de negocio
        if (string.IsNullOrWhiteSpace(docente.TipoIdentificacion))
            throw new ArgumentException("El tipo de identificación es obligatorio.");

        if (string.IsNullOrWhiteSpace(docente.NumeroIdentificacion))
            throw new ArgumentException("El número de identificación es obligatorio.");

        if (string.IsNullOrWhiteSpace(docente.PrimerNombre))
            throw new ArgumentException("El primer nombre es obligatorio.");

        if (string.IsNullOrWhiteSpace(docente.PrimerApellido))
            throw new ArgumentException("El primer apellido es obligatorio.");

        if (docente.FechaNacimiento > DateTime.Now)
            throw new ArgumentException("La fecha de nacimiento no puede ser en el futuro.");

        int edad = DateTime.Now.Year - docente.FechaNacimiento.Year;
        if (DateTime.Now < docente.FechaNacimiento.AddYears(edad)) edad--;
        if (edad < 18)
            throw new ArgumentException("El docente debe ser mayor de edad.");

        if (!string.IsNullOrWhiteSpace(docente.Correo))
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(docente.Correo, emailPattern))
                throw new ArgumentException("El correo electrónico no es válido.");
        }

        if (!string.IsNullOrWhiteSpace(docente.Telefono) && docente.Telefono.Length < 7)
            throw new ArgumentException("El teléfono debe tener al menos 7 dígitos.");


        return await _docenteDAL.InsertarDocenteAsync(docente);
    }

    public async Task<List<Docente>> ConsultarDocenteAsync(string numeroIdentificacion, bool aplicarFiltros)
    {
        return await _docenteDAL.ConsultarDocenteAsync(numeroIdentificacion, aplicarFiltros);
    }

    public async Task<bool> ModificarDocenteAsync(Docente docente)
    {
        // Validaciones de negocio para la modificación
        if (string.IsNullOrWhiteSpace(docente.NumeroIdentificacion))
            throw new ArgumentException("El número de identificación es obligatorio.");

        if (string.IsNullOrWhiteSpace(docente.PrimerNombre))
            throw new ArgumentException("El primer nombre es obligatorio.");

        if (string.IsNullOrWhiteSpace(docente.PrimerApellido))
            throw new ArgumentException("El primer apellido es obligatorio.");

        if (docente.FechaNacimiento > DateTime.Now)
            throw new ArgumentException("La fecha de nacimiento no puede ser en el futuro.");

        if (!string.IsNullOrWhiteSpace(docente.Correo))
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(docente.Correo, emailPattern))
                throw new ArgumentException("El correo electrónico no es válido.");
        }

        if (!string.IsNullOrWhiteSpace(docente.Telefono) && docente.Telefono.Length < 7)
            throw new ArgumentException("El teléfono debe tener al menos 7 dígitos.");

        // Llamar a la DAL para modificar el docente
        return await _docenteDAL.ModificarDocenteAsync(docente);
    }
}