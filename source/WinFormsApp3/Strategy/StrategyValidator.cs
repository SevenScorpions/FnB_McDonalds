using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Strategy
{
    public interface StrategyValidator
    {
        Boolean validate(string text);
    }
}
