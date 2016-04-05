using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

namespace RetailStoreApp
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connection"]); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DropDownList1.Enabled = false;
            //DropDownList1.Items.Clear();
            //string value = DropDownList1.SelectedItem.Text;
            //if (value == "Virginia")
            //{
            //    DropDownList2.Items.Clear();
            //    DropDownList2.Items.Add("Hampton");
            //    DropDownList2.Items.Add("Norfolk");
            //    DropDownList2.Items.Add("Suffolk");
            //    DropDownList2.Items.Add("Richmond");
            //    //DropDownList2.Enabled = true;
                
            //}
      
            //if (value == "Texas")
            //{
            //    DropDownList2.Items.Clear();
            //    DropDownList2.Items.Add("Austin");
            //    DropDownList2.Items.Add("Houston");
            //    DropDownList2.Items.Add("San Antonio");
            //    DropDownList2.Items.Add("Dallas");

            //}
            //if (value == "Missouri")
            //{
            //    DropDownList2.Items.Clear();
            //    DropDownList2.Items.Add("Columbia");
            //    DropDownList2.Items.Add("Jefferson City");
            //    DropDownList2.Items.Add("Kansas City");
               
           
            //}
            //if (value == "Select State...")
            //    DropDownList2.Items.Clear();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string region=DropDownList2.SelectedItem.Text;
            //if (region == "Columbia")
            //{
            //    DropDownList3.Items.Clear();
            //    DropDownList3.Items.Add("Randolph County");
            //    DropDownList3.Items.Add("Audrain County");
            //    DropDownList3.Items.Add("Boone County");
               





            //}
            //if (region == "Jefferson City")
            //{

            //    DropDownList3.Items.Clear();
            //    DropDownList3.Items.Add("Cole");
            //    DropDownList3.Items.Add("Callaway");
            //    DropDownList3.Items.Add("Moniteau");
            //    DropDownList3.Items.Add("Osage");
              
            //}
            //if (region == "Kansas City")
            //{

            //    DropDownList3.Items.Clear();
            //    DropDownList3.Items.Add("Overland Park");
            //    DropDownList3.Items.Add("Kansas city");
            //    DropDownList3.Items.Add("Independence");
            //}

            //if (region == "Springfield")
            //{

            //    DropDownList3.Items.Clear();
            //    DropDownList3.Items.Add("Dallas");
            //    DropDownList3.Items.Add("Polk");
            //    DropDownList3.Items.Add("Greene");
            //    DropDownList3.Items.Add("Webster");





            //}
            //if (region == "Austin")
            //{

            //    DropDownList3.Items.Clear();

            //    DropDownList3.Items.Add("Travis");
            //    DropDownList3.Items.Add("Williamson");
            //    DropDownList3.Items.Add("Hays");

            //}
            //if (region == "Houston")
            //{

            //    DropDownList3.Items.Clear();
            //    DropDownList3.Items.Add("Harris");
            //    DropDownList3.Items.Add("Fort Bend");
            //    DropDownList3.Items.Add("Montgomery");

            //}
            //                                   if(region=="San Antonio")
                                                   
            //    DropDownList3.Items.Clear();
            //                                        if(region=="Tallahassee")
                                                        
            //    DropDownList3.Items.Clear();
            //                                            if(region=="Jacksonville")
                                                            
            //    DropDownList3.Items.Clear();
            //                                                if(region=="Miami")
                                                                
            //    DropDownList3.Items.Clear();
            //                                                    if(region=="Olympia")
                                                                    
            //    DropDownList3.Items.Clear();
            //                                                        if(region=="Seattle")

            //                                                            DropDownList3.Items.Clear();
                                                                       

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                //set Connection Property  of  Command object.............
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandType = CommandType.Text;
                string uid = TextBox5.Text.Trim();
                string fname = TextBox3.Text.Trim();
                   string lname = TextBox4.Text.Trim();
                   string pwd = TextBox6.Text.Trim();
              
                string epwd = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "SHA1");



                cmd.CommandText = "Insert into tblUsers(UserId,FirstName,LastName,EnycPassword) values ('" + uid + "','" + fname + "','"+lname+"','"+epwd+"')";

                cmd.ExecuteNonQuery();






            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
                throw new Exception(msg);

            }
            finally
            {
                con.Close();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string legituser = "";
            string usid = TextBox1.Text.Trim();
            string uspwd = TextBox2.Text.Trim();
            string euname = FormsAuthentication.HashPasswordForStoringInConfigFile(usid, "SHA1");
            string epwd = FormsAuthentication.HashPasswordForStoringInConfigFile(uspwd, "SHA1");
            string query = "select * from tblUsers where UserId=@UserName and EnycPassword=@Userpassword";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = null;
            try
            {

                con.Open();

                cmd.Parameters.AddWithValue("@UserName", usid);
                cmd.Parameters.AddWithValue("@Userpassword", epwd);

                sdr = cmd.ExecuteReader();
                if (sdr.Read()&& DropDownList5.SelectedItem.Text=="Admin")
                {

                    legituser = sdr["UserId"].ToString();
                    
                    Response.Redirect("AdminHome.aspx");




                }
                if (sdr.Read() && DropDownList5.SelectedItem.Text == "Customer")
                {
                    legituser = sdr["UserId"].ToString();

                    Response.Redirect("CustomerHome.aspx");

                }

              


            }
            catch (Exception ex)
            {
                Response.Write("Error" + ex.Message);

            }
            finally
            {
                con.Close();
                //sdr.Close();

            }
        }
        
    }
}