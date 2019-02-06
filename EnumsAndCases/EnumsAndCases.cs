using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumsAndCases
{
    public static class EnumAndCases
    {
        public static void GetOrderStatus(object combo)
        {
            var dataSource = Enum.GetValues(typeof(OrderStatus))
                                     .Cast<OrderStatus>()
                                     .Select(p => new { Name = Enum.GetName(typeof(OrderStatus), p), Value = (int)p })
                                     .ToList();

            //PropertyInfo property = combo.GetType().GetProperty("DataSource");
            //property.SetValue(combo, dataSource);

            //property = combo.GetType().GetProperty("DisplayMember");
            //property.SetValue(combo, displayMember);

            //property = combo.GetType().GetProperty("ValueMember");
            //property.SetValue(combo, valueMember);

            Dictionary<string, object> propValues = new Dictionary<string, object>
            {
                {"DataSource",    dataSource},
                {"DisplayMember", "Name"},
                {"ValueMember",   "Value"}
            };

            foreach(KeyValuePair<string,object> entry in propValues)
            {
                PropertyInfo property = combo.GetType().GetProperty(entry.Key);
                property.SetValue(combo, entry.Value);
            }
        }
    }

    public enum OrderStatus
    {
        Заявка,
        ТКП,
        Рабочий,
        Отказ
    }
}
