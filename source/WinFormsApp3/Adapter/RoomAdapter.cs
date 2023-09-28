using LogInDemo.Adapter;
using LogInDemo.DAO;
using LogInDemo.DTO;

public class RoomAdapter : IRoomAdapter
{
    public List<Room> GetRoomsByCine(string cid)
    {
        return RoomDAO.Instance.getRoomListByCine(cid);
    }
}