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
        List<List<Sweets>> inventory = new List<List<Sweets>>();

        public CandyShop(int sugarStored)
        {
            inventory.Add(new List<Sweets>());
            inventory.Add(new List<Sweets>());
            this.sugarStored = sugarStored;
        }

        public void CreateSweets(Sweets sweetToAdd)
        {
            if (sweetToAdd.GetType().Name == "Candy")
            {
                inventory[0].Add(new Candy());
                sugarStored -= CANDY.sugarNeeded;
            }
            if (sweetToAdd.GetType().Name == "Lollipop")
            {
                inventory[1].Add(new Lollipop());
                sugarStored -= LOLLIPOP.sugarNeeded;
            }
        }

        public void SellSweets(Sweets sweetsToSell, int piece)
        {
            if (sweetsToSell.GetType().Name == "Candy")
            {
                inventory[0].RemoveRange(0, piece);
                income += CANDY.price;
            }
            if (sweetsToSell.GetType().Name == "Lollipop")
            {
                inventory[1].RemoveRange(0, piece);
                income += LOLLIPOP.price;
            }
        }

        public void BuySugar(int amount)
        {
            sugarStored += amount;
            income -= amount * (1000 / 100);
        }

        public void RaisePrice(int percentage)
        {
            CANDY.price += CANDY.price * (percentage / 100);
            LOLLIPOP.price += LOLLIPOP.price * (percentage / 100);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Inventory: {inventory[0].Count} candies, {inventory[1].Count} lollipops, Income: {income}$, Sugar: {sugarStored} gr");
        }
    }
}
