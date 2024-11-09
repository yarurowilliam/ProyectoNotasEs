namespace Presentacion.GestionDocenteModule
{
    partial class FrmModificarDocente
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
            isPracticante = new MaterialSkin.Controls.MaterialCheckbox();
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            btnModificar = new MaterialSkin.Controls.MaterialButton();
            txtDireccion = new MaterialSkin.Controls.MaterialTextBox2();
            txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
            txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            txtPrimerApellido = new MaterialSkin.Controls.MaterialTextBox2();
            txtPrimerNombre = new MaterialSkin.Controls.MaterialTextBox2();
            comboTipoIdentificacion = new MaterialSkin.Controls.MaterialComboBox();
            pickerFechaNacimiento = new DateTimePicker();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            txtSegundoApellido = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            txtSegundoNombre = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            txtNumeroIdentificacion = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            cardInfo1.SuspendLayout();
            SuspendLayout();
            // 
            // cardInfo1
            // 
            cardInfo1.BackColor = Color.FromArgb(255, 255, 255);
            cardInfo1.Controls.Add(BtnBuscar);
            cardInfo1.Controls.Add(isPracticante);
            cardInfo1.Controls.Add(btnLimpiar);
            cardInfo1.Controls.Add(btnModificar);
            cardInfo1.Controls.Add(txtDireccion);
            cardInfo1.Controls.Add(txtCorreo);
            cardInfo1.Controls.Add(txtTelefono);
            cardInfo1.Controls.Add(materialLabel12);
            cardInfo1.Controls.Add(materialLabel11);
            cardInfo1.Controls.Add(materialLabel10);
            cardInfo1.Controls.Add(txtPrimerApellido);
            cardInfo1.Controls.Add(txtPrimerNombre);
            cardInfo1.Controls.Add(comboTipoIdentificacion);
            cardInfo1.Controls.Add(pickerFechaNacimiento);
            cardInfo1.Controls.Add(materialLabel9);
            cardInfo1.Controls.Add(txtSegundoApellido);
            cardInfo1.Controls.Add(materialLabel6);
            cardInfo1.Controls.Add(materialLabel8);
            cardInfo1.Controls.Add(txtSegundoNombre);
            cardInfo1.Controls.Add(materialLabel2);
            cardInfo1.Controls.Add(txtNumeroIdentificacion);
            cardInfo1.Controls.Add(materialLabel7);
            cardInfo1.Controls.Add(materialLabel5);
            cardInfo1.Controls.Add(materialLabel3);
            cardInfo1.Controls.Add(materialLabel4);
            cardInfo1.Depth = 0;
            cardInfo1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardInfo1.Location = new Point(12, 34);
            cardInfo1.Margin = new Padding(12, 10, 12, 10);
            cardInfo1.MouseState = MaterialSkin.MouseState.HOVER;
            cardInfo1.Name = "cardInfo1";
            cardInfo1.Padding = new Padding(12, 10, 12, 10);
            cardInfo1.Size = new Size(964, 438);
            cardInfo1.TabIndex = 11;
            // 
            // BtnBuscar
            // 
            BtnBuscar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnBuscar.Depth = 0;
            BtnBuscar.HighEmphasis = true;
            BtnBuscar.Icon = null;
            BtnBuscar.Location = new Point(851, 23);
            BtnBuscar.Margin = new Padding(4);
            BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.NoAccentTextColor = Color.Empty;
            BtnBuscar.Size = new Size(64, 36);
            BtnBuscar.TabIndex = 27;
            BtnBuscar.Text = "🔎";
            BtnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnBuscar.UseAccentColor = false;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // isPracticante
            // 
            isPracticante.AutoSize = true;
            isPracticante.Depth = 0;
            isPracticante.Location = new Point(590, 310);
            isPracticante.Margin = new Padding(0);
            isPracticante.MouseLocation = new Point(-1, -1);
            isPracticante.MouseState = MaterialSkin.MouseState.HOVER;
            isPracticante.Name = "isPracticante";
            isPracticante.ReadOnly = false;
            isPracticante.Ripple = true;
            isPracticante.Size = new Size(115, 37);
            isPracticante.TabIndex = 26;
            isPracticante.Text = "Practicante";
            isPracticante.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.BackColor = Color.Red;
            btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiar.Depth = 0;
            btnLimpiar.HighEmphasis = true;
            btnLimpiar.Icon = null;
            btnLimpiar.Location = new Point(368, 384);
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
            // btnModificar
            // 
            btnModificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificar.Depth = 0;
            btnModificar.HighEmphasis = true;
            btnModificar.Icon = null;
            btnModificar.Location = new Point(480, 384);
            btnModificar.Margin = new Padding(4);
            btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            btnModificar.Name = "btnModificar";
            btnModificar.NoAccentTextColor = Color.Empty;
            btnModificar.Size = new Size(88, 36);
            btnModificar.TabIndex = 24;
            btnModificar.Text = "MODIFICAR";
            btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificar.UseAccentColor = false;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.AnimateReadOnly = false;
            txtDireccion.BackgroundImageLayout = ImageLayout.None;
            txtDireccion.CharacterCasing = CharacterCasing.Normal;
            txtDireccion.Depth = 0;
            txtDireccion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDireccion.HideSelection = true;
            txtDireccion.LeadingIcon = null;
            txtDireccion.Location = new Point(195, 303);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.MaxLength = 32767;
            txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PasswordChar = '\0';
            txtDireccion.PrefixSuffixText = null;
            txtDireccion.ReadOnly = false;
            txtDireccion.RightToLeft = RightToLeft.No;
            txtDireccion.SelectedText = "";
            txtDireccion.SelectionLength = 0;
            txtDireccion.SelectionStart = 0;
            txtDireccion.ShortcutsEnabled = true;
            txtDireccion.Size = new Size(254, 48);
            txtDireccion.TabIndex = 23;
            txtDireccion.TabStop = false;
            txtDireccion.TextAlign = HorizontalAlignment.Left;
            txtDireccion.TrailingIcon = null;
            txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtCorreo
            // 
            txtCorreo.AnimateReadOnly = false;
            txtCorreo.BackgroundImageLayout = ImageLayout.None;
            txtCorreo.CharacterCasing = CharacterCasing.Normal;
            txtCorreo.Depth = 0;
            txtCorreo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCorreo.HideSelection = true;
            txtCorreo.LeadingIcon = null;
            txtCorreo.Location = new Point(658, 244);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.MaxLength = 32767;
            txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PasswordChar = '\0';
            txtCorreo.PrefixSuffixText = null;
            txtCorreo.ReadOnly = false;
            txtCorreo.RightToLeft = RightToLeft.No;
            txtCorreo.SelectedText = "";
            txtCorreo.SelectionLength = 0;
            txtCorreo.SelectionStart = 0;
            txtCorreo.ShortcutsEnabled = true;
            txtCorreo.Size = new Size(255, 48);
            txtCorreo.TabIndex = 22;
            txtCorreo.TabStop = false;
            txtCorreo.TextAlign = HorizontalAlignment.Left;
            txtCorreo.TrailingIcon = null;
            txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.BackgroundImageLayout = ImageLayout.None;
            txtTelefono.CharacterCasing = CharacterCasing.Normal;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.HideSelection = true;
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(195, 244);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.MaxLength = 32767;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.PrefixSuffixText = null;
            txtTelefono.ReadOnly = false;
            txtTelefono.RightToLeft = RightToLeft.No;
            txtTelefono.SelectedText = "";
            txtTelefono.SelectionLength = 0;
            txtTelefono.SelectionStart = 0;
            txtTelefono.ShortcutsEnabled = true;
            txtTelefono.Size = new Size(254, 48);
            txtTelefono.TabIndex = 21;
            txtTelefono.TabStop = false;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.TrailingIcon = null;
            txtTelefono.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(100, 312);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(71, 19);
            materialLabel12.TabIndex = 19;
            materialLabel12.Text = "Direccion:";
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(590, 249);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(51, 19);
            materialLabel11.TabIndex = 18;
            materialLabel11.Text = "Correo:";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(104, 249);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(68, 19);
            materialLabel10.TabIndex = 17;
            materialLabel10.Text = "Telefono:";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.AnimateReadOnly = false;
            txtPrimerApellido.BackgroundImageLayout = ImageLayout.None;
            txtPrimerApellido.CharacterCasing = CharacterCasing.Normal;
            txtPrimerApellido.Depth = 0;
            txtPrimerApellido.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrimerApellido.HideSelection = true;
            txtPrimerApellido.LeadingIcon = null;
            txtPrimerApellido.Location = new Point(195, 132);
            txtPrimerApellido.Margin = new Padding(3, 2, 3, 2);
            txtPrimerApellido.MaxLength = 32767;
            txtPrimerApellido.MouseState = MaterialSkin.MouseState.OUT;
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.PasswordChar = '\0';
            txtPrimerApellido.PrefixSuffixText = null;
            txtPrimerApellido.ReadOnly = false;
            txtPrimerApellido.RightToLeft = RightToLeft.No;
            txtPrimerApellido.SelectedText = "";
            txtPrimerApellido.SelectionLength = 0;
            txtPrimerApellido.SelectionStart = 0;
            txtPrimerApellido.ShortcutsEnabled = true;
            txtPrimerApellido.Size = new Size(254, 48);
            txtPrimerApellido.TabIndex = 14;
            txtPrimerApellido.TabStop = false;
            txtPrimerApellido.TextAlign = HorizontalAlignment.Left;
            txtPrimerApellido.TrailingIcon = null;
            txtPrimerApellido.UseSystemPasswordChar = false;
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
            txtPrimerNombre.Location = new Point(195, 75);
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
            // comboTipoIdentificacion
            // 
            comboTipoIdentificacion.AutoResize = false;
            comboTipoIdentificacion.BackColor = Color.FromArgb(255, 255, 255);
            comboTipoIdentificacion.Depth = 0;
            comboTipoIdentificacion.DrawMode = DrawMode.OwnerDrawVariable;
            comboTipoIdentificacion.DropDownHeight = 174;
            comboTipoIdentificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoIdentificacion.DropDownWidth = 121;
            comboTipoIdentificacion.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboTipoIdentificacion.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboTipoIdentificacion.FormattingEnabled = true;
            comboTipoIdentificacion.IntegralHeight = false;
            comboTipoIdentificacion.ItemHeight = 43;
            comboTipoIdentificacion.Items.AddRange(new object[] { "Cedula de Ciudadania", "Tarjeta de Identidad", "Cedula de Extranjeria", "Pasaporte" });
            comboTipoIdentificacion.Location = new Point(195, 15);
            comboTipoIdentificacion.Margin = new Padding(3, 2, 3, 2);
            comboTipoIdentificacion.MaxDropDownItems = 4;
            comboTipoIdentificacion.MouseState = MaterialSkin.MouseState.OUT;
            comboTipoIdentificacion.Name = "comboTipoIdentificacion";
            comboTipoIdentificacion.Size = new Size(254, 49);
            comboTipoIdentificacion.StartIndex = 0;
            comboTipoIdentificacion.TabIndex = 10;
            // 
            // pickerFechaNacimiento
            // 
            pickerFechaNacimiento.Location = new Point(513, 205);
            pickerFechaNacimiento.Margin = new Padding(3, 2, 3, 2);
            pickerFechaNacimiento.Name = "pickerFechaNacimiento";
            pickerFechaNacimiento.Size = new Size(253, 23);
            pickerFechaNacimiento.TabIndex = 16;
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
            // txtSegundoApellido
            // 
            txtSegundoApellido.AnimateReadOnly = false;
            txtSegundoApellido.BackgroundImageLayout = ImageLayout.None;
            txtSegundoApellido.CharacterCasing = CharacterCasing.Normal;
            txtSegundoApellido.Depth = 0;
            txtSegundoApellido.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSegundoApellido.HideSelection = true;
            txtSegundoApellido.LeadingIcon = null;
            txtSegundoApellido.Location = new Point(658, 132);
            txtSegundoApellido.Margin = new Padding(3, 2, 3, 2);
            txtSegundoApellido.MaxLength = 32767;
            txtSegundoApellido.MouseState = MaterialSkin.MouseState.OUT;
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.PasswordChar = '\0';
            txtSegundoApellido.PrefixSuffixText = null;
            txtSegundoApellido.ReadOnly = false;
            txtSegundoApellido.RightToLeft = RightToLeft.No;
            txtSegundoApellido.SelectedText = "";
            txtSegundoApellido.SelectionLength = 0;
            txtSegundoApellido.SelectionStart = 0;
            txtSegundoApellido.ShortcutsEnabled = true;
            txtSegundoApellido.Size = new Size(255, 48);
            txtSegundoApellido.TabIndex = 15;
            txtSegundoApellido.TabStop = false;
            txtSegundoApellido.TextAlign = HorizontalAlignment.Left;
            txtSegundoApellido.TrailingIcon = null;
            txtSegundoApellido.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(13, 23);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(158, 19);
            materialLabel6.TabIndex = 5;
            materialLabel6.Text = "Tipo de Identificacion:";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(293, 205);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(154, 19);
            materialLabel8.TabIndex = 7;
            materialLabel8.Text = "Fecha de Nacimiento:";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.AnimateReadOnly = false;
            txtSegundoNombre.BackgroundImageLayout = ImageLayout.None;
            txtSegundoNombre.CharacterCasing = CharacterCasing.Normal;
            txtSegundoNombre.Depth = 0;
            txtSegundoNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSegundoNombre.HideSelection = true;
            txtSegundoNombre.LeadingIcon = null;
            txtSegundoNombre.Location = new Point(658, 75);
            txtSegundoNombre.Margin = new Padding(3, 2, 3, 2);
            txtSegundoNombre.MaxLength = 32767;
            txtSegundoNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.PasswordChar = '\0';
            txtSegundoNombre.PrefixSuffixText = null;
            txtSegundoNombre.ReadOnly = false;
            txtSegundoNombre.RightToLeft = RightToLeft.No;
            txtSegundoNombre.SelectedText = "";
            txtSegundoNombre.SelectionLength = 0;
            txtSegundoNombre.SelectionStart = 0;
            txtSegundoNombre.ShortcutsEnabled = true;
            txtSegundoNombre.Size = new Size(255, 48);
            txtSegundoNombre.TabIndex = 13;
            txtSegundoNombre.TabStop = false;
            txtSegundoNombre.TextAlign = HorizontalAlignment.Left;
            txtSegundoNombre.TrailingIcon = null;
            txtSegundoNombre.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(60, 83);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(111, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Primer Nombre:";
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
            txtNumeroIdentificacion.Location = new Point(658, 15);
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
            txtNumeroIdentificacion.Size = new Size(186, 48);
            txtNumeroIdentificacion.TabIndex = 11;
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
            materialLabel7.Location = new Point(480, 23);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(161, 19);
            materialLabel7.TabIndex = 6;
            materialLabel7.Text = "Numero Identificacion:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(512, 144);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(129, 19);
            materialLabel5.TabIndex = 4;
            materialLabel5.Text = "Segundo Apellido:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(60, 144);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(112, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Primer Apellido:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(513, 83);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(128, 19);
            materialLabel4.TabIndex = 3;
            materialLabel4.Text = "Segundo Nombre:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(403, 7);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(165, 24);
            materialLabel1.TabIndex = 10;
            materialLabel1.Text = "Modificar Docente";
            // 
            // FrmModificarDocente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 479);
            Controls.Add(cardInfo1);
            Controls.Add(materialLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmModificarDocente";
            Text = "FrmModificarDocente";
            cardInfo1.ResumeLayout(false);
            cardInfo1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardInfo1;
        private MaterialSkin.Controls.MaterialButton BtnBuscar;
        private MaterialSkin.Controls.MaterialCheckbox isPracticante;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialTextBox2 txtDireccion;
        private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrimerApellido;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrimerNombre;
        private MaterialSkin.Controls.MaterialComboBox comboTipoIdentificacion;
        private DateTimePicker pickerFechaNacimiento;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 txtSegundoApellido;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox2 txtSegundoNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtNumeroIdentificacion;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}