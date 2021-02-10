using System;
using Bank.Classes;

namespace Bank
{
    class Program
    {
        static void Main(string[] args){
            Conta minhaConta = new Conta();
            minhaConta.Nome="teste";
            Console.WriteLine(minhaConta.Nome);
        }
    }
}
