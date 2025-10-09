namespace Laboratorio_3
{
    partial class Problema1
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMontoInicial = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMontoInicial = new System.Windows.Forms.TextBox();
            this.btnAbrirCuenta = new System.Windows.Forms.Button();
            this.grpTransacciones = new System.Windows.Forms.GroupBox();
            this.lblError3 = new System.Windows.Forms.Label();
            this.rdbRetiros = new System.Windows.Forms.RadioButton();
            this.rdbDepositos = new System.Windows.Forms.RadioButton();
            this.grpDatosDeCuenta = new System.Windows.Forms.GroupBox();
            this.lblError1 = new System.Windows.Forms.Label();
            this.grpCuentaDeAhorros = new System.Windows.Forms.GroupBox();
            this.lblError2 = new System.Windows.Forms.Label();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.lstDepositos = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblRetiros = new System.Windows.Forms.Label();
            this.lblDepositos = new System.Windows.Forms.Label();
            this.lstRetiros = new System.Windows.Forms.ListBox();
            this.lblError4 = new System.Windows.Forms.Label();
            this.grpTransacciones.SuspendLayout();
            this.grpDatosDeCuenta.SuspendLayout();
            this.grpCuentaDeAhorros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(51, 28);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(69, 23);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Cliente:";
            // 
            // lblMontoInicial
            // 
            this.lblMontoInicial.AutoSize = true;
            this.lblMontoInicial.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoInicial.Location = new System.Drawing.Point(51, 67);
            this.lblMontoInicial.Name = "lblMontoInicial";
            this.lblMontoInicial.Size = new System.Drawing.Size(116, 23);
            this.lblMontoInicial.TabIndex = 2;
            this.lblMontoInicial.Text = "Monto Inicial:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(187, 31);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(146, 30);
            this.txtNom.TabIndex = 3;
            // 
            // txtMontoInicial
            // 
            this.txtMontoInicial.Location = new System.Drawing.Point(187, 70);
            this.txtMontoInicial.Name = "txtMontoInicial";
            this.txtMontoInicial.Size = new System.Drawing.Size(146, 30);
            this.txtMontoInicial.TabIndex = 4;
            // 
            // btnAbrirCuenta
            // 
            this.btnAbrirCuenta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnAbrirCuenta.Location = new System.Drawing.Point(397, 24);
            this.btnAbrirCuenta.Name = "btnAbrirCuenta";
            this.btnAbrirCuenta.Size = new System.Drawing.Size(155, 42);
            this.btnAbrirCuenta.TabIndex = 5;
            this.btnAbrirCuenta.Text = "Abrir Cuenta";
            this.btnAbrirCuenta.UseVisualStyleBackColor = true;
            this.btnAbrirCuenta.Click += new System.EventHandler(this.btnAbrirCuenta_Click);
            // 
            // grpTransacciones
            // 
            this.grpTransacciones.Controls.Add(this.lblError3);
            this.grpTransacciones.Controls.Add(this.rdbRetiros);
            this.grpTransacciones.Controls.Add(this.rdbDepositos);
            this.grpTransacciones.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.grpTransacciones.Location = new System.Drawing.Point(41, 130);
            this.grpTransacciones.Name = "grpTransacciones";
            this.grpTransacciones.Size = new System.Drawing.Size(594, 75);
            this.grpTransacciones.TabIndex = 7;
            this.grpTransacciones.TabStop = false;
            this.grpTransacciones.Text = "Transacciones";
            // 
            // lblError3
            // 
            this.lblError3.AutoSize = true;
            this.lblError3.BackColor = System.Drawing.Color.Transparent;
            this.lblError3.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError3.ForeColor = System.Drawing.Color.Red;
            this.lblError3.Location = new System.Drawing.Point(156, 57);
            this.lblError3.Name = "lblError3";
            this.lblError3.Size = new System.Drawing.Size(279, 14);
            this.lblError3.TabIndex = 12;
            this.lblError3.Text = "No puedes hacer una nueva transacción sin elegir que tipo será!";
            this.lblError3.Visible = false;
            // 
            // rdbRetiros
            // 
            this.rdbRetiros.AutoSize = true;
            this.rdbRetiros.Enabled = false;
            this.rdbRetiros.Location = new System.Drawing.Point(408, 29);
            this.rdbRetiros.Name = "rdbRetiros";
            this.rdbRetiros.Size = new System.Drawing.Size(83, 27);
            this.rdbRetiros.TabIndex = 1;
            this.rdbRetiros.TabStop = true;
            this.rdbRetiros.Text = "Retiros";
            this.rdbRetiros.UseVisualStyleBackColor = true;
            // 
            // rdbDepositos
            // 
            this.rdbDepositos.AutoSize = true;
            this.rdbDepositos.Enabled = false;
            this.rdbDepositos.Location = new System.Drawing.Point(99, 29);
            this.rdbDepositos.Name = "rdbDepositos";
            this.rdbDepositos.Size = new System.Drawing.Size(102, 27);
            this.rdbDepositos.TabIndex = 0;
            this.rdbDepositos.TabStop = true;
            this.rdbDepositos.Text = "Depósitos";
            this.rdbDepositos.UseVisualStyleBackColor = true;
            // 
            // grpDatosDeCuenta
            // 
            this.grpDatosDeCuenta.Controls.Add(this.lblError1);
            this.grpDatosDeCuenta.Controls.Add(this.lblNom);
            this.grpDatosDeCuenta.Controls.Add(this.lblMontoInicial);
            this.grpDatosDeCuenta.Controls.Add(this.btnAbrirCuenta);
            this.grpDatosDeCuenta.Controls.Add(this.txtNom);
            this.grpDatosDeCuenta.Controls.Add(this.txtMontoInicial);
            this.grpDatosDeCuenta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.grpDatosDeCuenta.Location = new System.Drawing.Point(41, 12);
            this.grpDatosDeCuenta.Name = "grpDatosDeCuenta";
            this.grpDatosDeCuenta.Size = new System.Drawing.Size(594, 113);
            this.grpDatosDeCuenta.TabIndex = 8;
            this.grpDatosDeCuenta.TabStop = false;
            this.grpDatosDeCuenta.Text = "Datos de Cuenta";
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.BackColor = System.Drawing.Color.Transparent;
            this.lblError1.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(397, 67);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(155, 14);
            this.lblError1.TabIndex = 6;
            this.lblError1.Text = "Monto Inicial debe ser un Número!";
            this.lblError1.Visible = false;
            // 
            // grpCuentaDeAhorros
            // 
            this.grpCuentaDeAhorros.Controls.Add(this.lblError4);
            this.grpCuentaDeAhorros.Controls.Add(this.lblError2);
            this.grpCuentaDeAhorros.Controls.Add(this.txtSaldoActual);
            this.grpCuentaDeAhorros.Controls.Add(this.lblSaldoActual);
            this.grpCuentaDeAhorros.Controls.Add(this.lstDepositos);
            this.grpCuentaDeAhorros.Controls.Add(this.btnNuevo);
            this.grpCuentaDeAhorros.Controls.Add(this.txtMonto);
            this.grpCuentaDeAhorros.Controls.Add(this.lblMonto);
            this.grpCuentaDeAhorros.Controls.Add(this.lblRetiros);
            this.grpCuentaDeAhorros.Controls.Add(this.lblDepositos);
            this.grpCuentaDeAhorros.Controls.Add(this.lstRetiros);
            this.grpCuentaDeAhorros.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.grpCuentaDeAhorros.Location = new System.Drawing.Point(41, 211);
            this.grpCuentaDeAhorros.Name = "grpCuentaDeAhorros";
            this.grpCuentaDeAhorros.Size = new System.Drawing.Size(594, 197);
            this.grpCuentaDeAhorros.TabIndex = 9;
            this.grpCuentaDeAhorros.TabStop = false;
            this.grpCuentaDeAhorros.Text = "Cuenta de Ahorros";
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.BackColor = System.Drawing.Color.Transparent;
            this.lblError2.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError2.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Location = new System.Drawing.Point(347, 180);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(247, 14);
            this.lblError2.TabIndex = 7;
            this.lblError2.Text = "Monto retirado no puede ser menor que tu Saldo Actual!";
            this.lblError2.Visible = false;
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.Location = new System.Drawing.Point(397, 44);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.ReadOnly = true;
            this.txtSaldoActual.Size = new System.Drawing.Size(146, 30);
            this.txtSaldoActual.TabIndex = 10;
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoActual.Location = new System.Drawing.Point(415, 18);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(114, 23);
            this.lblSaldoActual.TabIndex = 11;
            this.lblSaldoActual.Text = "Saldo Actual:";
            // 
            // lstDepositos
            // 
            this.lstDepositos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDepositos.FormattingEnabled = true;
            this.lstDepositos.ItemHeight = 18;
            this.lstDepositos.Location = new System.Drawing.Point(19, 55);
            this.lstDepositos.Name = "lstDepositos";
            this.lstDepositos.Size = new System.Drawing.Size(148, 130);
            this.lstDepositos.TabIndex = 9;
            this.lstDepositos.DoubleClick += new System.EventHandler(this.lstDepositos_DoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Enabled = false;
            this.btnNuevo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.Location = new System.Drawing.Point(393, 144);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(155, 36);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(397, 108);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(146, 30);
            this.txtMonto.TabIndex = 6;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(440, 82);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(63, 23);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "Monto:";
            // 
            // lblRetiros
            // 
            this.lblRetiros.AutoSize = true;
            this.lblRetiros.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiros.Location = new System.Drawing.Point(223, 26);
            this.lblRetiros.Name = "lblRetiros";
            this.lblRetiros.Size = new System.Drawing.Size(72, 23);
            this.lblRetiros.TabIndex = 7;
            this.lblRetiros.Text = "Retiros:";
            // 
            // lblDepositos
            // 
            this.lblDepositos.AutoSize = true;
            this.lblDepositos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositos.Location = new System.Drawing.Point(46, 26);
            this.lblDepositos.Name = "lblDepositos";
            this.lblDepositos.Size = new System.Drawing.Size(91, 23);
            this.lblDepositos.TabIndex = 6;
            this.lblDepositos.Text = "Depósitos:";
            // 
            // lstRetiros
            // 
            this.lstRetiros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRetiros.FormattingEnabled = true;
            this.lstRetiros.ItemHeight = 18;
            this.lstRetiros.Location = new System.Drawing.Point(187, 55);
            this.lstRetiros.Name = "lstRetiros";
            this.lstRetiros.Size = new System.Drawing.Size(148, 130);
            this.lstRetiros.TabIndex = 1;
            this.lstRetiros.DoubleClick += new System.EventHandler(this.lstRetiros_DoubleClick);
            // 
            // lblError4
            // 
            this.lblError4.AutoSize = true;
            this.lblError4.BackColor = System.Drawing.Color.Transparent;
            this.lblError4.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError4.ForeColor = System.Drawing.Color.Red;
            this.lblError4.Location = new System.Drawing.Point(32, 186);
            this.lblError4.Name = "lblError4";
            this.lblError4.Size = new System.Drawing.Size(292, 14);
            this.lblError4.TabIndex = 12;
            this.lblError4.Text = "No se puede eliminar el Monto porque dejaria el saldo debajo de 0!";
            this.lblError4.Visible = false;
            // 
            // Problema1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 420);
            this.Controls.Add(this.grpCuentaDeAhorros);
            this.Controls.Add(this.grpDatosDeCuenta);
            this.Controls.Add(this.grpTransacciones);
            this.Name = "Problema1";
            this.Text = "Problema1";
            this.grpTransacciones.ResumeLayout(false);
            this.grpTransacciones.PerformLayout();
            this.grpDatosDeCuenta.ResumeLayout(false);
            this.grpDatosDeCuenta.PerformLayout();
            this.grpCuentaDeAhorros.ResumeLayout(false);
            this.grpCuentaDeAhorros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMontoInicial;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMontoInicial;
        private System.Windows.Forms.Button btnAbrirCuenta;
        private System.Windows.Forms.GroupBox grpTransacciones;
        private System.Windows.Forms.GroupBox grpDatosDeCuenta;
        private System.Windows.Forms.RadioButton rdbRetiros;
        private System.Windows.Forms.RadioButton rdbDepositos;
        private System.Windows.Forms.GroupBox grpCuentaDeAhorros;
        private System.Windows.Forms.ListBox lstDepositos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblRetiros;
        private System.Windows.Forms.Label lblDepositos;
        private System.Windows.Forms.ListBox lstRetiros;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.Label lblError3;
        private System.Windows.Forms.Label lblError4;
    }
}