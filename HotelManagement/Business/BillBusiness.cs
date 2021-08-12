using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;
namespace HotelManagement.Business
{
   
    class BillBusiness
    {
        private BillDAO billDAO;
        public BillBusiness()
        {
            billDAO = new BillDAO();
        }
        public List<Bill> getAllBills()
        {
           return billDAO.getAllBills();
        }
        public Bill getBillByRoomId(int id)
        {
            return billDAO.getBillByRoomId(id);
        }
        public void updateBill(int billid, DateTime beginDate, DateTime endDate)
        {
            billDAO.updateBill(billid, beginDate, endDate);
        }
        public void  addBill(Bill bill)
        {
            billDAO.addBill(bill);
        }
        public void updateBillStatus(int id, string status)
        {
            billDAO.updateBillStatus(id, status);
        }
        public void updateTotal(int id, decimal total)
        {
            billDAO.updateTotal(id, total);
        }
        public void payBill(int billId, DateTime end_date, decimal total)
        {
            billDAO.payBill(billId, end_date, total);
        }
        public void deleteBill(int id)
        {
            billDAO.deleteBill(id);
        }
        public decimal getStatistical(int begin_month, int end_month, int year)
        {
            return billDAO.getStatistical(begin_month, end_month, year);
        }
        public List<Bill> searchByDate(DateTime begin, DateTime end)
        {
            return billDAO.searchByDate(begin, end);
        }
    }
}
