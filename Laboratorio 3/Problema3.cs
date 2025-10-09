using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    public partial class Problema3 : Form
    {
        int[] ventas;
        int[] vecOr;
        int cant;
        int con = 0;
        Ordenamiento od = new Ordenamiento();
        public Problema3()
        {
            InitializeComponent();
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            ventas = od.getVentas();
            vecOr = od.VecOrd();
            for (int i = 0; i < ventas.Length; i++)
            {
                dgvMyM.Rows[i].Cells[0].Value = vecOr[i];
                dgvMyM.Rows[i].Cells[1].Value = ventas[i];
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantV;
            cantV = Convert.ToInt32(txtVentas.Text);
            if (cantV < 75 || cantV > 215)
            {
                MessageBox.Show("Solo se pueden introducir ventas desde 75 a 215");
                txtVentas.Clear();
                return;
            }
            else
            {
                od.setA(cantV);
            }
            txtVentas.Clear();
        }

        private void numCant_ValueChanged(object sender, EventArgs e)
        {
            cant = Convert.ToInt32(numCant.Value);
    
            if (cant < 1) {
                MessageBox.Show("No puede dejar este campo en 0");
                numCant.Value+= numCant.Value + 1;
                return;
            }
            else {
                ventas = new int[cant];
                vecOr = new int[cant];
                od.set(cant);
            }
            if (cant > 0)
            {
                dgvMyM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMyM.RowCount = cant;
                dgvMyM.ColumnCount = 2;
            }
        }

        private void lblIformacion_Click(object sender, EventArgs e)
        {

        }
    }
}
