using Presentacion.GestionDocenteModule;
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
    }

    private void sonConsultarDocente_Click(object sender, EventArgs e)
    {
        OpenFormInPanel(new FrmConsultarDocente());
    }

    private void sonModificarDocente_Click(object sender, EventArgs e)
    {
        OpenFormInPanel(new FrmModificarDocente());
    }

    private void sonRegistrarRol_Click(object sender, EventArgs e)
    {
        OpenFormInPanel(new FrmRegistrarRol());
    }
}
