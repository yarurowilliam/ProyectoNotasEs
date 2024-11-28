namespace Presentacion.GestionSalon
{
    partial class FrmGestionSalon
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
            cardInfo1 = new MaterialSkin.Controls.MaterialCard();
            BtnBuscar = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            TxtGradoId = new MaterialSkin.Controls.MaterialTextBox2();
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            txtNombreSalon = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            tablaGrado = new DataGridView();
            cardInfo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaGrado).BeginInit();
            SuspendLayout();
            // 
            // cardInfo1
            // 
            cardInfo1.BackColor = Color.FromArgb(255, 255, 255);
            cardInfo1.Controls.Add(BtnBuscar);
            cardInfo1.Controls.Add(materialLabel1);
            cardInfo1.Controls.Add(TxtGradoId);
            cardInfo1.Controls.Add(btnLimpiar);
            cardInfo1.Controls.Add(btnGuardar);
            cardInfo1.Controls.Add(txtNombreSalon);
            cardInfo1.Controls.Add(materialLabel2);
            cardInfo1.Depth = 0;
            cardInfo1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardInfo1.Location = new Point(9, -2);
            cardInfo1.Margin = new Padding(12, 10, 12, 10);
            cardInfo1.MouseState = MaterialSkin.MouseState.HOVER;
            cardInfo1.Name = "cardInfo1";
            cardInfo1.Padding = new Padding(12, 10, 12, 10);
            cardInfo1.Size = new Size(1173, 87);
            cardInfo1.TabIndex = 15;
            // 
            // BtnBuscar
            // 
            BtnBuscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnBuscar.Depth = 0;
            BtnBuscar.HighEmphasis = true;
            BtnBuscar.Icon = null;
            BtnBuscar.Location = new Point(574, 15);
            BtnBuscar.Margin = new Padding(4);
            BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.NoAccentTextColor = Color.Empty;
            BtnBuscar.Size = new Size(64, 36);
            BtnBuscar.TabIndex = 29;
            BtnBuscar.Text = "🔎";
            BtnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnBuscar.UseAccentColor = false;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(378, 11);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(48, 19);
            materialLabel1.TabIndex = 27;
            materialLabel1.Text = "Grado:";
            // 
            // TxtGradoId
            // 
            TxtGradoId.AnimateReadOnly = false;
            TxtGradoId.BackgroundImageLayout = ImageLayout.None;
            TxtGradoId.CharacterCasing = CharacterCasing.Normal;
            TxtGradoId.Depth = 0;
            TxtGradoId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TxtGradoId.HideSelection = true;
            TxtGradoId.LeadingIcon = null;
            TxtGradoId.Location = new Point(432, 10);
            TxtGradoId.Margin = new Padding(3, 2, 3, 2);
            TxtGradoId.MaxLength = 32767;
            TxtGradoId.MouseState = MaterialSkin.MouseState.OUT;
            TxtGradoId.Name = "TxtGradoId";
            TxtGradoId.PasswordChar = '\0';
            TxtGradoId.PrefixSuffixText = null;
            TxtGradoId.ReadOnly = false;
            TxtGradoId.RightToLeft = RightToLeft.No;
            TxtGradoId.SelectedText = "";
            TxtGradoId.SelectionLength = 0;
            TxtGradoId.SelectionStart = 0;
            TxtGradoId.ShortcutsEnabled = true;
            TxtGradoId.Size = new Size(125, 48);
            TxtGradoId.TabIndex = 26;
            TxtGradoId.TabStop = false;
            TxtGradoId.TextAlign = HorizontalAlignment.Left;
            TxtGradoId.TrailingIcon = null;
            TxtGradoId.UseSystemPasswordChar = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiar.Depth = 0;
            btnLimpiar.HighEmphasis = true;
            btnLimpiar.Icon = null;
            btnLimpiar.Location = new Point(825, 14);
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
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGuardar.Depth = 0;
            btnGuardar.HighEmphasis = true;
            btnGuardar.Icon = null;
            btnGuardar.Location = new Point(729, 15);
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
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombreSalon
            // 
            txtNombreSalon.AnimateReadOnly = false;
            txtNombreSalon.BackgroundImageLayout = ImageLayout.None;
            txtNombreSalon.CharacterCasing = CharacterCasing.Normal;
            txtNombreSalon.Depth = 0;
            txtNombreSalon.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreSalon.HideSelection = true;
            txtNombreSalon.LeadingIcon = null;
            txtNombreSalon.Location = new Point(67, 10);
            txtNombreSalon.Margin = new Padding(3, 2, 3, 2);
            txtNombreSalon.MaxLength = 32767;
            txtNombreSalon.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreSalon.Name = "txtNombreSalon";
            txtNombreSalon.PasswordChar = '\0';
            txtNombreSalon.PrefixSuffixText = null;
            txtNombreSalon.ReadOnly = false;
            txtNombreSalon.RightToLeft = RightToLeft.No;
            txtNombreSalon.SelectedText = "";
            txtNombreSalon.SelectionLength = 0;
            txtNombreSalon.SelectionStart = 0;
            txtNombreSalon.ShortcutsEnabled = true;
            txtNombreSalon.Size = new Size(273, 48);
            txtNombreSalon.TabIndex = 12;
            txtNombreSalon.TabStop = false;
            txtNombreSalon.TextAlign = HorizontalAlignment.Left;
            txtNombreSalon.TrailingIcon = null;
            txtNombreSalon.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(15, 9);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(46, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Salon:";
            // 
            // tablaGrado
            // 
            tablaGrado.AllowUserToDeleteRows = false;
            tablaGrado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaGrado.Location = new Point(5, 98);
            tablaGrado.Name = "tablaGrado";
            tablaGrado.RowHeadersWidth = 51;
            tablaGrado.Size = new Size(1177, 416);
            tablaGrado.TabIndex = 16;
            tablaGrado.CellClick += tablaGrado_CellClick;
            // 
            // FrmGestionSalon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 512);
            Controls.Add(cardInfo1);
            Controls.Add(tablaGrado);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmGestionSalon";
            Text = "FrmGestionSalon";
            cardInfo1.ResumeLayout(false);
            cardInfo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaGrado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardInfo1;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreSalon;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private DataGridView tablaGrado;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 TxtGradoId;
        private MaterialSkin.Controls.MaterialButton BtnBuscar;
    }
}