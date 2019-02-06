﻿using System;
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

        public MainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            ResetBindingSource();
        }

        private void ResetBindingSource()
        {
            orderBindingSource.DataSource = db.GetOrders().OrderBy(o => o.ModifiedDate);

            //statusDataGridViewTextBoxColumn.DataSource = EnumAndCases.GetOrderStatus();
            //statusDataGridViewTextBoxColumn.DisplayMember = "Name";
            //statusDataGridViewTextBoxColumn.ValueMember = "Value";
            EnumAndCases.GetOrderStatus(StatusDgvColumn);
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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    var filter = (IEnumerable<Order>)orderBindingSource.DataSource;
                    filter = filter.Where(o => o.Customer.Contains(txtSearch.Text) || o.Number.Contains(txtSearch.Text));
                    orderBindingSource.DataSource = filter;
                }
                else ResetBindingSource();
            }
        }
    }
}
