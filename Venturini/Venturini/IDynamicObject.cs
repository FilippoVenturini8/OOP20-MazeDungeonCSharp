using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venturini
{
    /// <summary>
    /// An interface that define a DynamicObject as a GameObject, with features that allows movement with a direction and a speed.
    /// </summary>
    interface IDynamicObject
    {
        /// <summary>
        /// get and set the speed of the DynamicObject.
        /// </summary>
        int Speed { get; set; }

        /// <summary>
        /// get and set the direction of the DynamicObject.
        /// </summary>
        Vector2D Direction { get; set; }

        /// <summary>
        /// set the current position of the DynamicObject to the new position.
        /// </summary>
        Point2D Position { set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>the last position of the DynamicObject.</returns>
        Point2D GetLastPosition();

        /// <summary>
        /// Update the state of the DynamicObject considering the time passed from the last update.
        /// </summary>
        /// <param name="elapsed">the time passed from the last updateState.</param>
        void Update(double elapsed);
    }
}
