using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Курсовая_вп
{
    class newcompanyclass
    {
        private string type_comp;
        private string name_comp;
        private string city_comp;
        private string tel_comp;
        private string email_comp;
        private string wsite_comp;

        public newcompanyclass(string TypeComp, string NameComp, string CityComp, string TelComp, string EmailC, string WSiteC)
        {
            type_comp = TypeComp;
            name_comp = NameComp;
            city_comp = CityComp;
            tel_comp = TelComp;
            email_comp = EmailC;
            wsite_comp = WSiteC;
        }

        //insert vacancy
        public void vac()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=RIMMA\SQLEXPRESS;Initial Catalog=trudkont;Integrated Security=True");
            SqlCommand insert_company = new SqlCommand();
            insert_company.Connection = connection;
            insert_company.CommandType = CommandType.Text;
            insert_company.CommandText = "insert into [company] ([type_comp],[name_comp],[city_comp],[tel_comp],[email_comp]" +
      ",[wsite_comp])" +
      "values('" + type_comp + "','" + name_comp + "','" + city_comp + "','" + tel_comp + "','" +
      email_comp + "','" + wsite_comp + "')";
        insert_company.Connection.Open();
            insert_company.ExecuteNonQuery();
            insert_company.Connection.Close();
        }
    }
}
