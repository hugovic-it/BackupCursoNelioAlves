using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex60
{
    internal class Conta{

        public int Numero { get; }
        public string Titular { get;  }
        public double Saldo { get; }
        public Conta(int numero, string titular){
            Numero = numero;
            Titular = titular;
        }
        public Conta(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }
        public override string ToString() {
            return  " Numero da conta: " + Numero + "\n " 
                +" Nome do titular: "+ Titular + " \n " 
                +" Saldo: " + Saldo;
        }
    }
}
