using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" - Start - ");

            ContaCorrente contaDaCamila = new ContaCorrente(867, 86712540);

            contaDaCamila.Titular = new Cliente();

            contaDaCamila.Titular.Nome = "Camila";

            Console.WriteLine(contaDaCamila.Titular.Nome);
        }
    }
}
