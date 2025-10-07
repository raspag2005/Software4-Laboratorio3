using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Laboratorio_3
{
    public partial class Problema4 : Form
    {
        private bool nombreValido = false;
        private bool apellidoValido = false;
        private bool correoValido = false;
        private bool contraseñaValida = false;


        private string nombre = "";
        private string apellido = "";
        public Problema4()
        {
            InitializeComponent();
            this.KeyPreview = true;
            button1.Enabled = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarEstadoBoton() {

            if(nombreValido && apellidoValido && correoValido && contraseñaValida) { 
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        } 
        

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    erp.SetError(txtNombre, "Campo obligatorio");
                    nombreValido = false;

                }
                else if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z]+$"))
                {
                    erp2.SetError(txtNombre, "Solo se permiten letras A-Z");
                    nombreValido= false;

                }
                else
                {
                    erp.SetError(txtNombre, "");
                    erp2.SetError(txtNombre, "");
                   nombreValido = true;
                }
            
           ActualizarEstadoBoton();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            bool esValido = MetodoGenerales4.CorreoValido(correo);

            if (string.IsNullOrWhiteSpace(correo))
            {
                erp.SetError(txtCorreo, "Campo obligatorio");
                correoValido = false;

            }
            else if (!esValido)
            {
                erp2.SetError(txtCorreo, "Correo inválido");
                correoValido = false;

            }
            else
            {
                erp.SetError(txtCorreo, "");
                erp2.SetError(txtCorreo, "");
                correoValido = true;
            }
           ActualizarEstadoBoton();
        }



        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            string mensaje;
            bool esValida = MetodoGenerales4.EsValida(txtContraseña.Text, out mensaje);

            if (!esValida) { 
            erp2.SetError(txtContraseña, mensaje);
              contraseñaValida = false; 
            }
            else{
                erp2.SetError(txtContraseña, "");
                contraseñaValida = true;

            }
            ActualizarEstadoBoton();
        }

       

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtApellido.Text))
            {
                erp.SetError(TxtApellido, "Campo obligatorio");
                apellidoValido = false;
            }
            else if (!Regex.IsMatch(TxtApellido.Text, @"^[a-zA-Z]+$"))
            {
                erp2.SetError(TxtApellido, "Solo se permiten letras A-Z");
                apellidoValido=false;
            }
            else
            {
                erp.SetError(TxtApellido, "");
                erp2.SetError(TxtApellido, "");
                apellidoValido=true;
            }
           ActualizarEstadoBoton();
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                MessageBox.Show("¡Esta es la frase secreta! ", "Simply lovely");
                e.SuppressKeyPress = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombreValido && apellidoValido && correoValido && contraseñaValida)
            {
                
                string nombre = txtNombre.Text.Trim();
                string apellido = TxtApellido.Text.Trim();
                MessageBox.Show($"Ingreso exitoso\nNombre: {nombre} Apellido: {apellido}", "Éxito");
            }
            else
            {
                
                MessageBox.Show("Por favor completa todos los campos correctamente", "Error");
            }
        }
    }
    }

