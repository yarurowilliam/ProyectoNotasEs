namespace Presentacion.InicioModule
{
    partial class FrmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelNavigator = new Panel();
            btnMinimizar = new Button();
            btnExit = new Button();
            panelInformation = new Panel();
            panelPrincipal = new Panel();
            menuStrip1 = new MenuStrip();
            parentDocente = new ToolStripMenuItem();
            sonRegistrarDocente = new ToolStripMenuItem();
            consultarDocenteToolStripMenuItem = new ToolStripMenuItem();
            gestionAlumnosToolStripMenuItem = new ToolStripMenuItem();
            gestionCursosToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            panelNavigator.SuspendLayout();
            panelPrincipal.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavigator
            // 
            panelNavigator.BackColor = SystemColors.Highlight;
            panelNavigator.Controls.Add(btnMinimizar);
            panelNavigator.Controls.Add(btnExit);
            panelNavigator.Dock = DockStyle.Top;
            panelNavigator.Location = new Point(0, 0);
            panelNavigator.Name = "panelNavigator";
            panelNavigator.Size = new Size(929, 33);
            panelNavigator.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Dock = DockStyle.Right;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Heebo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.Location = new Point(865, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 33);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.Text = "_";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Heebo", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(897, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 33);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // panelInformation
            // 
            panelInformation.Dock = DockStyle.Bottom;
            panelInformation.Location = new Point(0, 475);
            panelInformation.Name = "panelInformation";
            panelInformation.Size = new Size(929, 62);
            panelInformation.TabIndex = 1;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(menuStrip1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 33);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(929, 442);
            panelPrincipal.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { parentDocente, gestionAlumnosToolStripMenuItem, gestionCursosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(929, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // parentDocente
            // 
            parentDocente.DropDownItems.AddRange(new ToolStripItem[] { sonRegistrarDocente, consultarDocenteToolStripMenuItem });
            parentDocente.Name = "parentDocente";
            parentDocente.Size = new Size(133, 24);
            parentDocente.Text = "Gestion Docente";
            // 
            // sonRegistrarDocente
            // 
            sonRegistrarDocente.Name = "sonRegistrarDocente";
            sonRegistrarDocente.Size = new Size(224, 26);
            sonRegistrarDocente.Text = "Registrar Docente";
            sonRegistrarDocente.Click += sonRegistrarDocente_Click;
            // 
            // consultarDocenteToolStripMenuItem
            // 
            consultarDocenteToolStripMenuItem.Name = "consultarDocenteToolStripMenuItem";
            consultarDocenteToolStripMenuItem.Size = new Size(224, 26);
            consultarDocenteToolStripMenuItem.Text = "Consultar Docente";
            // 
            // gestionAlumnosToolStripMenuItem
            // 
            gestionAlumnosToolStripMenuItem.Name = "gestionAlumnosToolStripMenuItem";
            gestionAlumnosToolStripMenuItem.Size = new Size(135, 24);
            gestionAlumnosToolStripMenuItem.Text = "Gestion Alumnos";
            // 
            // gestionCursosToolStripMenuItem
            // 
            gestionCursosToolStripMenuItem.Name = "gestionCursosToolStripMenuItem";
            gestionCursosToolStripMenuItem.Size = new Size(120, 24);
            gestionCursosToolStripMenuItem.Text = "Gestion Cursos";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 537);
            Controls.Add(panelPrincipal);
            Controls.Add(panelInformation);
            Controls.Add(panelNavigator);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInicio";
            panelNavigator.ResumeLayout(false);
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavigator;
        private Button btnExit;
        private Panel panelInformation;
        private Panel panelPrincipal;
        private Button btnMinimizar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem parentDocente;
        private ToolStripMenuItem sonRegistrarDocente;
        private ToolStripMenuItem consultarDocenteToolStripMenuItem;
        private ToolStripMenuItem gestionAlumnosToolStripMenuItem;
        private ToolStripMenuItem gestionCursosToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
    }
}