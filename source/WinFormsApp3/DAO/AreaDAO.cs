using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LogInDemo.DTO;

namespace LogInDemo.DAO
{
    public class AreaDAO:DAO<Area>
    {
        private static AreaDAO instance;
        public static AreaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AreaDAO();
                return instance;
            }
            private set => instance = value;
        }
        
        private AreaDAO()
        {
                
        }

        public override void Insert(Area t)
        {
            string query = string.Format(@"INSERT INTO AREA VALUES('{0}',N'{1}'",t.Id,t.Name);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Delete(Area t)
        {
            string query = string.Format(@"delete from area where aid = '{0}'", t.Id);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override void Update(Area t)
        {
            string query = string.Format(@"update AREA SET, ANAME = N'{1}' WHERE AID = '{0}'", t.Id,t.Name);
            DataProvider.Instance.ExcuteQuery(query);
        }

        public override List<Area> GetAll()
        {
            List<Area> list = new List<Area>();
            string query = @"Select * from AREA";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {

                list.Add(new Area(row));
            }
            return list;
        }
    }
}
