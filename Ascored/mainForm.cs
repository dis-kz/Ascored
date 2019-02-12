using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataMapping;
using DataModels;
using EnumsAndCases;

namespace Ascored
{
    public partial class MainForm : Form
    {
        DbService db = new DbService();
        char[] arrows = new char[]{ '▲', '▼' };
        private Dictionary<string, string> dctSorting = new Dictionary<string, string>()
        {
            {"Default",      "по умолчанию"},
            {"Customer▲",    "по наименованию заказчика ▲"},
            {"Customer▼",    "по наименованию заказчика ▼"},
            {"Number▲",      "по номеру заказа ▲"},
            {"Number▼",      "по номеру заказа ▼"},
            {"Cost▲",        "по стоимости ▲"},
            {"Cost▼",        "по стоимости ▼"},
            {"ModifiedDate▲","по дате изменения ▲"},
            {"ModifiedDate▼","по дате изменения ▼"}
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            ResetBindingSource();

            cmbSort.DataSource = new BindingSource(dctSorting, null);
            cmbSort.DisplayMember = "Value";
            cmbSort.ValueMember = "Key";
        }

        private void ResetBindingSource()
        {
            orderBindingSource.DataSource = db.GetOrders().OrderBy(o => o.ModifiedDate);
            SharedMethods.GetOrderStatus(StatusDgvColumn);
        }

        private void ResetBindingSource(string column, int arrow)
        {
            var sorting = typeof(Order).GetProperty(column);
            if(arrow == 0) orderBindingSource.DataSource = db.GetOrders().OrderBy(o => sorting.GetValue(o));
            else orderBindingSource.DataSource = db.GetOrders().OrderByDescending(o => sorting.GetValue(o));
        }

        //Создать новый заказ
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            using(OrderForm form = new OrderForm())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    //обновить привязку
                    ResetBindingSource();
                }
            }
        }

        //Редактирование заказа
        private void dataGridViewOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var order = orderBindingSource.Current as Order;
            using (OrderForm form = new OrderForm(order))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //обновить привязку
                    ResetBindingSource();
                }
            }
        }

        //Поиск по наименованию заказчика или номеру заказа
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    var source = (IEnumerable<Order>)orderBindingSource.DataSource;
                    SharedMethods.Search(orderBindingSource, source, (list) => (o) => 
                                                     {
                                                         return o.Customer.ToUpper().Contains(txtSearch.Text.ToUpper()) || 
                                                              o.Number.ToUpper().Contains(txtSearch.Text.ToUpper());
                                                     });
                }
                else ResetBindingSource();
            }
        }

        private void cmbSort_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string key = (string)cmbSort.SelectedValue;
            int index = Array.IndexOf(arrows, key[key.Count() - 1]);

            if (key.Equals("Default"))
            {
                key = "ModifiedDate▲";
                index = 0;
            }

            ResetBindingSource(key.Substring(0,key.Length - 1), index);
            dataGridViewOrders.Focus();
        }
    }
}
