using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FoodCate : Form
    {
        public FoodCate()
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
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int edit;

        private void button2_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.ControlEnable(panel1);
        }
        Int16 foodcatID;
        private void button3_Click(object sender, EventArgs e)
        {
            if (edit == 0)
            {
                insertion.insertfoodcate(textBox2.Text);
                Mainclass.resetDisable(panel1);
                Retreival.getfood(dataGridView1, ID, role);
            }
            else if (edit == 1)
            {
                Updation.updatefoodcate(textBox2.Text, foodcatID);
                Mainclass.resetDisable(panel1);
                Retreival.getfood(dataGridView1, ID, role);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure,You want to delete this record ?", "Question.....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Deletion.delete("st_deletefoodcate", "@rid", foodcatID);
                Mainclass.resetDisable(panel1);
                Retreival.getfood(dataGridView1, ID, role);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Retreival.getfood(dataGridView1, ID, role);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                
                Mainclass.ControlDisable(panel1);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                foodcatID = Convert.ToInt16(row.Cells["ID"].Value.ToString());
                textBox2.Text = row.Cells["role"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.resetEnable(panel1);
            
        }
    }
}
