using DataMapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using DataModels;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Component = DataModels.Component;
using System.Reflection;

namespace Ascored
{
    public partial class ComponentForm : Form
    {
        DbService db = new DbService();

        public ComponentForm()
        {
            InitializeComponent();
        }

        private void ComponentForm_Load(object sender, EventArgs e)
        {
            groupBindingSource.DataSource = db.GetComponentGroups();
            componentBindingSource.DataSource = db.GetComponents();
        }

        //добавить компонент
        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            Component component = componentBindingSource.AddNew() as Component;
            component.ComponentGuid = Guid.NewGuid();
            component.ComponentGroupGuid = (groupBindingSource.Current as ComponentGroup).ComponentGroupGuid;
        }

        //завершение редактирования ячейки
        private void dataGridViewComponents_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            componentBindingSource.EndEdit();
            var component = componentBindingSource.Current as Component;
            db.Save(component, (cmp) => (c) => c.ComponentGuid == cmp.ComponentGuid);
        }

        //создать группу
        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            using (ComponentGroupForm form = new ComponentGroupForm())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    groupBindingSource.Add(form.NewGroup);
                    db.Save(form.NewGroup, (cmpg) => (cg) => cg.ComponentGroupGuid == cmpg.ComponentGroupGuid);
                }
            }

        }

        //поиск по имени или референсу
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    var source = (IEnumerable<Component>)componentBindingSource.DataSource;
                    SharedMethods.Search(componentBindingSource, source, (list) => (c) => 
                                                      {
                                                          return c.Name.ToUpper().Contains(txtSearch.Text.ToUpper()) ||
                                                                 c.Reference.ToUpper().Contains(txtSearch.Text.ToUpper());
                                                      });
                }
                else componentBindingSource.DataSource = db.GetComponents();
            }
        }
    }
}
