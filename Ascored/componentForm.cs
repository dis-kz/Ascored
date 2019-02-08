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

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            Component component = componentBindingSource.AddNew() as Component;
            component.ComponentGroupGuid = (groupBindingSource.Current as ComponentGroup).ComponentGroupGuid;
        }
    }
}
