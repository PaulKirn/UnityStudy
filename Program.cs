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

            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write($"Вас зовут - {name}. {name}, пожалуста, введите ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Спасибо, {name}! Ваш возраст {age}, вы можете продолжить просмотр материала.");

            


        }
    }
}
