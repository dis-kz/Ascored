using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumsAndCases
{
    public static class EnumAndCases
    {
        public static object GetOrderStatus()
        {
            return Enum.GetValues(typeof(OrderStatus))
                                     .Cast<OrderStatus>()
                                     .Select(p => new { Name = Enum.GetName(typeof(OrderStatus), p), Value = (int)p })
                                     .ToList();
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
