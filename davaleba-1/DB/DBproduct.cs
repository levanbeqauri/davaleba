using davaleba_1.products;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba_1.DB
{
    public class DBproduct
    {

        //public static string connStr = ConfigurationManager.ConnectionStrings["Server=16.0.1000.6;Database=product;"].ConnectionString;
        string connStr = "Data Source=WINDOWS-EJCDL48;Database=product;user id=levan;password=levanlado12;"; 



        public DBproduct() { }

        public List<Products> GetAllProducts()
        {
            List<Products> list = new List<Products>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ProductTable");
            cmd.CommandType = System.Data.CommandType.Text;

            SqlConnection conn = new SqlConnection(connStr);
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Products p = new Products();
               
                p.Productname = reader["ProductName"].ToString();
                p.Productprice = Convert.ToDecimal(reader["ProductPrice"].ToString());
                p.Raodenoba = Convert.ToInt16(reader["Raodenoba"].ToString());
                //p.Dateofissue = reader["Dateofissue"] != System.DBNull.Value ? Convert.ToDateTime(reader["Dateofissue"]) : new DateTime();

                list.Add(p);
            }
            reader.Close();
            conn.Close();
            return list;

        }
        public void AddProduct(Products p)
        {
            SqlCommand cmd = new SqlCommand("insert into ProductTable (ProductName,ProductPrice,Raodenoba)\r\nvalues (@ProductName,@ProductPrice,@Raodenoba)");
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@ProductName", p.Productname);
            cmd.Parameters.AddWithValue("@ProductPrice", p.Productprice);
            cmd.Parameters.AddWithValue("@Raodenoba", p.Raodenoba);
            //cmd.Parameters.AddWithValue("Dateofissue", p.Dateofissue);

            SqlConnection conn = new SqlConnection(connStr);
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }  
    }
}
