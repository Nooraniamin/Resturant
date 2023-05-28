﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    internal class Retreival
    {
        public static void getfoodmenu(DataGridView gv, DataGridViewColumn mid, DataGridViewColumn m_name, DataGridViewColumn catId, DataGridViewColumn catname, DataGridViewColumn price, DataGridViewColumn status, DataGridViewColumn img)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_getMenuItem", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mid.DataPropertyName = dt.Columns["Menu ID"].ToString();
                m_name.DataPropertyName = dt.Columns["Menu Items"].ToString();
                price.DataPropertyName = dt.Columns["Price"].ToString();
                status.DataPropertyName = dt.Columns["Status"].ToString();
                catId.DataPropertyName = dt.Columns["Cateergory ID"].ToString();
                catname.DataPropertyName = dt.Columns["Category"].ToString();
                img.DataPropertyName = dt.Columns["Image"].ToString();
                gv.DataSource = dt;
                Mainclass.sno(gv, "SNO");
                Mainclass.con.Close();
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void getfood(DataGridView gv, DataGridViewColumn roleIDGV, DataGridViewColumn roleNameGV)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_getfoodcate", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                roleIDGV.DataPropertyName = dt.Columns["Food ID"].ToString();
                roleNameGV.DataPropertyName = dt.Columns["Food Categories"].ToString();
                gv.DataSource = dt;
                Mainclass.sno(gv, "SNO");
                Mainclass.con.Close();
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void gettables(DataGridView gv, DataGridViewColumn floorIDGV, DataGridViewColumn floorNameGV, DataGridViewColumn tableNumber, DataGridViewColumn tableid, DataGridViewColumn chairs)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_gettable", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                floorIDGV.DataPropertyName = dt.Columns["Floor ID"].ToString();
                floorNameGV.DataPropertyName = dt.Columns["Floor"].ToString();
                tableNumber.DataPropertyName = dt.Columns["Table Number"].ToString();
                tableid.DataPropertyName = dt.Columns["Table ID"].ToString();
                chairs.DataPropertyName = dt.Columns["Chairs"].ToString();
                gv.DataSource = dt;
                Mainclass.sno(gv, "SNO");
                Mainclass.con.Close();
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void getfloors(DataGridView gv, DataGridViewColumn floorIDGV, DataGridViewColumn floorNameGV, DataGridViewColumn floorNumber)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_getfloors", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                floorIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                floorNameGV.DataPropertyName = dt.Columns["Floor"].ToString();
                floorNumber.DataPropertyName = dt.Columns["Floor Number"].ToString();
                gv.DataSource = dt;
                Mainclass.sno(gv, "SNO");
                Mainclass.con.Close();
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void getcus(DataGridView gv, DataGridViewColumn UserIDGV, DataGridViewColumn userNameGV,  DataGridViewColumn phone, DataGridViewColumn address)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_getCustomers", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UserIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                userNameGV.DataPropertyName = dt.Columns["Customer"].ToString();
                phone.DataPropertyName = dt.Columns["Phone"].ToString();
                address.DataPropertyName = dt.Columns["Address"].ToString();
                gv.DataSource = dt;
                Mainclass.sno(gv, "SNO");
                Mainclass.con.Close();
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void getRoles(DataGridView gv,DataGridViewColumn roleIDGV,DataGridViewColumn roleNameGV)
        {
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_getRoles", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                roleIDGV.DataPropertyName = dt.Columns["RoleID"].ToString();
                roleNameGV.DataPropertyName = dt.Columns["Role"].ToString();
                gv.DataSource = dt;
                Mainclass.sno(gv, "SNO");
                Mainclass.con.Close();
            }
            catch (Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        public static void getUsers(DataGridView gv, DataGridViewColumn UserIDGV, DataGridViewColumn userNameGV, DataGridViewColumn uname, DataGridViewColumn pass, DataGridViewColumn phone, DataGridViewColumn address, DataGridViewColumn roleId, DataGridViewColumn role)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUser", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UserIDGV.DataPropertyName = dt.Columns["User Id"].ToString();
                userNameGV.DataPropertyName = dt.Columns["User"].ToString();
                uname.DataPropertyName = dt.Columns["Username"].ToString();
                pass.DataPropertyName = dt.Columns["Password"].ToString();
                phone.DataPropertyName = dt.Columns["Phone"].ToString();
                address.DataPropertyName = dt.Columns["Address"].ToString();
                roleId.DataPropertyName = dt.Columns["Role ID"].ToString();
                role.DataPropertyName = dt.Columns["Role"].ToString();
                gv.DataSource = dt;
                Mainclass.sno(gv, "SNO");
            }
            catch (Exception ex)
            {
                Mainclass.showMessge(ex.Message, "Error");
            }
        }
        
        public static void loaditems(string proc, ComboBox cb, string vMember, string dMember,string param=null,Int16 val =0)
        {
            try
            {
                if(param == null && val == 0)
                {
                    Mainclass.con.Open();
                    SqlCommand cmd = new SqlCommand(proc, Mainclass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cb.DisplayMember = dMember;
                    cb.ValueMember = vMember;
                    cb.DataSource = dt;
                    Mainclass.con.Close();
                    
                }
                else
                {
                    Mainclass.con.Open();
                    SqlCommand cmd = new SqlCommand(proc, Mainclass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue(param, val);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cb.DisplayMember = dMember;
                    cb.ValueMember = vMember;
                    cb.DataSource = dt;
                    Mainclass.con.Close();

                }
                
            }
            catch(Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message,"Error");
            }

        }
        private static string name;
        private static string role;
        public static string USER
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }
        public static string ROLE
        {
            get
            {
                return role;
            }
            private set
            {
                role= value;
            }
        }
        public static bool isValidUser(string user, string pass)
        {
            bool status = false;
            try
            {
                
                SqlCommand cmd = new SqlCommand("st_getUser4Auth", Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user",user);
                cmd.Parameters.AddWithValue("@pass",pass);
                Mainclass.con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        if(user == reader["Username"].ToString() && pass == reader["Password"].ToString())
                        {
                            USER = reader["User"].ToString();
                            ROLE = reader["Role"].ToString();
                            status = true;
                            
                        }
                        else
                        {
                            Mainclass.showMessge("Invalid User and Password ", "Error");
                            status = false;
                            
                        }
                    }
                }
                else
                {
                    Mainclass.showMessge("Invalid User and Password ", "Error");
                    status = false;
                    
                }
                Mainclass.con.Close();
            }
            catch (Exception ex)
            {
                Mainclass.showMessge(ex.Message, "Error");
                Mainclass.con.Close();
            }
            return status;
        }
    }
}
