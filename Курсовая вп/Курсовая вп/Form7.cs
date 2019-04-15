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
    public partial class Form7 : Form
    {
        public Form7(string b)
        {
            InitializeComponent();
            this.b = b;
        }
        string b;

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=RIMMA\SQLEXPRESS;Initial Catalog=trudkont;Integrated Security=True");
            int a = Convert.ToInt32(b);
            //тип компании//
            System.Text.StringBuilder type_comp = new System.Text.StringBuilder();
            SqlCommand type_compCommand = new SqlCommand();
            type_compCommand.Connection = connection;
            type_compCommand.CommandType = CommandType.Text;
            type_compCommand.CommandText = "Select type_comp from company where num_comp = " + a;
            type_compCommand.Connection.Open();
            SqlDataReader reader_1 = type_compCommand.ExecuteReader();

            bool MoreResults_1 = false;
            do
            {
                while (reader_1.Read())
                {
                    for (int i = 0; i < reader_1.FieldCount; i++)
                    {
                        type_comp.Append(reader_1[i].ToString());

                    }
                    type_comp.Append(Environment.NewLine);
                }

                MoreResults_1 = reader_1.NextResult();
            } while (MoreResults_1);
            reader_1.Close();
            type_compCommand.Connection.Close();
            textBox5.Text = type_comp.ToString();

            //название компании

            System.Text.StringBuilder name_comp = new System.Text.StringBuilder();
            SqlCommand name_compCommand = new SqlCommand();
            name_compCommand.Connection = connection;
            name_compCommand.CommandType = CommandType.Text;
            name_compCommand.CommandText = "Select name_comp from company where num_comp = " + a;
            name_compCommand.Connection.Open();
            SqlDataReader reader_2 = name_compCommand.ExecuteReader();

            bool MoreResults_2 = false;
            do
            {
                while (reader_2.Read())
                {
                    for (int i = 0; i < reader_2.FieldCount; i++)
                    {
                        name_comp.Append(reader_2[i].ToString());

                    }
                    name_comp.Append(Environment.NewLine);
                }

                MoreResults_2 = reader_2.NextResult();
            } while (MoreResults_2);
            reader_2.Close();
            name_compCommand.Connection.Close();
            textBox1.Text = name_comp.ToString();

            //город

            System.Text.StringBuilder city_comp = new System.Text.StringBuilder();
            SqlCommand city_compCommand = new SqlCommand();
            city_compCommand.Connection = connection;
            city_compCommand.CommandType = CommandType.Text;
            city_compCommand.CommandText = "Select city_comp from company where num_comp = " + a;
            city_compCommand.Connection.Open();
            SqlDataReader reader_3 = city_compCommand.ExecuteReader();

            bool MoreResults_3 = false;
            do
            {
                while (reader_3.Read())
                {
                    for (int i = 0; i < reader_3.FieldCount; i++)
                    {
                        city_comp.Append(reader_3[i].ToString());

                    }
                    city_comp.Append(Environment.NewLine);
                }

                MoreResults_3 = reader_3.NextResult();
            } while (MoreResults_3);
            reader_3.Close();
            city_compCommand.Connection.Close();
            textBox6.Text = city_comp.ToString();

            //телефон

            System.Text.StringBuilder tel_comp = new System.Text.StringBuilder();
            SqlCommand tel_compCommand = new SqlCommand();
            tel_compCommand.Connection = connection;
            tel_compCommand.CommandType = CommandType.Text;
            tel_compCommand.CommandText = "Select tel_comp from company where num_comp = " + a;
            tel_compCommand.Connection.Open();
            SqlDataReader reader_4 = tel_compCommand.ExecuteReader();

            bool MoreResults_4 = false;
            do
            {
                while (reader_4.Read())
                {
                    for (int i = 0; i < reader_4.FieldCount; i++)
                    {
                        tel_comp.Append(reader_4[i].ToString());

                    }
                    tel_comp.Append(Environment.NewLine);
                }

                MoreResults_4 = reader_4.NextResult();
            } while (MoreResults_4);
            reader_4.Close();
            tel_compCommand.Connection.Close();
            textBox4.Text = tel_comp.ToString();

            //e-mail

            System.Text.StringBuilder email_comp = new System.Text.StringBuilder();
            SqlCommand email_compCommand = new SqlCommand();
            email_compCommand.Connection = connection;
            email_compCommand.CommandType = CommandType.Text;
            email_compCommand.CommandText = "Select email_comp from company where num_comp = " + a;
            email_compCommand.Connection.Open();
            SqlDataReader reader_5 = email_compCommand.ExecuteReader();

            bool MoreResults_5 = false;
            do
            {
                while (reader_5.Read())
                {
                    for (int i = 0; i < reader_5.FieldCount; i++)
                    {
                        email_comp.Append(reader_5[i].ToString());

                    }
                    email_comp.Append(Environment.NewLine);
                }

                MoreResults_5 = reader_5.NextResult();
            } while (MoreResults_5);
            reader_5.Close();
            email_compCommand.Connection.Close();
            textBox2.Text = email_comp.ToString();

            //сайт

            System.Text.StringBuilder wsite_comp = new System.Text.StringBuilder();
            SqlCommand wsite_compCommand = new SqlCommand();
            wsite_compCommand.Connection = connection;
            wsite_compCommand.CommandType = CommandType.Text;
            wsite_compCommand.CommandText = "Select wsite_comp from company where num_comp = " + a;
            wsite_compCommand.Connection.Open();
            SqlDataReader reader_6 = wsite_compCommand.ExecuteReader();

            bool MoreResults_6 = false;
            do
            {
                while (reader_6.Read())
                {
                    for (int i = 0; i < reader_6.FieldCount; i++)
                    {
                        wsite_comp.Append(reader_6[i].ToString());

                    }
                    wsite_comp.Append(Environment.NewLine);
                }

                MoreResults_6 = reader_6.NextResult();
            } while (MoreResults_6);
            reader_6.Close();
            wsite_compCommand.Connection.Close();
            textBox3.Text = wsite_comp.ToString();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(b);
            //try
            //{
                SqlConnection connection = new SqlConnection(@"Data Source=RIMMA\SQLEXPRESS;Initial Catalog=trudkont;Integrated Security=True");
                SqlCommand update_company = new SqlCommand();
            update_company.Connection = connection;
            update_company.CommandType = CommandType.Text;
            update_company.CommandText = "update company set name_comp = '" + textBox1.Text + 
                "',tel_comp=" + textBox4.Text + ", email_comp='" + textBox2.Text + "', wsite_comp='" + textBox3.Text + "' where num_comp=" + a;
            update_company.Connection.Open();
            update_company.ExecuteNonQuery();
            update_company.Connection.Close();
                MessageBox.Show("Данные изменены");
                this.Close();
            /*
             * }
            catch (SqlException)
            {
                MessageBox.Show("");
            }*/
        }
    }
}
