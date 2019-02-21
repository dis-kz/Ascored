using DataMapping;
using System;
using System.Collections.Generic;
using DataModels;
using System.Windows.Forms;
using EnumsAndCases;
using Component = DataModels.Component;

namespace Ascored
{
    public partial class ComponentForm : Form
    {
        DbService db = DbService.Instance;

        public Component SelectedComponent { get; private set; }
        private Mode Mode { get; set; }

        public ComponentForm() : this(Mode.Справочник) { }
        public ComponentForm(Mode mode)
        {
            InitializeComponent();
            Mode = mode;
        }

        private void ComponentForm_Load(object sender, EventArgs e)
        {
            groupBindingSource.DataSource = db.GetComponentGroups();
            componentBindingSource.DataSource = db.GetComponents();

            if (groupBindingSource.Count == 0)
                btnAddComponent.Enabled = false;
        }

        //добавить компонент
        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            Component component = componentBindingSource.AddNew() as Component;
            component.ComponentGuid = Guid.NewGuid();
            component.ComponentGroupGuid = (groupBindingSource.Current as ComponentGroup).ComponentGroupGuid;
        }

        //создать группу
        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            using (ComponentGroupForm form = new ComponentGroupForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    groupBindingSource.Add(form.NewGroup);
                    db.Save(form.NewGroup, (cmpg) => (cg) => cg.ComponentGroupGuid == cmpg.ComponentGroupGuid);
                    if (!btnAddComponent.Enabled) btnAddComponent.Enabled = true;
                }
            }
        }

        //завершение редактирования ячейки
        private void dataGridViewComponents_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            componentBindingSource.EndEdit();
            var component = componentBindingSource.Current as Component;
            db.Save(component, (cmp) => (c) => c.ComponentGuid == cmp.ComponentGuid);
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

        //выбор компонента для привязки к продукту
        private void dataGridViewComponents_DoubleClick(object sender, EventArgs e)
        {
            if (Mode == Mode.Привязка)
            {
                SelectedComponent = componentBindingSource.Current as Component;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
