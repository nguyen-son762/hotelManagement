using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.Interface;
using HotelManagement.DAO;
namespace HotelManagement.Business
{
    class AdminManager : IHotelManager
    {   
        private readonly UserDAO user;

        public AdminManager()
        {
            this.user = new UserDAO();
        }
        public Admin signin(string username, string password)
        {
            Admin admin = user.login(username, password);
            return admin;
        }
        
        public void Sync()
        {
        }
    }
}
