using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venturini
{
    /// <summary>
    /// The BoundingBox is a class that permit to check a collision with an 
    /// other BondingBox.
    /// </summary>
    class BoundingBox
    {
        private Point2D upperLeft;
        private Point2D bottomRight;
        private readonly double width;
        private readonly double height;

        public Point2D ULCorner { get { return this.upperLeft; } }

        public Point2D BRCorner { get { return this.bottomRight; } }

        public double Height { get { return this.height;  } }

        public double Width { get { return this.width; } }

        public BoundingBox(Point2D upperLeft, double width, double height)
        {
            this.width = width;
            this.height = height;
            this.upperLeft = upperLeft;
            this.bottomRight = new Point2D(this.upperLeft.X + this.width, this.upperLeft.Y + this.height);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newUL">the new upper left corner</param>
        public void move(Point2D newUL)
        {
            this.upperLeft = newUL;
            this.bottomRight = new Point2D(this.upperLeft.X + this.width, this.upperLeft.Y + this.height);
        }

        /// <summary>
        /// check collisions between two bounding box.
        /// </summary>
        /// <param name="box">the BoundingBox to check collision with</param>
        /// <returns>true if the two BoundingBox collide, false otherwise</returns>
        public bool intersectWith(BoundingBox box)
        {
            if (box == null)
            {
                return false;
            }
            return !(this.upperLeft.X >= box.bottomRight.X || box.upperLeft.X >= this.bottomRight.X
                    || this.upperLeft.Y >= box.bottomRight.Y || box.upperLeft.Y >= this.bottomRight.Y);
        }
    }
}
