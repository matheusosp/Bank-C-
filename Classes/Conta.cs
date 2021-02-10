using Bank.Enum;

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
    }
}