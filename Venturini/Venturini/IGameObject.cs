using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venturini
{
    /// <summary>
    /// An interface that represent the basic entity which can be placed in a Room during the gameloop.
    /// </summary>
    public interface IGameObject
    {
        /// <summary>
        /// return or set the Position of the GameObject.
        /// </summary>
        Point2D Position { get; }

        /// <summary>
        /// return or set the id of the GameObject.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// get and set the BoundingBox corresponding to the GameObject.
        /// </summary>
        BoundingBox BoundingBox { get; set; }
    }
}
