using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Strategy
{
    public class PasswordValidator : StrategyValidator
    {
        public bool validate(string text)
        {
            string tbPassWord = text;
            if(tbPassWord == "")
            {
                MessageBox.Show("Not enoungh information");
                return false;
            }
            if (tbPassWord.Length < 8)
            {
                MessageBox.Show("Password must be longer than 8 characters");
                return false;
            }
            return true;
        }
    }
}
