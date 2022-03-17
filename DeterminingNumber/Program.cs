using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определение чётности числа
            Console.WriteLine("Здравствуйте!");
            Console.WriteLine("Введите любое положительное целое число, чтобы определить чётное оно или нет:");
            int UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber % 2 == 0)
            {
                Console.WriteLine("Ваше число четное");
            }
            else
            {
                Console.WriteLine("Ваше число не четное");
            }

            Console.ReadKey(); 
        }
    }
}
