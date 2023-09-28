using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LogInDemo.DTO;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;

namespace LogInDemo.DAO
{
    public class BillDAO:DAO<Bill>
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
            private set => instance = value;
        }
        private BillDAO()
        {

        }
        public List<Bill> getBillList(string sid)
        {
            List<Bill> list = new List<Bill>();
            string query = @"Select * from Bill where SID = '" + sid + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {

                list.Add(new Bill(row));
            }
            return list;
        }
        public List<Bill> getBillList(string sid,string username)
        {
            List<Bill> list = new List<Bill>();
            string query = @"Select * from Bill where SID = '" + sid + "' and USERNAME = '" + username +"'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {

                list.Add(new Bill(row));
            }
            return list;
        }
        public List<Bill> getUserBill(string username)
        {
            List<Bill> list = new List<Bill>();
            string query = @"Select * from Bill where USERNAME = '" + username + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {

                list.Add(new Bill(row));
            }
            return list;
        }
        public override void Insert(Bill t)
        {
            string query = string.Format(@"INSERT INTO BILL VALUES('{0}','{1}','{2}',N'{3}','{4}','{5}','{6}')", t.Id, t.Username, t.Sid, t.Term, t.Fid, t.Total,t.DateCreate);
            DataProvider.Instance.ExcuteQuery(query);
        }
        public override void Delete(Bill t)
        {
            string query = string.Format(@"delete from bill where bid = '{0}'", t.Id);
            DataProvider.Instance.ExcuteQuery(query);
        }
        public override void Update(Bill t)
        {
            string query = string.Format(@"update BILL SET USERNAME = '{0}', SID = '{1}', TERM = N'{2}',FID = '{3}',TOTAL = {4},DCREATE = '{5}' WHERE BID = '{6}'",t.Username,t.Sid,t.Term,t.Fid,t.Total,t.DateCreate);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override List<Bill> GetAll()
        {
            List<Bill> list = new List<Bill>();
            string query = @"Select * from Bill";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {

                list.Add(new Bill(row));
            }
            return list;
        }
    }
}
