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
            var myCandyShop = new CandyShop(500);
            myCandyShop.MakeSweets(CandyShop.CANDY);
            myCandyShop.MakeSweets(CandyShop.LOLLIPOP);
            myCandyShop.MakeSweets(CandyShop.CANDY);
            myCandyShop.RaisePrice(10);
            myCandyShop.MakeSweets(CandyShop.CANDY);
            myCandyShop.PrintInfo();
            Console.Read();
        }
    }
}
