using BLL.GestionDocente;
using Entity;

namespace Presentacion.GestionDocenteModule;

public partial class FrmRegistrarDocente : Form
{
    DocenteBLL docenteBLL;

    public FrmRegistrarDocente()
    {
        InitializeComponent();
    }

    private void materialLabel1_Click(object sender, EventArgs e)
    {

    }

    private void cardInfo1_Paint(object sender, PaintEventArgs e)
    {

    }

    private async void btnGuardar_Click(object sender, EventArgs e)
    {
        GuardarAsync();
    }

    private async void GuardarAsync()
    {
        try
        {
            docenteBLL = new DocenteBLL();

            var docente = new Docente
            {
                TipoIdentificacion = comboTipoIdentificacion.SelectedItem.ToString().ToUpper(),
                NumeroIdentificacion = txtNumeroIdentificacion.Text.ToUpper(),
                PrimerNombre = txtPrimerNombre.Text.ToUpper(),
                SegundoNombre = txtSegundoNombre.Text.ToUpper(),
                PrimerApellido = txtPrimerApellido.Text.ToUpper(),
                SegundoApellido = txtSegundoApellido.Text.ToUpper(),
                FechaNacimiento = pickerFechaNacimiento.Value,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text.ToUpper(),
                Correo = txtCorreo.Text.ToUpper(),
                Practicante = isPracticante.Checked,
                UltimoUsuario = "DEFAULT"
            };

            bool result = await docenteBLL.InsertarDocenteAsync(docente);

            if (result)
            {
                MessageBox.Show("Docente registrado con éxito", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar el docente", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al registrar el docente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
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
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarCampos();
    }
}
