using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DotNetUnitTestingExample;

namespace UnitTestsExample
{
    [TestClass]
    public class TestRoom
    {
        [TestMethod]
        public void TestFailing()
        {
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void TestCreate()
        { 
            Room room = new Room(1, 25);
            Assert.AreEqual(1, room.ID);
            Assert.AreEqual(25, room.Price);
        }

        [TestMethod]
        public void TestBook()
        {
            Room room = new Room(1, 25);
            Assert.IsFalse(room.IsTaken());
            Assert.IsTrue(room.Book());
            Assert.IsTrue(room.IsTaken());
        }

        [TestMethod]
        public void TestBookAlreadyBookedRoom()
        {
            Room room = new Room(1, 25);
            room.Book();
            Assert.IsFalse(room.Book());
        }

        [TestMethod]
        public void TestUnbook()
        {
            Room room = new Room(1, 25);
            room.Book();
            Assert.IsTrue(room.Unbook());
            Assert.IsFalse(room.IsTaken());
        }
    }
}
