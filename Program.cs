using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" - Start - ");

            ContaCorrente contaDaCamila = new ContaCorrente();
            contaDaCamila.titular = new Cliente();
            contaDaCamila.titular.nome = "Camila";

            Console.WriteLine(contaDaCamila.titular.nome);
        }
    }
}
