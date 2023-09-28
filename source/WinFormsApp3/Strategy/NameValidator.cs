using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Strategy
{
    public class NameValidator : StrategyValidator
    {
        public bool validate(string text)
        {
            string name = text;
            if(name == "")
            {
                MessageBox.Show("Not enoungh information");
                return false;
            }
            if (name.Length < 2)
            {
                MessageBox.Show("Name must be longer than 2 characters");
                return false;
            }
            return true;
        }
    }
}
