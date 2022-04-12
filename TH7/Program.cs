
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace TH7
{
    class Program
    {  
        static void Main(string[] args)
        {
          string cnnstr = "Server=;Database=QLSV;User Id =sa;Password=12";
          SqlConnection cnn = new SqlConnection(cnnstr);
          string query = "select count(*) from SV";
          SqlCommand cmd = new SqlCommand(query,cnn);
          cnn.Open();
          int n = (int)cmd.ExecuteScalar();
          cnn.Close();
          Console.WriteLine(n.ToString());
        }
    }
}