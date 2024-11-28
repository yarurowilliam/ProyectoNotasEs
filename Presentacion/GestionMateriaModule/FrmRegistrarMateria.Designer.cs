namespace Presentacion.GestionMateriaModule
{
    partial class FrmRegistrarMateria
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
            btnDesactivar = new MaterialSkin.Controls.MaterialButton();
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            btnGuardar = new MaterialSkin.Controls.MaterialButton();
            txtSalonID = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            txtNombreMateria = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            tablaMaterias = new DataGridView();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            lblNombreSalon = new MaterialSkin.Controls.MaterialLabel();
            cardInfo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaMaterias).BeginInit();
            SuspendLayout();
            // 
            // cardInfo1
            // 
            cardInfo1.BackColor = Color.FromArgb(255, 255, 255);
            cardInfo1.Controls.Add(lblNombreSalon);
            cardInfo1.Controls.Add(materialLabel1);
            cardInfo1.Controls.Add(BtnBuscar);
            cardInfo1.Controls.Add(btnDesactivar);
            cardInfo1.Controls.Add(btnLimpiar);
            cardInfo1.Controls.Add(btnGuardar);
            cardInfo1.Controls.Add(txtSalonID);
            cardInfo1.Controls.Add(materialLabel9);
            cardInfo1.Controls.Add(materialLabel6);
            cardInfo1.Controls.Add(txtNombreMateria);
            cardInfo1.Controls.Add(materialLabel7);
            cardInfo1.Depth = 0;
            cardInfo1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardInfo1.Location = new Point(13, 19);
            cardInfo1.Margin = new Padding(12, 10, 12, 10);
            cardInfo1.MouseState = MaterialSkin.MouseState.HOVER;
            cardInfo1.Name = "cardInfo1";
            cardInfo1.Padding = new Padding(12, 10, 12, 10);
            cardInfo1.Size = new Size(1169, 145);
            cardInfo1.TabIndex = 10;
            // 
            // BtnBuscar
            // 
            BtnBuscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnBuscar.Depth = 0;
            BtnBuscar.HighEmphasis = true;
            BtnBuscar.Icon = null;
            BtnBuscar.Location = new Point(547, 44);
            BtnBuscar.Margin = new Padding(4);
            BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.NoAccentTextColor = Color.Empty;
            BtnBuscar.Size = new Size(64, 36);
            BtnBuscar.TabIndex = 28;
            BtnBuscar.Text = "🔎";
            BtnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnBuscar.UseAccentColor = false;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // btnDesactivar
            // 
            btnDesactivar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDesactivar.BackColor = Color.Red;
            btnDesactivar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDesactivar.Depth = 0;
            btnDesactivar.HighEmphasis = true;
            btnDesactivar.Icon = null;
            btnDesactivar.Location = new Point(989, 14);
            btnDesactivar.Margin = new Padding(4);
            btnDesactivar.MouseState = MaterialSkin.MouseState.HOVER;
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.NoAccentTextColor = Color.Empty;
            btnDesactivar.Size = new Size(109, 36);
            btnDesactivar.TabIndex = 26;
            btnDesactivar.Text = "DESACTIVAR";
            btnDesactivar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDesactivar.UseAccentColor = true;
            btnDesactivar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiar.Depth = 0;
            btnLimpiar.HighEmphasis = true;
            btnLimpiar.Icon = null;
            btnLimpiar.Location = new Point(858, 10);
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
            btnGuardar.Location = new Point(762, 10);
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
            // txtSalonID
            // 
            txtSalonID.AnimateReadOnly = false;
            txtSalonID.BackgroundImageLayout = ImageLayout.None;
            txtSalonID.CharacterCasing = CharacterCasing.Normal;
            txtSalonID.Depth = 0;
            txtSalonID.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSalonID.HideSelection = true;
            txtSalonID.LeadingIcon = null;
            txtSalonID.Location = new Point(286, 33);
            txtSalonID.Margin = new Padding(3, 2, 3, 2);
            txtSalonID.MaxLength = 32767;
            txtSalonID.MouseState = MaterialSkin.MouseState.OUT;
            txtSalonID.Name = "txtSalonID";
            txtSalonID.PasswordChar = '\0';
            txtSalonID.PrefixSuffixText = null;
            txtSalonID.ReadOnly = false;
            txtSalonID.RightToLeft = RightToLeft.No;
            txtSalonID.SelectedText = "";
            txtSalonID.SelectionLength = 0;
            txtSalonID.SelectionStart = 0;
            txtSalonID.ShortcutsEnabled = true;
            txtSalonID.Size = new Size(254, 48);
            txtSalonID.TabIndex = 12;
            txtSalonID.TabStop = false;
            txtSalonID.TextAlign = HorizontalAlignment.Left;
            txtSalonID.TrailingIcon = null;
            txtSalonID.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(342, 144);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(1, 0);
            materialLabel9.TabIndex = 8;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(16, 10);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(119, 19);
            materialLabel6.TabIndex = 5;
            materialLabel6.Text = "Nombre Materia:";
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.AnimateReadOnly = false;
            txtNombreMateria.BackgroundImageLayout = ImageLayout.None;
            txtNombreMateria.CharacterCasing = CharacterCasing.Normal;
            txtNombreMateria.Depth = 0;
            txtNombreMateria.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombreMateria.HideSelection = true;
            txtNombreMateria.LeadingIcon = null;
            txtNombreMateria.Location = new Point(16, 32);
            txtNombreMateria.Margin = new Padding(3, 2, 3, 2);
            txtNombreMateria.MaxLength = 32767;
            txtNombreMateria.MouseState = MaterialSkin.MouseState.OUT;
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.PasswordChar = '\0';
            txtNombreMateria.PrefixSuffixText = null;
            txtNombreMateria.ReadOnly = false;
            txtNombreMateria.RightToLeft = RightToLeft.No;
            txtNombreMateria.SelectedText = "";
            txtNombreMateria.SelectionLength = 0;
            txtNombreMateria.SelectionStart = 0;
            txtNombreMateria.ShortcutsEnabled = true;
            txtNombreMateria.Size = new Size(255, 48);
            txtNombreMateria.TabIndex = 11;
            txtNombreMateria.TabStop = false;
            txtNombreMateria.TextAlign = HorizontalAlignment.Left;
            txtNombreMateria.TrailingIcon = null;
            txtNombreMateria.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(286, 10);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(65, 19);
            materialLabel7.TabIndex = 6;
            materialLabel7.Text = "Salon ID:";
            // 
            // tablaMaterias
            // 
            tablaMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaMaterias.Location = new Point(17, 173);
            tablaMaterias.Name = "tablaMaterias";
            tablaMaterias.Size = new Size(1169, 377);
            tablaMaterias.TabIndex = 11;
            tablaMaterias.CellClick += tablaMaterias_CellClick;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(286, 83);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(61, 19);
            materialLabel1.TabIndex = 29;
            materialLabel1.Text = "Nombre:";
            // 
            // lblNombreSalon
            // 
            lblNombreSalon.AutoSize = true;
            lblNombreSalon.Depth = 0;
            lblNombreSalon.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNombreSalon.Location = new Point(286, 102);
            lblNombreSalon.MouseState = MaterialSkin.MouseState.HOVER;
            lblNombreSalon.Name = "lblNombreSalon";
            lblNombreSalon.Size = new Size(68, 19);
            lblNombreSalon.TabIndex = 30;
            lblNombreSalon.Text = "NO DATA";
            // 
            // FrmRegistrarMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 722);
            Controls.Add(tablaMaterias);
            Controls.Add(cardInfo1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegistrarMateria";
            Text = "FrmRegistrarMateria";
            cardInfo1.ResumeLayout(false);
            cardInfo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaMaterias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardInfo1;
        private MaterialSkin.Controls.MaterialButton BtnBuscar;
        private MaterialSkin.Controls.MaterialButton btnDesactivar;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialTextBox2 txtSalonID;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreMateria;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private DataGridView tablaMaterias;
        private MaterialSkin.Controls.MaterialLabel lblNombreSalon;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}