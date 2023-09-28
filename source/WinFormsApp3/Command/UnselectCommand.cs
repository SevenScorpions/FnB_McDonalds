using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Command
{
    public class UnselectCommand : ICommand
    {
        private readonly Button _button;
        private readonly List<string> _currentTicketList;

        public UnselectCommand(Button button, List<string> currentTicketList)
        {
            _button = button;
            _currentTicketList = currentTicketList;
        }

        public void Execute()
        {
            _button.BackColor = Color.White;
            _button.ForeColor = Color.Black;
            _currentTicketList.Remove(_button.Text);
        }
    }

}
