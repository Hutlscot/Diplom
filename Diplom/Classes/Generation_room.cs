using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Diplom
{
    public static class Generation_room
    {
        //метод для генерации списка свободных комнат
        public static List<Room> Generation()
        {
            using (ConnectionEntity dbContext = new ConnectionEntity())
            {
                List<Room> rooms = new List<Room>();
                foreach(Room room in dbContext.Rooms.ToList())
                {
                    if (room.NumberOfPlace>room.Contracts.Count)
                    {
                        rooms.Add(room);
                    }
                }
                return rooms;
            }
        }
    }
}
