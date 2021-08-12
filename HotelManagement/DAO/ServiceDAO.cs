using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    class ServiceDAO
    {
        private static HotelManagementEntity hotelManagementEntity;
        public ServiceDAO()
        {
            hotelManagementEntity = new HotelManagementEntity();
        }
        public List<Service> getServicesByBillId(int id)
        {
                return hotelManagementEntity.Services.Where(s => s.bill_id == id).ToList();
        }
        public int updateService(int id,int quantity)
        {
                Service oldSerivce = hotelManagementEntity.Services.FirstOrDefault(s => s.service_id == id);
                string idd = oldSerivce.item_id+"";
                int x = Int32.Parse(idd);
                Item oldItem = hotelManagementEntity.Items.FirstOrDefault(i => i.item_id ==x);
                if (quantity > oldItem.amount)
                {
                    return 0;
                }
                oldItem.amount = oldItem.amount + oldSerivce.quantity - quantity;
                oldSerivce.quantity = quantity;
                Sync();
                return 1;
        }
        public int addService(int id,string itemName,int quantity)
        {
                Service service = new Service();
                Item item = hotelManagementEntity.Items.FirstOrDefault(i => i.name == itemName);
                service.item_id = item.item_id;
                service.quantity = quantity;
                service.bill_id = id;
                if (quantity > item.amount)
                {
                    return 0;
                }
                hotelManagementEntity.Services.Add(service);
                Sync();
                return 1;
        }
        public void deleteService(int idService)
        {
            Service service = hotelManagementEntity.Services.FirstOrDefault(s => s.service_id == idService);
            hotelManagementEntity.Services.Remove(service);
            Sync();
        }
        public void Sync()
        {
            hotelManagementEntity.SaveChanges();
        }
    }
}
