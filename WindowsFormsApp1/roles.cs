using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class roles : Form
    {
        public roles()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Items IT = new Items();
            Mainclass.showWindow(IT, MDI.ActiveForm);
            this.Close();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int edit  ;
        int delstatus;
        private void button1_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.resetEnable(panel1);
            delstatus = 0 ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.ControlEnable(panel1);
        }
         Int16 roleId;
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                error_lbl.Visible = true;
            }
            else
            {
                error_lbl.Visible = false;
            }
            if (error_lbl.Visible)
            {
                Mainclass.showMessge("Field with  * mandatory", "Error");
            }
            else
            {
                if (edit == 0)
                {
                    insertion.insertRole(textBox2.Text);
                    Mainclass.resetDisable(panel1);
                    Retreival.getRoles(dataGridView1, ID,role);
                }
                else if (edit == 1)
                {
                    Updation.updateRole(textBox2.Text, roleId);
                    Mainclass.resetDisable(panel1);
                    Retreival.getRoles(dataGridView1, ID, role);
                }
            }
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
                DialogResult dr = MessageBox.Show("Are you sure,You want to delete this record ?", "Question.....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.delete("st_deleteRole", "@rid", roleId);
                    Mainclass.resetDisable(panel1);
                    Retreival.getRoles(dataGridView1,ID,role);
                }
                
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Retreival.getRoles(dataGridView1, ID, role);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delstatus = 1;
                Mainclass.ControlDisable(panel1);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleId = Convert.ToInt16(row.Cells["ID"].Value.ToString());
                textBox2.Text = row.Cells["role"].Value.ToString();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = Retreival.USER;
        }
    }
}
