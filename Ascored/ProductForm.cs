using DataMapping;
using DataModels;
using EnumsAndCases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascored
{
    public partial class ProductForm : Form
    {
        DbService db = DbService.Instance;

        public Product SelectedProduct { get; private set; }
        private Mode Mode { get; set; }

        public ProductForm() : this(Mode.Справочник) { }

        public ProductForm(Mode mode)
        {
            InitializeComponent();
            Mode = mode;
        }

        //-- Состав оборудования
        private void btnComponents_Click(object sender, EventArgs e)
        {
            using(ProductComponentForm form = new ProductComponentForm(productBindingSource.Current as Product))
            {
                form.ShowDialog();
            }
        }

        //-- Добавить новый
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        //выбор продукта для привязки к заказу
        private void dataGridViewProduct_DoubleClick(object sender, EventArgs e)
        {
            if (Mode == Mode.Привязка)
            {
                SelectedProduct = productBindingSource.Current as Product;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
