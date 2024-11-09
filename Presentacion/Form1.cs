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
            // Deshabilita el botón mientras se realiza la conexión
            button1.Enabled = false;
            try
            {
                bool isConnected = await _connectionBLL.TestConnectionAsync();

                if (isConnected)
                {
                    MessageBox.Show("La conexión a Oracle ha sido exitosa.", "Conexión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo conectar a la base de datos Oracle.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reactiva el botón después de la conexión
                button1.Enabled = true;
            }
        }
    }
}
