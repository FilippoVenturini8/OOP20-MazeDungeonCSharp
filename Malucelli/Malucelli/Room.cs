using System;
using System.Collections.Generic;
using System.Text;

namespace Malucelli
{
    /// <summary>
    /// The implementation of the Interface Room.
    /// </summary>
    public class Room : IRoom
    {

        private IList<CardinalPoint> nearRooms = new List<CardinalPoint>();
        private IList<SimpleObject> simpleObjects = new List<SimpleObject>();
        private IList<DynamicObject> dynamicObjects = new List<DynamicObject>();

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

        public void AddDynamicObject(DynamicObject obj)
        {
            dynamicObjects.Add(obj);
        }

        public void AddSimpleObject(SimpleObject obj)
        {
            simpleObjects.Add(obj);
        }

        public void DeleteDynamicObject(DynamicObject obj)
        {
            dynamicObjects.Remove(obj);
        }

        public void DeleteSimpleObject(SimpleObject obj)
        {
            simpleObjects.Remove(obj);
        }

        public IList<DynamicObject> GetCurrentDynamicObjects()
        {
            return new List<DynamicObject>(dynamicObjects);
        }

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
            foreach(DynamicObject obj in dynamicObjects)
            {
                obj.Update(elapsed);
            }
        }

        public void Visit()
        {
            this.IsVisited = true;
        }
    }
}
