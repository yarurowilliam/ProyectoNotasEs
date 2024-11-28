using BLL.GestionDocente;
using DAL.GestionDocente;
using Entity;

namespace Presentacion.GestionDocenteModule;

public partial class FrmRegistrarDocente : Form
{
    DocenteBLL docenteBLL;

    public FrmRegistrarDocente()
    {
        InitializeComponent();
        try
        {
            CargarTabla();
            btnGuardar.Text = Valor;
        }
        catch
        {

        }
    }

    private void materialLabel1_Click(object sender, EventArgs e)
    {

    }

    private void cardInfo1_Paint(object sender, PaintEventArgs e)
    {

    }

    private async void btnGuardar_Click(object sender, EventArgs e)
    {
        if (Valor == "GUARDAR")
        {

            GuardarAsync();
        }
        else
        {
            Modificar();
        }
    }

    private async void GuardarAsync()
    {
        // Crear la instancia del objeto Docente con los valores del formulario
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
            Estado = "ACTIVO", // Asumimos que un nuevo docente siempre comienza como activo
            UsuarioIdentificacion = txtNumeroIdentificacion.Text // Reemplaza con el usuario autenticado, si aplica
        };

        try
        {
            var docenteBLL = new DocenteBLL();

            bool resultado = await docenteBLL.InsertarDocenteAsync(docente);

            if (resultado)
            {
                MessageBox.Show("El docente se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarTabla();
            }
        }
        catch (ApplicationException ex) when (ex.InnerException is DocenteException docenteEx)
        {
            MessageBox.Show($"Error: {docenteEx.Message} (Código: {docenteEx.ErrorCode})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (ApplicationException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocurrió un error inesperado al guardar el docente. Por favor, contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine($"Error no controlado: {ex.Message}");
        }
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

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarFormulario();
        Valor = "GUARDAR";
        btnGuardar.Text = Valor;
    }

    private async void CargarTabla(string filtroNumeroIdentificacion = null)
    {
        try
        {
            var docenteBLL = new DocenteBLL();

            List<Docente> docentes;

            if (string.IsNullOrEmpty(filtroNumeroIdentificacion))
            {
                docentes = await docenteBLL.TraerTodosAsync();
            }
            else
            {
                var docente = await docenteBLL.TraerPorIDAsync(filtroNumeroIdentificacion);
                docentes = docente != null ? new List<Docente> { docente } : new List<Docente>();
            }

            // Cargar datos en el DataGridView
            tablaDocentes.DataSource = docentes.Select(d => new
            {
                d.TipoIdentificacion,
                d.NumeroIdentificacion,
                d.PrimerNombre,
                d.SegundoNombre,
                d.PrimerApellido,
                d.SegundoApellido,
                d.FechaNacimiento,
                d.Telefono,
                d.Direccion,
                d.Correo,
                d.Estado
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

    private void tablaDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) // Asegurarse de que no sea el encabezado
        {
            DataGridViewRow row = tablaDocentes.Rows[e.RowIndex];

            MessageBox.Show("Llenado informacion para modificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Obtener el valor de TipoIdentificacion de la celda
            string tipoIdentificacion = row.Cells["TipoIdentificacion"].Value.ToString();

            // Buscar el índice exacto del valor en el ComboBox
            int index = comboTipoIdentificacion.FindStringExact(tipoIdentificacion);

            if (index >= 0)
            {
                comboTipoIdentificacion.SelectedIndex = index; // Seleccionar el índice encontrado
            }
            else
            {
                comboTipoIdentificacion.SelectedIndex = -1; // Deseleccionar si no se encuentra
            }

            txtNumeroIdentificacion.Text = row.Cells["NumeroIdentificacion"].Value.ToString();
            txtPrimerNombre.Text = row.Cells["PrimerNombre"].Value.ToString();
            txtSegundoNombre.Text = row.Cells["SegundoNombre"].Value.ToString();
            txtPrimerApellido.Text = row.Cells["PrimerApellido"].Value.ToString();
            txtSegundoApellido.Text = row.Cells["SegundoApellido"].Value.ToString();
            pickerFechaNacimiento.Value = Convert.ToDateTime(row.Cells["FechaNacimiento"].Value);
            txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
            txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
            txtCorreo.Text = row.Cells["Correo"].Value.ToString();
            Valor = "MODIFICAR";
            btnGuardar.Text = Valor;
        }
    }

    private string Valor = "GUARDAR";

    private async void Modificar()
    {
        try
        {
            // Crear un objeto Docente con los datos del formulario
            var docente = new Docente
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
                Estado = "ACTIVO", // Puedes ajustar esto según las reglas de negocio
                UsuarioIdentificacion = txtNumeroIdentificacion.Text.ToUpper() // Reemplaza con el usuario autenticado
            };

            // Instanciar la capa de negocio
            var docenteBLL = new DocenteBLL();

            // Llamar al método de modificación
            bool resultado = await docenteBLL.ModificarDocenteAsync(docente);

            if (resultado)
            {
                MessageBox.Show("El docente fue modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar la tabla
                CargarTabla();
                Valor = "GUARDAR";
                btnGuardar.Text = Valor;
            }
        }
        catch (ApplicationException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ocurrió un error inesperado al modificar el docente. Por favor, contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine($"Error no controlado: {ex.Message}");
        }
    }

    private void btnDesactivar_Click(object sender, EventArgs e)
    {
        Desactivar();
    }

    private async void Desactivar()
    {
        try
        {
            // Verificar que haya un docente seleccionado
            if (tablaDocentes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un docente para desactivar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el número de identificación del docente seleccionado
            DataGridViewRow row = tablaDocentes.SelectedRows[0];
            string numeroIdentificacion = row.Cells["NumeroIdentificacion"].Value.ToString();

            // Confirmar la desactivación
            var confirmResult = MessageBox.Show($"¿Está seguro de que desea desactivar al docente con identificación {numeroIdentificacion}?",
                "Confirmar Desactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Instanciar la capa de negocio
                var docenteBLL = new DocenteBLL();

                // Llamar al método de desactivación
                bool resultado = await docenteBLL.DesactivarDocenteAsync(numeroIdentificacion);

                if (resultado)
                {
                    MessageBox.Show("El docente fue desactivado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar la tabla para reflejar los cambios
                    CargarTabla();
                }
            }
        }
        catch (ApplicationException ex)
        {
            // Mostrar errores específicos
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            // Manejar errores inesperados
            MessageBox.Show("Ocurrió un error inesperado al desactivar el docente. Por favor, contacte al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine($"Error no controlado: {ex.Message}");
        }
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
}
