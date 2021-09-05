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
            int money;
            int eatCount;
            int eatPrice = 10;
            bool enoughMoney;

            Console.WriteLine($"Добро пожаловать в наш фермерский магазин! Сегодня вся наша еда стоит {eatPrice} золотых монет.");
            Console.WriteLine("Скажите, сколько у вас золота?");
            Console.Write("Ваш ответ: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Скажите, сколько Вам нужно еды?");
            Console.Write("Ваш ответ: ");
            eatCount= Convert.ToInt32(Console.ReadLine());

            enoughMoney = money >= eatCount * eatPrice;
            eatCount *= Convert.ToInt32(enoughMoney);
            money -= eatCount * eatPrice;

            Console.WriteLine($"Вы потратили {money} золотых монет.");
            Console.WriteLine($"Вы получили {eatCount} единиц еды.");
        }
    }
}
