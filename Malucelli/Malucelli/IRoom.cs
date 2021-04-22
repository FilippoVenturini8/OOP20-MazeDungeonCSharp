using System;
using System.Collections.Generic;
using System.Text;

namespace Malucelli
{
    /// <summary>
    /// this class contains some utility fields for the Room, the RoomManager and the RoomBuilder.
    /// </summary>
    public interface IRoom
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
        /// Add a DynamicObject to the room.
        /// </summary>
        /// <param name="obj">DynamicObject to add to the room</param>
        void AddDynamicObject(DynamicObject obj);

        /// <summary>
        /// /** Add a SimpleObject to the room.
        /// </summary>
        /// <param name="obj">SimpleObject to add to the room</param>
        void AddSimpleObject(SimpleObject obj);

        /// <summary>
        /// Remove a SimpleObject from the room.
        /// </summary>
        /// <param name="obj">SimpleObject to remove from the room</param>
        void DeleteSimpleObject(SimpleObject obj);

        /// <summary>
        /// Remove a DynamicObject from the room.
        /// </summary>
        /// <param name="obj">DynamicObject to remove from the room</param>
        void DeleteDynamicObject(DynamicObject obj);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>a list containing all the DynamicObject</returns>
        IList<DynamicObject> GetCurrentDynamicObjects();

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
