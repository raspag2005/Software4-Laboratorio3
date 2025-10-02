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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Problema1_Click(object sender, EventArgs e)
        {
            Problema1 prob1 = new Problema1();
            prob1.MdiParent = this;
            prob1.WindowState = FormWindowState.Maximized;
            prob1.Show();
        }

        private void Problema2_Click(object sender, EventArgs e)
        {
            Problema2 prob2 = new Problema2();
            prob2.MdiParent = this;
            prob2.WindowState = FormWindowState.Maximized;
            prob2.Show();
        }

        private void Problema3_Click(object sender, EventArgs e)
        {
            Problema3 prob3 = new Problema3();
            prob3.MdiParent = this;
            prob3.WindowState = FormWindowState.Maximized;
            prob3.Show();
        }

        private void Problema4_Click(object sender, EventArgs e)
        {
            Problema4 prob4 = new Problema4();
            prob4.MdiParent = this;
            prob4.WindowState = FormWindowState.Maximized;
            prob4.Show();
        }
    }
}
