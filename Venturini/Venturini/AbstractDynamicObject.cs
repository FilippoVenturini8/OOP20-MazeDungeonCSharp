using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venturini
{
    /// <summary>
    /// An abstract class that implements the DynamicObject as a SimpleObject,
    /// with more features defined in the DynamicObject's interface.
    ///
    /// It also implements the changing of the state of the DynamicObject,
    /// making explicit if it's moving and in what direction.
    /// </summary>
    public abstract class AbstractDynamicObject : AbstractSimpleObject, IDynamicObject
    {
        private Vector2D direction;
        private int speed;
        private Point2D lastPosition;

        public int Speed { get; set; }

        public Vector2D Direction
        {
            get { return this.direction; }

            set { this.direction = value; }
        }

        public override Point2D Position
        {
            set
            {
                this.lastPosition = base.Position;
                base.Position = value;
                this.updateBoundingBoxPosition();
            }
        }

        /// <summary>
        /// Build a new DynamicObject using it's speed, position in the room and it'0s type.
        /// </summary>
        /// <param name="speed">the initial speed of the DinamicObject.</param>
        /// <param name="position">the initial position of the DinamicObject.</param>
        public AbstractDynamicObject(int speed, Point2D position, int id) : base(position, id)
        {
            this.speed = speed;
            this.lastPosition = base.Position;
            this.direction = new Vector2D(0, 0);
        }

        public Point2D GetLastPosition()
        {
            return this.lastPosition;
        }

        /// <summary>
        /// Move the bounding box, following the DinamicObject movement.
        /// </summary>
        private void updateBoundingBoxPosition()
        {
            if (this.BoundingBox != null)
            {
                this.BoundingBox.move(base.Position);
            }
        }

        public abstract void Update(double elapsed);
    }
}
