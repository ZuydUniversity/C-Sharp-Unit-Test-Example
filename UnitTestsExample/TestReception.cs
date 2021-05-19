using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using DotNetUnitTestingExample;

namespace UnitTestsExample
{
    [TestClass]
    public class TestReception
    {
        [TestMethod]
        public void TestCreateReception()
        {
            List<Room> rooms = new List<Room>();
            rooms.Add(new Room(1, 25));
            Reception reception = new Reception(rooms);
            List<int> expected = new List<int>();
            expected.Add(1);
            Assert.IsTrue(reception.GetRooms().SequenceEqual(expected));
        }

        [TestMethod]
        public void TestCheckRoomFree()
        {
            List<Room> rooms = new List<Room>();
            Room room = new Room(1, 25);
            rooms.Add(room);
            Reception reception = new Reception(rooms);
            Assert.IsTrue(reception.CheckRoomFree(room.ID));
            room.Book();
            Assert.IsFalse(reception.CheckRoomFree(room.ID));
        }

        [TestMethod]
        public void TestBookRoom()
        {
            List<Room> rooms = new List<Room>();
            Room room = new Room(1, 25);
            rooms.Add(room);
            Reception reception = new Reception(rooms);
            Assert.AreEqual(room.Price, reception.BookRoom(room.ID));
            Assert.IsTrue(room.IsTaken());
        }

        [TestMethod]
        public void TestBookAlreadyBookedRoom()
        {
            List<Room> rooms = new List<Room>();
            Room room = new Room(1, 25);
            rooms.Add(room);
            Reception reception = new Reception(rooms);
            room.Book();
            Assert.AreEqual(-1, reception.BookRoom(room.ID));
        }
    }
}
