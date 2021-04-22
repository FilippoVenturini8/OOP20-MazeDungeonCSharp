using Microsoft.VisualStudio.TestTools.UnitTesting;
using Malucelli;
using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace UnitTest
{
    [TestClass]
    public class TestRoom
    {
        IRoomManager roomManager;
        [TestInitialize]
        public void init()
        {
            roomManager = new RoomManager();
        }

        [TestMethod]
        public void TestActualRoom()
        {
            Assert.IsNotNull(roomManager.ActualRoom);
        }

        [TestMethod]
        public void testChangeRoom()
        {
            IRoom spawn = roomManager.ActualRoom;
            CardinalPoint newRoomPosition = new List<CardinalPoint>(roomManager.ActualRoom.GetDoors())[0];
            roomManager.ChangeRoom(newRoomPosition);
            Assert.IsNotNull(roomManager.ActualRoom);
            Assert.AreNotEqual(spawn, roomManager.ActualRoom);
        }

        [TestMethod]
        public void testAddDynamicObject()
        {
            int initialSize = roomManager.ActualRoom.GetCurrentDynamicObjects().Count;
            Debug.Print(initialSize.ToString());
            DynamicObject obj = new DynamicObject();
            roomManager.ActualRoom.AddDynamicObject(obj);
            int finalSize = roomManager.ActualRoom.GetCurrentDynamicObjects().Count;
            Assert.AreEqual<int>((initialSize + 1), finalSize);

            roomManager.ActualRoom.DeleteDynamicObject(obj);
            finalSize = roomManager.ActualRoom.GetCurrentDynamicObjects().Count;
            Assert.AreEqual<int>(initialSize, finalSize);
        }

    }
}
