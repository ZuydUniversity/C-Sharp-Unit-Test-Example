using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetUnitTestingExample
{
    /// <summary>
    /// A Room in the hotel.
    /// </summary>
    public class Room
    {
        public int ID { get; }
        private bool Taken;
        public int Price { get; set; }

        /// <summary>
        /// Constructor for the room.
        /// </summary>
        /// <param name="ID">The ID of the room</param>
        /// <param name="price">The price of the room</param>
        public Room(int ID, int price)
        {
            this.ID = ID;
            this.Price = price;
            this.Taken = false;
        }

        /// <summary>
        /// Check if the room is taken.
        /// </summary>
        /// <returns>Whether the Room is taken or not.</returns>
        public bool IsTaken()
        {
            return Taken;
        }

        /// <summary>
        /// Book the Room.
        /// </summary>
        /// <returns>Whether the Room was successfully booked or not.</returns>
        public bool Book()
        {
            if (Taken)
            {
                return false;
            }
            Taken = true;
            return true;
        }
        
        /// <summary>
        /// Unbook the room.
        /// </summary>
        /// <returns>Whether the room was successfully unbooked or not.</returns>
        public bool Unbook()
        {
            if (!Taken)
            {
                return false;
            }
            Taken = false;
            return true;
        }
    }
}
