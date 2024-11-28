using BLL.GestionDocente;
using Entity;

namespace Presentacion.GestionDocenteModule;

public partial class FrmConsultarDocente : Form
{
    DocenteBLL _docenteBLL;

    public FrmConsultarDocente()
    {
        InitializeComponent();
        BuscarAsync();
    }

    private async void materialButton1_Click(object sender, EventArgs e)
    {
        BuscarConFiltros();
    }

    private async void BuscarAsync()
    {
        _docenteBLL = new DocenteBLL();
        // Llamar a la capa BLL para obtener los datos

        //List<Docente> listaDocentes = await _docenteBLL.ConsultarDocenteAsync(
        //    null,
        //    false
        //);

        //// Asignar los datos al DataGridView
        //tablaDocentes.DataSource = listaDocentes;
    }

    private async void BuscarConFiltros()
    {
        //try
        //{
        //    _docenteBLL = new DocenteBLL();
        //    // Obtener filtros desde los controles del formulario
        //    string numeroIdentificacion = txtNumeroIdentificacion.Text;
        //    bool aplicarFiltros = true; // Checkbox para activar/desactivar filtros

        //    if (numeroIdentificacion.Length == 0)
        //    {
        //        BuscarAsync();
        //        return;
        //    }

        //    // Llamar a la capa BLL para obtener los datos
        //    List<Docente> listaDocentes = await _docenteBLL.ConsultarDocenteAsync(
        //        numeroIdentificacion,
        //        aplicarFiltros
        //    );

        //    // Asignar los datos al DataGridView
        //    tablaDocentes.DataSource = listaDocentes;
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show($"Error al consultar docentes: {ex.Message}");
        //}
    }
}
