namespace TP_WinForm_App
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeObjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDePersonasToolStripMenuItem,
            this.listadoDeObjetosToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // listadoDePersonasToolStripMenuItem
            // 
            this.listadoDePersonasToolStripMenuItem.Name = "listadoDePersonasToolStripMenuItem";
            this.listadoDePersonasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoDePersonasToolStripMenuItem.Text = "Listado de Personas";
            this.listadoDePersonasToolStripMenuItem.Click += new System.EventHandler(this.listadoDePersonasToolStripMenuItem_Click);
            // 
            // listadoDeObjetosToolStripMenuItem
            // 
            this.listadoDeObjetosToolStripMenuItem.Name = "listadoDeObjetosToolStripMenuItem";
            this.listadoDeObjetosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoDeObjetosToolStripMenuItem.Text = "Listado de Objetos";
            this.listadoDeObjetosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeObjetosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeObjetosToolStripMenuItem;
    }
}

