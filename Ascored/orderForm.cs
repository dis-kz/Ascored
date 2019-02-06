using DataMapping;
using DataModels;
using EnumsAndCases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascored
{
    public partial class OrderForm : Form
    {
        public Order LastOrder { get; set; }

        public OrderForm() :this(null) { }

        public OrderForm(Order order)
        {
            InitializeComponent();

            LastOrder = order;
            if(LastOrder != null)
            {
                txtNumber.Text = LastOrder.Number;
                txtCustomer.Text = LastOrder.Customer;
                txtCost.Text = LastOrder.Cost.ToString();
            }
            else
            {
                txtCost.Text = $"0{CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator}00";
            }
        }

        //Загрузка формы
        private void orderForm_Load(object sender, EventArgs e)
        {
            //cmbStatus.DataSource = EnumAndCases.GetOrderStatus();
            //cmbStatus.DisplayMember = "Name";
            //cmbStatus.ValueMember = "Value";

            EnumAndCases.GetOrderStatus(cmbStatus);
            if (LastOrder != null) cmbStatus.SelectedItem = cmbStatus.Items[LastOrder.Status];
        }

        //Сохранить
        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = 0;

            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(TextBox))
                    if (string.IsNullOrEmpty(ctr.Text))
                    {
                        ctr.Focus();
                        ctr.BackColor = Color.MistyRose;
                        SystemSounds.Beep.Play();
                        return;
                    }
            }

            //запоминаем заказ
            if (LastOrder == null)
            {
                LastOrder = new Order();
                LastOrder.OrderGuid = Guid.NewGuid();
            }
            LastOrder.Customer = txtCustomer.Text;
            LastOrder.Number = txtNumber.Text;
            LastOrder.Status = (int)cmbStatus.SelectedValue;
            LastOrder.Cost = decimal.Parse(txtCost.Text);
            LastOrder.ModifiedDate = DateTime.Now;

            DbService db = new DbService();
            if (db.GetOrderById(LastOrder.OrderGuid) != null)
            {
                Func<Order, Expression<Func<Order, bool>>> predicate = (ord) => (i) => ord.OrderGuid == LastOrder.OrderGuid;
                result = db.Update(LastOrder, predicate, null);
            }
            else
            {
               result = db.Insert(LastOrder);
            }

            if(result > 0)
                MessageBox.Show($"Успешно сохранено в базе данных", "Сохранение в БД", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        //Отменить
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        //Очистка цвета при заполнении textBox'ов
        private void inputTxt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text.Length > 0) txt.BackColor = Color.White;
        }
    }
}
