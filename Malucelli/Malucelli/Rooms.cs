using System;
using System.Collections.Generic;
using System.Text;

namespace Malucelli
{
    /// <summary>
    /// this class contains some utility fields for the Room, the RoomManager and the RoomBuilder.
    /// </summary>
    static class Rooms
    {
        /// <summary>
        /// upper left corner of the room.
        /// </summary>
        public static Point2D UL_CORNER = new Point2D(240, 177);

        /// <summary>
        /// bottom right corner of the room.
        /// </summary>
        public static Point2D BR_CORNER = new Point2D(1025, 633);

        /// <summary>
        /// center corner of the room.
        /// </summary>
        public static Point2D CENTER = new Point2D((BR_CORNER.X + UL_CORNER.X) / 2, (BR_CORNER.Y + UL_CORNER.Y) / 2);

        /// <summary>
        /// number of rooms per floor.
        /// </summary>
        public static int NUMBER_OF_ROOMS = 10;

    }
}
