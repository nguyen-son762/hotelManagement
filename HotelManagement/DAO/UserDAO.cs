using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.Interface;
namespace HotelManagement.DAO
{
    class UserDAO : IUser
    {
        private static HotelManagementEntity hotelManagementEntities;
        public UserDAO()
        {
            hotelManagementEntities = new HotelManagementEntity();
        }

        public Admin login(string username, string password)
        {
            try
            {
                string query = "Select * from Admin where username='" + username + "'AND password='" + password + "'";
                Admin admin = hotelManagementEntities.Admins
                                        .SqlQuery(query)
                                        .First();
                return admin;
            }
            catch
            {
                return null;
            }
        }

        public void logout()
        {
            
        }
    }
}
