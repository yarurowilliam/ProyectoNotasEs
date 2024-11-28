namespace Entity;

public class Docente
{
    public string NumeroIdentificacion { get; set; }
    public string TipoIdentificacion { get; set; }
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set; }
    public string PrimerApellido { get; set; }
    public string SegundoApellido { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string Correo { get; set; }
    public string Estado { get; set; }
    public DateTime? FechaModificacion { get; set; }
    public string UsuarioIdentificacion { get; set; }
}