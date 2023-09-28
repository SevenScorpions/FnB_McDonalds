using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LogInDemo.DTO;
using System.Collections;
using System.Security.Cryptography;

namespace LogInDemo.DAO
{
    internal class TicketDAO:DAO<Ticket>
    {
        private static TicketDAO instance;
        public static TicketDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TicketDAO();
                return instance;
            }
            private set => instance = value;
        }
        public List<string> getleftchairlist()
        {
            List<string> list = new List<string>();
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            foreach (char s in alpha)
            {
                for (int i = 1; i <= 5; i++)
                {
                    list.Add(s.ToString() + i.ToString("00"));
                }
                if (s.ToString() == "p")
                {
                    break;
                }
            }
            return list;
        }
        public List<string> getRightChairList()
        {
            List<string> list = new List<string>();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            foreach (char s in alpha)
            {
                for (int i = 25; i <= 29; i++)
                {
                    list.Add(s.ToString() + i.ToString("00"));
                }
                if (s.ToString() == "P")
                {
                    break;
                }
            }
            return list;
        }
        public List<string> getMiddleChairList()
        {
            List<string> list = new List<string>();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            foreach (char s in alpha)
            {
                for (int i = 1; i <= 29; i++)
                {
                    list.Add(s.ToString() + i.ToString("00"));
                }
                if (s.ToString() == "P")
                {
                    break;
                }
            }
            return list;
        }
        private TicketDAO()
        {

        }
        public List<Ticket> getTicketList(string bid)
        {
            List<Ticket> list = new List<Ticket>();
            string query = @"Select * from Ticket where BID = '" + bid + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Ticket(row));
            }
            return list;
        }
        public List<Ticket> getTicketListIn4(string sid, string username)
        {
            List<Ticket> list = new List<Ticket>();
            string query = @"Select * from BILL where SID = '" + sid + "' AND USERNAME = '" + username + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.AddRange(getTicketList(row["BID"].ToString()));
            }
            return list;
        }
        public List<Ticket> getTicketListFromSID(string sid)
        {
            List<Ticket> list = new List<Ticket>();
            string query = @"Select * from BILL where SID = '" + sid + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.AddRange(getTicketList(row["BID"].ToString()));
            }
            return list;
        }
        public override void Insert(Ticket t)
        {
            string query = string.Format(@"INSERT INTO TICKET (TID, BID, CHAIR) VALUES('{0}', '{1}', '{2}')",
                t.Id, t.Bid, t.Chair);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Delete(Ticket t)
        {
            string query = string.Format(@"DELETE FROM TICKET WHERE TID = '{0}'", t.Id);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Update(Ticket t)
        {
            string query = string.Format(@"UPDATE TICKET SET BID = '{1}', CHAIR = '{2}' WHERE TID = '{0}'",
                t.Id, t.Bid, t.Chair);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override List<Ticket> GetAll()
        {
            List<Ticket> list = new List<Ticket>();
            string query = @"SELECT * FROM TICKET";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Ticket(row));
            }
            return list;
        }
    }

}
