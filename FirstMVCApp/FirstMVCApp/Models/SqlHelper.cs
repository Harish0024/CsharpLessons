using System;

using Microsoft.Data.SqlClient;
namespace FirstMVCApp.Models
   
{
    //datafirst approach it is bottom first approach
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()//this method is factory method
        {
            var connString = @"server=200411LTP2844\SQLEXPRESS; database=testdb;integrated security=true;Encrypt=false;";
            SqlConnection sqlcn=new SqlConnection(connString);
            return sqlcn;
        }
    }
}
