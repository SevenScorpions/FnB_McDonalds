using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Strategy
{
    public class IdValidator : StrategyValidator
    {
        public bool validate(string text)
        {
            string id = text;
            if( id == "") 
            {
                MessageBox.Show("Not enoungh information");
                return false;
            }
            return true;
        }
    }
}
