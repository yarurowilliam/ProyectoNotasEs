using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.GestionCursosModule
{
    public partial class FrmGestionCursos : Form
    {
        private readonly GradoBLL cursoBLL;
        private string Valor = "GUARDAR";

        public FrmGestionCursos()
        {
            InitializeComponent();
            cursoBLL = new GradoBLL();
            CargarTabla();
            btnGuardar.Text = Valor;
        }

        private void LimpiarFormulario()
        {
            txtPrimerNombre.Clear();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Valor == "GUARDAR")
            {
                await GuardarAsync();
            }
            else
            {
                await ModificarAsync();
            }
        }

        private async void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            Valor = "GUARDAR";
            btnGuardar.Text = Valor;
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (tablaGrado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un grado para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = tablaGrado.SelectedRows[0];
            var gradoId = (int)row.Cells["GradoId"].Value;

            try
            {
                var curso = await cursoBLL.TraerPorIdAsync(gradoId);

                // Verificar si el curso es nulo
                if (!curso.Equals(default((int GradoId, string NombreGrado))))
                {
                    txtPrimerNombre.Text = curso.NombreGrado;

                    Valor = "MODIFICAR";
                    btnGuardar.Text = Valor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la información del grado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GuardarAsync()
        {
            var nombreGrado = txtPrimerNombre.Text.ToUpper();

            try
            {
                await cursoBLL.InsertarAsync(nombreGrado);

                MessageBox.Show("El grado se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                await CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el grado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ModificarAsync()
        {
            var row = tablaGrado.SelectedRows[0];
            var gradoId = (int)row.Cells["GradoId"].Value;
            var nombreGrado = txtPrimerNombre.Text.ToUpper();

            try
            {
                await cursoBLL.ActualizarAsync(gradoId, nombreGrado);

                MessageBox.Show("El grado se modificó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                await CargarTabla();
                Valor = "GUARDAR";
                btnGuardar.Text = Valor;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el grado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                txtPrimerNombre.Text = row.Cells["NombreGrado"].Value?.ToString();
                Valor = "MODIFICAR";
                btnGuardar.Text = Valor;
            }
        }

        private void tablaGrado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}