using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LogInDemo.DTO;
namespace LogInDemo.DAO
{
    public class MovieDAO:DAO<Movie>
    {
        private static MovieDAO instance;
        public static MovieDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MovieDAO();
                return instance;
            }
            private set => instance = value;
        }
        private MovieDAO() { }

        public override void Insert(Movie t)
        {
            string query = string.Format(@"INSERT INTO MOVIE (MID, MNAME, DIRECTOR, LENGTH) VALUES('{0}', N'{1}', N'{2}', '{3}')",
                t.Id, t.Name, t.Director, t.Length);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Delete(Movie t)
        {
            string query = string.Format(@"DELETE FROM MOVIE WHERE MID = '{0}'", t.Id);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Update(Movie t)
        {
            string query = string.Format(@"UPDATE MOVIE SET MNAME = N'{1}', DIRECTOR = N'{2}', LENGTH = '{3}' WHERE MID = '{0}'",
                t.Id, t.Name, t.Director, t.Length);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override List<Movie> GetAll()
        {
            List<Movie> list = new List<Movie>();
            string query = @"SELECT * FROM MOVIE";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Movie(row));
            }
            return list;
        }
    }
}
