using System;
using System.Collections.Generic;
using System.Text;

namespace Malucelli
{
    /// <summary>
    /// this class contains some utility fields for the Room, the RoomManager and the RoomBuilder.
    /// </summary>
    interface IRoom
    {
        /// <summary>
        /// the room manager of the Room
        /// </summary>
        IRoomManager RoomManager { get; }

        /// <summary>
        /// boolean that show if the room has been visited
        /// </summary>
        bool IsVisited { get; }

        /// <summary>
        /// Update the state of each DynamicObject using the time passed from the last update./// </summary>
        /// <param name="elapsed">the time elapsed from the previous update.</param>
        void Update(double elapsed);

        /// <summary>
        /// </summary>
        /// <returns> true if Doors are open. Doors are open if there are no enemy in the Room </returns>
        bool IsDoorOpen();

        /// <summary>
        /// 
        /// </summary>
        /// <returns> the list of CardinalPoint where the doors are </returns>
        IList<CardinalPoint> GetDoors();

        /// <summary>
        /// Set the visited flag to true.
        /// </summary>
        void Visit();

    }
}
