using System;
using System.Globalization;

namespace AumentoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoDeAumento valor = new CalculoDeAumento();

            Console.WriteLine("Entre com o seu salario: ");
            valor.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valor.Calculo();
        }
    }
}
