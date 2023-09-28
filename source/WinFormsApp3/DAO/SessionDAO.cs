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
    public class SessionDAO:DAO<Session>
    {
        private static SessionDAO instance;
        private IRoomAdapter roomAdapter;

        public static SessionDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SessionDAO();
                return instance;
            }
            private set => instance = value;
        }
        public static int height = 78;
        public static int width = 455;

        public void SetRoomAdapter(IRoomAdapter adapter)
        {
            roomAdapter = adapter;
        }

        private SessionDAO()
        {

        }
        public List<Session> GetSessionsByMovieCinemaAndDate(Movie movie, Cinema cinema, DateTime? dateTime)
        {
            //List<Room> rooms = RoomDAO.Instance.getRoomListByCine(cinema.Id);
            List<Room> rooms = roomAdapter.GetRoomsByCine(cinema.Id);
            List<Session> sessions = new List<Session>();
            foreach(Room room in rooms)
            {
                sessions.AddRange(GetSessionsByMovieRoom(movie, room, dateTime));
            }
            return sessions;
        }
        public List<Session> GetSessionsByMovieRoom(Movie movie, Room room, DateTime? dateTime)
        {
            List<Session> sessions = new List<Session>();
            string query = @"SELECT * FROM SESSION WHERE 1 = 1";

            if (movie != null)
            {
                query += string.Format(@" AND MID = '{0}'", movie.Id);
            }

            if (room != null)
            {
                query += string.Format(@" AND RID = '{0}'", room.Id);
            }

            //if (dateTime != null)
            //{
            //    DateTime date = dateTime.Value;
            //    query += string.Format(@" AND SD >= '{0}' AND SD < '{1}'", date.ToString("yyyy-MM-dd HH:mm:ss"), date.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss"));
            //}

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                sessions.Add(new Session(row));
            }

            return sessions;
        }
        public override void Insert(Session t)
        {
            string query = string.Format(@"INSERT INTO SESSION (SID, MID, PRICE, SD, MFORMAT, SUBTITLE, RID) VALUES('{0}', '{1}', '{2}', '{3}', N'{4}', N'{5}', '{6}')",
                t.Id, t.Mid, t.Price, t.Date.ToString("yyyy-MM-dd HH:mm:ss"), t.Format, t.Subtitle, t.Room);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Delete(Session t)
        {
            string query = string.Format(@"DELETE FROM SESSION WHERE SID = '{0}'", t.Id);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Update(Session t)
        {
            string query = string.Format(@"UPDATE SESSION SET MID = '{1}', PRICE = '{2}', SD = '{3}', MFORMAT = N'{4}', SUBTITLE = N'{5}', RID = '{6}' WHERE SID = '{0}'",
                t.Id, t.Mid, t.Price, t.Date.ToString("yyyy-MM-dd HH:mm:ss"), t.Format, t.Subtitle, t.Room);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override List<Session> GetAll()
        {
            List<Session> list = new List<Session>();
            string query = @"SELECT * FROM SESSION";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Session(row));
            }
            return list;
        }
    }
}
