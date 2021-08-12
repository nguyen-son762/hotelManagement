using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    class StaffDAO
    {
        private HotelManagementEntity hotelManagementEntity;
        public StaffDAO()
        {
            hotelManagementEntity = new HotelManagementEntity();
        }
        public List<Staff> getAllStaff()
        {
            return hotelManagementEntity.Staffs.ToList();
        }
        public void addStaff(Staff staff)
        {
            hotelManagementEntity.Staffs.Add(staff);
            Sync();
        }
        public void updateStaff(int id,Staff staff)
        {
            Staff old = hotelManagementEntity.Staffs.FirstOrDefault(s => s.staff_id == id);
            old.name = staff.name;
            old.position = staff.position;
            old.address = staff.address;
            Sync();
        }
        public void deleteStaff(int id)
        {
            Staff old = hotelManagementEntity.Staffs.FirstOrDefault(s => s.staff_id == id);
            hotelManagementEntity.Staffs.Remove(old);
            Sync();
        }
        public void Sync()
        {
            hotelManagementEntity.SaveChanges();
        }
    }
}
