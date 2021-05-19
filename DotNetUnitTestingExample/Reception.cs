using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetUnitTestingExample
{
    /// <summary>
    /// Reception of the hotel. The Reception class is responsible
    /// for managing the rooms of the hotel.
    /// </summary>
    public class Reception
    {
        private readonly List<Room> Rooms;
        
        /// <summary>
        /// Constructor for the Reception class.
        /// </summary>
        /// <param name="rooms">The list of Room objects managed by
        ///     this Reception.</param>
        public Reception(List<Room> rooms)
        {
            this.Rooms = rooms;
        }
        
        /// <summary>
        /// Find a Room in the list of rooms based on the ID.
        /// </summary>
        /// <param name="roomId">The ID of the room to find</param>
        /// <returns>Returns the Room if found.</returns>
        private Room FindRoom(int roomId)
        {
            foreach (Room room in Rooms)
            {
                if (room.ID == roomId)
                {
                    return room;
                }
            }
            throw new KeyNotFoundException();
        }
        
        /// <summary>
        /// Check if a Room is free.
        /// </summary>
        /// <param name="roomId">ID of the room to check.</param>
        /// <returns></returns>
        public bool CheckRoomFree(int roomId)
        {
            Room room = FindRoom(roomId);
            return !room.IsTaken();
        }

        /// <summary>
        /// Book a Room if it is available.
        /// </summary>
        /// <param name="roomId">ID of the Room to book.</param>
        /// <returns>The price of the Room or -1 if the room is not available</returns>
        public int BookRoom(int roomId)
        {
            Room room = FindRoom(roomId);
            bool success = room.Book();
            if (success)
            {
                return room.Price;
            }

            return -1;
        }

        /// <summary>
        /// Unbook a Room.
        /// </summary>
        /// <param name="roomId">ID of the room to unbook.</param>
        /// <returns>Whether the Room has been unbooked or not</returns>
        public bool UnbookRoom(int roomId)
        {
            Room room = FindRoom(roomId);
            return room.Unbook();
        }

        /// <summary>
        /// Get the list of rooms (by ID) managed by this reception.
        /// </summary>
        /// <returns>A list of room IDs</returns>
        public List<int> GetRooms()
        {
            List<int> roomIds = new List<int>();
            foreach (Room room in Rooms)
            {
                roomIds.Add(room.ID);
            }

            return roomIds;
        }

        /// <summary>
        /// Get the list of available rooms (by ID).
        /// </summary>
        /// <returns>The list of available rooms by ID</returns>
        public List<int> GetFreeRooms()
        {
            List<int> freeRooms = new List<int>();
            foreach (Room room in Rooms)
            {
                if (!room.IsTaken())
                {
                    freeRooms.Add(room.ID);
                }
            }
            return freeRooms;
        }


    }
}
