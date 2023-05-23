using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Tables : Form

    {
        public Tables()
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
            Retreival.loaditems("st_getfloors", FloorDD, "ID", "Floor");
            FloorDD.SelectedIndex = -1;
        }
        int edit;
        int TableID;
        private void button3_Click(object sender, EventArgs e)
        {
            if (Mainclass.checkControl(panel1).Count == 0)
            {
                if (edit == 0)
                {

                    insertion.insertTables(Convert.ToInt32(TableDD.SelectedItem.ToString()), Convert.ToInt16(ChairDD.SelectedItem.ToString()),Convert.ToInt16(FloorDD.SelectedValue.ToString()));
                    Mainclass.resetDisable(panel1);
                    Retreival.gettables(dataGridView1, floorID, floorname, tablenumber,ID, chairs);
                }
                else if (edit == 1)
                {


                    Updation.updateTables(TableID,Convert.ToInt32(TableDD.SelectedItem.ToString()), Convert.ToInt16(ChairDD.SelectedItem.ToString()), Convert.ToInt16(FloorDD.SelectedItem.ToString()));
                    Mainclass.resetDisable(panel1);
                    Retreival.gettables(dataGridView1, floorID, floorname, tablenumber, ID, chairs);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Retreival.gettables(dataGridView1, floorID, floorname, tablenumber, ID, chairs);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure,You want to delete this record ?", "Question.....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Deletion.delete("st_deleteTable", "@tID", TableID);
                Mainclass.resetDisable(panel1);
                Retreival.gettables(dataGridView1, floorID, floorname, tablenumber, ID, chairs);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.ControlEnable(panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.resetEnable(panel1);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = Retreival.USER;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                Mainclass.ControlDisable(panel1);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                TableID = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                TableDD.SelectedItem = row.Cells["tablenumber"].Value.ToString();
                ChairDD.SelectedItem = row.Cells["chairs"].Value.ToString();
                FloorDD.SelectedValue = row.Cells["floorID"].Value;


            }
        }
    }
}
