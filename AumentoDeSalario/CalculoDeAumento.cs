using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AumentoDeSalario
{
    class CalculoDeAumento
    {
        public double Salario;
        public double Total;
        public double ValorAumento;

        public void Calculo()
        {
            if (Salario <= 400.00)
            {
                Total = Salario + Salario * 0.15;
                ValorAumento = Total - Salario;
                Console.WriteLine("Novo salario: " + Total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ValorAumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual : 15%");

            }
            else if (Salario <= 800.00)
            {
                Total = Salario + Salario * 0.12;
                ValorAumento = Total - Salario;
                Console.WriteLine("Novo salario: " + Total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ValorAumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual : 12%");

            }
            else if (Salario <= 1200.00)
            {
                Total = Salario + Salario * 0.10;
                ValorAumento = Total - Salario;
                Console.WriteLine("Novo salario: " + Total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ValorAumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual : 10%");

            }
            else if (Salario <= 2000.00)
            {
                Total = Salario + Salario * 0.07;
                ValorAumento = Total - Salario;
                Console.WriteLine("Novo salario: " + Total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ValorAumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual : 7%");

            }
            else if(Salario >= 2000.01)
            {
                Total = Salario + Salario * 0.04;
                ValorAumento = Total - Salario;
                Console.WriteLine("Novo salario: " + Total.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + ValorAumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual : 4%");
            }
            else { }
        }
    }

}
