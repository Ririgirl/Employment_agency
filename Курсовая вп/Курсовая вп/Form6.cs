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
    public partial class Form6 : Form
    {
        public Form6(string b)
        {
            InitializeComponent();
            this.b = b;
        }
        string b;
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trudkontDataSet.vacancy". При необходимости она может быть перемещена или удалена.
            this.vacancyTableAdapter.Fill(this.trudkontDataSet.vacancy);
            SqlConnection connection = new SqlConnection(@"Data Source=RIMMA\SQLEXPRESS;Initial Catalog=trudkont;Integrated Security=True");
            int a = Convert.ToInt32(b);
            //название специальности//
            System.Text.StringBuilder name_vac = new System.Text.StringBuilder();
            SqlCommand name_vacCommand = new SqlCommand();
            name_vacCommand.Connection = connection;
            name_vacCommand.CommandType = CommandType.Text;
            name_vacCommand.CommandText = "Select name_vac from vacancy where num_vac = " + a;
            name_vacCommand.Connection.Open();
            SqlDataReader reader_2 = name_vacCommand.ExecuteReader();

            bool MoreResults_2 = false;
            do
            {
                while (reader_2.Read())
                {
                    for (int i = 0; i < reader_2.FieldCount; i++)
                    {
                        name_vac.Append(reader_2[i].ToString());

                    }
                    name_vac.Append(Environment.NewLine);
                }

                MoreResults_2 = reader_2.NextResult();
            } while (MoreResults_2);
            reader_2.Close();
            name_vacCommand.Connection.Close();
            textBox1.Text = name_vac.ToString();
            //название фирмы из бд
            System.Text.StringBuilder name_comp = new System.Text.StringBuilder();
            SqlCommand name_compCommand = new SqlCommand();
            name_compCommand.Connection = connection;
            name_compCommand.CommandType = CommandType.Text;
            name_compCommand.CommandText = "Select company.name_comp from company join vacancy on vacancy.num_comp=company.num_comp where vacancy.num_vac = " + a;
            name_compCommand.Connection.Open();
            SqlDataReader reader_1 = name_compCommand.ExecuteReader();

            bool MoreResults_1 = false;
            do
            {
                while (reader_1.Read())
                {
                    for (int i = 0; i < reader_1.FieldCount; i++)
                    {
                        name_comp.Append(reader_1[i].ToString());

                    }
                    name_comp.Append(Environment.NewLine);
                }

                MoreResults_1 = reader_1.NextResult();
            } while (MoreResults_1);
            reader_1.Close();
            name_compCommand.Connection.Close();
            textBox5.Text = name_comp.ToString();
            //опыт работы

            System.Text.StringBuilder or_vac = new System.Text.StringBuilder();
            SqlCommand or_vacCommand = new SqlCommand();
            or_vacCommand.Connection = connection;
            or_vacCommand.CommandType = CommandType.Text;
            or_vacCommand.CommandText = "Select or_vac from vacancy where num_vac = " + a;
            or_vacCommand.Connection.Open();
            SqlDataReader reader_3 = or_vacCommand.ExecuteReader();

            bool MoreResults_3 = false;
            do
            {
                while (reader_3.Read())
                {
                    for (int i = 0; i < reader_3.FieldCount; i++)
                    {
                        or_vac.Append(reader_3[i].ToString());

                    }
                    or_vac.Append(Environment.NewLine);
                }

                MoreResults_3 = reader_3.NextResult();
            } while (MoreResults_3);
            reader_3.Close();
            or_vacCommand.Connection.Close();
            textBox6.Text = or_vac.ToString();

            //образование

            System.Text.StringBuilder obr_vac = new System.Text.StringBuilder();
            SqlCommand obr_vacCommand = new SqlCommand();
            obr_vacCommand.Connection = connection;
            obr_vacCommand.CommandType = CommandType.Text;
            obr_vacCommand.CommandText = "Select obr_vac from vacancy where num_vac = " + a;
            obr_vacCommand.Connection.Open();
            SqlDataReader reader_4 = obr_vacCommand.ExecuteReader();

            bool MoreResults_4 = false;
            do
            {
                while (reader_4.Read())
                {
                    for (int i = 0; i < reader_4.FieldCount; i++)
                    {
                        obr_vac.Append(reader_4[i].ToString());

                    }
                    obr_vac.Append(Environment.NewLine);
                }

                MoreResults_4 = reader_4.NextResult();
            } while (MoreResults_4);
            reader_4.Close();
            obr_vacCommand.Connection.Close();
            textBox8.Text = obr_vac.ToString();

            //пол

            System.Text.StringBuilder gender_vac = new System.Text.StringBuilder();
            SqlCommand gender_vacCommand = new SqlCommand();
            gender_vacCommand.Connection = connection;
            gender_vacCommand.CommandType = CommandType.Text;
            gender_vacCommand.CommandText = "Select gender_vac from vacancy where num_vac = " + a;
            gender_vacCommand.Connection.Open();
            SqlDataReader reader_5 = gender_vacCommand.ExecuteReader();

            bool MoreResults_5 = false;
            do
            {
                while (reader_5.Read())
                {
                    for (int i = 0; i < reader_5.FieldCount; i++)
                    {
                        gender_vac.Append(reader_5[i].ToString());

                    }
                    gender_vac.Append(Environment.NewLine);
                }

                MoreResults_5 = reader_5.NextResult();
            } while (MoreResults_5);
            reader_5.Close();
            gender_vacCommand.Connection.Close();
            textBox7.Text = gender_vac.ToString();

            //навыки

            System.Text.StringBuilder skills_vac = new System.Text.StringBuilder();
            SqlCommand skills_vacCommand = new SqlCommand();
            skills_vacCommand.Connection = connection;
            skills_vacCommand.CommandType = CommandType.Text;
            skills_vacCommand.CommandText = "Select skills_vac from vacancy where num_vac = " + a;
            skills_vacCommand.Connection.Open();
            SqlDataReader reader_6 = skills_vacCommand.ExecuteReader();

            bool MoreResults_6 = false;
            do
            {
                while (reader_6.Read())
                {
                    for (int i = 0; i < reader_6.FieldCount; i++)
                    {
                        skills_vac.Append(reader_6[i].ToString());

                    }
                    skills_vac.Append(Environment.NewLine);
                }

                MoreResults_6 = reader_6.NextResult();
            } while (MoreResults_6);
            reader_6.Close();
            skills_vacCommand.Connection.Close();
            textBox2.Text = skills_vac.ToString();

            //должность

            System.Text.StringBuilder dolzn_vac = new System.Text.StringBuilder();
            SqlCommand dolzn_vacCommand = new SqlCommand();
            dolzn_vacCommand.Connection = connection;
            dolzn_vacCommand.CommandType = CommandType.Text;
            dolzn_vacCommand.CommandText = "Select dolzn_vac from vacancy where num_vac = " + a;
            dolzn_vacCommand.Connection.Open();
            SqlDataReader reader_7 = dolzn_vacCommand.ExecuteReader();

            bool MoreResults_7 = false;
            do
            {
                while (reader_7.Read())
                {
                    for (int i = 0; i < reader_7.FieldCount; i++)
                    {
                        dolzn_vac.Append(reader_7[i].ToString());

                    }
                    dolzn_vac.Append(Environment.NewLine);
                }

                MoreResults_7 = reader_7.NextResult();
            } while (MoreResults_7);
            reader_7.Close();
            dolzn_vacCommand.Connection.Close();
            textBox3.Text = dolzn_vac.ToString();

            //зп

            System.Text.StringBuilder zp_vac = new System.Text.StringBuilder();
            SqlCommand zp_vacCommand = new SqlCommand();
            zp_vacCommand.Connection = connection;
            zp_vacCommand.CommandType = CommandType.Text;
            zp_vacCommand.CommandText = "Select zp_vac from vacancy where num_vac = " + a;
            zp_vacCommand.Connection.Open();
            SqlDataReader reader_8 = zp_vacCommand.ExecuteReader();

            bool MoreResults_8 = false;
            do
            {
                while (reader_8.Read())
                {
                    for (int i = 0; i < reader_8.FieldCount; i++)
                    {
                        zp_vac.Append(reader_8[i].ToString());

                    }
                    zp_vac.Append(Environment.NewLine);
                }

                MoreResults_8 = reader_8.NextResult();
            } while (MoreResults_8);
            reader_8.Close();
            zp_vacCommand.Connection.Close();
            textBox4.Text = zp_vac.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(b);
           SqlConnection connection = new SqlConnection(@"Data Source=RIMMA\SQLEXPRESS;Initial Catalog=trudkont;Integrated Security=True");
                SqlCommand delete_vacancy = new SqlCommand();
                delete_vacancy.Connection = connection;
                delete_vacancy.CommandType = CommandType.Text;
                delete_vacancy.CommandText = "Delete from vacancy where num_vac="+a;
                delete_vacancy.Connection.Open();
                delete_vacancy.ExecuteNonQuery();
                delete_vacancy.Connection.Close();
                MessageBox.Show("Данные удалены");
                this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(b);
                SqlConnection connection = new SqlConnection(@"Data Source=RIMMA\SQLEXPRESS;Initial Catalog=trudkont;Integrated Security=True");
                SqlCommand update_vacancy = new SqlCommand();
                update_vacancy.Connection = connection;
                update_vacancy.CommandType = CommandType.Text;
                update_vacancy.CommandText = "update vacancy set name_vac='"+ textBox1.Text + "',dolzn_vac='" + textBox3.Text + "',zp_vac=" + textBox4.Text + ",obr_vac='" +
                    textBox8.Text + "',or_vac='" + textBox6.Text + "',skills_vac='" + textBox2.Text + "' where num_vac=" + a;
                update_vacancy.Connection.Open();
                update_vacancy.ExecuteNonQuery();
                update_vacancy.Connection.Close();
                MessageBox.Show("Данные изменены");
                this.Close();
        }
    }
}
