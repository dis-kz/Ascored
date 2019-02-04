using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using LinqToDB;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataMapping
{
    public class DbService
    {
        AscoredDB db;
        public DbService(string ConnectionString)
        {
            db = new AscoredDB(ConnectionString);
            db.CommandTimeout = 60000;
            db.Command.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED";
            db.Command.ExecuteNonQuery();
        }

        //новая запись
        public void Insert<T>(T po)
        {
            db.Insert(po);
        }

        //обновление записи
        public void Update<T>(T po, Func<T, Expression<Func<T, bool>>> predicate, Func<T, Expression<Func<T, T>>> setter) where T : class
        {
            if (setter == null)
            {
                db.Update(po);
            }
            else
            {
                db.GetTable<T>().Update(predicate(po), setter(po));
            }
        }

        #region Orders

        public IEnumerable<Order> GetOrders()
        {
            var list = db.Orders.ToList();
            return list;
        }

        public Order GetOrderById(Guid orderguid)
        {
            var order = db.Orders.Where(o => o.OrderGuid == orderguid).First();
            return order;
        }

        #endregion
    }
}
