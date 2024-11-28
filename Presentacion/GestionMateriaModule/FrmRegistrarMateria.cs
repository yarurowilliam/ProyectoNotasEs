using BLL;
using Entity.GestionMateria;
using System.Data;

namespace Presentacion.GestionMateriaModule
{
    public partial class FrmRegistrarMateria : Form
    {
        private string Valor = "GUARDAR";

        public FrmRegistrarMateria()
        {
            InitializeComponent();
            try
            {
                ConfigurarTabla();
                ConsultarMaterias(); // Carga inicial de datos
            }
            catch
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Valor == "GUARDAR")
            {
                InsertarMateria();
            }
            else if (Valor == "MODIFICAR")
            {
                ActualizarMateria();
            }
        }

        private async void InsertarMateria()
        {
            try
            {
                // Validar entrada de datos
                if (string.IsNullOrWhiteSpace(txtNombreMateria.Text) || string.IsNullOrWhiteSpace(txtSalonID.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtSalonID.Text, out int salonId))
                {
                    MessageBox.Show("El ID del salón debe ser un número.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear objeto Materia
                var materia = new Materia
                {
                    NombreMateria = txtNombreMateria.Text.Trim(),
                    SalonId = salonId
                };

                // Llamar a la BLL
                var materiaBLL = new MateriaBLL();
                bool resultado = await materiaBLL.InsertarMateriaAsync(materia);

                if (resultado)
                {
                    MessageBox.Show("Materia insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar la tabla
                    ConsultarMaterias();
                    LimpiarCampos();
                    Valor = "GUARDAR";
                    btnGuardar.Text = Valor;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al insertar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ActualizarMateria()
        {
            try
            {
                // Validar entrada de datos
                if (string.IsNullOrWhiteSpace(txtNombreMateria.Text) || string.IsNullOrWhiteSpace(txtSalonID.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtSalonID.Text, out int salonId))
                {
                    MessageBox.Show("El ID del salón debe ser un número.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tablaMaterias.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una materia de la tabla para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el ID de la materia seleccionada
                int materiaId = (int)tablaMaterias.SelectedRows[0].Cells["MateriaId"].Value;

                // Crear objeto Materia
                var materia = new Materia
                {
                    MateriaId = materiaId,
                    NombreMateria = txtNombreMateria.Text.Trim(),
                    SalonId = salonId
                };

                // Llamar a la BLL
                var materiaBLL = new MateriaBLL();
                bool resultado = await materiaBLL.ActualizarMateriaAsync(materia);

                if (resultado)
                {
                    MessageBox.Show("Materia actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar la tabla
                    ConsultarMaterias();
                    LimpiarCampos();
                    Valor = "GUARDAR";
                    btnGuardar.Text = Valor;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al actualizar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ConsultarMaterias()
        {
            try
            {
                // Llamar a la BLL
                var materiaBLL = new MateriaBLL();
                var materias = await materiaBLL.TraerTodasLasMateriasAsync();

                if (materias != null && materias.Count > 0)
                {
                    // Cargar datos en el DataGridView
                    tablaMaterias.DataSource = materias.Select(m => new
                    {
                        m.MateriaId,
                        m.NombreMateria,
                        m.SalonId
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("No se encontraron materias.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tablaMaterias.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreMateria.Clear();
            txtSalonID.Clear();
            if (tablaMaterias.SelectedRows.Count > 0)
            {
                tablaMaterias.ClearSelection();
            }
        }

        private void ConfigurarTabla()
        {
            tablaMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaMaterias.ReadOnly = true;
            tablaMaterias.AllowUserToAddRows = false;
            tablaMaterias.AllowUserToDeleteRows = false;
        }

        private void tablaMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tablaMaterias.Rows[e.RowIndex];

                txtNombreMateria.Text = row.Cells["NombreMateria"].Value.ToString();
                txtSalonID.Text = row.Cells["SalonId"].Value.ToString();
                Valor = "MODIFICAR";
                btnGuardar.Text = Valor;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
