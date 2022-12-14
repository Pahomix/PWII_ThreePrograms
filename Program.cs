using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Work_II
{
    internal class Program
    {
        static void GuessTheNumber()
        {
            Random random = new Random();
            int number = random.Next(1, 100);
            Console.WriteLine("Угадай число от 1 до 100");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            while (userNumber != number)
            {
                if (userNumber < number)
                {
                    Console.WriteLine("Нужно число больше");
                }
                else if (userNumber > number)
                {
                    Console.WriteLine("Нужно число меньше");
                }
                userNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Угадал");
        }

        static void MultiplicationTable()
        {
            int[,] multiplication = new int [10, 10];

            for (int i = 1; i < multiplication.GetLength(0); i++)
            {
                for (int j = 1; j < multiplication.GetLength(0); j++)
                {
                    multiplication[i, j] = i * j;
                }
            }

            for (int i = 1; i < multiplication.GetLength(0); i++)
            {
                for (int j = 1; j < multiplication.GetLength(1); j++)
                {
                    Console.Write($"{i * j} \t");
                }
                Console.WriteLine();
            }
        }

        static void AllSeparators()
        {
            string number;
            Console.WriteLine("Чтобы выйти, введите слово 'выйти'");
            Console.WriteLine("Введите число, делители которого хотите найти: ");
            number = Console.ReadLine();
            do
            {
                int myNum = Convert.ToInt32(number);    
                for (int i = 1; i <= myNum; i++)
                {
                    if (myNum % i == 0)
                    {
                        Console.Write(i + "\t");
                    }
                }

                Console.WriteLine();
                number = Console.ReadLine();
            } while (number != "выйти");
        }

        static void Start()
        {
            Console.WriteLine("Выберите программу, которую вы хотите запустить: " +
                              "\n 1. Угадай число " +
                              "\n 2. Таблица умножения " +
                              "\n 3. Вывод делителей числа " +
                              "\n 4. Закрыть программу ");
        }

        static void Main(string[] args)
        {
            Start();
            int action = Convert.ToInt32(Console.ReadLine());
            while (action != 4)
            {
                switch (action)
                {
                    case 1:
                        GuessTheNumber();
                        break;
                    case 2:
                        MultiplicationTable();
                        break;
                    case 3:
                        AllSeparators();
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                Start();
                action = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Вы успешно вышли из программы");
            }
    }
}
