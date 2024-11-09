using BLL;
using Oracle.ManagedDataAccess.Client;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private readonly OracleConnectionBLL _connectionBLL;

        public Form1()
        {
            InitializeComponent();
            _connectionBLL = new OracleConnectionBLL();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Deshabilita el bot�n mientras se realiza la conexi�n
            button1.Enabled = false;
            try
            {
                bool isConnected = await _connectionBLL.TestConnectionAsync();

                if (isConnected)
                {
                    MessageBox.Show("La conexi�n a Oracle ha sido exitosa.", "Conexi�n Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo conectar a la base de datos Oracle.", "Error de Conexi�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurri� un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reactiva el bot�n despu�s de la conexi�n
                button1.Enabled = true;
            }
        }
    }
}
