using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiGirolamo
{
    interface IShop
    {

        /// <summary>
        /// To show the player messages about the Items.
        /// </summary>
        String MessageOuput { get; }
        /// <summary>
        /// To check if an Item can be purchased.
        /// Check if the character has enough money and if he hasn't bought it yet.
        /// </summary>
        /// <param name="i">item selected, to check if the item is affordable</param>
        void checkItem(Items i);
        /// <summary>
        /// return ArthemideBow Item
        /// </summary>
        IItem ArthemideBow { get; }
        /// <summary>
        /// return HermesBoots Item
        /// </summary>
        IItem HermesBoots { get; }
        /// <summary>
        /// return ZeusBolt Item
        /// </summary>
        IItem ZeusBolt { get; }
        /// <summary>
        /// return Health Item
        /// </summary>
        IItem Health { get; }
        /// <summary>
        /// return Oracle Amulet Item
        /// </summary>
        IItem OracleAmulet { get; }
        /// <summary>
        /// </summary>
        /// <returns> every Item with its price </returns>
        Dictionary<Items, int> addPrice();
        /// <summary>
        /// Empty the character's current cart.
        /// empty the current cart.
        /// </summary>
        void clearCart();
        /// <summary>
        /// To get the character's shopping cart.
        /// </summary>
        /// <returns>a copy of current cart</returns>
        List<Items> getCart();
    }
}
