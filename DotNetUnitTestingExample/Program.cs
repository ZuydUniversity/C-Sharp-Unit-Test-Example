using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetUnitTestingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Room r1 = new Room(1, 25);
            Room r2 = new Room(2, 10);
            Room r3 = new Room(3, 50);

            List<Room> rooms = new List<Room>();
            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            Reception reception = new Reception(rooms);

            Console.WriteLine(reception.CheckRoomFree(r1.ID));
            Console.WriteLine(reception.BookRoom(r1.ID));
            Console.WriteLine(reception.CheckRoomFree(r1.ID));

            Console.WriteLine(reception.BookRoom(r1.ID));

            Console.ReadKey();
        }
    }
}
