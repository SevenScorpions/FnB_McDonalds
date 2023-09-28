using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LogInDemo.DTO;
using System.Security.Cryptography;

namespace LogInDemo.DAO
{
    public class CinemaDAO:DAO<Cinema>
    {
        private static CinemaDAO instance;
        public static CinemaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CinemaDAO();
                return instance;
            }
            private set => instance = value;
        }
        private CinemaDAO() { }
        public List<Cinema> getCinemaListByAID(string aid)
        { 
            List<Cinema> list = new List<Cinema>();
            string query = @"Select * from CINEMA where AID = '" + aid +"'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Cinema(row));
            }
            return list;
        }

        public override void Insert(Cinema t)
        {
            string query = string.Format(@"INSERT INTO CINEMA (CID, CNAME, AID) VALUES('{0}', N'{1}', '{2}')",
                t.Id, t.Name, t.Aid);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Delete(Cinema t)
        {
            string query = string.Format(@"DELETE FROM CINEMA WHERE CID = '{0}'", t.Id);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Update(Cinema t)
        {
            string query = string.Format(@"UPDATE CINEMA SET CNAME = N'{1}', AID = '{2}' WHERE CID = '{0}'",
                t.Id, t.Name, t.Aid);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override List<Cinema> GetAll()
        {
            List<Cinema> list = new List<Cinema>();
            string query = @"SELECT * FROM CINEMA";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Cinema(row));
            }
            return list;
        }
    }
}
