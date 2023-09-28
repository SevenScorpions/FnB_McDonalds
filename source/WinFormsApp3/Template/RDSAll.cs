using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Template
{
    public class RDSAll : RevenueDataService
    {
        public RDSAll(DataGridView dataGridView) : base(dataGridView)
        {
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
            return true;
        }
    }
}
