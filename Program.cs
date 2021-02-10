using System;
using Bank.Classes;

namespace Bank
{
    class Program
    {
        static void Main(string[] args){
            Conta minhaConta = new Conta(Enum.TipoConta.PessoaFisica, 0, 0, "Eliezer Zarpelao");

            Console.WriteLine(minhaConta.ToString());
        }
    }   
}
