using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    class BillDAO
    {
        private static HotelManagementEntity hotelManagementEntity;
        public BillDAO()
        {
            hotelManagementEntity = new HotelManagementEntity();
        }
        public List<Bill> getAllBills()
        {
            return hotelManagementEntity.Bills.ToList();
        }
        public Bill getBillByRoomId(int id)
        {
            Bill bill = hotelManagementEntity.Bills.FirstOrDefault(b => b.room_id == id && b.status != "Đã thanh toán");
            return bill;
        }
        public void updateBill(int billid, DateTime beginDate, DateTime endDate)
        {
            Bill bill = hotelManagementEntity.Bills.FirstOrDefault(b => b.bill_id == billid);
            if (bill != null)
            {
                bill.begin_date = beginDate;
                bill.end_date = endDate;
            }
            Sync();
        }
        public void addBill(Bill bill)
        {
            hotelManagementEntity.Bills.Add(bill);
            Sync();
        }
        public void updateBillStatus(int id,string status)
        {
            Bill bill = hotelManagementEntity.Bills.FirstOrDefault(b => b.bill_id == id);
            bill.status = status;
            if(status== "Chưa thanh toán")
            {
                Room room = hotelManagementEntity.Rooms.FirstOrDefault(r => r.room_id == bill.room_id);
                room.status = "Có người";
            }
            if(bill.status=="Đã thanh toán")
            {
                Room room = hotelManagementEntity.Rooms.FirstOrDefault(r => r.room_id == bill.room_id);
                room.status = "Còn trống";
            }
            Sync();
        }
        public void payBill(int billId,DateTime end_date,decimal total)
        {
            Bill bill = hotelManagementEntity.Bills.FirstOrDefault(b => b.bill_id == billId);
            Room room = hotelManagementEntity.Rooms.FirstOrDefault(r => r.room_id == bill.room_id);
            room.status = "Còn trống";
            bill.end_date = end_date;
            bill.total = total;
            bill.status = "Đã thanh toán";
            Sync();
        }
        public void deleteBill(int id)
        {
            Bill bill = hotelManagementEntity.Bills.FirstOrDefault(b => b.bill_id == id);
            hotelManagementEntity.Bills.Remove(bill);
            Sync();
        }
        public decimal getStatistical(int begin_month,int end_month,int year)
        {
            DateTime begin = new DateTime(year, begin_month, 1);
            DateTime end;
            end = new DateTime(year, end_month, 28);
            if (end_month == 1||end_month==3||end_month==5 || end_month == 7 || end_month == 8 || end_month == 10 || end_month == 12)
            {
                end= new DateTime(year, end_month, 31);
            }
            else if(end_month==4 || end_month == 6 || end_month == 9 || end_month == 11)
            {
                end = new DateTime(year, end_month, 30);
            }
            decimal total=0;
            List<Bill> list = hotelManagementEntity.Bills.ToList();
            foreach(Bill b in list)
            {
                if (b.end_date < end && b.end_date>begin)
                {
                    total += (decimal)b.total;
                }
            }
            return total;
        }
        public void updateTotal(int id,decimal total)
        {
            Bill bill = hotelManagementEntity.Bills.FirstOrDefault(b => b.bill_id == id);
            bill.total = total;
            Sync();
        }
        public List<Bill> searchByDate(DateTime begin,DateTime end)
        {
            return hotelManagementEntity.Bills.Where(b => b.end_date > begin&&b.end_date<end).ToList();
        }
        public void Sync()
        {
            hotelManagementEntity.SaveChanges();
        }
    }
}
