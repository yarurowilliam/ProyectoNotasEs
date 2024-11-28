public class EstudianteBLL
{
    private readonly EstudianteDAL _estudianteDAL;

    public EstudianteBLL(string connectionString)
    {
        _estudianteDAL = new EstudianteDAL(connectionString);
    }

    public void InsertarEstudiante(Estudiante estudiante)
    {
        _estudianteDAL.InsertarEstudiante(estudiante);
    }

    public void ActualizarEstudiante(Estudiante estudiante)
    {
        _estudianteDAL.ActualizarEstudiante(estudiante);
    }

    public void DesactivarEstudiante(string numeroIdentificacion)
    {
        _estudianteDAL.DesactivarEstudiante(numeroIdentificacion);
    }

    public Estudiante ObtenerEstudiantePorIdentificacion(string numeroIdentificacion)
    {
        return _estudianteDAL.ObtenerEstudiantePorIdentificacion(numeroIdentificacion);
    }

    public List<Estudiante> ObtenerTodosLosEstudiantes()
    {
        return _estudianteDAL.ObtenerTodosLosEstudiantes();
    }
}
