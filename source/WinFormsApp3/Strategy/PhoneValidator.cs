using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Strategy
{
    public class PhoneValidator : StrategyValidator
    {
        public bool validate(string text)
        {
            if (text == "")
            {
                return false;
            }
            try
            {
                int.Parse(text);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Phone is numbers");
                return false;
            }
        }
    }
}
