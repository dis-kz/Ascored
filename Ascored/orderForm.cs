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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascored
{
    public partial class OrderForm : Form
    {
        public Order LastOrder { get; set; }
        string separator = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;

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
                txtFactor.Text = LastOrder.Factor.ToString();
                txtTaxRate.Text = LastOrder.TaxRate.ToString();
                txtPrice.Text = LastOrder.Price.ToString();
            }
            else
            {
                txtCost.Text = txtPrice.Text = SharedMethods.Convert("0.00");
            }
        }

        //Загрузка формы
        private void orderForm_Load(object sender, EventArgs e)
        {
            SharedMethods.GetOrderStatus(cmbStatus);
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
            LastOrder.Cost = decimal.Parse(SharedMethods.Convert(txtPrice.Text));
            LastOrder.Factor = decimal.Parse(SharedMethods.Convert(txtFactor.Text));
            LastOrder.TaxRate = int.Parse(txtTaxRate.Text);
            LastOrder.Price = decimal.Parse(SharedMethods.Convert(txtPrice.Text));
            LastOrder.Status = (int)cmbStatus.SelectedValue;
            LastOrder.ModifiedDate = DateTime.Now;

            DbService db = DbService.Instance;
            db.Save(LastOrder, (ord) => (i) => i.OrderGuid == ord.OrderGuid);

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

        //добавление коэффициента или ставки НДС
        private void txtFactAndTax_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                double cost = double.Parse(SharedMethods.Convert(txtCost.Text));
                double factor = double.Parse(SharedMethods.Convert(txtFactor.Text));
                double tax = double.Parse(SharedMethods.Convert(txtTaxRate.Text));

                //расчёт Итого
                double price = (cost * factor) + ((tax / 100) * cost);
                txtPrice.Text = price.ToString();
            }
        }

        //маска ввода на НДС
        private void txtTaxRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)
                && e.KeyChar != 8  /*Backspace*/
                && e.KeyChar != 13 /*Enter*/
                )
            {
                e.Handled = true;
            }
        }

        private void btnEditContent_Click(object sender, EventArgs e)
        {
            using(ProductForm form = new ProductForm(Mode.Привязка))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    MessageBox.Show("Продукт успешно добавлен в заказ!");
            }
        }
    }
}
