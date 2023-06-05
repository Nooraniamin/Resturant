using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApp1
{
    internal class Updation
    {
        public static void insertorderDetail(Int64 id,Int64 o_id, int p_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateorderDetail", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@o_id", id);
                cmd.Parameters.AddWithValue("@order", o_id);
                cmd.Parameters.AddWithValue("@p_id", p_id);
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.showMessge("item" + "add successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void updateorder(Int64 id,DateTime date, Int64 cate, Int16 o_type, Int16 f_id, Int16 t_id, float t_amount, float p_amount, float r_amount, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateorder", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@catID", cate);
                cmd.Parameters.AddWithValue("@orderType", o_type);
                cmd.Parameters.AddWithValue("@floorid", f_id);
                cmd.Parameters.AddWithValue("@tableid", t_id);
                cmd.Parameters.AddWithValue("@t_amount", t_amount);
                cmd.Parameters.AddWithValue("@a_paid", p_amount);
                cmd.Parameters.AddWithValue("@a_return", r_amount);
                cmd.Parameters.AddWithValue("@status", status);
                Mainclass.con.Open();
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.showMessge("item" + "add successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void updatefoodmenu(string name, Int16 cate, float price, Int16 status,int mid, Image img)
        {
            try
            {
                MemoryStream sa = new MemoryStream();
                img.Save(sa, ImageFormat.Jpeg);
                byte[] data = sa.ToArray();
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_updateMenuItem", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@catID", cate);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@mid", mid);
                int res = cmd.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("@image", data);
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.showMessge(name + "updated successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void updatefoodcate(string role, Int16 roleId)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_updatefoodcate", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", role);
                cmd.Parameters.AddWithValue("@rid", roleId);
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.showMessge(role + "updated successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void updateTables(int tid, int tableNumber, Int16 chairs, Int16 floorID)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_insertTable", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableNumber", tableNumber);
                cmd.Parameters.AddWithValue("@chair", chairs);
                cmd.Parameters.AddWithValue("@floorID", floorID);
                cmd.Parameters.AddWithValue("@tableID", tid);
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.showMessge(tableNumber + "add successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void updatefloors(Int16 fid, string name,Int16 number)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_updatefloor", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@floor", name);
                cmd.Parameters.AddWithValue("@floorN", number);
                cmd.Parameters.AddWithValue("@floorID", fid);
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.showMessge(name + "UPDATED successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void updateCustomer(Int64 cid,string name, string phone, string address)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_updatecustomers", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@cID", cid);
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.showMessge(name + "UPDATED successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void updateRole(string role, Int16 roleId)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_updateRoles", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", role);
                cmd.Parameters.AddWithValue("@rid", roleId);
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if(res > 0)
                {
                    Mainclass.showMessge(role + "updated successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void updateUser(int userId,string name, string uname, string pass, string address, string phone, Int16 roleId)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_updateUser", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", uname);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@roleId", roleId);
                cmd.Parameters.AddWithValue("@userId", userId);
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.showMessge(name + "add successfully into the system", "success");
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
