using System.Collections.Generic;
using System.Threading.Tasks;
using DAL;
using Entity;
using Entity.GestionAcudiente;

namespace BLL
{
    public class AcudienteBLL
    {
        private readonly AcudienteDAL _acudienteDAL;

        public AcudienteBLL()
        {
            _acudienteDAL = new AcudienteDAL();
        }

        public async Task<bool> InsertarAcudienteAsync(Acudiente acudiente)
        {
            return await _acudienteDAL.InsertarAcudienteAsync(acudiente);
        }

        public async Task<Acudiente> TraerAcudientePorIDAsync(int idAcudiente)
        {
            return await _acudienteDAL.TraerAcudientePorIDAsync(idAcudiente);
        }

        public async Task<List<Acudiente>> TraerTodosAcudientesAsync()
        {
            return await _acudienteDAL.TraerTodosAcudientesAsync();
        }
    }
}
