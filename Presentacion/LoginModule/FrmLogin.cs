using Presentacion.InicioModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;

namespace Presentacion.LoginModule
{
    public partial class FrmLogin : Form
    {
        private Notifier notifier;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            notifier = new Notifier(cfg =>
            {
                cfg.PositionProvider = new WindowPositionProvider(
                    parentWindow: this,
                    corner: Corner.BottomRight,
                    offsetX: 10,
                    offsetY: 10);

                cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                    notificationLifetime: TimeSpan.FromSeconds(3), // Duración
                    maximumNotificationCount: MaximumNotificationCount.FromCount(5));
            });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Auth();
        }

        private void WindowOutsideHeader(object sender, EventArgs e)
        {
            // Lógica del método
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
