using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiGirolamo
{
    interface IItem
    {
        /// <summary>
        ///get and set value that represents the price
        /// </summary>
        int Cost {get; set;}
        /// <summary>
        /// returns the name of the item.
        /// </summary>
        Items Name { get; }
        /// <summary>
        /// returns the value that represents the life that the item adds
        /// </summary>
        double Health { get; }
        /// <summary>
        /// returns the value that represents the movement speed that the item adds
        /// </summary>
        int Speed { get; }
        /// <summary>
        /// returns the value that represents the bullet speed that the item adds
        /// </summary>
        int BulletSpeed { get; }
        /// <summary>
        /// returns the value that represents the damage that the item adds
        /// </summary>
        int Damage { get; }
    }
}
