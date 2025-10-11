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
    public partial class Problema2 : Form
    {
        Danel dn = new Danel();
        int i, fila, columna;
        double nuevoNumero;
        public Problema2()
        {
            InitializeComponent();
        }

        private void Problema2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnRANDOM_Click(object sender, EventArgs e)
        {
            nuevoNumero = dn.randomNumeros();
            int nuevaColumna = dataGridView1.Columns.Count;
            dataGridView1.Columns.Add($"Columna{nuevaColumna}", $"Posición {nuevaColumna}");
            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView1.Rows.Add();
            }
            dataGridView1.Rows[0].Cells[nuevaColumna].Value = nuevoNumero.ToString();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double num;
            if (double.TryParse(txtNumero.Text, out num))
            {
                num = dn.addNumeros(num);
                int nuevaColumna = dataGridView1.Columns.Count;
                dataGridView1.Columns.Add($"Columna{nuevaColumna}", $"Posición {nuevaColumna}");
                if (dataGridView1.Rows.Count == 0)
                {
                    dataGridView1.Rows.Add();
                }
                dataGridView1.Rows[0].Cells[nuevaColumna].Value = num.ToString();

            }
            else
            {
                MessageBox.Show("Ingrese un número válido.No se permiten letras");
            }
            txtNumero.Clear();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            double num;
            if (double.TryParse(txtEliminarNum.Text, out num))
            {
                bool eliminado = false;
                for (int i = dn.listDNum.Count - 1; i >= 0; i--)
                {
                    if (dn.listDNum[i] == num)
                    {
                        dn.listDNum.RemoveAt(i);
                        eliminado = true;
                        if (i < dataGridView1.Columns.Count)
                            dataGridView1.Columns.RemoveAt(i);
                    }
                }
                if (eliminado)
                    MessageBox.Show($"Número(s) {num} eliminado(s) correctamente.");
                else
                    MessageBox.Show("El número no se encuentra en la lista.");
                txtEliminarNum.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un número válido para eliminar. No se permiten letras.");
            }
        }
    }
}

 