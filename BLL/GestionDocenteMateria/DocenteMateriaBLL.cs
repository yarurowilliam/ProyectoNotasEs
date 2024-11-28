using DAL;
using System;
using System.Data;

namespace BLL
{
    public class DocenteMateriaBLL
    {
        private readonly DocenteMateriaDAL _docenteMateriaDAL;

        public DocenteMateriaBLL(string connectionString)
        {
            _docenteMateriaDAL = new DocenteMateriaDAL(connectionString);
        }

        public void Insertar(string docenteNumeroIdentificacion, int materiaId)
        {
            _docenteMateriaDAL.Insertar(docenteNumeroIdentificacion, materiaId);
        }

        public void Actualizar(string docenteNumeroIdentificacion, int materiaId, int nuevoMateriaId)
        {
            _docenteMateriaDAL.Actualizar(docenteNumeroIdentificacion, materiaId, nuevoMateriaId);
        }

        public DataTable TraerMateriasPorDocente(string docenteNumeroIdentificacion)
        {
            return _docenteMateriaDAL.TraerMateriasPorDocente(docenteNumeroIdentificacion);
        }

        public DataTable TraerDocentesPorMateria(int materiaId)
        {
            return _docenteMateriaDAL.TraerDocentesPorMateria(materiaId);
        }

        public DataTable Consultar()
        {
            return _docenteMateriaDAL.Consultar();
        }
    }
}
