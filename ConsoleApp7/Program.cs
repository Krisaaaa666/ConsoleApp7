using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Здравствуйте! Сколько у вас карт?");
                int numberOfCards = int.Parse(Console.ReadLine());
                int sum = 0;
                int valueCard;
                Console.WriteLine("Допустимые номиналы: 2-10, J - Валет, Q - Дама, K - Король, T - Туз.");
                int countCard = 0;
                while (countCard < numberOfCards)
                {
                    valueCard = 0;
                    Console.WriteLine("Введите номинал карты: ");
                    string inputString = (Console.ReadLine());
                    switch (inputString)
                    {
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                        case "10":
                            valueCard = int.Parse(inputString); break;
                        case "J":
                        case "Q":
                        case "K":
                        case "T":
                            valueCard = 10; break;
                        default:
                            Console.WriteLine("Допустимые номиналы: 2-10, J - Валет, Q - Дама, K - Король, T - Туз.");
                            continue;
                    }
                    sum += valueCard;
                    countCard++;
                }
                Console.WriteLine($"Сумма карт:  {sum}");
                Console.ReadKey();
        }
    }
}