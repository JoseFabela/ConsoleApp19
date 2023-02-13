using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            do
            {

                Console.WriteLine("1.PERIMETRO 2.AREA 3.SALIR"); respuesta = Console.ReadLine();

                if (respuesta == "1")
                {
                    Console.WriteLine("Cual figura? \n 1.Cuadrado 2.Triangulo 3.Rectangulo"); string resp = Console.ReadLine();
                    if (resp == "1")
                    {
                        Perimetro_Cuadrado();
                        Console.ReadKey();
                    }
                    if (resp == "2")
                    {
                        Perimetro_Triangulo();
                        Console.ReadKey();
                    }
                    if (resp == "3")
                    {
                        Perimetro_Rectangulo();
                        Console.ReadKey();
                    }
                }
                if (respuesta == "2")
                {
                    Console.WriteLine("Cual figura? \n 1.Cuadrado 2.Triangulo 3.Rectangulo"); string respu = Console.ReadLine();
                    if (respu == "1")
                    {
                        Area_Cuadrado();
                        Console.ReadKey();
                    }
                    if (respu == "2")
                    {
                        Area_Triangulo();
                        Console.ReadKey();
                    }
                    if (respu == "3")
                    {
                        Area_Rectangulo();
                        Console.ReadKey();
                    }

                }

            } while (respuesta == "1"| respuesta == "2");
        }
        static void Perimetro_Cuadrado()
        {
            Console.WriteLine("Cuanto mide un lado?"); int lado=int.Parse(Console.ReadLine());
            lado = lado * 4;
            Console.WriteLine("SU PERIMETRO ES: "+lado);
            Console.WriteLine("PRESIONE ENTER");
        }
        static void Area_Cuadrado()
        {
            Console.WriteLine("Cuanto mide un lado?"); int lado = int.Parse(Console.ReadLine());
            lado = lado * lado;
            Console.WriteLine("SU AREA ES: " + lado);
            Console.WriteLine("PRESIONE ENTER");
        }
        static void Perimetro_Triangulo()
        {
            Console.WriteLine("Cuanto mide un lado?"); int lado = int.Parse(Console.ReadLine());
            lado = lado * 3;
            Console.WriteLine("SU PERIMETRO ES: " + lado);
            Console.WriteLine("PRESIONE ENTER");
        }
        static void Area_Triangulo()
        {
            Console.WriteLine("Cuanto mide la base?"); int bAse = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto mide la altura?"); int altura = int.Parse(Console.ReadLine());
            bAse= bAse * altura;
            Console.WriteLine("SU AREA ES: " + bAse);
            Console.WriteLine("PRESIONE ENTER");
        }
        static void Perimetro_Rectangulo()
        {
            Console.WriteLine("Cuanto mide la base?"); int bAse = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto mide la altura?"); int altura = int.Parse(Console.ReadLine());
            bAse = bAse + bAse;
            altura = altura + altura;
            bAse = bAse + altura;
            Console.WriteLine("SU PERIMETRO ES: " + bAse);
            Console.WriteLine("PRESIONE ENTER");
        }
        static void Area_Rectangulo()
        {
            Console.WriteLine("Cuanto mide la base?"); int bAse = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto mide la altura?"); int altura = int.Parse(Console.ReadLine());
            bAse = bAse * altura;
            Console.WriteLine("SU AREA ES: " + bAse);
            Console.WriteLine("PRESIONE ENTER");
        }
    }
}
