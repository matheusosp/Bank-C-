using Bank.Enum;
using System;

namespace Bank.Classes
{
    public class Conta
    {
        private TipoConta tipoConta{ get; set; }
        private double saldo { get; set; }
        private double credito { get; set; }
        private string nome{ get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome){
            this.tipoConta = tipoConta;
            this.saldo = saldo;
            this.credito = credito;
            this.nome = nome;
        }
        public bool Sacar(double valorSaque){
            if(this.saldo - valorSaque < (this.credito*-1)){
                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }
            this.saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}",this.nome, this.saldo);
            return true;
        }

        public void Depositar(double valorDeposito){
            this.saldo += valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.nome, this.saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino){
            if(this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
        }

         
    }
}