using Presentacion.GestionAcudienteModule;
using Presentacion.GestionDocenteModule;
using Presentacion.GestionEstudianteModule;
using Presentacion.GestionRolesModule;

namespace Presentacion.InicioModule;

public partial class FrmInicio : Form
{
    public FrmInicio()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private Form activeForm = null;

    private void OpenFormInPanel(Form childForm)
    {
        if (activeForm != null)
        {
            activeForm.Close();
        }

        activeForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        panelPrincipal.Controls.Add(childForm);
        panelPrincipal.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
    }

    private void sonRegistrarDocente_Click(object sender, EventArgs e)
    {
        OpenFormInPanel(new FrmRegistrarDocente());
        lblModulo.Text = "Registrar Docentes";
    }

    private void sonConsultarDocente_Click(object sender, EventArgs e)
    {
        OpenFormInPanel(new FrmConsultarDocente());
        lblModulo.Text = "Consultar Docentes";
    }

    private void sonModificarDocente_Click(object sender, EventArgs e)
    {
        OpenFormInPanel(new FrmModificarDocente());
        lblModulo.Text = "Modificar Docentes";
    }

    private void sonRegistrarRol_Click(object sender, EventArgs e)
    {
        OpenFormInPanel(new FrmRegistrarRol());
        lblModulo.Text = "Gestionar Roles";
    }

    private void gestionAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenFormInPanel(new FrmRegistrarEstudiante());
        lblModulo.Text = "Gestionar Alumnos";
    }

    private void gestionAcudienteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenFormInPanel(new FrmRegistrarAcudiente());
        lblModulo.Text = "Gestionar Acudientes";
    }

    private void parentDocente_Click(object sender, EventArgs e)
    {
        OpenFormInPanel(new FrmRegistrarDocente());
        lblModulo.Text = "Registrar Docentes";
    }
}
