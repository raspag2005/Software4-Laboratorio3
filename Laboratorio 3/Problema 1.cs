using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    public partial class Problema1 : Form
    {
        public Problema1()
        {
            InitializeComponent();
        }
        CuentaDeAhorro clase = new CuentaDeAhorro();

        public void setSaldoActual()
        {
            txtSaldoActual.Text = clase.getSaldo().ToString();
        }
        private void btnAbrirCuenta_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMontoInicial.Text, out int montoInicial))
            {
                if (montoInicial > 0)
                {
                    if (! String.IsNullOrEmpty(txtNom.Text))
                    {
                        lblError1.Visible = false;
                        btnAbrirCuenta.Enabled = false;
                        txtNom.Enabled = false;
                        txtMontoInicial.Enabled = false;
                        rdbDepositos.Enabled = true;
                        rdbRetiros.Enabled = true;
                        txtMonto.Enabled = true;
                        btnNuevo.Enabled = true;
                        clase.setSaldo(montoInicial);
                        clase.setNom(txtNom.Text);
                        setSaldoActual();
                    } else
                    {
                        lblError1.Text = "El Cliente debe tener nombre!";
                        lblError1.Visible = true;
                    }
                } else
                {
                    lblError1.Text = "Monto Inicial debe ser un monto positivo!";
                    lblError1.Visible = true;
                }
            } else
            {
                lblError1.Text = "Monto Inicial debe ser un número!";
                lblError1.Visible = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMonto.Text, out int monto) && monto > 0)
            {
                lblError4.Visible = false;
                lblError3.Visible = false;
                lblError2.Visible = false;
                if (rdbRetiros.Checked)
                {
                    if(monto <= clase.getSaldo())
                    {
                        lstRetiros.Items.Add(txtMonto.Text);
                        clase.retiro(monto);
                        setSaldoActual();
                    } else
                    {
                        lblError2.Text = "Monto retirado no puede ser mayor que tu Saldo Actual!";
                        lblError2.Visible = true;
                    }
                }
                else if (rdbDepositos.Checked)
                {
                    lstDepositos.Items.Add(txtMonto.Text);
                    clase.deposito(monto);
                    setSaldoActual();
                }
                else {
                    lblError3.Text = "No puedes hacer una nueva transacción sin elegir que tipo será!";
                    lblError3.Visible = true; 
                }
            }
            else
            {
                lblError4.Visible = false;
                lblError3.Visible = false;
                lblError2.Text = "El Monto puesto debe ser un número válido!";
                lblError2.Visible = true;
            }
        }
        private void lstRetiros_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine(lstRetiros.SelectedItem.ToString());
            if (int.TryParse(lstRetiros.SelectedItem.ToString(), out int monto))
            {
                lblError3.Visible = false;
                lblError2.Visible = false;
                    lblError4.Visible = false;
                    lstRetiros.Items.RemoveAt(lstRetiros.SelectedIndex);
                    clase.deposito(monto);
                    setSaldoActual();
            }
            else MessageBox.Show("Yo no sé que hiciestes. Pero es un error", "ERROR..??", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lstDepositos_DoubleClick(object sender, EventArgs e)
        {
            if (Int32.TryParse(lstDepositos.SelectedItem.ToString(), out int monto))
            {
                lblError3.Visible = false;
                lblError2.Visible = false;
                if (clase.puedeEliminar(monto))
                {
                    lblError4.Visible = false;
                    lstDepositos.Items.Remove(lstDepositos.SelectedItem);
                    clase.retiro(monto);
                    setSaldoActual();
                }
                else
                {
                    lblError4.Visible = true;
                }
            }
            else MessageBox.Show("Yo no sé que hiciestes. Pero es un error", "ERROR..??", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
