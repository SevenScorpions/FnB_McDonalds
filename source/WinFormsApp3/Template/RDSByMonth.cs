using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Template
{
    public class RDSByMonth : RevenueDataService
    {
        private int year;
        private int month;
        public RDSByMonth(DataGridView dataGridView,int year,int month):base(dataGridView)
        {
            this.month = month;
            this.year = year;
        } 
        protected override bool DayCompare(int day)
        {
            return true;
        }

        protected override bool MonthCompare(int month)
        {
            if (month == this.month) return true;
            return false;
        }

        protected override bool YearCompare(int year)
        {
            if(year == this.year)  return true;
            return false;
        }
    }
}
