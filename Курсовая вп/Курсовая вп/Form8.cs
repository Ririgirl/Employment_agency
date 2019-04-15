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
    public partial class Form8 : Form
    {
        public Form8(string b)
        {
            InitializeComponent();
            this.b = b;
        }
        string b;

        private void Form8_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=RIMMA\SQLEXPRESS;Initial Catalog=trudkont;Integrated Security=True");
            int a = Convert.ToInt32(b);
            //фамилия//
            System.Text.StringBuilder fname_res = new System.Text.StringBuilder();
            SqlCommand fname_resCommand = new SqlCommand();
            fname_resCommand.Connection = connection;
            fname_resCommand.CommandType = CommandType.Text;
            fname_resCommand.CommandText = "Select fname_res from resume where num_res = " + a;
            fname_resCommand.Connection.Open();
            SqlDataReader reader_1 = fname_resCommand.ExecuteReader();

            bool MoreResults_1 = false;
            do
            {
                while (reader_1.Read())
                {
                    for (int i = 0; i < reader_1.FieldCount; i++)
                    {
                        fname_res.Append(reader_1[i].ToString());

                    }
                    fname_res.Append(Environment.NewLine);
                }

                MoreResults_1 = reader_1.NextResult();
            } while (MoreResults_1);
            reader_1.Close();
            fname_resCommand.Connection.Close();
            textBox1.Text = fname_res.ToString();

            //имя

            System.Text.StringBuilder name_res = new System.Text.StringBuilder();
            SqlCommand name_resCommand = new SqlCommand();
            name_resCommand.Connection = connection;
            name_resCommand.CommandType = CommandType.Text;
            name_resCommand.CommandText = "Select name_res from resume where num_res = " + a;
            name_resCommand.Connection.Open();
            SqlDataReader reader_2 = name_resCommand.ExecuteReader();

            bool MoreResults_2 = false;
            do
            {
                while (reader_2.Read())
                {
                    for (int i = 0; i < reader_2.FieldCount; i++)
                    {
                        name_res.Append(reader_2[i].ToString());

                    }
                    name_res.Append(Environment.NewLine);
                }

                MoreResults_2 = reader_2.NextResult();
            } while (MoreResults_2);
            reader_2.Close();
            name_resCommand.Connection.Close();
            textBox2.Text = name_res.ToString();

            //отчество

            System.Text.StringBuilder oname_res = new System.Text.StringBuilder();
            SqlCommand oname_resCommand = new SqlCommand();
            oname_resCommand.Connection = connection;
            oname_resCommand.CommandType = CommandType.Text;
            oname_resCommand.CommandText = "Select oname_res from resume where num_res = " + a;
            oname_resCommand.Connection.Open();
            SqlDataReader reader_3 = oname_resCommand.ExecuteReader();

            bool MoreResults_3 = false;
            do
            {
                while (reader_3.Read())
                {
                    for (int i = 0; i < reader_3.FieldCount; i++)
                    {
                        oname_res.Append(reader_3[i].ToString());

                    }
                    oname_res.Append(Environment.NewLine);
                }

                MoreResults_3 = reader_3.NextResult();
            } while (MoreResults_3);
            reader_3.Close();
            oname_resCommand.Connection.Close();
            textBox4.Text = oname_res.ToString();

            //специальность

            System.Text.StringBuilder spec_res = new System.Text.StringBuilder();
            SqlCommand spec_resCommand = new SqlCommand();
            spec_resCommand.Connection = connection;
            spec_resCommand.CommandType = CommandType.Text;
            spec_resCommand.CommandText = "Select spec_res from resume where num_res = " + a;
            spec_resCommand.Connection.Open();
            SqlDataReader reader_4 = spec_resCommand.ExecuteReader();

            bool MoreResults_4 = false;
            do
            {
                while (reader_4.Read())
                {
                    for (int i = 0; i < reader_4.FieldCount; i++)
                    {
                        spec_res.Append(reader_4[i].ToString());

                    }
                    spec_res.Append(Environment.NewLine);
                }

                MoreResults_4 = reader_4.NextResult();
            } while (MoreResults_4);
            reader_4.Close();
            spec_resCommand.Connection.Close();
            textBox3.Text = spec_res.ToString();

            //пол

            System.Text.StringBuilder gender_res = new System.Text.StringBuilder();
            SqlCommand gender_resCommand = new SqlCommand();
            gender_resCommand.Connection = connection;
            gender_resCommand.CommandType = CommandType.Text;
            gender_resCommand.CommandText = "Select gender_res from resume where num_res = " + a;
            gender_resCommand.Connection.Open();
            SqlDataReader reader_5 = gender_resCommand.ExecuteReader();

            bool MoreResults_5 = false;
            do
            {
                while (reader_5.Read())
                {
                    for (int i = 0; i < reader_5.FieldCount; i++)
                    {
                        gender_res.Append(reader_5[i].ToString());

                    }
                    gender_res.Append(Environment.NewLine);
                }

                MoreResults_5 = reader_5.NextResult();
            } while (MoreResults_5);
            reader_5.Close();
            gender_resCommand.Connection.Close();
            textBox17.Text = gender_res.ToString();

            //gr

            System.Text.StringBuilder gr_res = new System.Text.StringBuilder();
            SqlCommand gr_resCommand = new SqlCommand();
            gr_resCommand.Connection = connection;
            gr_resCommand.CommandType = CommandType.Text;
            gr_resCommand.CommandText = "Select gr_res from resume where num_res = " + a;
            gr_resCommand.Connection.Open();
            SqlDataReader reader_6 = gr_resCommand.ExecuteReader();

            bool MoreResults_6 = false;
            do
            {
                while (reader_6.Read())
                {
                    for (int i = 0; i < reader_6.FieldCount; i++)
                    {
                        gr_res.Append(reader_6[i].ToString());

                    }
                    gr_res.Append(Environment.NewLine);
                }

                MoreResults_6 = reader_6.NextResult();
            } while (MoreResults_6);
            reader_6.Close();
            gr_resCommand.Connection.Close();
            textBox5.Text = gr_res.ToString();

            //city

            System.Text.StringBuilder city_res = new System.Text.StringBuilder();
            SqlCommand city_resCommand = new SqlCommand();
            city_resCommand.Connection = connection;
            city_resCommand.CommandType = CommandType.Text;
            city_resCommand.CommandText = "Select city_res from resume where num_res = " + a;
            city_resCommand.Connection.Open();
            SqlDataReader reader_7 = city_resCommand.ExecuteReader();

            bool MoreResults_7 = false;
            do
            {
                while (reader_7.Read())
                {
                    for (int i = 0; i < reader_7.FieldCount; i++)
                    {
                        city_res.Append(reader_7[i].ToString());

                    }
                    city_res.Append(Environment.NewLine);
                }

                MoreResults_7 = reader_7.NextResult();
            } while (MoreResults_7);
            reader_7.Close();
            city_resCommand.Connection.Close();
            textBox18.Text = city_res.ToString();

            //email

            System.Text.StringBuilder email_res = new System.Text.StringBuilder();
            SqlCommand email_resCommand = new SqlCommand();
            email_resCommand.Connection = connection;
            email_resCommand.CommandType = CommandType.Text;
            email_resCommand.CommandText = "Select email_res from resume where num_res = " + a;
            email_resCommand.Connection.Open();
            SqlDataReader reader_8 = email_resCommand.ExecuteReader();

            bool MoreResults_8= false;
            do
            {
                while (reader_8.Read())
                {
                    for (int i = 0; i < reader_8.FieldCount; i++)
                    {
                        email_res.Append(reader_8[i].ToString());

                    }
                    email_res.Append(Environment.NewLine);
                }

                MoreResults_8 = reader_8.NextResult();
            } while (MoreResults_8);
            reader_8.Close();
            email_resCommand.Connection.Close();
            textBox10.Text = email_res.ToString();

            //zp

            System.Text.StringBuilder zp_res = new System.Text.StringBuilder();
            SqlCommand zp_resCommand = new SqlCommand();
            zp_resCommand.Connection = connection;
            zp_resCommand.CommandType = CommandType.Text;
            zp_resCommand.CommandText = "Select zp_res from resume where num_res = " + a;
            zp_resCommand.Connection.Open();
            SqlDataReader reader_9 = zp_resCommand.ExecuteReader();

            bool MoreResults_9 = false;
            do
            {
                while (reader_9.Read())
                {
                    for (int i = 0; i < reader_9.FieldCount; i++)
                    {
                        zp_res.Append(reader_9[i].ToString());

                    }
                    zp_res.Append(Environment.NewLine);
                }

                MoreResults_9 = reader_9.NextResult();
            } while (MoreResults_9);
            reader_9.Close();
            zp_resCommand.Connection.Close();
            textBox6.Text = zp_res.ToString();

            //dolzn

            System.Text.StringBuilder dolzn_res = new System.Text.StringBuilder();
            SqlCommand dolzn_resCommand = new SqlCommand();
            dolzn_resCommand.Connection = connection;
            dolzn_resCommand.CommandType = CommandType.Text;
            dolzn_resCommand.CommandText = "Select dolzn_res from resume where num_res = " + a;
            dolzn_resCommand.Connection.Open();
            SqlDataReader reader_10 = dolzn_resCommand.ExecuteReader();

            bool MoreResults_10 = false;
            do
            {
                while (reader_10.Read())
                {
                    for (int i = 0; i < reader_10.FieldCount; i++)
                    {
                        dolzn_res.Append(reader_10[i].ToString());

                    }
                    dolzn_res.Append(Environment.NewLine);
                }

                MoreResults_10 = reader_10.NextResult();
            } while (MoreResults_10);
            reader_10.Close();
            dolzn_resCommand.Connection.Close();
            textBox9.Text = dolzn_res.ToString();

            //typezan

            System.Text.StringBuilder typezan_res = new System.Text.StringBuilder();
            SqlCommand typezan_resCommand = new SqlCommand();
            typezan_resCommand.Connection = connection;
            typezan_resCommand.CommandType = CommandType.Text;
            typezan_resCommand.CommandText = "Select typezan_res from resume where num_res = " + a;
            typezan_resCommand.Connection.Open();
            SqlDataReader reader_11 = typezan_resCommand.ExecuteReader();

            bool MoreResults_11 = false;
            do
            {
                while (reader_11.Read())
                {
                    for (int i = 0; i < reader_11.FieldCount; i++)
                    {
                        typezan_res.Append(reader_11[i].ToString());

                    }
                    typezan_res.Append(Environment.NewLine);
                }

                MoreResults_11 = reader_11.NextResult();
            } while (MoreResults_11);
            reader_11.Close();
            typezan_resCommand.Connection.Close();
            textBox12.Text = typezan_res.ToString();

            //graph

            System.Text.StringBuilder graph_res = new System.Text.StringBuilder();
            SqlCommand graph_resCommand = new SqlCommand();
            graph_resCommand.Connection = connection;
            graph_resCommand.CommandType = CommandType.Text;
            graph_resCommand.CommandText = "Select graph_res from resume where num_res  = " + a;
            graph_resCommand.Connection.Open();
            SqlDataReader reader_12 = graph_resCommand.ExecuteReader();

            bool MoreResults_12 = false;
            do
            {
                while (reader_12.Read())
                {
                    for (int i = 0; i < reader_12.FieldCount; i++)
                    {
                        graph_res.Append(reader_12[i].ToString());

                    }
                    graph_res.Append(Environment.NewLine);
                }

                MoreResults_12 = reader_12.NextResult();
            } while (MoreResults_12);
            reader_12.Close();
            graph_resCommand.Connection.Close();
            textBox13.Text = graph_res.ToString();

            //sp

            System.Text.StringBuilder sp_res = new System.Text.StringBuilder();
            SqlCommand sp_resCommand = new SqlCommand();
            sp_resCommand.Connection = connection;
            sp_resCommand.CommandType = CommandType.Text;
            sp_resCommand.CommandText = "Select sp_res from resume where num_res  = " + a;
            sp_resCommand.Connection.Open();
            SqlDataReader reader_13 = sp_resCommand.ExecuteReader();

            bool MoreResults_13 = false;
            do
            {
                while (reader_13.Read())
                {
                    for (int i = 0; i < reader_13.FieldCount; i++)
                    {
                        sp_res.Append(reader_13[i].ToString());

                    }
                    sp_res.Append(Environment.NewLine);
                }

                MoreResults_13 = reader_13.NextResult();
            } while (MoreResults_13);
            reader_13.Close();
            sp_resCommand.Connection.Close();
            textBox15.Text = sp_res.ToString();

            //sp

            System.Text.StringBuilder child_res = new System.Text.StringBuilder();
            SqlCommand child_resCommand = new SqlCommand();
            child_resCommand.Connection = connection;
            child_resCommand.CommandType = CommandType.Text;
            child_resCommand.CommandText = "Select child_res from resume where num_res  = " + a;
            child_resCommand.Connection.Open();
            SqlDataReader reader_14 = child_resCommand.ExecuteReader();

            bool MoreResults_14 = false;
            do
            {
                while (reader_14.Read())
                {
                    for (int i = 0; i < reader_14.FieldCount; i++)
                    {
                        child_res.Append(reader_14[i].ToString());

                    }
                    child_res.Append(Environment.NewLine);
                }

                MoreResults_14 = reader_14.NextResult();
            } while (MoreResults_14);
            reader_14.Close();
            child_resCommand.Connection.Close();
            textBox7.Text = child_res.ToString();

            //obr

            System.Text.StringBuilder obr_res = new System.Text.StringBuilder();
            SqlCommand obr_resCommand = new SqlCommand();
            obr_resCommand.Connection = connection;
            obr_resCommand.CommandType = CommandType.Text;
            obr_resCommand.CommandText = "Select obr_res from resume where num_res  = " + a;
            obr_resCommand.Connection.Open();
            SqlDataReader reader_15 = obr_resCommand.ExecuteReader();

            bool MoreResults_15 = false;
            do
            {
                while (reader_15.Read())
                {
                    for (int i = 0; i < reader_15.FieldCount; i++)
                    {
                        obr_res.Append(reader_15[i].ToString());

                    }
                    obr_res.Append(Environment.NewLine);
                }

                MoreResults_15 = reader_15.NextResult();
            } while (MoreResults_15);
            reader_15.Close();
            obr_resCommand.Connection.Close();
            textBox19.Text = obr_res.ToString();

            //or

            System.Text.StringBuilder or_res = new System.Text.StringBuilder();
            SqlCommand or_resCommand = new SqlCommand();
            or_resCommand.Connection = connection;
            or_resCommand.CommandType = CommandType.Text;
            or_resCommand.CommandText = "Select or_res from resume where num_res  = " + a;
            or_resCommand.Connection.Open();
            SqlDataReader reader_16 = or_resCommand.ExecuteReader();

            bool MoreResults_16 = false;
            do
            {
                while (reader_16.Read())
                {
                    for (int i = 0; i < reader_16.FieldCount; i++)
                    {
                        or_res.Append(reader_16[i].ToString());

                    }
                    or_res.Append(Environment.NewLine);
                }

                MoreResults_16 = reader_16.NextResult();
            } while (MoreResults_16);
            reader_16.Close();
            or_resCommand.Connection.Close();
            textBox14.Text = or_res.ToString();

            //tel

            System.Text.StringBuilder tel_res = new System.Text.StringBuilder();
            SqlCommand tel_resCommand = new SqlCommand();
            tel_resCommand.Connection = connection;
            tel_resCommand.CommandType = CommandType.Text;
            tel_resCommand.CommandText = "Select tel_res from resume where num_res  = " + a;
            tel_resCommand.Connection.Open();
            SqlDataReader reader_17 = tel_resCommand.ExecuteReader();

            bool MoreResults_17 = false;
            do
            {
                while (reader_17.Read())
                {
                    for (int i = 0; i < reader_17.FieldCount; i++)
                    {
                        tel_res.Append(reader_17[i].ToString());

                    }
                    tel_res.Append(Environment.NewLine);
                }

                MoreResults_17 = reader_17.NextResult();
            } while (MoreResults_17);
            reader_17.Close();
            tel_resCommand.Connection.Close();
            textBox11.Text = tel_res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(b);
            SqlConnection connection = new SqlConnection(@"Data Source=RIMMA\SQLEXPRESS;Initial Catalog=trudkont;Integrated Security=True");
            SqlCommand delete_vacancy = new SqlCommand();
            delete_vacancy.Connection = connection;
            delete_vacancy.CommandType = CommandType.Text;
            delete_vacancy.CommandText = "Delete from resume where num_res=" + a;
            delete_vacancy.Connection.Open();
            delete_vacancy.ExecuteNonQuery();
            delete_vacancy.Connection.Close();
            MessageBox.Show("Данные удалены");
            this.Close();
        }
    }
}
