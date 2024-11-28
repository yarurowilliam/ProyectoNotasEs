using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.GestionMateriaModule
{
    public partial class FrmGradoGet : Form
    {
        public static Grado grado = new Grado();
        private readonly GradoBLL cursoBLL;

        public FrmGradoGet()
        {
            InitializeComponent();
            try
            {
                cursoBLL = new GradoBLL();
                CargarTabla();
            }
            catch
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async Task CargarTabla()
        {
            try
            {
                var grados = await cursoBLL.TraerTodosAsync();

                tablaGrado.DataSource = grados.Select(g => new
                {
                    g.GradoId,
                    g.NombreGrado
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los grados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tablaGrado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no sea el encabezado
            {
                DataGridViewRow row = tablaGrado.Rows[e.RowIndex];

                MessageBox.Show("Llenado información para modificar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Llenar el formulario con los datos seleccionados
                grado.GradoId = Convert.ToInt32(row.Cells["GradoId"].Value);
                grado.NombreGrado = row.Cells["NombreGrado"].Value?.ToString();
            }
        }
    }
}
