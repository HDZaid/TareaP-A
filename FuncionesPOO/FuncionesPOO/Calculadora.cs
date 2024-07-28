using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//principio de responsabilidad unica
namespace CalculadoraEstadisticaPOO
{
    //es una clase que imita una aplicaicon
    //puede recibir distintas listas
    internal class Calculadora
    {
        static double resultado = 0;
        public double Media(List<double> listaNumeros)
        {
            double sumaNumeros = 0;
            foreach (int i in listaNumeros)
            {
                sumaNumeros += i;
            }
            double resultado = (sumaNumeros / listaNumeros.Count);
            return resultado;
        }

        public double Mediana(List<double> listaNumeros)
        {
            listaNumeros.Sort();
            int puntoMedio = listaNumeros.Count / 2;

            if (listaNumeros.Count % 2 == 0)
            {
                resultado = (listaNumeros[puntoMedio] + listaNumeros[puntoMedio - 1]) / 2;
                return resultado;
            }
            else
            {
                return resultado = listaNumeros[puntoMedio];
            }
        }

        public void Moda(List<double> listaNumeros)
        {
            Dictionary<double, int> frecuencias = new Dictionary<double, int>();

            foreach (double num in listaNumeros)
            {
                if (frecuencias.ContainsKey(num))
                {
                    frecuencias[num]++;
                }
                else
                {
                    frecuencias[num] = 1;
                }
            }

            int maxFrecuencia = frecuencias.Values.Max();
            double moda = frecuencias.First(x => x.Value == maxFrecuencia).Key;

            Console.WriteLine("La moda es: " + moda);
        }

        public double DesviacionEstandar(List<double> listaNumeros)
        {
            double media = Media(listaNumeros);
            double sumaDesviaciones = 0;
            foreach (int i in listaNumeros)
            {
                double diferencia = i - media;
                sumaDesviaciones += Math.Pow(diferencia, 2);
            }
            double varianza = (sumaDesviaciones / listaNumeros.Count);
            return resultado = Math.Round(Math.Sqrt(varianza), 6);
        }
    }
}
