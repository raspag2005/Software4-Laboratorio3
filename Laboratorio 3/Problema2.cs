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
        public Problema2()
        {
            InitializeComponent();
        }

        private void Problema2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dn.addCeldas()
        }
    }
}
 