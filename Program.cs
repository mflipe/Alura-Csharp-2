using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" - Start - ");

            ContaCorrente primeiraContaCorrente = new ContaCorrente();
            primeiraContaCorrente.saldo = 200;
            Console.WriteLine(primeiraContaCorrente.saldo);

            primeiraContaCorrente.saldo += 100;
            Console.WriteLine(primeiraContaCorrente.saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente();
            segundaContaCorrente.saldo = 50;

            Console.WriteLine("primeira conta tem " + primeiraContaCorrente.saldo);
            Console.WriteLine("segunda conta tem " + segundaContaCorrente.saldo);

            Console.ReadLine();
        }
    }
}
