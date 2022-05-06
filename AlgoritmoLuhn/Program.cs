using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoLuhn
{
    class Program
    {
        static bool validateCardNumber(string input) /* Questa funzione verifica se, applicando l'algoritmo di Luhn,
                                                      il numero inserito può essere utilizzato per il pan di una carta di credito. */
        {
            
            // Converto l'input in un intero
            int[] cardNumber = new int[input.Length];

            for(int i = 0; i < input.Length; i++)
            {
                cardNumber[i] = (int)(input[i] - '0');
            }

            // Moltiplico per due le cifre nelle posizioni pari partendo da destra
            for (int i = cardNumber.Length - 2; i >= 0; i = i - 2)
            {
                int temp = cardNumber[i];
                temp = temp * 2;
                if (temp > 9)
                {
                    temp = temp % 10 + 1;
                }
                cardNumber[i] = temp;
            }

            // Sommo le cifre
            int total = 0;
            for (int i = 0; i < cardNumber.Length; i++)
            {
                total += cardNumber[i];
            }

            // Se il totale è un numero multiplo di 10 allora il numero inserito inizialmente è valido
            if (total % 10 == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci il numero PAN della carta che vuoi controllare attraverso l'algoritmo di Luhn");
            Console.WriteLine(validateCardNumber(Console.ReadLine()));
            
            
            
            Console.ReadKey();
        }
    }
}
