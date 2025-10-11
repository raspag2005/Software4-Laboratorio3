using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Danel
    {
        Random numRand = new Random();
       public List<double> listDNum = new List<double>();


        //Método para agregar nuevo nuevo random
        public double randomNumeros()
        {       
                listDNum.Add(numRand.Next(1, 20));
                return listDNum.Last();
        }
        public double addNumeros(double elNum)  // método para agregar número en la lista 
        {
                listDNum.Add(elNum);
                return listDNum.Last();
        }
        //Método para elminar un número de la lista
        public string deleteNum (double elNum) 
        {
            string texto = "";
            bool eliminado = false;
            for (int i = listDNum.Count - 1; i >= 0; i--)
            {
                if (listDNum[i] == elNum)
                {
                    listDNum.RemoveAt(i);
                    eliminado = true;
                }
            }

            if (eliminado)
                texto = "Número(s) eliminado(s)";
            else
                texto = "No se encontró el número";

            return texto;
        }
    }
}
