using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LogInDemo.DTO;
using LogInDemo.Adapter;

namespace LogInDemo.DAO
{
    public class RoomDAO:DAO<Room>
    {
        private static RoomDAO instance;
        public static RoomDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RoomDAO();
                return instance;
            }
            private set => instance = value;
        }
        private RoomDAO()
        {

        }
        public List<Room> getRoomListByCine(string cid)
        {
            List<Room> list = new List<Room>();
            string query = @"Select * from Room where CID = '" + cid + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {

                list.Add(new Room(row));
            }
            return list;
        }

        public override void Insert(Room t)
        {
            string query = string.Format(@"INSERT INTO ROOM (RID, RNUMBER, CID) VALUES('{0}', '{1}', '{2}')",
                t.Id, t.Number, t.Cid);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Delete(Room t)
        {
            string query = string.Format(@"DELETE FROM ROOM WHERE RID = '{0}'", t.Id);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Update(Room t)
        {
            string query = string.Format(@"UPDATE ROOM SET RNUMBER = '{1}', CID = '{2}' WHERE RID = '{0}'",
                t.Id, t.Number, t.Cid);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override List<Room> GetAll()
        {
            List<Room> list = new List<Room>();
            string query = @"SELECT * FROM ROOM";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Room(row));
            }
            return list;
        }
    }
}
