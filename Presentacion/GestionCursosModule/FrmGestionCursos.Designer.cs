namespace Presentacion.GestionCursosModule
{
    partial class FrmGestionCursos
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
            tablaEstudiante = new DataGridView();
            cardInfo1 = new MaterialSkin.Controls.MaterialCard();
            btnDesactivar = new MaterialSkin.Controls.MaterialButton();
            btnModificar = new MaterialSkin.Controls.MaterialButton();
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            txtPrimerNombre = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)tablaEstudiante).BeginInit();
            cardInfo1.SuspendLayout();
            SuspendLayout();
            // 
            // tablaEstudiante
            // 
            tablaEstudiante.AllowUserToDeleteRows = false;
            tablaEstudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaEstudiante.Location = new Point(12, 119);
            tablaEstudiante.Name = "tablaEstudiante";
            tablaEstudiante.Size = new Size(1177, 416);
            tablaEstudiante.TabIndex = 14;
            // 
            // cardInfo1
            // 
            cardInfo1.BackColor = Color.FromArgb(255, 255, 255);
            cardInfo1.Controls.Add(btnDesactivar);
            cardInfo1.Controls.Add(btnModificar);
            cardInfo1.Controls.Add(btnLimpiar);
            cardInfo1.Controls.Add(btnGuardar);
            cardInfo1.Controls.Add(txtPrimerNombre);
            cardInfo1.Controls.Add(materialLabel2);
            cardInfo1.Depth = 0;
            cardInfo1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardInfo1.Location = new Point(16, 19);
            cardInfo1.Margin = new Padding(12, 10, 12, 10);
            cardInfo1.MouseState = MaterialSkin.MouseState.HOVER;
            cardInfo1.Name = "cardInfo1";
            cardInfo1.Padding = new Padding(12, 10, 12, 10);
            cardInfo1.Size = new Size(1173, 87);
            cardInfo1.TabIndex = 13;
            // 
            // btnDesactivar
            // 
            btnDesactivar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDesactivar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDesactivar.Depth = 0;
            btnDesactivar.HighEmphasis = true;
            btnDesactivar.Icon = null;
            btnDesactivar.Location = new Point(563, 14);
            btnDesactivar.Margin = new Padding(4);
            btnDesactivar.MouseState = MaterialSkin.MouseState.HOVER;
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.NoAccentTextColor = Color.Empty;
            btnDesactivar.Size = new Size(96, 36);
            btnDesactivar.TabIndex = 31;
            btnDesactivar.Text = "Bloquear";
            btnDesactivar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDesactivar.UseAccentColor = false;
            btnDesactivar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificar.Depth = 0;
            btnModificar.HighEmphasis = true;
            btnModificar.Icon = null;
            btnModificar.Location = new Point(456, 14);
            btnModificar.Margin = new Padding(4);
            btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            btnModificar.Name = "btnModificar";
            btnModificar.NoAccentTextColor = Color.Empty;
            btnModificar.Size = new Size(99, 36);
            btnModificar.TabIndex = 30;
            btnModificar.Text = "Modificar";
            btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificar.UseAccentColor = false;
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiar.Depth = 0;
            btnLimpiar.HighEmphasis = true;
            btnLimpiar.Icon = null;
            btnLimpiar.Location = new Point(679, 14);
            btnLimpiar.Margin = new Padding(4);
            btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.NoAccentTextColor = Color.Empty;
            btnLimpiar.Size = new Size(79, 36);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLimpiar.UseAccentColor = true;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(347, 14);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(88, 36);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.AnimateReadOnly = false;
            txtPrimerNombre.BackgroundImageLayout = ImageLayout.None;
            txtPrimerNombre.CharacterCasing = CharacterCasing.Normal;
            txtPrimerNombre.Depth = 0;
            txtPrimerNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrimerNombre.HideSelection = true;
            txtPrimerNombre.LeadingIcon = null;
            txtPrimerNombre.Location = new Point(67, 10);
            txtPrimerNombre.Margin = new Padding(3, 2, 3, 2);
            txtPrimerNombre.MaxLength = 32767;
            txtPrimerNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.PasswordChar = '\0';
            txtPrimerNombre.PrefixSuffixText = null;
            txtPrimerNombre.ReadOnly = false;
            txtPrimerNombre.RightToLeft = RightToLeft.No;
            txtPrimerNombre.SelectedText = "";
            txtPrimerNombre.SelectionLength = 0;
            txtPrimerNombre.SelectionStart = 0;
            txtPrimerNombre.ShortcutsEnabled = true;
            txtPrimerNombre.Size = new Size(254, 48);
            txtPrimerNombre.TabIndex = 12;
            txtPrimerNombre.TabStop = false;
            txtPrimerNombre.TextAlign = HorizontalAlignment.Left;
            txtPrimerNombre.TrailingIcon = null;
            txtPrimerNombre.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(15, 10);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(46, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Curso:";
            // 
            // FrmGestionCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 547);
            Controls.Add(tablaEstudiante);
            Controls.Add(cardInfo1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionCursos";
            Text = "FrmGestionCursos";
            ((System.ComponentModel.ISupportInitialize)tablaEstudiante).EndInit();
            cardInfo1.ResumeLayout(false);
            cardInfo1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tablaEstudiante;
        private MaterialSkin.Controls.MaterialCard cardInfo1;
        private MaterialSkin.Controls.MaterialButton btnDesactivar;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrimerNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}