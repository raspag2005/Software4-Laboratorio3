namespace Laboratorio_3
{
    partial class Problema3
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMostar = new System.Windows.Forms.Button();
            this.dgvMyM = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIformacion = new System.Windows.Forms.Label();
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.lblCantVV = new System.Windows.Forms.Label();
            this.numCant = new System.Windows.Forms.NumericUpDown();
            this.lblCantV = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnMostar);
            this.panel1.Controls.Add(this.dgvMyM);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblIformacion);
            this.panel1.Controls.Add(this.txtVentas);
            this.panel1.Controls.Add(this.lblCantVV);
            this.panel1.Controls.Add(this.numCant);
            this.panel1.Controls.Add(this.lblCantV);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(61, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 510);
            this.panel1.TabIndex = 2;
            // 
            // btnMostar
            // 
            this.btnMostar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMostar.Location = new System.Drawing.Point(684, 385);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(87, 33);
            this.btnMostar.TabIndex = 10;
            this.btnMostar.Text = "Mostar";
            this.btnMostar.UseVisualStyleBackColor = false;
            this.btnMostar.Click += new System.EventHandler(this.btnMostar_Click);
            // 
            // dgvMyM
            // 
            this.dgvMyM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyM.Location = new System.Drawing.Point(335, 312);
            this.dgvMyM.Name = "dgvMyM";
            this.dgvMyM.RowHeadersWidth = 51;
            this.dgvMyM.RowTemplate.Height = 24;
            this.dgvMyM.Size = new System.Drawing.Size(324, 195);
            this.dgvMyM.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAgregar.Location = new System.Drawing.Point(519, 240);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 26);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIformacion
            // 
            this.lblIformacion.AutoSize = true;
            this.lblIformacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIformacion.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIformacion.ForeColor = System.Drawing.Color.Red;
            this.lblIformacion.Location = new System.Drawing.Point(106, 221);
            this.lblIformacion.Name = "lblIformacion";
            this.lblIformacion.Size = new System.Drawing.Size(311, 23);
            this.lblIformacion.TabIndex = 7;
            this.lblIformacion.Text = "*Solo puede colocar valores entre 75 a 215*";
            this.lblIformacion.Click += new System.EventHandler(this.lblIformacion_Click);
            // 
            // txtVentas
            // 
            this.txtVentas.BackColor = System.Drawing.SystemColors.Info;
            this.txtVentas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtVentas.Location = new System.Drawing.Point(506, 200);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(100, 22);
            this.txtVentas.TabIndex = 6;
            // 
            // lblCantVV
            // 
            this.lblCantVV.AutoSize = true;
            this.lblCantVV.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantVV.Location = new System.Drawing.Point(105, 191);
            this.lblCantVV.Name = "lblCantVV";
            this.lblCantVV.Size = new System.Drawing.Size(332, 30);
            this.lblCantVV.TabIndex = 5;
            this.lblCantVV.Text = "Ingrese el valor de la venta realizada";
            // 
            // numCant
            // 
            this.numCant.Location = new System.Drawing.Point(506, 103);
            this.numCant.Name = "numCant";
            this.numCant.Size = new System.Drawing.Size(102, 22);
            this.numCant.TabIndex = 4;
            this.numCant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCant.ValueChanged += new System.EventHandler(this.numCant_ValueChanged);
            // 
            // lblCantV
            // 
            this.lblCantV.AutoSize = true;
            this.lblCantV.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantV.Location = new System.Drawing.Point(106, 97);
            this.lblCantV.Name = "lblCantV";
            this.lblCantV.Size = new System.Drawing.Size(357, 30);
            this.lblCantV.TabIndex = 3;
            this.lblCantV.Text = "Ingrese la cantidad de ventas realizadas";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(326, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 49);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Registro de ventas";
            // 
            // Problema3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Problema3";
            this.Text = "Problema3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown numCant;
        private System.Windows.Forms.Label lblCantV;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIformacion;
        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.Label lblCantVV;
        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.DataGridView dgvMyM;
    }
}