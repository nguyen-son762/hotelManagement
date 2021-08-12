using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;
namespace HotelManagement.Business
{
    class ItemBusiness
    {
        private static ItemDAO itemDAO;
        public ItemBusiness()
        {
            itemDAO = new ItemDAO();
        }
        public Item getItemById(int id)
        {
            return itemDAO.getItemById(id);
        }
        public List<Item> getAllItems()
        {
            return itemDAO.getAllItems();
        }
        public void addItem(Item item)
        {
            itemDAO.addItem(item);
        }
        public void updateItem(int id,Item item)
        {
            itemDAO.updateItem(id,item);
        }
        public void deleteItem(int id)
        {
            itemDAO.deleteItem(id);
        }
    }
}
