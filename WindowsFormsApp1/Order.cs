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
using WindowsFormsApp1.Properties;
using System.Transactions;
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
            Retreival.loaditem("st_getMenuItem", listBox1, "Menu ID", "Menu Items");
            
            Retreival.loaditems("st_getMenuItem", itemDD, "Menu ID", "Menu Items");
            Retreival.loaditems("st_getfloors",floorDD , "ID", "Floor");
            floorDD.SelectedIndex = -1;
            tableDD.SelectedIndex = -1;
            itemDD.SelectedIndex = -1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CateDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void itemDD_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (itemDD.SelectedIndex != -1)
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("st_getpriceWRTMenuItems", Mainclass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mid", Convert.ToInt32(itemDD.SelectedValue.ToString()));
                    Mainclass.con.Open();
                    price_txt.Text = Math.Round(Convert.ToDouble(cmd.ExecuteScalar().ToString()), 0).ToString();
                    Mainclass.con.Close();
                    Image I = Retreival.getimage(Convert.ToInt32(itemDD.SelectedValue.ToString()));
                    pictureBox1.Image = I;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    DataRowView drv = itemDD.SelectedItem as DataRowView;
                    Retreival.loaditemCate(drv["Menu Items"].ToString());

                }
                catch (Exception ex)
                {
                    Mainclass.con.Close();
                    Mainclass.showMessge(ex.Message, "Error");
                }
            }
            else
            {
                price_txt.Text = null;
                pictureBox1.Image = null;

            }
        }

        private void floorDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Retreival.loaditemssa("st_gettablesWRTFloor", tableDD, "Table ID", "Table Number", "@floorID", Convert.ToInt16(floorDD.SelectedValue.ToString()));
                
            }
            catch (Exception ex)
            {
                Mainclass.showMessge(ex.Message, "Error");
            }
            
        }

        private void OrderDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(OrderDD.SelectedIndex != -1)
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
        float ta = 0;
        int catID; string catname;
        
        private void button7_Click(object sender, EventArgs e)
        {
            if (Mainclass.checkControl(panel1).Count != 0)
            {
                catID = Retreival.CATEID;
                catname = Retreival.CATENAME;
                DataRowView drvitem = itemDD.SelectedItem as DataRowView;
                DataRowView drvfloor = floorDD.SelectedItem as DataRowView;
                DataRowView drvtable = tableDD.SelectedItem as DataRowView;

                bool check = false;
                if (dataGridView1.Rows.Count == 1)
                {
                    if (OrderDD.SelectedIndex == 0)
                    {
                        dataGridView1.Rows.Add(null, catID, catname, Convert.ToInt32(itemDD.SelectedValue.ToString()), drvitem["Menu Items"], price_txt.Text,
                        numericUpDown1.Value, OrderDD.SelectedItem, Convert.ToInt16(floorDD.SelectedValue.ToString()), drvfloor["Floor"],
                        Convert.ToInt16(tableDD.SelectedValue.ToString()), drvtable["Table Number"], null, 0, 0); 
                    }
                    else
                    {
                            dataGridView1.Rows.Add(null,catID, catname, Convert.ToInt32(itemDD.SelectedValue.ToString()),
                            drvitem["Menu Items"], price_txt.Text, numericUpDown1.Value, OrderDD.SelectedItem, null, null,
                            null, null, phone_txt.Text, 0);
                        
                        
                    }
                }
                else if (dataGridView1.Rows.Count > 1)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (itemDD.SelectedValue.ToString() == row.Cells["menuID"].Value.ToString())
                        {
                            check = true;

                            if (check)
                            {
                                Mainclass.showMessge("Item added already", "Error");
                                break;
                            }

                        }
                        else if (itemDD.SelectedValue.ToString() != row.Cells["menuID"].Value.ToString())
                        {
                            if (OrderDD.SelectedIndex == 0)
                            {
                                dataGridView1.Rows.Add(null, catID, catname, Convert.ToInt32(itemDD.SelectedValue.ToString()), drvitem["Menu Items"], price_txt.Text,
                                numericUpDown1.Value, OrderDD.SelectedItem, Convert.ToInt16(floorDD.SelectedValue.ToString()), drvfloor["Floor"],
                                Convert.ToInt16(tableDD.SelectedValue.ToString()), drvtable["Table Number"], null, 0, 0);
                            }
                            else
                            {
                                dataGridView1.Rows.Add(null, catID, catname, Convert.ToInt32(itemDD.SelectedValue.ToString()),
                                drvitem["Menu Items"], price_txt.Text, numericUpDown1.Value, OrderDD.SelectedItem, null, null,
                                null, null, phone_txt.Text, 0);


                            }
                        }

                    }
                }

                ta += float.Parse(price_txt.Text);
                totalAmount.Text = ta.ToString();

            }



        }
        int edit;
        private void button1_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.resetEnable(panel1);
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 14)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    float prc = Convert.ToSingle(row.Cells["price"].Value.ToString());
                    ta -= prc;
                    totalAmount.Text = ta.ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    if (OrderDD.SelectedIndex == 0)
                    {
                        insertion.insertorder(DateTime.Today, catID, Convert.ToInt16(OrderDD.SelectedIndex), 
                        Convert.ToInt16(floorDD.SelectedValue.ToString()), Convert.ToInt16(tableDD.SelectedValue.ToString()),
                        float.Parse(totalAmount.Text), 0, 0,0);
                    }
                    else
                    {
                        insertion.insertorder(DateTime.Today, catID, Convert.ToInt16(OrderDD.SelectedIndex), Convert.ToInt16(floorDD.SelectedValue.ToString()), Convert.ToInt16(tableDD.SelectedValue.ToString()), float.Parse(totalAmount.Text), 0, 0, 0);
                    }

                }
                catch (Exception ex)
                {

                }
                ts.Complete();
            }
        }
        Int64 cusID;
        private void phone_txt_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Phone_txt_Leave(object sender, EventArgs e) 
        {
            
        }

        private void phone_txt_Leave_1(object sender, EventArgs e)
        {
            if (phone_txt.Text != "")
            {
                cusID = Retreival.getcusWrtPhone(phone_txt.Text);
                if (cusID == 0)
                {
                    Customer cw = new Customer();
                    Mainclass.showWindow(cw, this, MDI.ActiveForm);
                }
                else if( cusID != 0)
                {
                    Mainclass.showMessge(Retreival.CUSTOMER + "\n" + Retreival.ADDRESS + "\n", "Success"); 
                }
            }

        }
    }
}
