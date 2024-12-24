using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace _2_T_Application_Prv
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Golu Kumar\source\repos\2_T_Application_Prv\2_T_Application_Prv\App_Data\Database1.mdf"";Integrated Security=True";

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            getcon();
        }

        void getcon()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            getcon();
            cmd = new SqlCommand("insert into MyTable (Username, Email, Address)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", con);
            
            cmd.ExecuteNonQuery();
        }
    }
}