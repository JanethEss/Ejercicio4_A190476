using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcularAreaWS
{
    public class CalcularArea
    {
        public double numero1 { get; set; }
        public double numero2 { get; set; }

        public double cuadrado(double lado1)
        {
            numero1 = lado1;           
            var resultado = numero1 * numero1;
            return resultado;
        }
        public double triangulo(double bse, double altura)
        {
            numero1 = bse;
            numero2 = altura;
            var resultado = (numero1 * numero2) / 2;
            return resultado;
        }
        public double circulo(double radio)
        {
            numero1 = radio;            
            var resultado = Math.PI* Math.Pow(numero1, 2);
            return resultado;
        }
    }
}