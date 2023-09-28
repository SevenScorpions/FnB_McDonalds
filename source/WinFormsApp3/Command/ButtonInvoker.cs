using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Command
{
    public class ButtonInvoker
    {
        private readonly ICommand _selectedCommand;
        private readonly ICommand _unselectedCommand;

        public ButtonInvoker(ICommand selectedCommand, ICommand unselectedCommand)
        {
            _selectedCommand = selectedCommand;
            _unselectedCommand = unselectedCommand;
        }

        public void SelectButton()
        {
            _selectedCommand.Execute();
        }

        public void UnselectButton()
        {
            _unselectedCommand.Execute();
        }
    }
}
