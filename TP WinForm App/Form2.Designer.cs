namespace TP_WinForm_App
{
    partial class ListadoPersonas
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.chbClasica = new System.Windows.Forms.CheckBox();
            this.chbTango = new System.Windows.Forms.CheckBox();
            this.chbSalsa = new System.Windows.Forms.CheckBox();
            this.chbMetal = new System.Windows.Forms.CheckBox();
            this.chbHardRock = new System.Windows.Forms.CheckBox();
            this.chbPop = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.labApellido = new System.Windows.Forms.Label();
            this.labFechaNac = new System.Windows.Forms.Label();
            this.labColor = new System.Windows.Forms.Label();
            this.cobColores = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.labEdad = new System.Windows.Forms.Label();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rbOtro);
            this.gb1.Controls.Add(this.rbHombre);
            this.gb1.Controls.Add(this.rbMujer);
            this.gb1.Location = new System.Drawing.Point(44, 137);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(373, 65);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Sexo";
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Location = new System.Drawing.Point(255, 30);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(45, 17);
            this.rbOtro.TabIndex = 2;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbOtro_CheckedChanged);
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(136, 30);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 1;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            this.rbHombre.CheckedChanged += new System.EventHandler(this.rbHombre_CheckedChanged);
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Checked = true;
            this.rbMujer.Location = new System.Drawing.Point(21, 30);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 0;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            this.rbMujer.CheckedChanged += new System.EventHandler(this.rbMujer_CheckedChanged);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.chbClasica);
            this.gb2.Controls.Add(this.chbTango);
            this.gb2.Controls.Add(this.chbSalsa);
            this.gb2.Controls.Add(this.chbMetal);
            this.gb2.Controls.Add(this.chbHardRock);
            this.gb2.Controls.Add(this.chbPop);
            this.gb2.Location = new System.Drawing.Point(44, 235);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(373, 100);
            this.gb2.TabIndex = 1;
            this.gb2.TabStop = false;
            this.gb2.Text = "Estilos Musicales";
            // 
            // chbClasica
            // 
            this.chbClasica.AutoSize = true;
            this.chbClasica.Location = new System.Drawing.Point(255, 66);
            this.chbClasica.Name = "chbClasica";
            this.chbClasica.Size = new System.Drawing.Size(60, 17);
            this.chbClasica.TabIndex = 7;
            this.chbClasica.Text = "Clásica";
            this.chbClasica.UseVisualStyleBackColor = true;
            this.chbClasica.CheckedChanged += new System.EventHandler(this.chbClasica_CheckedChanged);
            // 
            // chbTango
            // 
            this.chbTango.AutoSize = true;
            this.chbTango.Location = new System.Drawing.Point(141, 66);
            this.chbTango.Name = "chbTango";
            this.chbTango.Size = new System.Drawing.Size(57, 17);
            this.chbTango.TabIndex = 6;
            this.chbTango.Text = "Tango";
            this.chbTango.UseVisualStyleBackColor = true;
            this.chbTango.CheckedChanged += new System.EventHandler(this.chbTango_CheckedChanged);
            // 
            // chbSalsa
            // 
            this.chbSalsa.AutoSize = true;
            this.chbSalsa.Location = new System.Drawing.Point(26, 66);
            this.chbSalsa.Name = "chbSalsa";
            this.chbSalsa.Size = new System.Drawing.Size(52, 17);
            this.chbSalsa.TabIndex = 5;
            this.chbSalsa.Text = "Salsa";
            this.chbSalsa.UseVisualStyleBackColor = true;
            this.chbSalsa.CheckedChanged += new System.EventHandler(this.chbSalsa_CheckedChanged);
            // 
            // chbMetal
            // 
            this.chbMetal.AutoSize = true;
            this.chbMetal.Location = new System.Drawing.Point(255, 29);
            this.chbMetal.Name = "chbMetal";
            this.chbMetal.Size = new System.Drawing.Size(52, 17);
            this.chbMetal.TabIndex = 4;
            this.chbMetal.Text = "Metal";
            this.chbMetal.UseVisualStyleBackColor = true;
            this.chbMetal.CheckedChanged += new System.EventHandler(this.chbMetal_CheckedChanged);
            // 
            // chbHardRock
            // 
            this.chbHardRock.AutoSize = true;
            this.chbHardRock.Location = new System.Drawing.Point(141, 29);
            this.chbHardRock.Name = "chbHardRock";
            this.chbHardRock.Size = new System.Drawing.Size(75, 17);
            this.chbHardRock.TabIndex = 3;
            this.chbHardRock.Text = "HardRock";
            this.chbHardRock.UseVisualStyleBackColor = true;
            this.chbHardRock.CheckedChanged += new System.EventHandler(this.chbHardRock_CheckedChanged);
            // 
            // chbPop
            // 
            this.chbPop.AutoSize = true;
            this.chbPop.Checked = true;
            this.chbPop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPop.Location = new System.Drawing.Point(26, 29);
            this.chbPop.Name = "chbPop";
            this.chbPop.Size = new System.Drawing.Size(45, 17);
            this.chbPop.TabIndex = 2;
            this.chbPop.Text = "Pop";
            this.chbPop.UseVisualStyleBackColor = true;
            this.chbPop.CheckedChanged += new System.EventHandler(this.chbPop_CheckedChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(155, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(262, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(90, 13);
            this.labNombre.Name = "labNombre";
            this.labNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labNombre.Size = new System.Drawing.Size(47, 13);
            this.labNombre.TabIndex = 5;
            this.labNombre.Text = "Nombre:";
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Location = new System.Drawing.Point(90, 50);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(47, 13);
            this.labApellido.TabIndex = 6;
            this.labApellido.Text = "Apellido:";
            // 
            // labFechaNac
            // 
            this.labFechaNac.AutoSize = true;
            this.labFechaNac.Location = new System.Drawing.Point(41, 88);
            this.labFechaNac.Name = "labFechaNac";
            this.labFechaNac.Size = new System.Drawing.Size(96, 13);
            this.labFechaNac.TabIndex = 7;
            this.labFechaNac.Text = "Fecha Nacimiento:";
            // 
            // labColor
            // 
            this.labColor.AutoSize = true;
            this.labColor.Location = new System.Drawing.Point(47, 351);
            this.labColor.Name = "labColor";
            this.labColor.Size = new System.Drawing.Size(75, 13);
            this.labColor.TabIndex = 8;
            this.labColor.Text = "Color Favorito:";
            // 
            // cobColores
            // 
            this.cobColores.FormattingEnabled = true;
            this.cobColores.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Azul",
            "Naranja",
            "Morado",
            "Verde"});
            this.cobColores.Location = new System.Drawing.Point(123, 351);
            this.cobColores.Name = "cobColores";
            this.cobColores.Size = new System.Drawing.Size(294, 21);
            this.cobColores.TabIndex = 9;
            this.cobColores.SelectedIndexChanged += new System.EventHandler(this.cobColores_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(109, 390);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(238, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(446, 390);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(65, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(527, 390);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(155, 88);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(196, 20);
            this.dtpFechaNac.TabIndex = 14;
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.dtpFechaNac_ValueChanged);
            this.dtpFechaNac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaNac_KeyPress);
            // 
            // labEdad
            // 
            this.labEdad.AutoSize = true;
            this.labEdad.Location = new System.Drawing.Point(366, 95);
            this.labEdad.Name = "labEdad";
            this.labEdad.Size = new System.Drawing.Size(35, 13);
            this.labEdad.TabIndex = 15;
            this.labEdad.Text = "Edad:";
            this.labEdad.Click += new System.EventHandler(this.labEdad_Click);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersonas.Location = new System.Drawing.Point(446, 13);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(328, 359);
            this.dgvPersonas.TabIndex = 16;
            this.dgvPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_CellContentClick);
            // 
            // ListadoPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.labEdad);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cobColores);
            this.Controls.Add(this.labColor);
            this.Controls.Add(this.labFechaNac);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Name = "ListadoPersonas";
            this.Text = "ListadoPersonas";
            this.Load += new System.EventHandler(this.ListadoPersonas_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.CheckBox chbClasica;
        private System.Windows.Forms.CheckBox chbTango;
        private System.Windows.Forms.CheckBox chbSalsa;
        private System.Windows.Forms.CheckBox chbMetal;
        private System.Windows.Forms.CheckBox chbHardRock;
        private System.Windows.Forms.CheckBox chbPop;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.Label labFechaNac;
        private System.Windows.Forms.Label labColor;
        private System.Windows.Forms.ComboBox cobColores;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label labEdad;
        private System.Windows.Forms.DataGridView dgvPersonas;
    }
}