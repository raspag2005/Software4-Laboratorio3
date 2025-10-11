using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Ordenamiento
    {
        int cant;
        int[] ventas;
        int[] vecO;
        int cantV;
        int i = 0;
        public void set(int a)
        {
            cant = a;
            ventas = new int[cant];
            vecO = new int[cant];
        }
        public void setA(int b)
        {
            cantV = b;
            ventas[i] = cantV;
            i++;
        }
        public int[] VecOrd()
        {
            for (int i = 0; i < ventas.Length; i++)
            {
                vecO[i] = ventas[i];
            }
            for (int i = 0; i < vecO.Length - 1; i++)
            {
                for (int j = i + 1; j < vecO.Length; j++)
                {
                    if (vecO[i] > vecO[j])
                    {
                        int temp = vecO[i];
                        vecO[i] = vecO[j];
                        vecO[j] = temp;
                    }
                }
            }

            return vecO;
        }
        public int[] getVentas()
        {
            return ventas;
        }
    }
}
