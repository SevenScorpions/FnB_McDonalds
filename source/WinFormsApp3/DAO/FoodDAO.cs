
﻿using LogInDemo.DTO;
using System;
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogInDemo.DTO;

namespace LogInDemo.DAO
{
    public class FoodDAO:DAO<Food>
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodDAO();
                return instance;
            }
            private set => instance = value;
        }

        private FoodDAO() { }

        public override void Insert(Food t)
        {
            string query = string.Format(@"INSERT INTO FOOD (FID, Name, Price, Quantity) VALUES('{0}', N'{1}', {2}, {3})",
                t.Id, t.Name, t.Price, t.Quantity);
            DataProvider.Instance.ExcuteQuery(query);
        }
        public override void Delete(Food t)
        {
            string query = string.Format(@"DELETE FROM FOOD WHERE FID = '{0}'", t.Id);
            DataProvider.Instance.ExcuteQuery(query);
        }
        public override void Update(Food t)
        {
            string query = string.Format(@"UPDATE FOOD SET Name = N'{1}', Price = {2}, Quantity = {3} WHERE FID = '{0}'",
                t.Id, t.Name, t.Price, t.Quantity);
            DataProvider.Instance.ExcuteQuery(query);
        }
        public override List<Food> GetAll()
        {
            List<Food> list = new List<Food>();
            string query = @"Select * from FOOD";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Food(row));
            }
            return list;
        }
    }
}
