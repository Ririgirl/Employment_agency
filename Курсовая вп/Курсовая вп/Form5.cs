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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                newresumeclass cls = new newresumeclass(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text,
      textBox5.Text, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), textBox10.Text, textBox6.Text,
      textBox9.Text, comboBox3.SelectedItem.ToString(), comboBox4.SelectedItem.ToString(), comboBox5.SelectedItem.ToString(), textBox7.Text, comboBox6.SelectedItem.ToString(), comboBox8.SelectedItem.ToString(),textBox11.Text);
                cls.vac();
                MessageBox.Show("Данные добавлены");
            this.Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не все обязательные поя заполнены");
            }
            catch (SqlException)
            {
                MessageBox.Show("Если поле 'Заработная плата' и/или 'Количество детей' не заполнено, введите 0 ");
            }
        }
    }
}
