using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;
namespace HotelManagement.Business
{
    class StaffBusiness
    {
        private StaffDAO staffDAO;
        public StaffBusiness()
        {
            staffDAO = new StaffDAO();
        }
        public List<Staff> getAllStaff()
        {
            return staffDAO.getAllStaff();
        }
        public void addStaff(Staff staff)
        {
            staffDAO.addStaff(staff);
        }
        public void updateStaff(int id,Staff staff)
        {
            staffDAO.updateStaff(id,staff);
        }
        public void deleteStaff(int id)
        {
            staffDAO.deleteStaff(id);
        }
    }
}
