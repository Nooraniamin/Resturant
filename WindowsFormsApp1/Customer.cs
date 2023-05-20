using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Items IT = new Items();
            Mainclass.showWindow(IT, MDI.ActiveForm);
            this.Close();
        }
        int edit,delestatus;
        Int64 cusID;
        private void button1_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.resetEnable(panel1);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure,You want to delete this record ?", "Question.....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Deletion.deleteData("st_deletecustomer", "@cID", 0, cusID);
                Mainclass.resetDisable(panel1);
                Retreival.getcus(dataGridView1, ID, name1, Phone, Address);
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (Mainclass.checkControl(panel1).Count == 0)
            {
                if (edit == 0)
                {
                    //textBox3.Visible = false;
                    insertion.insertcus(cusname_txt.Text, phone_txt.Text, address_txt.Text);
                    Mainclass.resetDisable(panel1);
                    Retreival.getcus(dataGridView1, ID, name1,  Phone, Address);
                }
                else if (edit == 1)
                {

                    //userID = Convert.ToInt16(textBox3.Text);
                    Updation.updateCustomer(cusID, cusname_txt.Text, phone_txt.Text, address_txt.Text);
                    Mainclass.resetDisable(panel1);
                    Retreival.getcus(dataGridView1, ID, name1 ,Phone, Address);
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Retreival.getcus(dataGridView1, ID, name1,Phone, Address);
        }

        private void cusname_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void phone_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void address_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.ControlEnable(panel1);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = Retreival.USER;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delestatus = 1;
                Mainclass.ControlDisable(panel1);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cusID = Convert.ToInt64(row.Cells["ID"].Value.ToString());
                cusname_txt.Text = row.Cells["name1"].Value.ToString();
                phone_txt.Text = row.Cells["Phone"].Value.ToString();
                address_txt.Text = row.Cells["Address"].Value.ToString();
                
            }
        }
    }
}
