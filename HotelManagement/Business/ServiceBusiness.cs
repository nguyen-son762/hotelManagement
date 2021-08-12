using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;
namespace HotelManagement.Business
{
    class ServiceBusiness
    {
        private static ServiceDAO serviceDAO;
        public ServiceBusiness()
        {
            serviceDAO = new ServiceDAO();
        }
        public List<Service> getServicesByBillId(int id)
        {
            return serviceDAO.getServicesByBillId(id);
        }
        public int updateService(int id,int quantity)
        {
            return serviceDAO.updateService(id, quantity);
        }
        public int addService(int billId,string itemName,int quantity)
        {
            return serviceDAO.addService(billId, itemName, quantity);
        }
        public void deleteService(int id)
        {
            serviceDAO.deleteService(id);
        }
    }
}
