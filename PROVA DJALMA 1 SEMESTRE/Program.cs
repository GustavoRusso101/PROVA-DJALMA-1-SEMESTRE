using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVA_DJALMA_1_SEMESTRE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite 1 para o calculo da area triango, 2 para a do circulo, 3 para a do losangulo : ");
            int n1;
            double a, b, h,r,pi, DMaior, DMenor;
            n1 = Convert.ToInt32(Console.ReadLine());
            switch (n1)
            { 
                case 1:
                    Console.Write("Digite a base: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite a altura: ");
                    h = Convert.ToDouble(Console.ReadLine());
                    a = (h * b) / 2;
                    Console.WriteLine("Area do triangulo = " + a);

                    break;
                case 2:
                    Console.Write("Digite o Raio: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    pi = 3.14;
                    a = pi * (r * r);
                    Console.Write("Area do Circulo =" + a);

            
                    break;
                case 3:
                    Console.Write("Valor da Diagonal Maior: ");
                    DMaior = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Valor da Diagonal Menor: ");
                    DMenor = Convert.ToDouble(Console.ReadLine());
                    a = (DMaior * DMenor) / 2;
                    Console.Write("Area do losangulo =" + a);
                    break;

                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
            Console.ReadKey();


        }
    }
}

