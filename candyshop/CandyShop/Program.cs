using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var candyShop = new CandyShop(300);
            candyShop.CreateSweets(CandyShop.CANDY);
            candyShop.CreateSweets(CandyShop.CANDY);
            candyShop.CreateSweets(CandyShop.LOLLIPOP);
            candyShop.CreateSweets(CandyShop.LOLLIPOP);
            candyShop.PrintInfo();
            candyShop.SellSweets(CandyShop.CANDY, 1);
            candyShop.PrintInfo();
            candyShop.RaisePrice(5);
            candyShop.SellSweets(CandyShop.LOLLIPOP, 1);
            candyShop.PrintInfo();
            candyShop.BuySugar(300);
            candyShop.PrintInfo();
            Console.Read();
        }
    }
}
