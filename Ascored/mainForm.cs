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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        //событие нажатия кнопки на главной форме
        private void button1_Click(object sender, EventArgs e)
        {
            //строим
            componentForm form = new componentForm();
            //показываем в модальном режиме - короче, как диалог))
            form.ShowDialog();
        }
    }
}
