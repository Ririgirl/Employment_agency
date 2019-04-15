using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Курсовая_вп
{
    class newvacancylass
    {
        private string vac_name;
        private string comp_name;
        private string opit;
        private string gender;
        private string obr;
        private string skills;
        private string dolz;
        private string salary;

        public newvacancylass(string vacName, string compName, string opit, string gender, string obr, string skills, string dolz, string slSalary)
        {
            vac_name = vacName;
            comp_name = compName;
            this.opit = opit;
            this.gender = gender;
            this.obr = obr;
            this.skills = skills;
            this.dolz = dolz;
            salary = slSalary;
        }

        //insert vacancy
        public void vac()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=RIMMA\SQLEXPRESS;Initial Catalog=trudkont;Integrated Security=True");
            SqlCommand insert_vacancy = new SqlCommand();
            insert_vacancy.Connection = connection;
            insert_vacancy.CommandType = CommandType.Text;
            insert_vacancy.CommandText = "insert into [vacancy] ([name_vac],[dolzn_vac],[zp_vac],[gender_vac],[obr_vac]" +
                                         ",[or_vac],[skills_vac],[num_comp])" +
                                         "values('" + vac_name + "','" + comp_name + "','" + opit + "','" + gender + "','" + obr + "','" +
                                         skills + "','" + dolz + "'," + salary + ")";
            insert_vacancy.Connection.Open();
            insert_vacancy.ExecuteNonQuery();
            insert_vacancy.Connection.Close();
        }
    }
}