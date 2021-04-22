using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venturini
{
    /// <summary>
    /// An abstract class representing a SimpleObject.
    /// A SimpleObject has an ID for it's identification, a BoundingBox for manage it's collisions with
    /// other GameObjects, a State, a Room which is placed in at specific Position.
    ///    
    /// The method for manage collisions is to be implemented in base of the type of the SimpleObject that need it.
    /// </summary>
    public abstract class AbstractSimpleObject : IGameObject
    {
        public int Id { get; set; }

        public virtual Point2D Position { get; set; }

        public BoundingBox BoundingBox  { get; set; }

        /// <summary>
        /// Build a new SimpleObject, by it's type and it's position in the room.
        /// </summary>
        /// <param name="position">the position where the SimpleObject will be placed.</param>
        public AbstractSimpleObject(Point2D position, int id)
        {
            this.Position = position;
            this.Id = id;
        }
    }
}
