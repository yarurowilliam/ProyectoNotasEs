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
            tablaGrado = new DataGridView();
            cardInfo1 = new MaterialSkin.Controls.MaterialCard();
            btnModificar = new MaterialSkin.Controls.MaterialButton();
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            txtPrimerNombre = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)tablaGrado).BeginInit();
            cardInfo1.SuspendLayout();
            SuspendLayout();
            // 
            // tablaGrado
            // 
            tablaGrado.AllowUserToDeleteRows = false;
            tablaGrado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaGrado.Location = new Point(14, 159);
            tablaGrado.Margin = new Padding(3, 4, 3, 4);
            tablaGrado.Name = "tablaGrado";
            tablaGrado.RowHeadersWidth = 51;
            tablaGrado.Size = new Size(1345, 555);
            tablaGrado.TabIndex = 14;
            tablaGrado.CellClick += tablaGrado_CellClick;
            tablaGrado.CellContentClick += tablaGrado_CellContentClick;
            // 
            // cardInfo1
            // 
            cardInfo1.BackColor = Color.FromArgb(255, 255, 255);
            cardInfo1.Controls.Add(btnModificar);
            cardInfo1.Controls.Add(btnLimpiar);
            cardInfo1.Controls.Add(btnGuardar);
            cardInfo1.Controls.Add(txtPrimerNombre);
            cardInfo1.Controls.Add(materialLabel2);
            cardInfo1.Depth = 0;
            cardInfo1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardInfo1.Location = new Point(18, 25);
            cardInfo1.Margin = new Padding(14, 13, 14, 13);
            cardInfo1.MouseState = MaterialSkin.MouseState.HOVER;
            cardInfo1.Name = "cardInfo1";
            cardInfo1.Padding = new Padding(14, 13, 14, 13);
            cardInfo1.Size = new Size(1341, 116);
            cardInfo1.TabIndex = 13;
            // 
            // btnModificar
            // 
            btnModificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificar.Depth = 0;
            btnModificar.HighEmphasis = true;
            btnModificar.Icon = null;
            btnModificar.Location = new Point(521, 19);
            btnModificar.Margin = new Padding(5);
            btnModificar.Margin = new Padding(5, 5, 5, 5);
            btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            btnModificar.Name = "btnModificar";
            btnModificar.NoAccentTextColor = Color.Empty;
            btnModificar.Size = new Size(99, 36);
            btnModificar.TabIndex = 30;
            btnModificar.Text = "Modificar";
            btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificar.UseAccentColor = false;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiar.Depth = 0;
            btnLimpiar.HighEmphasis = true;
            btnLimpiar.Icon = null;
            btnLimpiar.Location = new Point(697, 19);
            btnLimpiar.Margin = new Padding(5);
            btnLimpiar.Location = new Point(776, 19);
            btnLimpiar.Margin = new Padding(5, 5, 5, 5);
            btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.NoAccentTextColor = Color.Empty;
            btnLimpiar.Size = new Size(79, 36);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLimpiar.UseAccentColor = true;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(397, 19);
            btnGuardar.Margin = new Padding(5);
            btnGuardar.Margin = new Padding(5, 5, 5, 5);
            btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.NoAccentTextColor = Color.Empty;
            btnGuardar.Size = new Size(88, 36);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGuardar.UseAccentColor = false;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
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
            txtPrimerNombre.Location = new Point(77, 13);
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
            txtPrimerNombre.Size = new Size(290, 48);
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
            materialLabel2.Location = new Point(17, 13);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(46, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Curso:";
            // 
            // FrmGestionCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 729);
            Controls.Add(tablaGrado);
            Controls.Add(cardInfo1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmGestionCursos";
            Text = "FrmGestionCursos";
            ((System.ComponentModel.ISupportInitialize)tablaGrado).EndInit();
            cardInfo1.ResumeLayout(false);
            cardInfo1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tablaGrado;
        private MaterialSkin.Controls.MaterialCard cardInfo1;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrimerNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}