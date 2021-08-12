using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    class RoomDAO
    {
        private static HotelManagementEntity hotelManagementEntity;
        public RoomDAO()
        {
            hotelManagementEntity = new HotelManagementEntity();
        }
        public List<Room> getAllRooms()
        {

            List<Room> rooms = hotelManagementEntity.Rooms.ToList();
            return rooms;


        }
        public List<Room> getRoomsByTypeAndStatus(string type, string status)
        {

            List<Room> rooms = hotelManagementEntity.Rooms.Where(r => r.type.Contains(type) && r.status.Contains(status)).ToList();
            return rooms;
        }
        public Room getRoomsById(int id)
        {

            Room room = hotelManagementEntity.Rooms.FirstOrDefault(r => r.room_id == id);
            return room;

        }
        public void addRoom(Room room)
        {

            hotelManagementEntity.Rooms.Add(room);
            Sync();

        }
        public void changeDetailRoom(Room room)
        {
            Room room1 = hotelManagementEntity.Rooms.FirstOrDefault(r => r.room_id == room.room_id);
            room1.name = room.name;
            room1.price = room.price;
            room1.type = room.type;
            room1.status = room.status;
            if (room.status == "Còn trống")
            {
                Bill bill = hotelManagementEntity.Bills.FirstOrDefault(b => b.status != "Đã thanh toán" && b.room_id == room.room_id);
                if (bill != null)
                {
                    hotelManagementEntity.Bills.Remove(bill);
                }
            }
            Sync();

        }
        public void deleteRoom(int id)
        {

            Room room1 = hotelManagementEntity.Rooms.FirstOrDefault(r => r.room_id == id);
            hotelManagementEntity.Rooms.Remove(room1);
            Sync();

        }
        public void updateRoomStatus(int id,string status)
        {
            Room room = hotelManagementEntity.Rooms.FirstOrDefault(r=>r.room_id==id);
            room.status = status;
            Sync();
        }
        public void Sync()
        {
            hotelManagementEntity.SaveChanges();
        }
    }
}
