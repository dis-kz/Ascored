using EnumsAndCases;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascored
{
    public static class  SharedMethods
    {
        //извлечь статус заказа
        public static void GetOrderStatus(object combo)
        {
            var dataSource = Enum.GetValues(typeof(OrderStatus))
                                     .Cast<OrderStatus>()
                                     .Select(p => new { Name = Enum.GetName(typeof(OrderStatus), p), Value = (int)p })
                                     .ToList();

            Dictionary<string, object> propValues = new Dictionary<string, object>
            {
                {"DataSource",    dataSource},
                {"DisplayMember", "Name"},
                {"ValueMember",   "Value"}
            };

            foreach (KeyValuePair<string, object> entry in propValues)
            {
                PropertyInfo property = combo.GetType().GetProperty(entry.Key);
                property.SetValue(combo, entry.Value);
            }
        }

        //текстовый поиск
        public static void Search<T>(BindingSource bSource, IEnumerable<T> source, Func<IEnumerable<T>, Func<T, bool>> predicate) where T : class
        {
            bSource.DataSource = source.Where(predicate(source));
        }

        //независимый парсинг дробного числа
        public static string Convert(string input)
        {
            return Regex.Replace(input, @"[^\d]", CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
        }
    }
}
