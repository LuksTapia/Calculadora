using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculator
    {
        static void Main(String[] args)
        {

            {

                int numero1;
                int numero2;
                char operacion;
                int resultado;

                Console.WriteLine("Ingrese un numero");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero");
                numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese operacion  SUMA (+) , RESTA (-) , MULTI (*), DIVISION (/)");
                operacion = char.Parse(Console.ReadLine());


                switch (operacion)
                {
                    case '+':
                        resultado = numero1 + numero2;
                        Console.WriteLine(resultado);
                        break;
                    case '-':
                        resultado = numero1 - numero2;
                        Console.WriteLine(resultado);

                        break;
                    case '*':
                        resultado = numero1 * numero2;
                        Console.WriteLine(resultado);
                        break;

                    case '/':
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine(resultado);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por 0");
                            break;



                        }



                }

            }
        }
    }
}