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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                newvacancylass cls = new newvacancylass(textBox1.Text, textBox3.Text,textBox4.Text, comboBox3.SelectedItem.ToString(), comboBox6.SelectedItem.ToString(), textBox1.Text, textBox2.Text, comboBox1.SelectedValue.ToString());
                cls.vac();
                MessageBox.Show("Данные добавлены");
                this.Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не все обязательные поля заполнены");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trudkontDataSet.company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.trudkontDataSet.company);

        }
    }
}
