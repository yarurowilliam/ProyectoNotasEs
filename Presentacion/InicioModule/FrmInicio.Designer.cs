﻿namespace Presentacion.InicioModule
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
            sonConsultarDocente = new ToolStripMenuItem();
            sonModificarDocente = new ToolStripMenuItem();
            gestionAlumnosToolStripMenuItem = new ToolStripMenuItem();
            gestionCursosToolStripMenuItem = new ToolStripMenuItem();
            gestionRolesToolStripMenuItem = new ToolStripMenuItem();
            sonRegistrarRol = new ToolStripMenuItem();
            gestionAcudienteToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            lblModulo = new MaterialSkin.Controls.MaterialLabel();
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
            panelNavigator.Margin = new Padding(3, 2, 3, 2);
            panelNavigator.Name = "panelNavigator";
            panelNavigator.Size = new Size(1219, 25);
            panelNavigator.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Dock = DockStyle.Right;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.Location = new Point(1163, 0);
            btnMinimizar.Margin = new Padding(3, 2, 3, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(28, 25);
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
            btnExit.Location = new Point(1191, 0);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(28, 25);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // panelInformation
            // 
            panelInformation.Controls.Add(lblModulo);
            panelInformation.Controls.Add(materialLabel1);
            panelInformation.Dock = DockStyle.Bottom;
            panelInformation.Location = new Point(0, 715);
            panelInformation.Margin = new Padding(3, 2, 3, 2);
            panelInformation.Name = "panelInformation";
            panelInformation.Size = new Size(1219, 46);
            panelInformation.TabIndex = 1;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(menuStrip1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 25);
            panelPrincipal.Margin = new Padding(3, 2, 3, 2);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1219, 690);
            panelPrincipal.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { parentDocente, gestionAlumnosToolStripMenuItem, gestionCursosToolStripMenuItem, gestionRolesToolStripMenuItem, gestionAcudienteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1219, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // parentDocente
            // 
            parentDocente.DropDownItems.AddRange(new ToolStripItem[] { sonRegistrarDocente, sonConsultarDocente, sonModificarDocente });
            parentDocente.Name = "parentDocente";
            parentDocente.Size = new Size(106, 20);
            parentDocente.Text = "Gestion Docente";
            // 
            // sonRegistrarDocente
            // 
            sonRegistrarDocente.Name = "sonRegistrarDocente";
            sonRegistrarDocente.Size = new Size(172, 22);
            sonRegistrarDocente.Text = "Registrar Docente";
            sonRegistrarDocente.Click += sonRegistrarDocente_Click;
            // 
            // sonConsultarDocente
            // 
            sonConsultarDocente.Name = "sonConsultarDocente";
            sonConsultarDocente.Size = new Size(172, 22);
            sonConsultarDocente.Text = "Consultar Docente";
            sonConsultarDocente.Click += sonConsultarDocente_Click;
            // 
            // sonModificarDocente
            // 
            sonModificarDocente.Name = "sonModificarDocente";
            sonModificarDocente.Size = new Size(172, 22);
            sonModificarDocente.Text = "Modificar Docente";
            sonModificarDocente.Click += sonModificarDocente_Click;
            // 
            // gestionAlumnosToolStripMenuItem
            // 
            gestionAlumnosToolStripMenuItem.Name = "gestionAlumnosToolStripMenuItem";
            gestionAlumnosToolStripMenuItem.Size = new Size(110, 20);
            gestionAlumnosToolStripMenuItem.Text = "Gestion Alumnos";
            gestionAlumnosToolStripMenuItem.Click += gestionAlumnosToolStripMenuItem_Click;
            // 
            // gestionCursosToolStripMenuItem
            // 
            gestionCursosToolStripMenuItem.Name = "gestionCursosToolStripMenuItem";
            gestionCursosToolStripMenuItem.Size = new Size(98, 20);
            gestionCursosToolStripMenuItem.Text = "Gestion Cursos";
            // 
            // gestionRolesToolStripMenuItem
            // 
            gestionRolesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sonRegistrarRol });
            gestionRolesToolStripMenuItem.Name = "gestionRolesToolStripMenuItem";
            gestionRolesToolStripMenuItem.Size = new Size(90, 20);
            gestionRolesToolStripMenuItem.Text = "Gestion Roles";
            // 
            // sonRegistrarRol
            // 
            sonRegistrarRol.Name = "sonRegistrarRol";
            sonRegistrarRol.Size = new Size(140, 22);
            sonRegistrarRol.Text = "Registrar Rol";
            sonRegistrarRol.Click += sonRegistrarRol_Click;
            // 
            // gestionAcudienteToolStripMenuItem
            // 
            gestionAcudienteToolStripMenuItem.Name = "gestionAcudienteToolStripMenuItem";
            gestionAcudienteToolStripMenuItem.Size = new Size(116, 20);
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
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(12, 13);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(206, 24);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Estas en el modulo de: ";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Depth = 0;
            lblModulo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblModulo.Location = new Point(229, 16);
            lblModulo.MouseState = MaterialSkin.MouseState.HOVER;
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(157, 19);
            lblModulo.TabIndex = 1;
            lblModulo.Text = "Seleccione un modulo";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 761);
            Controls.Add(panelPrincipal);
            Controls.Add(panelInformation);
            Controls.Add(panelNavigator);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
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
        private ToolStripMenuItem sonRegistrarDocente;
        private ToolStripMenuItem sonConsultarDocente;
        private ToolStripMenuItem gestionAlumnosToolStripMenuItem;
        private ToolStripMenuItem gestionCursosToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem sonModificarDocente;
        private ToolStripMenuItem gestionRolesToolStripMenuItem;
        private ToolStripMenuItem sonRegistrarRol;
        private ToolStripMenuItem gestionAcudienteToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel lblModulo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}