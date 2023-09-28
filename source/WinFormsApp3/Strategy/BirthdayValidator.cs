using NPOI.SS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Strategy
{
    public class BirthdayValidator : StrategyValidator
    {
        public bool validate(string text)
        {
            string bd = text;
            DateTime current = DateTime.Now;
            DateTime input = DateTime.Parse(text);
            if (bd == "")
            {
                MessageBox.Show("Not enoungh information");
                return false;
            }
            if(current < input)
            {
                MessageBox.Show("Date cannot exceed current date!");
                return false;
            }
            return true;
        }
    }
}
