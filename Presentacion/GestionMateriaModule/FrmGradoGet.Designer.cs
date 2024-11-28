namespace Presentacion.GestionMateriaModule
{
    partial class FrmGradoGet
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
            tablaGrado = new DataGridView();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)tablaGrado).BeginInit();
            SuspendLayout();
            // 
            // tablaGrado
            // 
            tablaGrado.AllowUserToDeleteRows = false;
            tablaGrado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaGrado.Location = new Point(42, 47);
            tablaGrado.Name = "tablaGrado";
            tablaGrado.RowHeadersWidth = 51;
            tablaGrado.Size = new Size(651, 409);
            tablaGrado.TabIndex = 17;
            tablaGrado.CellClick += tablaGrado_CellClick;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(505, 491);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(97, 36);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "RETORNAR";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiar.Depth = 0;
            btnLimpiar.HighEmphasis = true;
            btnLimpiar.Icon = null;
            btnLimpiar.Location = new Point(397, 491);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.NoAccentTextColor = Color.Empty;
            btnLimpiar.Size = new Size(64, 36);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.Text = "SALIR";
            btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLimpiar.UseAccentColor = true;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // FrmGradoGet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 549);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(tablaGrado);
            Name = "FrmGradoGet";
            Text = "FrmSalonesGet";
            ((System.ComponentModel.ISupportInitialize)tablaGrado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablaGrado;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
    }
}