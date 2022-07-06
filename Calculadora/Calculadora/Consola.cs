using System;
using System.Text.RegularExpressions;

namespace Calculadora
{

    public class Program
    {
        
        public static void selectOp()
        {
            Console.Out.WriteLine("Selecciona una operacion");
            Console.Out.WriteLine("1. Suma");
            Console.Out.WriteLine("2. resta");
            Console.Out.WriteLine("3. Multiplicacion");
            Console.Out.WriteLine("4. Division");
        }

        public static double [] numbers()
        {
            double a;
            double b;

            Console.Out.WriteLine("Ingrese dos numeros");
            Console.Out.Write("Primer numero: ");
            a = Double.Parse(Console.In.ReadLine());
            Console.Out.Write("Segundo numero: ");
            b = Double.Parse(Console.In.ReadLine());
            return new[] { a, b };
        }
        
        public static double divByZero(double x)
        {
            while (x != 0)
            {
                try
                {
                    x = Double.Parse(Console.In.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine("Error: Ingrese solo numeros\n" + e.Message);
                }
            }

            return x;
        }

        public static bool checkOpts(string opts)
        {
            if (opts.Equals("") || opts.Equals("0"))
                return false;
            try
            {
                double x = Double.Parse(opts);
                return x < 4;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static void Main(String[] args)
        {
            String opts = "0";
            double[] n;
            while (!checkOpts(opts))
            {
                selectOp();
                opts = Console.In.ReadLine();
                
                if(!checkOpts(opts))
                    Console.Error.WriteLine("Error: debes ingresar las opciones indicadas");
            }

            while (true)
            {
                try
                {
                    n = numbers();
                    break;
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine("Error: Ingrese solo numeros\n" + e.Message);
                }
            }

            if (opts.Equals("4") && n[1] == 0)
            {
                n[1] = divByZero(n[1]);
            }
            
            Operacion calc = new Operacion(n[0], n[1], opts);
            Console.Out.WriteLine(calc.resultado());

        }
    }
}
