using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Command
{
    public class SelectCommand : ICommand
    {
        private readonly Button _button;
        private readonly List<string> _currentTicketList;

        public SelectCommand(Button button, List<string> currentTicketList)
        {
            _button = button;
            _currentTicketList = currentTicketList;
        }

        public void Execute()
        {
            _button.BackColor = Color.DarkCyan;
            _button.ForeColor = Color.White;
            _currentTicketList.Add(_button.Text);
        }
    }
}
