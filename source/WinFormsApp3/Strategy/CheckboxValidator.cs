using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Strategy
{
    public class CheckboxValidator : StrategyValidator
    {
        public bool validate(string text)
        {
            if (text == "False")
            {
                MessageBox.Show("You must agree to our Terms of Use and Privacy Notice.");
                return false;
            }
            return true;
        }
    }
}
