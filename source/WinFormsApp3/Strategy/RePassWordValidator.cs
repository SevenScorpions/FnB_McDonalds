using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Strategy
{
    public class RePassWordValidator : StrategyValidator
    {
        private readonly string _referenceValue;


        public RePassWordValidator(string referenceValue)
        {
            _referenceValue = referenceValue;
        }

        public bool validate(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Not enoungh information");
                return false;
            }
            if(text != _referenceValue)
            {
                MessageBox.Show("Password does not match");
                return false;
            }
            return true;
        }
    }
}
