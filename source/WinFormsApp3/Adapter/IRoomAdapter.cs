using LogInDemo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Adapter
{
    public interface IRoomAdapter
    {
        List<Room> GetRoomsByCine(string cid);
    }
}
