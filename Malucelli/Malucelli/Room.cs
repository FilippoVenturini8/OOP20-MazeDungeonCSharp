using System;
using System.Collections.Generic;
using System.Text;

namespace Malucelli
{
    /// <summary>
    /// The implementation of the Interface Room.
    /// </summary>
    class Room : IRoom
    {

        private IList<CardinalPoint> nearRooms = new List<CardinalPoint>();

        public Room(RoomManager roomManager, IList<CardinalPoint> doors)
        {
            this.RoomManager = roomManager;
            foreach(CardinalPoint cp in doors)
            {
                this.nearRooms.Add(cp);
            }
        }

        public IRoomManager RoomManager { get; private set; }
        public bool IsVisited { get; private set; }

        public IList<CardinalPoint> GetDoors()
        {
            return this.nearRooms;
        }

        public bool IsDoorOpen()
        {
            return true;
        }

        public void Update(double elapsed)
        {
            //should call the update on each DynamicObject but in this simple version
            //there are not DynamicObject to update
        }

        public void Visit()
        {
            this.IsVisited = true;
        }
    }
}
