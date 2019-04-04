namespace TP_WinForm_App
{
    partial class ListadoObjetos
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
            this.labNomObj = new System.Windows.Forms.Label();
            this.txtNomObj = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.labCantReg1 = new System.Windows.Forms.Label();
            this.btnDerTodos = new System.Windows.Forms.Button();
            this.btnDerUno = new System.Windows.Forms.Button();
            this.btnIzqUno = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.labCantReg2 = new System.Windows.Forms.Label();
            this.listaUno = new System.Windows.Forms.ListBox();
            this.listaDos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labNomObj
            // 
            this.labNomObj.AutoSize = true;
            this.labNomObj.Location = new System.Drawing.Point(22, 35);
            this.labNomObj.Name = "labNomObj";
            this.labNomObj.Size = new System.Drawing.Size(81, 13);
            this.labNomObj.TabIndex = 0;
            this.labNomObj.Text = "Nombre Objeto:";
            // 
            // txtNomObj
            // 
            this.txtNomObj.Location = new System.Drawing.Point(109, 32);
            this.txtNomObj.Name = "txtNomObj";
            this.txtNomObj.Size = new System.Drawing.Size(146, 20);
            this.txtNomObj.TabIndex = 1;
            this.txtNomObj.TextChanged += new System.EventHandler(this.txtNomObj_TextChanged);
            this.txtNomObj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomObj_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(261, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // labCantReg1
            // 
            this.labCantReg1.AutoSize = true;
            this.labCantReg1.Location = new System.Drawing.Point(22, 402);
            this.labCantReg1.Name = "labCantReg1";
            this.labCantReg1.Size = new System.Drawing.Size(91, 13);
            this.labCantReg1.TabIndex = 4;
            this.labCantReg1.Text = "Cantidad registros";
            // 
            // btnDerTodos
            // 
            this.btnDerTodos.Location = new System.Drawing.Point(367, 68);
            this.btnDerTodos.Name = "btnDerTodos";
            this.btnDerTodos.Size = new System.Drawing.Size(75, 23);
            this.btnDerTodos.TabIndex = 5;
            this.btnDerTodos.Text = ">>";
            this.btnDerTodos.UseVisualStyleBackColor = true;
            this.btnDerTodos.Click += new System.EventHandler(this.btnDerTodos_Click);
            // 
            // btnDerUno
            // 
            this.btnDerUno.Location = new System.Drawing.Point(367, 110);
            this.btnDerUno.Name = "btnDerUno";
            this.btnDerUno.Size = new System.Drawing.Size(75, 23);
            this.btnDerUno.TabIndex = 6;
            this.btnDerUno.Text = ">";
            this.btnDerUno.UseVisualStyleBackColor = true;
            this.btnDerUno.Click += new System.EventHandler(this.btnDerUno_Click);
            // 
            // btnIzqUno
            // 
            this.btnIzqUno.Location = new System.Drawing.Point(367, 153);
            this.btnIzqUno.Name = "btnIzqUno";
            this.btnIzqUno.Size = new System.Drawing.Size(75, 23);
            this.btnIzqUno.TabIndex = 7;
            this.btnIzqUno.Text = "<";
            this.btnIzqUno.UseVisualStyleBackColor = true;
            this.btnIzqUno.Click += new System.EventHandler(this.btnIzqUno_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(367, 194);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "...";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // labCantReg2
            // 
            this.labCantReg2.AutoSize = true;
            this.labCantReg2.Location = new System.Drawing.Point(463, 402);
            this.labCantReg2.Name = "labCantReg2";
            this.labCantReg2.Size = new System.Drawing.Size(91, 13);
            this.labCantReg2.TabIndex = 10;
            this.labCantReg2.Text = "Cantidad registros";
            // 
            // listaUno
            // 
            this.listaUno.FormattingEnabled = true;
            this.listaUno.Location = new System.Drawing.Point(25, 68);
            this.listaUno.Name = "listaUno";
            this.listaUno.Size = new System.Drawing.Size(311, 316);
            this.listaUno.TabIndex = 11;
            this.listaUno.SelectedIndexChanged += new System.EventHandler(this.TextBox);
            // 
            // listaDos
            // 
            this.listaDos.FormattingEnabled = true;
            this.listaDos.Location = new System.Drawing.Point(466, 68);
            this.listaDos.Name = "listaDos";
            this.listaDos.Size = new System.Drawing.Size(311, 316);
            this.listaDos.TabIndex = 12;
            this.listaDos.SelectedIndexChanged += new System.EventHandler(this.TextBox);
            // 
            // ListadoObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaDos);
            this.Controls.Add(this.listaUno);
            this.Controls.Add(this.labCantReg2);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnIzqUno);
            this.Controls.Add(this.btnDerUno);
            this.Controls.Add(this.btnDerTodos);
            this.Controls.Add(this.labCantReg1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNomObj);
            this.Controls.Add(this.labNomObj);
            this.Name = "ListadoObjetos";
            this.Text = "ListadoObjetos";
            this.Load += new System.EventHandler(this.ListadoObjetos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNomObj;
        private System.Windows.Forms.TextBox txtNomObj;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label labCantReg1;
        private System.Windows.Forms.Button btnDerTodos;
        private System.Windows.Forms.Button btnDerUno;
        private System.Windows.Forms.Button btnIzqUno;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label labCantReg2;
        private System.Windows.Forms.ListBox listaUno;
        private System.Windows.Forms.ListBox listaDos;
    }
}