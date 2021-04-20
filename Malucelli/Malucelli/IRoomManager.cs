using System;
using System.Collections.Generic;
using System.Text;

namespace Malucelli
{
    /// <summary>
    /// An interface that help the user to managing multiple Rooms.
    /// The RoomManager can update the current room and can select
    /// a new Room as current.
    /// </summary>
    interface IRoomManager
    {
        /// <summary>
        /// Update the current Room.
        /// </summary>
        /// <param name="elapsed"> the time elapsed from the last call </param>
        void Update(double elapsed);

        /// <summary>
        /// </summary>
        /// <returns>the current Room that's the Room where the MainCharacter is.</returns>
        IRoom GetCurrentRoom();

        /// <summary>
        /// </summary>
        /// <returns> the IdIterator </returns>
        IdIterator GetIdIterator();

        /// <summary>
        /// load a new Room ad current Room.
        /// </summary>
        /// <param name="cp">the cardinal point of the new Room in reference at the current</param>
        void ChangeRoom(CardinalPoint cp);

        /// <summary>
        /// </summary>
        /// <returns> the number of visited Rooms </returns>
        int GetVisitedRooms();
    }
}
