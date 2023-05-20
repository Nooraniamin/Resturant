using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (name_txt.Text == "") { nameerror_lbl.Visible = true; } else { nameerror_lbl.Visible = false; }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (phone_txt.Text == "") { phoneerror_lbl.Visible = true; } else { phoneerror_lbl.Visible = false; }
        }
        public static int edit, delstatus;

        private void button2_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.ControlEnable(panel1);
        }
        Int16 userID;
        
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (Mainclass.checkControl(panel1).Count == 0)
            {
                if (edit == 0)
                {
                     
                    insertion.insertUser(name_txt.Text, uname.Text, password_txt.Text, address_txt.Text, phone_txt.Text, Convert.ToInt16(RoleDD.SelectedValue.ToString()));
                    Mainclass.resetDisable(panel1);
                    Retreival.getUsers(dataGridView1, ID, name1, Username, Password, Phone, Address, RoleID, Role);
                }
                else if (edit == 1)
                {

                    
                    Updation.updateUser(userID, name_txt.Text, uname.Text, password_txt.Text, address_txt.Text, phone_txt.Text, Convert.ToInt16(RoleDD.SelectedValue.ToString()));
                    Mainclass.resetDisable(panel1);
                    Retreival.getUsers(dataGridView1, ID, name1, Username, Password, Phone, Address, RoleID, Role);
                }
            }
            else
            {
                MessageBox.Show("Please Enter all required fields");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure,You want to delete this record ?", "Question.....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.delete("st_deleteUser", "@userId", userID);
                    Mainclass.resetDisable(panel1);
                    Retreival.getUsers(dataGridView1, ID, name1, Username, Password, Phone, Address, RoleID, Role);

                }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Retreival.getUsers(dataGridView1, ID, name1, Username, Password, Phone, Address, RoleID, Role);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delstatus = 1;
                Mainclass.ControlDisable(panel1);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt16(row.Cells["ID"].Value.ToString());
                name_txt.Text = row.Cells["name1"].Value.ToString();
                uname.Text = row.Cells["Username"].Value.ToString();
                password_txt.Text = row.Cells["Password"].Value.ToString();
                phone_txt.Text = row.Cells["Phone"].Value.ToString();
                address_txt.Text = row.Cells["Address"].Value.ToString();
                RoleDD.SelectedValue = row.Cells["RoleID"].Value;
            }
        }

        private void address_txt_TextChanged(object sender, EventArgs e)
        {
            if (address_txt.Text == "") { addresserror_lbl.Visible = true; } else { addresserror_lbl.Visible = false; }
        }

        private void RoleDD_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (RoleDD.SelectedIndex == -1) { roleerror_lbl.Visible = true; } 
            else 
            { 
                roleerror_lbl.Visible = false;
                
            }
        }

        private void uname_TextChanged(object sender, EventArgs e)
        {
            if(uname.Text == "") { unameerror_lbl.Visible = true; } else { unameerror_lbl.Visible= false; }
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            if(password_txt.Text =="") { passworderror_lbl.Visible = true; } else {  passworderror_lbl.Visible = false; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Items IT = new Items();
            Mainclass.showWindow(IT, this,MDI.ActiveForm);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Retreival.loaditems("st_getRoles", RoleDD, "RoleID", "Role");
            RoleDD.SelectedIndex = -1;
        }

        private void phoneerror_lbl_Click(object sender, EventArgs e)
        {

        }

        private void unameerror_lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void User_Load(object sender, EventArgs e)
        {
            label2.Text = Retreival.USER;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            edit = 0;
            Mainclass.resetEnable(panel1);
            delstatus = 0;
            
        }

    }
}