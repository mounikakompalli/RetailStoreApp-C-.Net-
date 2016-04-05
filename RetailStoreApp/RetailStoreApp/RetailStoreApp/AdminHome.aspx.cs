using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace RetailStoreApp
{
    public partial class AdminHome : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connection"]);  
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            Label2.Visible = false;
            if (!IsPostBack)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tblEmployee", con);
                SqlDataAdapter dtAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dtAdapter.Fill(ds);
                
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                SqlCommand cmd1 = new SqlCommand("select * from tblMerchandise", con);
                SqlDataAdapter dtAdapter1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                dtAdapter1.Fill(ds1);

                GridView2.DataSource = ds1.Tables[0];
                GridView2.DataBind();
                con.Close();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            string eid =TextBox1.Text;
            string sec = TextBox2.Text;
            string ename = TextBox3.Text;
            string sex = RadioButtonList1.SelectedItem.Text;
            string job = TextBox4.Text;
            string joining = TextBox5.Text;
            string sal = TextBox6.Text;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into tblEmployee(EmployeeId,SSN,EmployeeName,Sex,JobTitle,JoinDate,salary) values ('" + eid + "','"+sec+"','" + ename + "','"+sex+"','"+job+"','"+joining+"','"+sal+"')";

            cmd.ExecuteNonQuery();
            
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string emid = TextBox7.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tblEmployee where EmployeeId=('"+emid+"')";
            cmd.ExecuteNonQuery();
          
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string item = TextBox10.Text;
            string desc = TextBox11.Text;
            double price = Convert.ToDouble (TextBox12.Text);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into tblMerchandise(ItemId,ItemDescription,Price) values ('" + item + "','" + desc + "','" + price +  "')";

            cmd.ExecuteNonQuery();
            Label1.Visible = true;
            //Response.Redirect("AdminHome.aspx");
            con.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string Itid = TextBox13.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tblMerchandise where ItemId=('" + Itid + "')";
            cmd.ExecuteNonQuery();
            Label2.Visible = true;
            con.Close();
        }
    }
}