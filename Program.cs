using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercício 1
            Console.Write("Exercicio 1) \n");

            int numero = 0, fibonacci1 = 0, fibonacci2 = 1, temp = 0;

            Console.Write("Informe o numero desejado: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write(fibonacci1 + " ");
            while(true)
            {
                if(fibonacci2 > numero)
                {
                    Console.WriteLine("\nO numero " + numero + " nao pertence a sequencia Fibonacci.");
                    break;
                }
                else if(fibonacci2 == numero)
                {
                    Console.WriteLine("\nO numero " + numero + " pertence a sequencia Fibonacci");
                    break;
                }
                else
                {
                    temp = fibonacci2;

                    fibonacci2 = fibonacci2 + fibonacci1;
                    fibonacci1 = temp;

                    Console.Write(fibonacci2 + " ");

                }
            }
            #endregion

            #region Exercício 2
            Console.Write("\nExercicio 2) \n");

            Console.WriteLine("Insira um texto: ");
            String texto = Console.ReadLine();
            int contador = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (char.ToUpper(texto[i]) == 'A')
                {
                    contador++;
                }
            }
            Console.WriteLine("Ha " + contador + " letra(s) 'A' no texto: \n" + texto);
            #endregion

            #region Exercício 3
            Console.Write("\nExercicio 3) \n");

            int indice = 12, soma = 0, k = 1;

            while(k < indice)
            {
                k++;
                soma += k;
            }
            Console.WriteLine("K: " + k);
            Console.WriteLine("Soma: " + soma);

            #endregion


            Console.ReadKey();
        }
    }
}
