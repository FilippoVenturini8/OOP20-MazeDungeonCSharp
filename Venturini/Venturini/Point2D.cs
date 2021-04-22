using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venturini
{
    /// <summary>
    /// A basic class that implements the concept of Point in two dimensions.
    /// </summary>
    public class Point2D
    {
        private readonly double x;
        private readonly double y; 

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">the x coordinate of the point.</param>
        /// <param name="y">the y coordinate of the point.</param>
        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v">the vector to be added.</param>
        /// <returns>the resultant Point</returns>
        public Point2D Sum(Vector2D v)
        {
            return new Point2D(this.X + v.X, this.y + v.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v">the vector to be multiplied.</param>
        /// <returns>the resultant Point</returns>
        public Point2D Mul(double v)
        {
            return new Point2D(this.x * v, this.y * v);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v">the vector to be subtracted.</param>
        /// <returns>the resultant Point</returns>
        public Vector2D Sub(Point2D v)
        {
            return new Vector2D(this.x - v.X, this.y - v.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>the string representation of a Point2D</returns>
        public override String ToString()
        {
            return "Point2D [x=" + x + ", y=" + y + "]";
        }
    }
}
