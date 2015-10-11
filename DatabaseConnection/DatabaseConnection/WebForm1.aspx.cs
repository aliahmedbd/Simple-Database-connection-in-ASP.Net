using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace DatabaseConnection
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load();
                this.loaddept();
            }
        }
        public void load()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "SELECT e.id,e.name,e.salary,d.name,d.location FROM Employees e,Departments d WHERE e.deptid=d.id";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();//must be open
            SqlDataReader reader = cmd.ExecuteReader();
            /*while (reader.Read())
            {
                Response.Write(reader["name"].ToString());
            }*/
            Gridview1.DataSource = reader;
            Gridview1.DataBind();
            conn.Close();
        }
        public void loaddept()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "SELECT * from Departments";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();//must be open
            SqlDataReader reader = cmd.ExecuteReader();
            DropDownList1.DataSource = reader;
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" )
            {
                Label1.Text = "Invalid";
                return;
            }
            double salary;
            try
            {
                salary = Convert.ToDouble(TextBox3.Text);
            }
            catch (Exception ex)
            {
                Label1.Text = "Invalid salary";
            }

            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "INSERT INTO Employees(name,email,salary,deptid) values('"+TextBox2.Text+"','"+TextBox1.Text+"',"+TextBox3.Text+","+DropDownList1.SelectedValue+")";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "Data Add successfully";
            this.load();

        }

    }
}