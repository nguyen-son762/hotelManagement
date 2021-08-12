using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    class ItemDAO
    {
        private static HotelManagementEntity hotelManagementEntity;
        public ItemDAO()
        {
            hotelManagementEntity = new HotelManagementEntity();
        }
        public List<Item> getAllItems()
        {
                return hotelManagementEntity.Items.ToList();
        }
        public Item getItemById(int id)
        {
                return hotelManagementEntity.Items.FirstOrDefault(i => i.item_id == id);

        }
        public void addItem(Item item)
        {
            hotelManagementEntity.Items.Add(item);
            Sync();
        }
        public void updateItem(int id,Item item)
        {
            Item olditem = hotelManagementEntity.Items.FirstOrDefault(i => i.item_id ==id);
            olditem.name = item.name;
            olditem.price = item.price;
            olditem.amount = item.amount;
            Sync();
        }
        public void deleteItem(int id)
        {
            Item item = hotelManagementEntity.Items.FirstOrDefault(i => i.item_id == id);
            hotelManagementEntity.Items.Remove(item);
            Sync();
        }
        public void Sync()
        {
            hotelManagementEntity.SaveChanges();
        }
    }
}
