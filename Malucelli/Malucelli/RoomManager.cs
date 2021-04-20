using System;
using System.Collections.Generic;
using System.Text;

namespace Malucelli
{
    class RoomManager : IRoomManager
    {
        private Dictionary<Point2D, IRoom> rooms = new Dictionary<Point2D, IRoom>();
        private IRoom ActualRoom { get; set; }

        public void ChangeRoom(CardinalPoint cp)
        {
            throw new NotImplementedException();
        }

        public IRoom GetCurrentRoom()
        {
            throw new NotImplementedException();
        }

        public IdIterator GetIdIterator()
        {
            throw new NotImplementedException();
        }

        public int GetVisitedRooms()
        {
            throw new NotImplementedException();
        }

        public void Update(double elapsed)
        {
            throw new NotImplementedException();
        }
    }
}
