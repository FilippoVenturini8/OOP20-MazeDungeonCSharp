using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venturini
{
    /// <summary>
    /// A basic class that implements the concept of Vector in two dimensions.
    /// </summary>
    class Vector2D
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
        /// <param name="x">the initial x of the vector.</param>
        /// <param name="y">the initial y of the vector.</param>
        public Vector2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="to">starting point of the vector</param>
        /// <param name="from">ending point of the vector</param>
        public Vector2D(Point2D to, Point2D from)
        {
            x = to.X - from.X;
            y = to.Y - from.Y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v">the vector to be added.</param>
        /// <returns>the resultant vector</returns>
        public Vector2D Sum(Vector2D v)
        {
            return new Vector2D(this.X + v.X, this.Y + v.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>the module of the vector</returns>
        public double Module()
        {
            return (double)Math.Sqrt(X * X + Y * Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fact">the number to be multiplied.</param>
        /// <returns>the resultant vector</returns>
        public Vector2D Mul(double fact)
        {
            return new Vector2D(X * fact, Y * fact);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>the normalized vector</returns>
        public Vector2D GetNormalized()
        {
            double module = this.Module();
            return new Vector2D(X / module, Y / module);
        }
    }
}
