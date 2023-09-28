using LogInDemo.DAO;
using LogInDemo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Template
{
    public abstract class RevenueDataService
    {
        private DataGridView dataGridView;
        protected RevenueDataService(DataGridView dataGridView) 
        {
            this.dataGridView = dataGridView;
        }
        public void FillStatisticData()
        {
            List<Bill> bills = BillDAO.Instance.GetAll();
            List<Bill> validBills = new List<Bill>();
            foreach(Bill bill in bills)
            {
                if(MonthCompare(bill.DateCreate.Month) && DayCompare(bill.DateCreate.Day) && YearCompare(bill.DateCreate.Year))
                {
                    validBills.Add(bill);
                }
            }
            dataGridView.DataSource = validBills;
        }
        protected abstract bool MonthCompare(int month);
        protected abstract bool DayCompare(int day);
        protected abstract bool YearCompare(int year);

    }
}
