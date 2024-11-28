using BLL;

namespace Presentacion.GestionRolesModule
{
    public partial class FrmRegistrarRol : Form
    {
        RolesBLL _rolesBLL;

        public FrmRegistrarRol()
        {
            InitializeComponent();
            _rolesBLL = new RolesBLL();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreRol = txtNombreRol.Text;

            try
            {
                bool resultado = await _rolesBLL.InsertarRolAsync(nombreRol);
                MessageBox.Show(resultado ? "Rol insertado correctamente." : "Error al insertar el rol.");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ConsultarRoles()
        {
         //   _rolesBLL.ConsultarRolPorNombreAsync()
        }

        private void Limpiar()
        {
            txtNombreRol.Text = string.Empty;
        }
    }
}
