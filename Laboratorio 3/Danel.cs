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
        int numerosRandom;
        int elNum;
        List<int> listDNum = new List<int>();

        // método para crear listas 
        public void addCeldas(int elNum)
        {
            numerosRandom = numRand.Next(1,20);
            if (elNum == 0) // Se le pregunta al usuario si desea que las celdas se hagan aleatorias
            {
                for (int i = 0; i <= numerosRandom; i ++) {
                    listDNum.Add(numerosRandom); }                
            }
            else { for (int i = 0; i < 20; i++)
                    listDNum.Add(elNum); } // el usuario coloca los valores manualmente

        }
        public string delNumEnCelda (int elNum) //Método para elminar un número de la lista
        {
            string texto =""; 
            for (int i = 0; i <= listDNum.Count; i++) //recorre la lista y si encuentra el número lo borra
                if (listDNum.Contains(elNum)) 
                    {  
                    listDNum.Remove(elNum);
                  texto = "Número eliminado";  
                }
            else { texto = "No se encontró el número"; }
            return texto; 
        }
    }
}
