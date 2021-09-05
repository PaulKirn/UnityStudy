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
            float health;
            int armor;
            int damage;

            Console.Write("Введите количество жизней: ");
            health = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество брони: ");
            armor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество урона: ");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= Convert.ToSingle(damage) / 100 * armor;

            Console.WriteLine($"Сила атаки составила {damage} урона. У вас осталось {health} жизней");

        }
    }
}
