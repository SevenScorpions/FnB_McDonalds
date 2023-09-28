using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static NPOI.SS.Format.CellNumberFormatter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LogInDemo.Strategy
{
    public class UsernameValidator : StrategyValidator
    {
        public bool validate(string text)
        {
            string tbUserName = text;
            if (tbUserName == "")
            {
                MessageBox.Show("Not enoungh information");
                return false;
            }
            if (!Regex.IsMatch(text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("UserName only allows input of letters and numbers without special characters!");
                return false;
            }
            return true;
        }
    }
}
