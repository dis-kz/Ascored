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

        //сохранение в базе
        public int Save<T>(T po, Func<T, Expression<Func<T, bool>>> predicate) where T : class
        {
            int result = 0;
            var exist = db.GetTable<T>().Where(predicate(po)).FirstOrDefault();

            if (exist != null)
                result = Update(po, predicate);
            else result = Insert(po);

            return result;
        }

        //новая запись
        private int Insert<T>(T po)
        {
            return db.Insert(po);
        }

        //обновление записи
        private int Update<T>(T po, Func<T, Expression<Func<T, bool>>> predicate, Func<T, Expression<Func<T, T>>> setter = null) where T : class
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

        public Order GetOrder(Guid orderguid)
        {
            var order = db.Orders.Where(o => o.OrderGuid == orderguid).FirstOrDefault();
            return order;
        }

        #endregion

        #region Components and Groups

        public Component GetComponent(Guid componentGuid)
        {
            return db.Components.Where(c => c.ComponentGuid == componentGuid).FirstOrDefault();
        }

        public IEnumerable<Component> GetComponents()
        {
            var list = db.Components.ToList();
            return list;
        }

        public IEnumerable<Component> GetComponents(Guid groupGuid)
        {
            var list = db.Components.Where(c => c.ComponentGroupGuid == groupGuid).ToList();
            return list;
        }

        public IEnumerable<ComponentGroup> GetComponentGroups()
        {
            var list = db.ComponentGroups.ToList();
            return list;
        } 

        #endregion
    }
}
