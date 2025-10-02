using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class CuentaDeAhorro
    {
        private int saldo;
        private string nom;

        public void setSaldo(int saldo)
        {
            this.saldo = saldo;
        }
        public int getSaldo()
        {
            return this.saldo;
        }
        public void deposito(int monto)
        {
            saldo += monto;
        }
        public void retiro(int monto)
        {
            saldo -= monto;
        }
        public bool puedeEliminar(int monto)
        {
            int saldoTeorico = saldo;
            return (saldoTeorico - monto) > -1;
        }
        public string getNom()
        {
            return nom;
        }
        public void setNom(string nom) { this.nom = nom; }
    }
}
