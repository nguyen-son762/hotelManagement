using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Interface
{
    public interface IHotelManager
    {
        Admin signin(string username,string password);
        void Sync();
    }
}
