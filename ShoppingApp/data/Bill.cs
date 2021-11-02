using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.data
{
    public class Bill
    {
        string id;
        DataRow[] meals;
        int[] numbers;
        string address;
        int status;
        DateTime dateTimeOrder;
        string message;
        

        public Bill(DataRow[] meals, string address, DateTime dateTimeOrder)
        {
            int numberOfMeal = meals.Length;
            this.id = Bills.getInstant().getBills().Count().ToString();
            this.address = address;
            this.meals = meals;
            numbers = new int[numberOfMeal];
            for(int i = 0; i < numberOfMeal; i++)
            {
                this.numbers[i] = (int)meals[i][5];
            }
            this.status = 1;
            this.dateTimeOrder = dateTimeOrder;
            this.message = "";
        }

        public void CancelOrder(string mess)
        {
            this.status = 3;
            this.message = mess;
        }

        public string getReason()
        {
            return this.message;
        }
        public string getAdd()
        { return this.address; }
        public int getStatus()
        {
            return status;
        }

        public void setStatus(int status)
        {
            this.status = status;
        }
        public int[] getNumbers()
        {
            return this.numbers;
        }

        public DataRow[] getMeals()
        {
            return meals;
        }

        public string getAddress()
        {
            return this.address;
        }

        public DateTime getDateOrder()
        {
            return this.dateTimeOrder;
        }
    }


    class Bills
    {
        private static Bills __instant;

        public static Bills getInstant()
        {
            if (__instant == null)
                __instant = new Bills();
            return __instant;
        }

        List<Bill> bills;

        public Bills()
        {
            bills = new List<Bill>();
        }

        public void add(Bill bill)
        {
            bills.Add(bill);
        }

        public List<Bill> getBills()
        {
            return bills;
        }

        public List<Bill> getPendingBills()
        {
            List<Bill> pendingBills = new List<Bill>();
            foreach(Bill bill in bills)
            {
                if (bill.getStatus() == 1)
                {
                    TimeSpan timeSpan = DateTime.Now.Subtract(bill.getDateOrder());
                    if (timeSpan.TotalSeconds < 30)
                        pendingBills.Add(bill);
                    else
                        bill.setStatus(2);
                }
            }
            return pendingBills;
        }


        public List<Bill> getDeliveringBills()
        {
            List<Bill> dlrBills = new List<Bill>();
            foreach (Bill bill in bills)
            {
                if (bill.getStatus() == 2)
                    dlrBills.Add(bill);
            }
            return dlrBills;
        }

        public List<Bill> getCanceledBills()
        {
            List<Bill> canceledBills = new List<Bill>();
            foreach (Bill bill in bills)
            {
                if (bill.getStatus() == 3)
                    canceledBills.Add(bill);
            }
            return canceledBills;
        }
    }
}
