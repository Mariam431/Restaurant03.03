using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant03._03
{
    internal class Restaurant
    {
        public Restaurant()
        {

        }
        public Restaurant(int t)
        {
            this.t = t;
            PrintAnkapBan();
        }
        public int t;
        public const string Address = "Abovyan-1";
        public const string Number = "+37496666666";

        public void PrintAnkapBan()
        {
            Console.WriteLine("printAnkapBan");
        }
        public decimal MakeFood(Menu menu, int count)

        {
            switch (menu)
            {
                case Menu.HotDog:
                    return (decimal)Menu.HotDog * (count + t);
                case Menu.Sushi:
                    return (decimal)Menu.Sushi * (count + t);
                case Menu.Pizza:
                    return (decimal)Menu.Pizza * (count + t);
                case Menu.Shawrma:
                    return (decimal)Menu.Shawrma * (count + t);
                case Menu.Xash:
                    return (decimal)Menu.Xash * (count + t);
                default:
                    return 0;
            }
        }

    }
    public enum Menu
    {
        HotDog = 500,
        Sushi = 12000,
        Pizza = 300,
        Shawrma = 750,
        Xash = 1350
    }
}


