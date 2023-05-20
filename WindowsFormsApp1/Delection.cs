using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    internal class Deletion
    {
        public static void delete(string procedure, string param, int value1=0,Int16 value2=0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (value1 != 0)
                {
                    cmd.Parameters.AddWithValue(param, value1);
                }
                else if (value2 != 0)
                {
                    cmd.Parameters.AddWithValue(param, value2);

                }
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.showMessge("Data Delete successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");

            }
        }
        public static void deleteData(string procedure, string param, int value1 = 0, Int64 value2 = 0)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedure, Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (value1 != 0)
                {
                    cmd.Parameters.AddWithValue(param, value1);
                }
                else if (value2 != 0)
                {
                    cmd.Parameters.AddWithValue(param, value2);

                }
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.showMessge("Data Delete successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");

            }
        }
    }
}