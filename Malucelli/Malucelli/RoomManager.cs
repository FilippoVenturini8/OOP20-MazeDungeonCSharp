using System;
using System.Collections.Generic;
using System.Text;

namespace Malucelli
{
    class RoomManager : IRoomManager
    {
        private Dictionary<Point2D, IRoom> rooms = new Dictionary<Point2D, IRoom>();

        RoomManager()
        {
            this.InitializeRooms(this.CreateGameMap());
        }

        public IRoom ActualRoom { get; private set; }

        public IdIterator IdIterator { get; private set; }

        public int VisitedRooms { get; private set; }

        private Point2D GetNearRoomPosition(Point2D point, CardinalPoint cardinalPoint)
        {
            switch (cardinalPoint)
            {
                case CardinalPoint.NORTH:
                    return new Point2D(point.X, point.Y + 1);
                case CardinalPoint.SOUTH:
                    return new Point2D(point.X, point.Y - 1);
                case CardinalPoint.WEST:
                    return new Point2D(point.X - 1, point.Y);
                default:
                    return new Point2D(point.X + 1, point.Y);
            }
        }

        private void InitializeRooms(Dictionary<Point2D, IList<CardinalPoint>> map)
        {
            foreach(Point2D point in map.Keys)
            {
                IList<CardinalPoint> cps = map.GetValueOrDefault(point);
                Room room = new Room(this, cps);
                this.rooms.Add(point, room);
            }
            
            this.ActualRoom = rooms.GetValueOrDefault(new Point2D(0, 0));
            this.ActualRoom.Visit();
        }

        private Dictionary<Point2D, IList<CardinalPoint>> CreateGameMap()
        {

            Dictionary<Point2D, IList<CardinalPoint>> map = new Dictionary<Point2D, IList<CardinalPoint>>();
            map.Add(new Point2D(0, 0), new List<CardinalPoint>());

            while (map.Count < Rooms.NUMBER_OF_ROOMS)
            {
                CardinalPoint extractedCP = CardinalPoints.GetAny();
                Point2D extractedPosition = new List<Point2D>(map.Keys)[new Random().Next(map.Count)];
                Point2D newRoomPosition = this.GetNearRoomPosition(extractedPosition, extractedCP);
                if (!map.ContainsKey(newRoomPosition))
                {
                    map.Add(newRoomPosition, new List<CardinalPoint>());
                }
                map.GetValueOrDefault(newRoomPosition).Add(CardinalPoints.GetOpposite(extractedCP));
                map.GetValueOrDefault(extractedPosition).Add(extractedCP);
            }
            return map;
        }
        private Point2D GetRoomPosition(IRoom room)
        {
            foreach(Point2D point in rooms.Keys)
            {
                if (rooms.GetValueOrDefault(point).Equals(room))
                {
                    return point;
                }
            }
            throw new ArgumentException();
        }

        public void ChangeRoom(CardinalPoint cp)
        {
            IRoom newRoom = rooms.GetValueOrDefault(this.GetNearRoomPosition(this.GetRoomPosition(ActualRoom), cp));
            if (newRoom == null)
            {
                return;
            }
            if (!newRoom.IsVisited)
            {
                this.VisitedRooms++;
            }
            this.ActualRoom = newRoom;
            this.ActualRoom.Visit();
        }

        public void Update(double elapsed)
        {
            ActualRoom.Update(elapsed);
        }
    }
}
