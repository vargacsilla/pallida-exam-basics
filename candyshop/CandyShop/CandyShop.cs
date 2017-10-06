using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyShop
{
    class CandyShop
    {
        public static readonly Candy CANDY = new Candy();
        public static readonly Lollipop LOLLIPOP = new Lollipop();

        int sugarStored;
        int income;
        List<Sweets> inventory = new List<Sweets>();

        public CandyShop(int sugarStored)
        {
            this.sugarStored = sugarStored;
        }

        public void MakeSweets(Sweets sweetToAdd)
        {
            if (sweetToAdd.GetType().Name == "Candy")
            {
                inventory.Add(new Candy());
                sugarStored -= CANDY.sugarNeeded;
            }
            if (sweetToAdd.GetType().Name == "Lollipop")
            {
                inventory.Add(new Lollipop());
                sugarStored -= LOLLIPOP.sugarNeeded;
            }
        }

        public void SellSweets()
        {

            
        }

        public void BuySugar(int amount)
        {
            sugarStored += amount;
            income -= amount * (1000 / 100);
        }

        public void RaisePrice(int percentage)
        {
            Sweets.price += Sweets.price * (percentage / 100);
        }

        public void PrintInfo()
        {
            var candyList = new List<Sweets>();
            var lollipopList = new List<Sweets>();
            try
            {
                foreach (var sweet in inventory)
                {
                    if (sweet.GetType().Name == "Candy")
                    {
                        candyList.Add(sweet);
                    }
                    else
                    {
                        lollipopList.Add(sweet);
                    }
                }
            
                Console.WriteLine($"Inventory: {candyList.Count} candies, {lollipopList.Count} lollipops, Income: {income}$, Sugar: {sugarStored} gr");
            }
            catch
            {
                Console.WriteLine($"Inventory: your shop is empty, Income: {income}$, Sugar: {sugarStored} gr");
            }
        }
    }
}
