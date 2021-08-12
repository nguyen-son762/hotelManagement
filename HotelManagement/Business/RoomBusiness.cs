using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;
namespace HotelManagement.Business
{
    class RoomBusiness
    {
        private RoomDAO roomDAO;
        public RoomBusiness()
        {
            roomDAO = new RoomDAO();
        }
        public List<Room> getAllRooms()
        {
            return roomDAO.getAllRooms();
        }
        public List<Room> getRoomsByTypeAndStatus(string type,string status)
        {
                List<Room> rooms = roomDAO.getRoomsByTypeAndStatus(type,status);
                return rooms;
        }
        public Room getRoomByID(int id)
        {
            return roomDAO.getRoomsById(id);
        }
        public void addRoom(Room room)
        {
            roomDAO.addRoom(room);
        }
        public void fixRoom(Room room)
        {
            roomDAO.changeDetailRoom(room);
        }
        public void deleteRoom(int id)
        {
            roomDAO.deleteRoom(id);
        }
        public void updateRoomStatus(int id, string status)
        {
            roomDAO.updateRoomStatus(id, status);
        }
    }
}
