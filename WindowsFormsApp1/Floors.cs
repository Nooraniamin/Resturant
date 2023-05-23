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

namespace WindowsFormsApp1
{
    public partial class Floors : Form
    {
        public Floors()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int edit;
        private void button1_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.resetEnable(panel1);
        }
        Int16 fID;
        private void button3_Click(object sender, EventArgs e)
        {
            if (Mainclass.checkControl(panel1).Count == 0)
            {
                if (edit == 0)
                {

                    insertion.insertFloors(f_name_txt.Text,Convert.ToInt16(floorDD.SelectedItem.ToString()));
                    Mainclass.resetDisable(panel1);
                    Retreival.getfloors(dataGridView1, ID, name1, f_number);
                }
                else if (edit == 1)
                {


                    Updation.updatefloors(fID,f_name_txt.Text, Convert.ToInt16(floorDD.SelectedItem.ToString()));
                    Mainclass.resetDisable(panel1);
                    Retreival.getfloors(dataGridView1, ID, name1, f_number);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure,You want to delete this record ?", "Question.....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Deletion.delete("st_deletefloor", "@floorID", fID);
                Mainclass.resetDisable(panel1);
                Retreival.getfloors(dataGridView1, ID, name1, f_number);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Retreival.getfloors(dataGridView1, ID, name1, f_number);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Items IT = new Items();
            Mainclass.showWindow(IT, MDI.ActiveForm);
            this.Close();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                Mainclass.ControlDisable(panel1);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                fID = Convert.ToInt16(row.Cells["ID"].Value.ToString());
                f_name_txt.Text = row.Cells["name1"].Value.ToString();
                floorDD.SelectedItem = row.Cells["f_number"].Value.ToString();


            }
        }
    }
}
