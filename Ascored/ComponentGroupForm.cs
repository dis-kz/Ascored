using DataModels;
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
    public partial class ComponentGroupForm : Form
    {
        public ComponentGroup NewGroup { get; set; }

        public ComponentGroupForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGroupName.Text)) return;
            else
            {
                NewGroup = new ComponentGroup();
                NewGroup.ComponentGroupGuid = Guid.NewGuid();
                NewGroup.Name = txtGroupName.Text;
            }
        }
    }
}
