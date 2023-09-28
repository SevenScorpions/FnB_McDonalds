using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Template
{
    public class RDSByDate:RevenueDataService
    {
        private int day;
        private int month;
        private int year;
        public RDSByDate(DataGridView dataGridView, int day, int month, int year):base(dataGridView)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        protected override bool DayCompare(int day)
        {
            return this.day == day;
        }

        protected override bool MonthCompare(int month)
        {
            return month == this.month;
        }

        protected override bool YearCompare(int year)
        {
            return year == this.year;
        }
    }
}
