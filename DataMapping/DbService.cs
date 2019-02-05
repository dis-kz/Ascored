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

        public DbService() : this("SqlServer", "data source=localhost;initial catalog=Ascored;persist security info=True;user id=sa;password=Pass123;") { }

        public DbService(string providerName, string connectionString)
        {
            db = new AscoredDB(providerName, connectionString);
            db.CommandTimeout = 60000;
            db.Command.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED";
            db.Command.ExecuteNonQuery();
        }

        //новая запись
        public int Insert<T>(T po)
        {
            return db.Insert(po);
        }

        //обновление записи
        public int Update<T>(T po, Func<T, Expression<Func<T, bool>>> predicate, Func<T, Expression<Func<T, T>>> setter) where T : class
        {
            if (setter == null)
            {
                return db.Update(po);
            }
            else
            {
                return db.GetTable<T>().Update(predicate(po), setter(po));
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
            var order = db.Orders.Where(o => o.OrderGuid == orderguid).FirstOrDefault();
            return order;
        }

        #endregion
    }
}
