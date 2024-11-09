namespace Presentacion.GestionDocenteModule
{
    partial class FrmConsultarDocente
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tablaDocentes = new DataGridView();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            txtNumeroIdentificacion = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)tablaDocentes).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(391, 9);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(166, 24);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Consultar Docente";
            // 
            // tablaDocentes
            // 
            tablaDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaDocentes.Location = new Point(12, 129);
            tablaDocentes.Name = "tablaDocentes";
            tablaDocentes.Size = new Size(981, 338);
            tablaDocentes.TabIndex = 2;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialButton1);
            materialCard1.Controls.Add(txtNumeroIdentificacion);
            materialCard1.Controls.Add(materialLabel7);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(15, 35);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(978, 77);
            materialCard1.TabIndex = 3;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(883, 20);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(77, 36);
            materialButton1.TabIndex = 19;
            materialButton1.Text = "Buscar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // txtNumeroIdentificacion
            // 
            txtNumeroIdentificacion.AnimateReadOnly = false;
            txtNumeroIdentificacion.BackgroundImageLayout = ImageLayout.None;
            txtNumeroIdentificacion.CharacterCasing = CharacterCasing.Normal;
            txtNumeroIdentificacion.Depth = 0;
            txtNumeroIdentificacion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNumeroIdentificacion.HideSelection = true;
            txtNumeroIdentificacion.LeadingIcon = null;
            txtNumeroIdentificacion.Location = new Point(211, 13);
            txtNumeroIdentificacion.Margin = new Padding(3, 2, 3, 2);
            txtNumeroIdentificacion.MaxLength = 32767;
            txtNumeroIdentificacion.MouseState = MaterialSkin.MouseState.OUT;
            txtNumeroIdentificacion.Name = "txtNumeroIdentificacion";
            txtNumeroIdentificacion.PasswordChar = '\0';
            txtNumeroIdentificacion.PrefixSuffixText = null;
            txtNumeroIdentificacion.ReadOnly = false;
            txtNumeroIdentificacion.RightToLeft = RightToLeft.No;
            txtNumeroIdentificacion.SelectedText = "";
            txtNumeroIdentificacion.SelectionLength = 0;
            txtNumeroIdentificacion.SelectionStart = 0;
            txtNumeroIdentificacion.ShortcutsEnabled = true;
            txtNumeroIdentificacion.Size = new Size(225, 48);
            txtNumeroIdentificacion.TabIndex = 14;
            txtNumeroIdentificacion.TabStop = false;
            txtNumeroIdentificacion.TextAlign = HorizontalAlignment.Left;
            txtNumeroIdentificacion.TrailingIcon = null;
            txtNumeroIdentificacion.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(44, 30);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(161, 19);
            materialLabel7.TabIndex = 13;
            materialLabel7.Text = "Numero Identificacion:";
            // 
            // FrmConsultarDocente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 518);
            Controls.Add(materialCard1);
            Controls.Add(tablaDocentes);
            Controls.Add(materialLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConsultarDocente";
            Text = "FrmConsultarDocente";
            ((System.ComponentModel.ISupportInitialize)tablaDocentes).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DataGridView tablaDocentes;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txtNumeroIdentificacion;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}