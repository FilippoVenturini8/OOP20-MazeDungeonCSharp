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
    public interface IRoomManager
    {
        /// <summary>
        /// the IdIterator
        /// </summary>
        IdIterator IdIterator { get; }

        /// <summary>
        /// the current Room.
        /// </summary>
        IRoom ActualRoom { get;  }

        /// <summary>
        /// the number of visited rooms
        /// </summary>
        int VisitedRooms { get;  }

        /// <summary>
        /// Update the current Room.
        /// </summary>
        /// <param name="elapsed"> the time elapsed from the last call </param>
        void Update(double elapsed);

        /// <summary>
        /// load a new Room ad current Room.
        /// </summary>
        /// <param name="cp">the cardinal point of the new Room in reference at the current</param>
        void ChangeRoom(CardinalPoint cp);
    }
}
