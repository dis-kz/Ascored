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
    public partial class componentForm : Form
    {
        // это конструктор формы - главный метод построения класса
        public componentForm()
        {
            InitializeComponent();

            //здесь будет весь функциональный код новой формы
            //а вот метод InitializeComponent() описан в файле автоматически сгенерированном при создании формы

            //если на вызове метода ткнуть F12 провалишься к его определению
        }

        //это событие загрузки (прорисовки формы)
        private void componentForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Привет, Серёга!");
        }
    }
}
