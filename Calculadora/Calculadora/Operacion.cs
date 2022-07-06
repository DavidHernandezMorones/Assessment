using System;

namespace Calculadora
{
    public class Operacion
    {
        double _a;
        double _b;
        double _result;
        string _op;

        public double A
        {
            get => _a;
            set => _a = value;
        }

        public double B
        {
            get => _b;
            set => _b = value;
        }

        public double Result
        {
            get => _result;
            set => _result = value;
        }

        public string Op
        {
            get => _op;
            set => _op = value;
        }

        public Operacion(double a, double b, string op)
        {
            _a = a;
            _b = b;
            _op = op;
        }
        
        public Operacion(double a, double b)
        {
            _a = a;
            _b = b;
            _op = "1";
        }
        
        public Func<double, double, double> suma = (a, b) => a + b;
        public Func<double, double, double> resta = (a, b) => a - b;
        public Func<double, double, double> multiplicacion = (a, b) => a * b;
        public Func<double, double, double> division = (a, b) => a / b;

        public double resultado()
        {
            switch (_op)
            {
                case "1":
                    _result = suma(_a, _b);
                    break;
                case "2":
                    _result = resta(_a, _b);
                    break;
                case "3":
                    _result = multiplicacion(_a, _b);
                    break;
                case "4":
                    _result = division(_a, _b);
                    break;
            }

            return _result;
        }
    }
}