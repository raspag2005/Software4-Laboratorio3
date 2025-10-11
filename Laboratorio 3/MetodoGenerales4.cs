using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class MetodoGenerales4
    {
        public static bool CorreoValido(string correo)
        {
            if (string.IsNullOrWhiteSpace(correo))
                return false;

            int cantidadArroba, indiceArroba;
            cantidadArroba = correo.Split('@').Length - 1;
            if (cantidadArroba != 1)
                return false;


            indiceArroba = correo.IndexOf('@');
            if (indiceArroba < 1)
                return false;


            string[] terminacionesValidas = { "@gmail.com", "@hotmail.com", "@utp.ac.pa" };
            foreach (string term in terminacionesValidas)
            {
                if (correo.EndsWith(term, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }
        public static bool EsValida(string contraseña, out string mensaje)
        {
            mensaje = "";

            if (string.IsNullOrWhiteSpace(contraseña))
            {
                mensaje = "Campo obligatorio";
                return false;
            }

            if (contraseña.Length < 12)
            {
                mensaje = "Debe tener al menos 12 caracteres";
                return false;
            }

            if (!Regex.IsMatch(contraseña, @"[A-Z]"))
            {
                mensaje = "Debe tener al menos una letra mayúscula";
                return false;
            }

            if (!Regex.IsMatch(contraseña, @"\d"))
            {
                mensaje = "Debe tener al menos un dígito";
                return false;
            }

            if (!Regex.IsMatch(contraseña, @"[!@#$%^&*]"))
            {
                mensaje = "Debe tener al menos un carácter especial (!, @, #, $, %, ^, &, *)";
                return false;
            }
            return true;
        }
    }
}


