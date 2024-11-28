using BLL;
using ENTITY;
using Presentacion.GestionMateriaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.GestionSalon
{
    public partial class FrmGestionSalon : Form
    {
        private readonly SalonBLL salonBLL;
        private string Valor = "GUARDAR";

        public FrmGestionSalon()
        {
            InitializeComponent();
            salonBLL = new SalonBLL();
            CargarTabla();
            btnGuardar.Text = Valor;
        }

        private void LimpiarFormulario()
        {
            txtNombreSalon.Clear();
            TxtGradoId.Clear();
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
                MessageBox.Show("Seleccione un salón para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = tablaGrado.SelectedRows[0];
            var salonId = (int)row.Cells["SalonId"].Value;

            try
            {
                var salon = await salonBLL.TraerPorIDAsync(salonId);
                if (!salon.Equals(default(Salon)))
                {
                    txtNombreSalon.Text = salon.NombreSalon;

                    Valor = "MODIFICAR";
                    btnGuardar.Text = Valor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la información del salón: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async Task GuardarAsync()
        {
            var salon = new Salon
            {
                NombreSalon = txtNombreSalon.Text.ToUpper(),
                GradoId_FK = GradoId // Incluir GradoId_FK
            };

            try
            {
                await salonBLL.InsertarAsync(salon);

                MessageBox.Show("El salón se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                await CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el salón: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task ModificarAsync()
        {
            var row = tablaGrado.SelectedRows[0];
            var salonId = (int)row.Cells["SALONID"].Value;

            var salon = new Salon
            {
                SalonId = salonId,
                NombreSalon = txtNombreSalon.Text.ToUpper(),
                GradoId_FK = GradoId
            };

            try
            {
                await salonBLL.ActualizarAsync(salon);

                MessageBox.Show("El salón se modificó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                await CargarTabla();
                Valor = "GUARDAR";
                btnGuardar.Text = Valor;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el salón: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task CargarTabla()
        {
            try
            {
                var salones = await salonBLL.TraerTodosAsync();

                tablaGrado.DataSource = salones.Select(s => new
                {
                    s.SalonId,
                    s.NombreSalon,
                    s.GradoId_FK
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los salones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tablaGrado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no sea el encabezado
            {
                DataGridViewRow row = tablaGrado.Rows[e.RowIndex];

                MessageBox.Show("Llenado información para modificar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreSalon.Text = row.Cells["NombreSalon"].Value?.ToString();
                TxtGradoId.Text = row.Cells["GradoId_FK"].Value?.ToString(); // Incluir GradoId_FK
                Valor = "MODIFICAR";
                btnGuardar.Text = Valor;
            }


        }

        private int GradoId = 0;

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            new FrmGradoGet().ShowDialog();
            GradoId = FrmGradoGet.grado.GradoId;
            TxtGradoId.Text = FrmGradoGet.grado.NombreGrado;
        }
    }
}
