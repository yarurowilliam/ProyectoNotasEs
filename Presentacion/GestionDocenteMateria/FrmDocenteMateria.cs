using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.GestionDocenteMateria
{
    public partial class FrmDocenteMateria : Form
    {
        private readonly DocenteMateriaBLL docenteMateriaBLL;
        private string Valor = "GUARDAR";

        public FrmDocenteMateria()
        {
            InitializeComponent();
            docenteMateriaBLL = new DocenteMateriaBLL(OracleConnectionString.CadenaConexion);
            CargarTabla();
            btnGuardar.Text = Valor;

            // Asociar el evento CellClick al DataGridView
            tablaDocenteMateria.CellClick += tablaDocenteMateria_CellClick;
        }


        private void LimpiarFormulario()
        {
            TxtIdentificacion.Clear();
            TxtMateriaId.Clear();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tablaDocenteMateria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = tablaDocenteMateria.SelectedRows[0];
            var numeroIdentificacion = row.Cells["NumeroIdentificacion"].Value.ToString();
            var materiaId = (int)row.Cells["MateriaId"].Value;

            TxtIdentificacion.Text = numeroIdentificacion;
            TxtMateriaId.Text = materiaId.ToString();

            Valor = "MODIFICAR";
            btnGuardar.Text = Valor;

        }

        private async Task GuardarAsync()
        {
            var numeroIdentificacion = TxtIdentificacion.Text;
            var materiaId = int.Parse(TxtMateriaId.Text);

            try
            {
                await docenteMateriaBLL.InsertarAsync(numeroIdentificacion, materiaId);

                MessageBox.Show("El registro se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                await CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ModificarAsync()
        {
            var row = tablaDocenteMateria.SelectedRows[0];
            var numeroIdentificacion = row.Cells["DOCENTE_NUMEROIDENTIFICACION"].Value.ToString();
            var materiaId = Convert.ToInt32(row.Cells["MATERIA_MATERIAID"].Value);
            var nuevoMateriaId = int.Parse(TxtMateriaId.Text);

            try
            {
                await docenteMateriaBLL.ActualizarAsync(numeroIdentificacion, materiaId, nuevoMateriaId);

                MessageBox.Show("El registro se modificó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                await CargarTabla();
                Valor = "GUARDAR";
                btnGuardar.Text = Valor;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async Task CargarTabla()
        {
            try
            {
                var dataTable = await docenteMateriaBLL.ConsultarAsync();

                tablaDocenteMateria.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los registros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tablaDocenteMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < tablaDocenteMateria.Rows.Count) // Verificar que el índice de la fila sea válido
            {
                DataGridViewRow row = tablaDocenteMateria.Rows[e.RowIndex];

                MessageBox.Show("Llenado información para modificar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Verificar y asignar valores a los campos de texto
                if (row.Cells["DOCENTE_NUMEROIDENTIFICACION"] != null && row.Cells["DOCENTE_NUMEROIDENTIFICACION"].Value != null)
                {
                    TxtIdentificacion.Text = row.Cells["DOCENTE_NUMEROIDENTIFICACION"].Value.ToString();
                }

                if (row.Cells["MATERIA_MATERIAID"] != null && row.Cells["MATERIA_MATERIAID"].Value != null)
                {
                    TxtMateriaId.Text = row.Cells["MATERIA_MATERIAID"].Value.ToString();
                }

                Valor = "MODIFICAR";
                btnGuardar.Text = Valor;
            }

        }

        private void CBOEstudianteSalon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
