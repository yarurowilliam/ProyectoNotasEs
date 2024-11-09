using Presentacion.InicioModule;

namespace Presentacion.LoginModule
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Auth();
        }

        private async void Auth()
        {
            btnLogin.Enabled = false;

            materialProgressBarLoading.Visible = true;
            materialProgressBarLoading.Value = 0;

            // Simula la carga durante 3 segundos
            for (int i = 0; i <= 100; i += 10)
            {
                materialProgressBarLoading.Value = i;
                await Task.Delay(300); // Ajusta el tiempo según el efecto de carga que desees
            }


            string username = txtUsuario.Text;
            string password = txtPassword.Text;

            // Supongamos que la autenticación es exitosa
            bool isAuthenticated = AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                // Oculta el MaterialProgressBar después de 3 segundos
                materialProgressBarLoading.Visible = false;
                MessageBox.Show("Iniciado sesión con éxito");
                btnLogin.Enabled = true;
                FrmInicio frmInicio = new FrmInicio();
                frmInicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            return username == "admin" && password == "admin";
        }
    }
}
