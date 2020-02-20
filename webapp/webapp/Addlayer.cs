using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace webapp
{
    public class Addlayer
    {
        DataSet ds = new DataSet();
        string constr = "";

        public Addlayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myclass"].ConnectionString;
        }
        public DataSet Insert()
        {
            string constr = "";
            constr = ConfigurationManager.ConnectionStrings["myclass"].ConnectionString;
            DataSet dd = new DataSet();
            string qry = "insert into student values(7,'alex','javascript','2-6-2020')";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(dd);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dd;
        }

        public DataSet Getstudent(int id)
        {
            // DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.CommandText = "prdstudent";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);

                }

            }
            catch { }
            return ds;
        }
        public DataSet getallrecords()
        {
            // DataSet ds = new DataSet();

            string query = "select * from student";



            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);


                }
            }
            catch (Exception e)
            {
            }
            return ds;

        }
        public void DInsert(int Id, string Sname, string Scourse, string Doj)
        {
            //DataSet ds = new DataSet();
            string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SNR;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                try
                {
                    con.Open();
                    cmd = new SqlCommand("insert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Sname", Sname);
                    cmd.Parameters.AddWithValue("@Scourse", Scourse);
                    cmd.Parameters.AddWithValue("@Doj", Doj);
                    cmd.CommandText = "insertstu";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);
                }
                catch (Exception e)
                { }

            }
        }
         public  DataSet update(DateTime Doj,string Sname)
            {
                
                     SqlCommand cmd = new SqlCommand();
                try { 
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        
                            con.Open();
                            
                            cmd.Connection = con;
                        cmd = new SqlCommand("update", con);

                        
                        cmd.CommandText = "prdupdate";

                        cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Sname",Sname);
                            cmd.Parameters.AddWithValue("@Doj", Doj);
                    /*  cmd.Parameters.AddWithValue("@Sname", Sname);
                      cmd.Parameters.AddWithValue("@Scourse", Scourse);*/
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);

                }

            }
                catch (Exception e)
                { }
                return ds;

            }

        }

    }



            


