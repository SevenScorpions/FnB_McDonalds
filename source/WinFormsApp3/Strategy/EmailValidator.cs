using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogInDemo.Strategy
{
    public class EmailValidator : StrategyValidator
    {
        static bool isValid(string email)
        {
            string regex = "^(?=.{1,64}@)[A-Za-z0-9_-]+(\\.[A-Za-z0-9_-]+)*@" + "[^-][A-Za-z0-9-]+(\\.[A-Za-z0-9-]+)*(\\.[A-Za-z]{2,})$";
            if (email == "")
            {
                MessageBox.Show("Not enoungh information");
                return false;
            }
            if (!Regex.IsMatch(email, regex))
            {
                MessageBox.Show("Example: ThanhDat@gmail.com");
                return false;
            }
            return true;
        }


        public bool validate(string text)
        {
            return isValid(text);
        }
    }
}
