using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplofundamentos.Common.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void SomSubtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {potencia}");
        }
        public void Seno(double angulo)
        {
            double radiano = this.Radiano(angulo);
            double seno = Math.Round(Math.Sin(radiano), 5);
            Console.WriteLine($"Seno de {angulo}º = {seno}");
        }
        public void Coseno(double angulo)
        {
            double radiano = this.Radiano(angulo);
            double coseno = Math.Round(Math.Cos(radiano), 5);
            Console.WriteLine($"Coseno de {angulo}º = {coseno}");
        }
        public void Tangente(double angulo)
        {
            double radiano = this.Radiano(angulo);
            double tangente = Math.Round(Math.Tan(radiano), 5);
            Console.WriteLine($"Tangente de {angulo}º = {tangente}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
        public double Radiano(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            return radiano;
        }
    }
}