using System;
using System.Data;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class NotasBLL
    {
        private readonly NotasDAL _notasDAL;

        public NotasBLL()
        {
            _notasDAL = new NotasDAL();
        }

        public async Task<int> InsertarNotaAsync(decimal nota, int materiaId, int periodoId, string numeroIdentificacion)
        {
            return await _notasDAL.InsertarNotaAsync(nota, materiaId, periodoId, numeroIdentificacion);
        }

        public async Task<int> ActualizarNotaAsync(int notaId, decimal nuevaNota)
        {
            return await _notasDAL.ActualizarNotaAsync(notaId, nuevaNota);
        }

        public async Task<DataTable> TraerNotasAsync(string numeroIdentificacion, int materiaId, int periodoId)
        {
            return await _notasDAL.TraerNotasAsync(numeroIdentificacion, materiaId, periodoId);
        }
    }
}
