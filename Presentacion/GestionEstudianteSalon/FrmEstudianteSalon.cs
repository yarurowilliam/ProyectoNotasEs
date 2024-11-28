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

namespace Presentacion.GestionEstudianteSalon
{
    public partial class FrmEstudianteSalon : Form
    {
        private readonly EstudianteSalonBLL estudianteSalonBLL;
        private string Valor = "GUARDAR";
        private readonly SalonBLL salonBLL;

        public FrmEstudianteSalon()
        {
            InitializeComponent();
            estudianteSalonBLL = new EstudianteSalonBLL();
            salonBLL = new SalonBLL();
            CargarTabla();
            btnGuardar.Text = Valor;
            CargarSalonesAsync();
        }

        private void LimpiarFormulario()
        {
            TxtIdentificacion.Clear();
            TxtSalonId.Clear();
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
            if (tablaEstudianteSalon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una relación estudiante-salón para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = tablaEstudianteSalon.SelectedRows[0];
            var numeroIdentificacion = row.Cells["NumeroIdentificacion"].Value.ToString();
            var salonId = Convert.ToInt32(row.Cells["SalonId"].Value);

            TxtIdentificacion.Text = numeroIdentificacion;
            TxtSalonId.Text = salonId.ToString();

            Valor = "MODIFICAR";
            btnGuardar.Text = Valor;
        }


        

        private async Task GuardarAsync()
        {
            var numeroIdentificacion = TxtIdentificacion.Text;
            var salonId = int.Parse(TxtSalonId.Text);

            try
            {
                await estudianteSalonBLL.InsertarEstudianteSalonAsync(numeroIdentificacion, salonId);

                MessageBox.Show("La relación estudiante-salón se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                await CargarEstudiantesPorSalonAsync(salonId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la relación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async Task ModificarAsync()
        {
            var row = tablaEstudianteSalon.SelectedRows[0];
            var numeroIdentificacion = row.Cells["NumeroIdentificacion"].Value.ToString();
            var salonId = Convert.ToInt32(row.Cells["SalonId"].Value);
            var nuevoSalonId = int.Parse(TxtSalonId.Text);

            try
            {
                await estudianteSalonBLL.ActualizarEstudianteSalonAsync(numeroIdentificacion, salonId, nuevoSalonId);

                MessageBox.Show("La relación estudiante-salón se modificó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                await CargarEstudiantesPorSalonAsync(nuevoSalonId);
                Valor = "GUARDAR";
                btnGuardar.Text = Valor;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar la relación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async Task CargarTabla()
        {
            try
            {
                if (TxtSalonId.Text.Trim() != "")
                {
                    // Aquí debes proporcionar el ID del salón que deseas cargar
                    int salonId = int.Parse(TxtSalonId.Text); // Puedes ajustar esto según tus necesidades
                    var dataTable = await estudianteSalonBLL.TraerEstudiantesPorSalonAsync(salonId);

                    tablaEstudianteSalon.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los registros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tablaEstudianteSalon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < tablaEstudianteSalon.Rows.Count)
            {
                DataGridViewRow row = tablaEstudianteSalon.Rows[e.RowIndex];

                if (row.Cells["ESTUDIANTES_NumeroIdentificaion"] != null && row.Cells["ESTUDIANTES_NumeroIdentificaion"].Value != null)
                {
                    TxtIdentificacion.Text = row.Cells["ESTUDIANTES_NumeroIdentificaion"].Value.ToString();
                }

                if (row.Cells["SalonId"] != null && row.Cells["SalonId"].Value != null)
                {
                    TxtSalonId.Text = row.Cells["SalonId"].Value.ToString();
                }

                Valor = "MODIFICAR";
                btnGuardar.Text = Valor;
            }


        }

        private async Task CargarSalonesAsync()
        {
            try
            {
                // Supongamos que tienes un método en tu BLL que trae los salones
                var salones = await salonBLL.TraerTodosAsync();

                CBOEstudianteSalon.DataSource = salones;
                CBOEstudianteSalon.DisplayMember = "NombreSalon"; // Campo que se mostrará en el ComboBox
                CBOEstudianteSalon.ValueMember = "SalonId";      // Campo que representa el valor asociado a cada opción
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los salones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarEstudiantesPorSalonAsync(int salonId)
        {
            try
            {
                var dataTable = await estudianteSalonBLL.TraerEstudiantesPorSalonAsync(salonId);
                tablaEstudianteSalon.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los estudiantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void CBOEstudianteSalon_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CBOEstudianteSalon.SelectedValue != null && CBOEstudianteSalon.SelectedValue is int salonId)
            {
                await CargarEstudiantesPorSalonAsync(salonId);
            }


        }

    }
}