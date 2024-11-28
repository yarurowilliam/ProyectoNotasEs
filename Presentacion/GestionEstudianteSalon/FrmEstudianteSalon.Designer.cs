namespace Presentacion.GestionEstudianteSalon
{
    partial class FrmEstudianteSalon
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
            btnModificar = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            TxtSalonId = new MaterialSkin.Controls.MaterialTextBox2();
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            TxtIdentificacion = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            cardInfo1 = new MaterialSkin.Controls.MaterialCard();
            tablaEstudianteSalon = new DataGridView();
            CBOEstudianteSalon = new ComboBox();
            cardInfo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaEstudianteSalon).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificar.Depth = 0;
            btnModificar.HighEmphasis = true;
            btnModificar.Icon = null;
            btnModificar.Location = new Point(788, 61);
            btnModificar.Margin = new Padding(5);
            btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            btnModificar.Name = "btnModificar";
            btnModificar.NoAccentTextColor = Color.Empty;
            btnModificar.Size = new Size(99, 36);
            btnModificar.TabIndex = 31;
            btnModificar.Text = "Modificar";
            btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificar.UseAccentColor = false;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(474, 11);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(59, 19);
            materialLabel1.TabIndex = 27;
            materialLabel1.Text = "SalonId:";
            // 
            // TxtSalonId
            // 
            TxtSalonId.AnimateReadOnly = false;
            TxtSalonId.BackgroundImageLayout = ImageLayout.None;
            TxtSalonId.CharacterCasing = CharacterCasing.Normal;
            TxtSalonId.Depth = 0;
            TxtSalonId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtSalonId.HideSelection = true;
            TxtSalonId.LeadingIcon = null;
            TxtSalonId.Location = new Point(560, 13);
            TxtSalonId.MaxLength = 32767;
            TxtSalonId.MouseState = MaterialSkin.MouseState.OUT;
            TxtSalonId.Name = "TxtSalonId";
            TxtSalonId.PasswordChar = '\0';
            TxtSalonId.PrefixSuffixText = null;
            TxtSalonId.ReadOnly = false;
            TxtSalonId.RightToLeft = RightToLeft.No;
            TxtSalonId.SelectedText = "";
            TxtSalonId.SelectionLength = 0;
            TxtSalonId.SelectionStart = 0;
            TxtSalonId.ShortcutsEnabled = true;
            TxtSalonId.Size = new Size(143, 48);
            TxtSalonId.TabIndex = 26;
            TxtSalonId.TabStop = false;
            TxtSalonId.TextAlign = HorizontalAlignment.Left;
            TxtSalonId.TrailingIcon = null;
            TxtSalonId.UseSystemPasswordChar = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiar.Depth = 0;
            btnLimpiar.HighEmphasis = true;
            btnLimpiar.Icon = null;
            btnLimpiar.Location = new Point(856, 11);
            btnLimpiar.Margin = new Padding(5);
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
            btnGuardar.Location = new Point(743, 11);
            btnGuardar.Margin = new Padding(5);
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
            // TxtIdentificacion
            // 
            TxtIdentificacion.AnimateReadOnly = false;
            TxtIdentificacion.BackgroundImageLayout = ImageLayout.None;
            TxtIdentificacion.CharacterCasing = CharacterCasing.Normal;
            TxtIdentificacion.Depth = 0;
            TxtIdentificacion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtIdentificacion.HideSelection = true;
            TxtIdentificacion.LeadingIcon = null;
            TxtIdentificacion.Location = new Point(137, 13);
            TxtIdentificacion.MaxLength = 32767;
            TxtIdentificacion.MouseState = MaterialSkin.MouseState.OUT;
            TxtIdentificacion.Name = "TxtIdentificacion";
            TxtIdentificacion.PasswordChar = '\0';
            TxtIdentificacion.PrefixSuffixText = null;
            TxtIdentificacion.ReadOnly = false;
            TxtIdentificacion.RightToLeft = RightToLeft.No;
            TxtIdentificacion.SelectedText = "";
            TxtIdentificacion.SelectionLength = 0;
            TxtIdentificacion.SelectionStart = 0;
            TxtIdentificacion.ShortcutsEnabled = true;
            TxtIdentificacion.Size = new Size(312, 48);
            TxtIdentificacion.TabIndex = 12;
            TxtIdentificacion.TabStop = false;
            TxtIdentificacion.TextAlign = HorizontalAlignment.Left;
            TxtIdentificacion.TrailingIcon = null;
            TxtIdentificacion.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 10);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(105, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Identificacion: ";
            // 
            // cardInfo1
            // 
            cardInfo1.BackColor = Color.FromArgb(255, 255, 255);
            cardInfo1.Controls.Add(CBOEstudianteSalon);
            cardInfo1.Controls.Add(btnModificar);
            cardInfo1.Controls.Add(materialLabel1);
            cardInfo1.Controls.Add(TxtSalonId);
            cardInfo1.Controls.Add(btnLimpiar);
            cardInfo1.Controls.Add(btnGuardar);
            cardInfo1.Controls.Add(TxtIdentificacion);
            cardInfo1.Controls.Add(materialLabel2);
            cardInfo1.Depth = 0;
            cardInfo1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardInfo1.Location = new Point(10, -3);
            cardInfo1.Margin = new Padding(14, 13, 14, 13);
            cardInfo1.MouseState = MaterialSkin.MouseState.HOVER;
            cardInfo1.Name = "cardInfo1";
            cardInfo1.Padding = new Padding(14, 13, 14, 13);
            cardInfo1.Size = new Size(1341, 116);
            cardInfo1.TabIndex = 19;
            // 
            // tablaEstudianteSalon
            // 
            tablaEstudianteSalon.AllowUserToDeleteRows = false;
            tablaEstudianteSalon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaEstudianteSalon.Location = new Point(6, 131);
            tablaEstudianteSalon.Margin = new Padding(3, 4, 3, 4);
            tablaEstudianteSalon.Name = "tablaEstudianteSalon";
            tablaEstudianteSalon.RowHeadersWidth = 51;
            tablaEstudianteSalon.Size = new Size(1345, 555);
            tablaEstudianteSalon.TabIndex = 20;
            tablaEstudianteSalon.CellClick += tablaEstudianteSalon_CellClick;
            // 
            // CBOEstudianteSalon
            // 
            CBOEstudianteSalon.FormattingEnabled = true;
            CBOEstudianteSalon.Location = new Point(449, 72);
            CBOEstudianteSalon.Name = "CBOEstudianteSalon";
            CBOEstudianteSalon.Size = new Size(151, 28);
            CBOEstudianteSalon.TabIndex = 33;
            CBOEstudianteSalon.SelectedIndexChanged += CBOEstudianteSalon_SelectedIndexChanged;
            // 
            // FrmEstudianteSalon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 682);
            Controls.Add(cardInfo1);
            Controls.Add(tablaEstudianteSalon);
            Name = "FrmEstudianteSalon";
            Text = "FrmEstudianteSalon";
            cardInfo1.ResumeLayout(false);
            cardInfo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaEstudianteSalon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 TxtSalonId;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox2 TxtIdentificacion;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard cardInfo1;
        private DataGridView tablaEstudianteSalon;
        private ComboBox CBOEstudianteSalon;
    }
}