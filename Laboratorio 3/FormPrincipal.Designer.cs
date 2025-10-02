namespace Laboratorio_3
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.Problema1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Problema2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Problema3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Problema4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.mnuPrincipal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Problema1,
            this.Problema2,
            this.Problema3,
            this.Problema4});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // Problema1
            // 
            this.Problema1.Name = "Problema1";
            this.Problema1.Size = new System.Drawing.Size(73, 20);
            this.Problema1.Text = "1. Ahorros";
            this.Problema1.Click += new System.EventHandler(this.Problema1_Click);
            // 
            // Problema2
            // 
            this.Problema2.Name = "Problema2";
            this.Problema2.Size = new System.Drawing.Size(153, 20);
            this.Problema2.Text = "2. DataGridView de Nums";
            this.Problema2.Click += new System.EventHandler(this.Problema2_Click);
            // 
            // Problema3
            // 
            this.Problema3.Name = "Problema3";
            this.Problema3.Size = new System.Drawing.Size(78, 20);
            this.Problema3.Text = "3. Importes";
            this.Problema3.Click += new System.EventHandler(this.Problema3_Click);
            // 
            // Problema4
            // 
            this.Problema4.Name = "Problema4";
            this.Problema4.Size = new System.Drawing.Size(71, 20);
            this.Problema4.Text = "4. Usuario";
            this.Problema4.Click += new System.EventHandler(this.Problema4_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FormPrincipal";
            this.Text = "Lab 3";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem Problema1;
        private System.Windows.Forms.ToolStripMenuItem Problema2;
        private System.Windows.Forms.ToolStripMenuItem Problema3;
        private System.Windows.Forms.ToolStripMenuItem Problema4;
    }
}

