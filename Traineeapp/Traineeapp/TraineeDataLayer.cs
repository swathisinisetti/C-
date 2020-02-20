using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Traineeapp
{
    public class TraineeDataLayer
    {
        DataSet ds = new DataSet();
        Trainee1 t1 = new Trainee1();
        string constr = "";

        public TraineeDataLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myclass"].ConnectionString;
        }

        public void DInsert(Trainee1 t1)
        {
            //DataSet ds = new DataSet();
            string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SNR;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                try
                {
                    con.Open();
                    cmd = new SqlCommand("Insert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tid",t1.tid);
                    cmd.Parameters.AddWithValue("@tname", t1.tname);
                    cmd.Parameters.AddWithValue("@location", t1.location);
                    cmd.Parameters.AddWithValue("@techdomain", t1.techdomain);
                    cmd.Parameters.AddWithValue("@startdate",t1.startdate);
                    cmd.CommandText = "insTrainee";
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
        public DataSet getallrecords()
        {


            string query = "select * from Trainee";



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
        public void update(int tid,string tname)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@tid",tid);
                    cmd.Parameters.AddWithValue("@tname",tname);
                    cmd.CommandText = "updateprd";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    ad.Fill(ds);
                    ad.Update(ds);


                }
            }
            catch(Exception e)
            { }
        }
    }
}