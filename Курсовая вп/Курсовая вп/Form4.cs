using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Курсовая_вп
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                newcompanyclass cls = new newcompanyclass(comboBox1.SelectedItem.ToString(),textBox1.Text,comboBox2.SelectedItem.ToString(), textBox4.Text,textBox2.Text,textBox3.Text);
                cls.vac();
                MessageBox.Show("Данные добавлены");
            this.Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не все обязательные поя заполнены");
            }

        }
    }
}
