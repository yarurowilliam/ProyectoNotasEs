using System;
using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class GradoBLL
    {
        private GradoDAL gradoDAL;

        public GradoBLL()
        {
            gradoDAL = new GradoDAL();
        }

        public void Insertar(string nombreGrado)
        {
            if (string.IsNullOrEmpty(nombreGrado))
            {
                throw new ArgumentException("El nombre del grado es obligatorio.");
            }

            gradoDAL.Insertar(nombreGrado);
        }

        public void Actualizar(int gradoId, string nombreGrado)
        {
            if (gradoId <= 0)
            {
                throw new ArgumentException("ID de grado inválido.");
            }

            if (string.IsNullOrEmpty(nombreGrado))
            {
                throw new ArgumentException("El nombre del grado es obligatorio.");
            }

            gradoDAL.Actualizar(gradoId, nombreGrado);
        }

        public List<(int GradoId, string NombreGrado)> TraerTodos()
        {
            return gradoDAL.TraerTodos();
        }

        public (int GradoId, string NombreGrado) TraerPorId(int gradoId)
        {
            return gradoDAL.TraerPorId(gradoId);
        }
    }
}
