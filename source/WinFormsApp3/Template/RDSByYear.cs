using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Template
{
    internal class RDSByYear : RevenueDataService
    {
        private int year;
        public RDSByYear(DataGridView dataGridView, int year):base(dataGridView) 
        {
            this.year = year;
        }
        protected override bool DayCompare(int day)
        {
            return true;
        }

        protected override bool MonthCompare(int month)
        {
            return true;
        }

        protected override bool YearCompare(int year)
        {
            if(year == this.year) 
            { 
                return true;
            }
            return false;
        }
    }
}
