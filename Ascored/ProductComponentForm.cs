using DataMapping;
using DataModels;
using EnumsAndCases;
using System;
using System.Windows.Forms;
using Component = DataModels.Component;

namespace Ascored
{
    public partial class ProductComponentForm : Form
    {
        DbService db = DbService.Instance;
        public Product Product { get; private set; }

        public ProductComponentForm(Product _product)
        {
            InitializeComponent();
            Product = _product;
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            using(ComponentForm form = new ComponentForm(Mode.Привязка))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    Component component = form.SelectedComponent;
                    if (component != null)
                    {
                        ProductComponent pc = db.GetProductComponent(Product, component);
                        if (pc == null)
                        {
                            pc = new ProductComponent();
                            pc.ProductComponentGuid = Guid.NewGuid();
                            pc.ProductGuid = Product.ProductGuid;
                            pc.ComponentGuid = component.ComponentGuid;
                            pc.ComponentCount = 1;
                        }
                        else pc.ComponentCount++;

                        db.Save(pc, (prcm) => (i) => i.ProductComponentGuid == prcm.ProductComponentGuid);

                        //обновление связанного источника dataGridView
                    }
                    MessageBox.Show("Компонент успешно привязан к продукту");
                }
            }
        }

        private void btnAddAssembly_Click(object sender, EventArgs e)
        {

        }
    }
}
