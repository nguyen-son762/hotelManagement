using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;
namespace HotelManagement.Business
{
    class CustomerBusiness
    {
        private CustomerDAO customerDAO;
        public CustomerBusiness()
        {
            customerDAO = new CustomerDAO();
        }
        public List<Customer> getAllCustomer()
        {
            return customerDAO.getAllCustomer();
        }
        public void addCustomer(Customer customer)
        {
            customerDAO.addCustomer(customer);
        }
        public Customer getCustomer(int idCus)
        {
            return customerDAO.getCustomer(idCus);
        }
        public Customer getCustomerById(string id)
        {
            return customerDAO.getCustomerById(id);
        }
        public List<Customer> searchCustomer(string name)
        {
            return customerDAO.searchCustomer(name);
        }
        public void updateCustomer(int id,Customer customer)
        {
            customerDAO.updateCustomer(id, customer);
        }
        public void deleteCustomer(int id)
        {
            customerDAO.deleteCustomer(id);
        }
    }
}
