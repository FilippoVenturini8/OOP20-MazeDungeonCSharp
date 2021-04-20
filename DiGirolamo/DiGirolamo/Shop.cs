using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiGirolamo
{
    class Shop
    {
        private const double MORE_HEALTH = 20;
        private const int MORE_DAMAGE = 5;
        private const int MORE_SPEED = 40;
        private const int MORE_BULLETSPEED = 40;
        private const int PRICE_ARTHEMIDEBOW = 4;
        private const int PRICE_HERMESBOOTS = 3;
        private const int PRICE_ZEUSBOLT = 4;
        private const int PRICE_HEALTH = 2;
        private const int PRICE_ORACLEAMULET = 7;

        private readonly List<Items> purchasedItems = new List<Items>();
        private readonly List<Items> cart = new List<Items>();
        private String messageOuput = "";
        private readonly String msgBought;
        private readonly String msgNoMoney;

    public Shop()
        {
            msgBought = "You bought this item! You have coins: ";
            msgNoMoney = "You don't have enough coins!";
        }

        private void setItem(IItem item)
        {
            this.purchasedItems.Add(item.Name);
            this.cart.Add(item.Name);
            this.messageOuput = this.msgBought;
        }

        public Dictionary<Items, int> addPrice()
        {         
            Dictionary<Items, int> mapPrice = new Dictionary<Items, int>();
            mapPrice.Add(Items.ArthemideBow, PRICE_ARTHEMIDEBOW);
            mapPrice.Add(Items.HermesBoots, PRICE_HERMESBOOTS);
            mapPrice.Add(Items.ZeusBolt, PRICE_ZEUSBOLT);
            mapPrice.Add(Items.Health, PRICE_HEALTH);
            mapPrice.Add(Items.OracleAmulet, PRICE_ORACLEAMULET);
            return mapPrice;
        }

        public void checkItem(Items i)
        {
            if (this.purchasedItems.Contains(i))
            {
                this.messageOuput = "You already have this item";
            }
            else
            {
                switch (i)
                {
                    case Items.ArthemideBow:
                        this.setItem(this.ArthemideBow());
                        break;
                    case Items.HermesBoots:
                        this.setItem(this.HermesBoots());
                        break;
                    case Items.ZeusBolt:
                        this.setItem(this.ZeusBolt());
                        break;
                    case Items.OracleAmulet:
                        this.setItem(this.OracleAmulet());
                        break;
                    default:
                        messageOuput = "ERROR!";
                        break;
                }
            }
        }

        public String MessageOuput()
        {
            return messageOuput;
        }

        public IItem ArthemideBow()
        {
            return new ItemBuilder.Builder(Items.ArthemideBow, PRICE_ARTHEMIDEBOW).addDamage(MORE_DAMAGE).build();
        }

        public IItem HermesBoots()
        {
            return new ItemBuilder.Builder(Items.HermesBoots, PRICE_HERMESBOOTS).addSpeed(MORE_SPEED).build();
        }

        public IItem ZeusBolt()
        {
            return new ItemBuilder.Builder(Items.ZeusBolt, PRICE_ZEUSBOLT).addBulletSpeed(MORE_BULLETSPEED).build();
        }

        public IItem Health()
        {
            return new ItemBuilder.Builder(Items.Health, PRICE_HEALTH).addHelath(MORE_HEALTH).build();
        }

        public IItem OracleAmulet()
        {
            return new ItemBuilder.Builder(Items.OracleAmulet, PRICE_ORACLEAMULET).addDamage(MORE_DAMAGE).addSpeed(MORE_SPEED).addBulletSpeed(MORE_BULLETSPEED).build();
        }

        public void clearCart()
        {
            this.cart.Clear();
        }

        public List<Items> getCart()
        {
            return this.cart;
        }

    }
}
