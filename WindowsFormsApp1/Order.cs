using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Items IT = new Items();
            Mainclass.showWindow(IT, MDI.ActiveForm);
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = Retreival.USER;
            Retreival.loaditems("st_getfoodcate", CateDD, "Food ID", "Food Categories");
            CateDD.SelectedIndex = -1;
            
            Retreival.loaditems("st_getfloors",floorDD , "ID", "Floor");
            floorDD.SelectedIndex = -1;
            tableDD.SelectedIndex = -1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CateDD_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                Retreival.loaditems("st_getMenuItemWRtCategory", itemDD, "Menu ID", "Menu Items", "@cid", Convert.ToInt16(CateDD.SelectedValue.ToString()));
                itemDD.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Mainclass.showMessge(ex.Message, "Error");
            }
                
            
        }
        private void itemDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                Mainclass.con.Open();
                SqlCommand cmd = new SqlCommand("st_getpriceWRTMenuItems",Mainclass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mid", Convert.ToInt32(itemDD.SelectedValue.ToString()));
                price_txt.Text = cmd.ExecuteScalar().ToString();
                Mainclass.con.Close();
            }
            catch(Exception ex)
            {
                Mainclass.con.Close();
                Mainclass.showMessge(ex.Message, "Error");
            }
            
        }

        private void floorDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Retreival.loaditems("st_gettablesWRTFloor", tableDD, "Table ID", "Table Number", "@floorID", Convert.ToInt16(floorDD.SelectedValue.ToString()));
                
            }
            catch (Exception ex)
            {
                Mainclass.showMessge(ex.Message, "Error");
            }
            
        }

        private void OrderDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(OrderDD.SelectedIndex != 1)
            {
                if (OrderDD.SelectedIndex == 0) 
                {
                    floorDD.Enabled = true;
                    tableDD.Enabled = true;
                    phone_txt.Visible = false;
                    label10.Visible = false;
                }
                else 
                {
                    floorDD.Enabled = false;
                    tableDD.Enabled = false;
                    phone_txt.Visible = true;
                    label10.Visible = true;
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
