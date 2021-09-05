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
            string name;
            int age;
            string zodiacSign;
            string profession;

            Console.Write("Здравствуйте! Пожалуйста, введите Ваше имя:");
            name = Console.ReadLine();
            Console.Write("Введите Ваш возраст:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите Ваш знак зодиака:");
            zodiacSign = Console.ReadLine();
            Console.Write("Введите Вашу профессию:");
            profession = Console.ReadLine();

            Console.WriteLine($"Итак, Вас зовут {name} и вам {age} лет. Ваш знак зодиака {zodiacSign}, а Ваша профессия {profession}, все верно?");



        }
    }
}
