﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApp1
{
    internal class insertion
    {
        public static void insertorderDetail(Int64 o_id, int p_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertorderDetail", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public static void insertorder(DateTime date, Int64 cate, Int16 o_type, Int16 f_id, Int16 t_id,float t_amount,float p_amount,float r_amount,Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertorder", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@catID", cate);
                cmd.Parameters.AddWithValue("@orderType", o_type);
                cmd.Parameters.AddWithValue("@floorid", f_id);
                cmd.Parameters.AddWithValue("@tableid",t_id );
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
        public static void insertfoodmenu(string name,Int16 cate,float price,Int16 status, Image img)
        {
            try
            {
                MemoryStream sa = new MemoryStream();
                img.Save(sa, ImageFormat.Png);
                byte[] data = sa.ToArray();
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_insertMenuItem", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@catID", cate);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@image", data);
                Mainclass.con.Open();
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
        public static void insertfoodcate(string Role)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_insertfoodcate", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", Role);
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res > 0)
                {
                    Mainclass.showMessge(Role + "add successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void insertTables(int tableNumber, Int16 chairs, Int16 floorID)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_insertTable", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tableNumber", tableNumber);
                cmd.Parameters.AddWithValue("@chair", chairs);
                cmd.Parameters.AddWithValue("@floorID", floorID);
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
        public static void insertFloors(string name, Int16 number)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_insertfloor", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@floor", name);
                cmd.Parameters.AddWithValue("@floorN", number);
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
        public static void insertCustomer(string name,string phone,string address)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_insertCustomer55", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name );
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
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
        public static void insertRole(string Role)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_insertRole", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", Role);
                int res = cmd.ExecuteNonQuery();
                Mainclass.con.Close();
                if (res>0)
                {
                    Mainclass.showMessge(Role + "add successfully into the system", "success"); 
                }
            }
            catch (Exception ex) 
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void insertUser(string name,string uname,string pass,string address,string phone,Int16 roleId)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_insertUser", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", uname);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.Parameters.AddWithValue("address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@roleId", roleId);
                
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
        public static void insertcus(string name,string address, string phone)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_insertCustomer", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
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
