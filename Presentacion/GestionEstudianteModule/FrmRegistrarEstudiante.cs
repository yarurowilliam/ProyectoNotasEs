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

namespace Presentacion.GestionEstudianteModule
{
    public partial class FrmRegistrarEstudiante : Form
    {
        EstudianteBLL estudianteBLL;
        private string Valor = "GUARDAR";

        public FrmRegistrarEstudiante()
        {
            InitializeComponent();
            estudianteBLL = new EstudianteBLL();
            CargarTabla();
            btnGuardar.Text = Valor;
        }

        private void LimpiarFormulario()
        {
            comboTipoIdentificacion.SelectedIndex = 0;
            txtNumeroIdentificacion.Clear();
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            pickerFechaNacimiento.Value = DateTime.Today;
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
        }


        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (tablaEstudiante.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un estudiante para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = tablaEstudiante.SelectedRows[0];
            var numeroIdentificacion = row.Cells["NumeroIdentificacion"].Value.ToString();

            var estudiante = await estudianteBLL.TraerPorIDAsync(numeroIdentificacion);
            if (estudiante != null)
            {
                comboTipoIdentificacion.SelectedItem = estudiante.TipoIdentificacion;
                txtNumeroIdentificacion.Text = estudiante.NumeroIdentificacion;
                txtPrimerNombre.Text = estudiante.PrimerNombre;
                txtSegundoNombre.Text = estudiante.SegundoNombre;
                txtPrimerApellido.Text = estudiante.PrimerApellido;
                txtSegundoApellido.Text = estudiante.SegundoApellido;
                pickerFechaNacimiento.Value = estudiante.FechaNacimiento;
                txtTelefono.Text = estudiante.Telefono;
                txtDireccion.Text = estudiante.Direccion;
                txtCorreo.Text = estudiante.Correo;

                Valor = "MODIFICAR";
                btnGuardar.Text = Valor;
            }

        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroIdentificacion.Text))
            {
                await CargarTabla();
            }
            else
            {
                await CargarTabla(txtNumeroIdentificacion.Text);
            }

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

        private async void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (tablaEstudiante.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un estudiante para desactivar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = tablaEstudiante.SelectedRows[0];
            var numeroIdentificacion = row.Cells["NumeroIdentificacion"].Value.ToString();

            var confirmResult = MessageBox.Show($"¿Desea desactivar al estudiante con identificación {numeroIdentificacion}?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var resultado = await estudianteBLL.DesactivarEstudianteAsync(numeroIdentificacion);

                    if (resultado)
                    {
                        MessageBox.Show("El estudiante fue desactivado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CargarTabla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al desactivar el estudiante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            Valor = "GUARDAR";
            btnGuardar.Text = Valor;
        }

        private async Task GuardarAsync()
        {
            var estudiante = new Estudiante
            {
                TipoIdentificacion = comboTipoIdentificacion.SelectedItem?.ToString().ToUpper(),
                NumeroIdentificacion = txtNumeroIdentificacion.Text.ToUpper(),
                PrimerNombre = txtPrimerNombre.Text.ToUpper(),
                SegundoNombre = txtSegundoNombre.Text.ToUpper(),
                PrimerApellido = txtPrimerApellido.Text.ToUpper(),
                SegundoApellido = txtSegundoApellido.Text.ToUpper(),
                FechaNacimiento = pickerFechaNacimiento.Value,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text.ToUpper(),
                Correo = txtCorreo.Text.ToUpper(),
                Estado = "ACTIVO"
            };

            try
            {
                var resultado = await estudianteBLL.InsertarEstudianteAsync(estudiante);

                if (resultado)
                {
                    MessageBox.Show("El estudiante se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    await CargarTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el estudiante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task CargarTabla(string filtroNumeroIdentificacion = null)
        {
            try
            {
                List<Estudiante> estudiantes;

                if (string.IsNullOrEmpty(filtroNumeroIdentificacion))
                {
                    estudiantes = await estudianteBLL.TraerTodosAsync();
                }
                else
                {
                    var estudiante = await estudianteBLL.TraerPorIDAsync(filtroNumeroIdentificacion);
                    estudiantes = estudiante != null ? new List<Estudiante> { estudiante } : new List<Estudiante>();
                }

                tablaEstudiante.DataSource = estudiantes.Select(e => new
                {
                    e.TipoIdentificacion,
                    e.NumeroIdentificacion,
                    e.PrimerNombre,
                    e.SegundoNombre,
                    e.PrimerApellido,
                    e.SegundoApellido,
                    e.FechaNacimiento,
                    e.Telefono,
                    e.Direccion,
                    e.Correo,
                    e.Estado
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los estudiantes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task ModificarAsync()
        {
            var estudiante = new Estudiante
            {
                TipoIdentificacion = comboTipoIdentificacion.SelectedItem?.ToString().ToUpper(),
                NumeroIdentificacion = txtNumeroIdentificacion.Text.ToUpper(),
                PrimerNombre = txtPrimerNombre.Text.ToUpper(),
                SegundoNombre = txtSegundoNombre.Text.ToUpper(),
                PrimerApellido = txtPrimerApellido.Text.ToUpper(),
                SegundoApellido = txtSegundoApellido.Text.ToUpper(),
                FechaNacimiento = pickerFechaNacimiento.Value,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text.ToUpper(),
                Correo = txtCorreo.Text.ToUpper(),
                Estado = "ACTIVO"
            };

            try
            {
                var resultado = await estudianteBLL.ModificarEstudianteAsync(estudiante);

                if (resultado)
                {
                    MessageBox.Show("El estudiante se modificó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    await CargarTabla();
                    Valor = "GUARDAR";
                    btnGuardar.Text = Valor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el estudiante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tablaEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0) // Asegurarse de que no sea el encabezado
                {
                    DataGridViewRow row = tablaEstudiante.Rows[e.RowIndex];

                    MessageBox.Show("Llenado información para modificar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Llenar el formulario sin `TipoIdentificacion`
                    txtNumeroIdentificacion.Text = row.Cells["NumeroIdentificacion"].Value?.ToString();
                    txtPrimerNombre.Text = row.Cells["PrimerNombre"].Value?.ToString();
                    txtSegundoNombre.Text = row.Cells["SegundoNombre"].Value?.ToString();
                    txtPrimerApellido.Text = row.Cells["PrimerApellido"].Value?.ToString();
                    txtSegundoApellido.Text = row.Cells["SegundoApellido"].Value?.ToString();

                    if (row.Cells["FechaNacimiento"].Value != null)
                    {
                        pickerFechaNacimiento.Value = Convert.ToDateTime(row.Cells["FechaNacimiento"].Value);
                    }

                    txtTelefono.Text = row.Cells["Telefono"].Value?.ToString();
                    txtDireccion.Text = row.Cells["Direccion"].Value?.ToString();
                    txtCorreo.Text = row.Cells["Correo"].Value?.ToString();

                    Valor = "MODIFICAR";
                    btnGuardar.Text = Valor;

                }

            }
        }
    }
}
