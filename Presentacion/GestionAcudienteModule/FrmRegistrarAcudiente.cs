using BLL;
using Entity.GestionAcudiente;
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

namespace Presentacion.GestionAcudienteModule
{
    public partial class FrmRegistrarAcudiente : Form
    {
        private readonly AcudienteBLL _acudienteBLL;

        public FrmRegistrarAcudiente()
        {
            InitializeComponent();
            CargarTabla();
            _acudienteBLL = new AcudienteBLL();
            
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {

            var acudiente = CrearAcudienteDesdeFormulario();
            bool resultado = await _acudienteBLL.InsertarAcudienteAsync(acudiente);

            if (resultado)
            {
                MessageBox.Show("Acudiente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Error al registrar el acudiente. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {

            var acudiente = CrearAcudienteDesdeFormulario();
            bool resultado = await _acudienteBLL.ModificarDocenteAsync(acudiente);

            if (resultado)
            {
                MessageBox.Show("Acudiente modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Error al modificar el acudiente. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


        private Acudiente CrearAcudienteDesdeFormulario()
        {
            return new Acudiente
            {
                IdAcudiente = int.Parse(txtNumeroIdentificacion.Text.Trim()),
                PrimerNombre = txtPrimerNombre.Text.Trim(),
                SegundoNombre = txtSegundoNombre.Text.Trim(),
                PrimerApellido = txtPrimerApellido.Text.Trim(),
                SegundoApellido = txtSegundoApellido.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtCorreo.Text.Trim()
            };
        }

        private void LimpiarFormulario()
        {
            txtNumeroIdentificacion.Clear();
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtPrimerNombre.Focus();
        }

        

        private async void CargarTabla(string filtroNumeroIdentificacion = null)
        {
            try
            {
                // Instancia la BLL de Acudiente
                var acudienteBLL = new AcudienteBLL();

                List<Acudiente> acudientes;

                if (string.IsNullOrEmpty(filtroNumeroIdentificacion))
                {
                    acudientes = await acudienteBLL.TraerTodosAsync();
                }
                else
                {
                    var filtroNumeroIdentificacion2 = int.Parse(filtroNumeroIdentificacion);
                    var acudiente = await acudienteBLL.TraerPorIDAsync(filtroNumeroIdentificacion2);
                    acudientes = acudiente != null ? new List<Acudiente> { acudiente } : new List<Acudiente>();
                }

                // Cargar datos en el DataGridView
                tablaAcudiente.DataSource = acudientes.Select(a => new
                {
                    //a.TipoIdentificacion,
                    a.IdAcudiente,
                    a.PrimerNombre,
                    a.SegundoNombre,
                    a.PrimerApellido,
                    a.SegundoApellido,
                    a.Telefono,
                    a.Email,
                    //a.Estado
                }).ToList();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado al cargar la tabla. Por favor, contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error no controlado: {ex.Message}");
            }
        }

        private void tablaAcudiente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNumeroIdentificacion.Text == "")
            {
                CargarTabla();
            }
            else
            {
                CargarTabla(txtNumeroIdentificacion.Text);
            }
        }

        private void tablaAcudiente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no sea el encabezado
            {
                DataGridViewRow row = tablaAcudiente.Rows[e.RowIndex];

                MessageBox.Show("Llenando información para modificar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Asignar valores a los campos de texto
                txtNumeroIdentificacion.Text = row.Cells["IdAcudiente"].Value.ToString();
                txtPrimerNombre.Text = row.Cells["PrimerNombre"].Value.ToString();
                txtSegundoNombre.Text = row.Cells["SegundoNombre"].Value.ToString();
                txtPrimerApellido.Text = row.Cells["PrimerApellido"].Value.ToString();
                txtSegundoApellido.Text = row.Cells["SegundoApellido"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = row.Cells["Email"].Value.ToString();

                
            }
        }
    }
}


