using BLL.GestionDocente;
using DAL.GestionDocente;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.GestionDocenteModule
{
    public partial class FrmModificarDocente : Form
    {
        DocenteBLL _docenteBLL;
        Docente docente;

        public FrmModificarDocente()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarConFiltros();
        }

        private void LimpiarCampos()
        {
            comboTipoIdentificacion.SelectedIndex = 0;
            txtNumeroIdentificacion.Text = string.Empty;
            txtPrimerNombre.Text = string.Empty;
            txtSegundoNombre.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            pickerFechaNacimiento.Value = DateTime.Now;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            isPracticante.Checked = false;
            txtNumeroIdentificacion.Enabled = true;
        }

        private async void BuscarConFiltros()
        {
            try
            {
                _docenteBLL = new DocenteBLL();
                // Obtener filtros desde los controles del formulario
                string numeroIdentificacion = txtNumeroIdentificacion.Text;
                bool aplicarFiltros = true; // Checkbox para activar/desactivar filtros

                if (numeroIdentificacion.Length == 0)
                {
                    MessageBox.Show("Debe ingresar un número de identificación.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar a la capa BLL para obtener los datos
                List<Docente> listaDocentes = await _docenteBLL.ConsultarDocenteAsync(
                    numeroIdentificacion,
                    aplicarFiltros
                );

                if (listaDocentes.Count == 0)
                {
                    MessageBox.Show("No se encontraron docentes con el número de identificación ingresado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    docente = listaDocentes.FirstOrDefault();
                    comboTipoIdentificacion.SelectedIndex = comboTipoIdentificacion.FindStringExact(docente.TipoIdentificacion);
                    txtNumeroIdentificacion.Text = docente.NumeroIdentificacion;
                    txtPrimerNombre.Text = docente.PrimerNombre;
                    txtSegundoNombre.Text = docente.SegundoNombre;
                    txtPrimerApellido.Text = docente.PrimerApellido;
                    txtSegundoApellido.Text = docente.SegundoApellido;
                    pickerFechaNacimiento.Value = docente.FechaNacimiento;
                    txtTelefono.Text = docente.Telefono;
                    txtDireccion.Text = docente.Direccion;
                    txtCorreo.Text = docente.Correo;
                    isPracticante.Checked = docente.Practicante;

                    txtNumeroIdentificacion.Enabled = false;

                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar docentes: {ex.Message}");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarAsync();
        }

        private async void ModificarAsync()
        {
            try
            {
                if(docente == null)
                {
                    MessageBox.Show("Debe ingresar un número de identificación y consultar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _docenteBLL = new DocenteBLL();

                docente.TipoIdentificacion = comboTipoIdentificacion.SelectedItem.ToString().ToUpper();
                docente.NumeroIdentificacion = txtNumeroIdentificacion.Text.ToUpper();
                docente.PrimerNombre = txtPrimerNombre.Text.ToUpper();
                docente.SegundoNombre = txtSegundoNombre.Text.ToUpper();
                docente.PrimerApellido = txtPrimerApellido.Text.ToUpper();
                docente.SegundoApellido = txtSegundoApellido.Text.ToUpper();
                docente.FechaNacimiento = pickerFechaNacimiento.Value;
                docente.Telefono = txtTelefono.Text;
                docente.Practicante = isPracticante.Checked;
                docente.Direccion = txtDireccion.Text.ToUpper();
                docente.Correo = txtCorreo.Text.ToUpper();
                docente.UltimoUsuario = "DEFAULT";

                bool result = await _docenteBLL.ModificarDocenteAsync(docente);

                if (result)
                {
                    MessageBox.Show("Docente modificado con éxito", "Modifica exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificado el docente", "Modifica fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificado el docente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
