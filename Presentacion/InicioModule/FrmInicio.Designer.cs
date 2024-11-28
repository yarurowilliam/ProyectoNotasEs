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
            lblModulo = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            panelPrincipal = new Panel();
            menuStrip1 = new MenuStrip();
            parentDocente = new ToolStripMenuItem();
            gestionAlumnosToolStripMenuItem = new ToolStripMenuItem();
            gestionCursosToolStripMenuItem = new ToolStripMenuItem();
            gestionRolesToolStripMenuItem = new ToolStripMenuItem();
            gestionAcudienteToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            panelNavigator.SuspendLayout();
            panelInformation.SuspendLayout();
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
            panelNavigator.Size = new Size(1393, 33);
            panelNavigator.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Dock = DockStyle.Right;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.Location = new Point(1329, 0);
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
            btnExit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1361, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 33);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // panelInformation
            // 
            panelInformation.Controls.Add(lblModulo);
            panelInformation.Controls.Add(materialLabel1);
            panelInformation.Dock = DockStyle.Bottom;
            panelInformation.Location = new Point(0, 954);
            panelInformation.Name = "panelInformation";
            panelInformation.Size = new Size(1393, 61);
            panelInformation.TabIndex = 1;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Depth = 0;
            lblModulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblModulo.Location = new Point(262, 21);
            lblModulo.MouseState = MaterialSkin.MouseState.HOVER;
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(157, 19);
            lblModulo.TabIndex = 1;
            lblModulo.Text = "Seleccione un modulo";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(14, 17);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(206, 24);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Estas en el modulo de: ";
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(menuStrip1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 33);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1393, 921);
            panelPrincipal.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { parentDocente, gestionAlumnosToolStripMenuItem, gestionCursosToolStripMenuItem, gestionRolesToolStripMenuItem, gestionAcudienteToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1393, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // parentDocente
            // 
            parentDocente.Name = "parentDocente";
            parentDocente.Size = new Size(133, 24);
            parentDocente.Text = "Gestion Docente";
            parentDocente.Click += parentDocente_Click;
            // 
            // gestionAlumnosToolStripMenuItem
            // 
            gestionAlumnosToolStripMenuItem.Name = "gestionAlumnosToolStripMenuItem";
            gestionAlumnosToolStripMenuItem.Size = new Size(135, 24);
            gestionAlumnosToolStripMenuItem.Text = "Gestion Alumnos";
            gestionAlumnosToolStripMenuItem.Click += gestionAlumnosToolStripMenuItem_Click;
            // 
            // gestionCursosToolStripMenuItem
            // 
            gestionCursosToolStripMenuItem.Name = "gestionCursosToolStripMenuItem";
            gestionCursosToolStripMenuItem.Size = new Size(120, 24);
            gestionCursosToolStripMenuItem.Text = "Gestion Cursos";
            gestionCursosToolStripMenuItem.Click += gestionCursosToolStripMenuItem_Click;
            // 
            // gestionRolesToolStripMenuItem
            // 
            gestionRolesToolStripMenuItem.Name = "gestionRolesToolStripMenuItem";
            gestionRolesToolStripMenuItem.Size = new Size(113, 24);
            gestionRolesToolStripMenuItem.Text = "Gestion Roles";
            // 
            // sonRegistrarRol
            // 
            sonRegistrarRol.Name = "sonRegistrarRol";
            sonRegistrarRol.Size = new Size(224, 26);
            sonRegistrarRol.Text = "Registrar Rol";
            sonRegistrarRol.Click += sonRegistrarRol_Click;
            gestionRolesToolStripMenuItem.Size = new Size(107, 20);
            gestionRolesToolStripMenuItem.Text = "Gestion Materias";
            gestionRolesToolStripMenuItem.Click += gestionRolesToolStripMenuItem_Click;
            // 
            // gestionAcudienteToolStripMenuItem
            // 
            gestionAcudienteToolStripMenuItem.Name = "gestionAcudienteToolStripMenuItem";
            gestionAcudienteToolStripMenuItem.Size = new Size(144, 24);
            gestionAcudienteToolStripMenuItem.Text = "Gestion Acudiente";
            gestionAcudienteToolStripMenuItem.Click += gestionAcudienteToolStripMenuItem_Click;
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
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(114, 24);
            toolStripMenuItem1.Text = "Gestion Salon";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 1015);
            Controls.Add(panelPrincipal);
            Controls.Add(panelInformation);
            Controls.Add(panelNavigator);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInicio";
            panelNavigator.ResumeLayout(false);
            panelInformation.ResumeLayout(false);
            panelInformation.PerformLayout();
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
        private ToolStripMenuItem gestionAlumnosToolStripMenuItem;
        private ToolStripMenuItem gestionCursosToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem gestionRolesToolStripMenuItem;
        private ToolStripMenuItem gestionAcudienteToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel lblModulo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}