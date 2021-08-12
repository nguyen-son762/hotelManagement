using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    class CustomerDAO
    {
        private static HotelManagementEntity hotelManagementEntity;
        public CustomerDAO()
        {
            hotelManagementEntity = new HotelManagementEntity();
        }
        public List<Customer> getAllCustomer()
        {
            return hotelManagementEntity.Customers.ToList();
        }
        public void addCustomer(Customer customer)
        {
            hotelManagementEntity.Customers.Add(customer);
            Sync();
        }
        public Customer getCustomer(int idCus)
        {
            return hotelManagementEntity.Customers.FirstOrDefault(c => c.customer_id == idCus);
        }
        public Customer getCustomerById(string id)
        {
           return hotelManagementEntity.Customers.FirstOrDefault(c => c.identity_card_number == id);
        }
        public List<Customer> searchCustomer(string name)
        {
            return hotelManagementEntity.Customers.Where(s => (s.first_name+" " + s.last_name).Contains(name)).ToList();
        }
        public void updateCustomer(int id,Customer customer)
        {
            Customer old = hotelManagementEntity.Customers.FirstOrDefault(i => i.customer_id == id);
            old.first_name = customer.first_name;
            old.last_name = customer.last_name;
            old.address = customer.address;
            old.sex = customer.sex;
            old.phone_number = customer.phone_number;
            old.identity_card_number = customer.identity_card_number;
            Sync();
        }
        public void deleteCustomer(int id)
        {
            Customer cus = hotelManagementEntity.Customers.FirstOrDefault(c => c.customer_id == id);
            hotelManagementEntity.Customers.Remove(cus);
            Sync();
        }
        public void Sync()
        {
            hotelManagementEntity.SaveChanges();
        }
    }
}
