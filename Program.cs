using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int people;
            int timeOfreceipt = 10;

            Console.WriteLine("Фиксированное время приема одного человека 10 минут.");
            Console.Write("Введите количество людей в очереди: ");
           
            people = Convert.ToInt32(Console.ReadLine());

            int totalTime = people * timeOfreceipt;
            int hour = totalTime / 60;
            int minutes = totalTime % 60;

            Console.WriteLine($"Вы должны отстоять в очереди {hour} часа и {minutes} минут.");



        }
    }
}
