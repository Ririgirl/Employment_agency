using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Курсовая_вп
{
    class newresumeclass
    {
        private string fname_res;
        private string name_res;
        private string oname_res;
        private string spec_res;
        private string gr_res;
        private string gender_res;
        private string city_res;
        private string email_res;
        private string zp_res;
        private string dolzn_res;
        private string typezan_res;
        private string graph_res;
        private string sp_res;
        private string child_res;
        private string obr_res;
        private string or_res;
        private string tel_res;

        public newresumeclass(string FNamer, string Namer, string oNamer, string Specr, string Grr, string Genderr, string Cityr, string Emailr, string Zpr, string Dolznr, string TZr, string Graphr, string Spr, string Childr, string Obrr, string Orr, string Telr)
        {
            fname_res= FNamer;
        name_res= Namer;
        oname_res= oNamer;
        spec_res= Specr;
        gr_res= Grr;
        gender_res=Genderr;
        city_res=Cityr;
        email_res=Emailr;
        zp_res=Zpr;
        dolzn_res=Dolznr;
        typezan_res=TZr;
        graph_res=Graphr;
        sp_res=Spr;
        child_res=Childr;
        obr_res=Obrr;
        or_res=Orr;
        tel_res=Telr;
    }

        //insert vacancy
        public void vac()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=RIMMA\SQLEXPRESS;Initial Catalog=trudkont;Integrated Security=True");
            SqlCommand insert = new SqlCommand();
            insert.Connection = connection;
            insert.CommandType = CommandType.Text;
            insert.CommandText = "insert into [resume] ([fname_res],[name_res],[oname_res],[spec_res]" +
      ",[gr_res],[gender_res],[city_res],[email_res],[zp_res],[dolzn_res],[typezan_res],[graph_res],[sp_res],[child_res],[obr_res],[or_res],[tel_res])" +
      "values('" + fname_res + "','" + name_res + "','" + oname_res + "','" + spec_res + "'," +
      gr_res + ",'" + gender_res + "','" + city_res + "','" + email_res + "'," + zp_res + ",'" +
      dolzn_res + "','" + typezan_res + "','" + graph_res + "','" + sp_res + "'," + child_res + ",'" + obr_res + "','" + or_res + "'," + tel_res + ")";
            insert.Connection.Open();
            insert.ExecuteNonQuery();
            insert.Connection.Close();
        }
    }
}
