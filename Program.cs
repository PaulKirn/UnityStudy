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
            int crystalsCount;
            int crystalPrice = 20;
            bool enoughMoney;

            Console.WriteLine($"Здравствуй, путник! В моей лавке все кристалы стоят {crystalPrice} золотых монет. Сколько у тебя монет?");
            Console.Write("Ваш ответ: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Прекрасно! Сколько кристалов тебе нужно?");
            Console.Write("Ваш ответ: ");
            crystalsCount = Convert.ToInt32(Console.ReadLine());
            enoughMoney = money >= crystalsCount * crystalPrice;
            crystalsCount *= Convert.ToInt32(enoughMoney);
            money -= crystalsCount * crystalPrice;
            Console.WriteLine($"У вас осталось {money} золотых монет");
            Console.WriteLine($"Вы получили {crystalsCount} кристалов");


        }
    }
}
