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

namespace WindowsFormsApp1
{
    public partial class FoodMenu : Form
    {
        public FoodMenu()
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
        }
        int edit;
        private void button1_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.resetEnable(panel1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.resetEnable(panel1);
        }
        int m_id;
        private void button3_Click(object sender, EventArgs e)
        {
            if (Mainclass.checkControl(panel1).Count == 0)
            {
                Int16 stus = statusDD.SelectedItem == "Available"?Convert.ToInt16(1):Convert.ToInt16(0);
                if (edit == 0)
                {

                    insertion.insertfoodmenu(name_txt.Text, Convert.ToInt16(CateDD.SelectedValue.ToString()),Convert.ToSingle(price_txt.Text),stus,pictureBox1.Image);
                    Mainclass.resetDisable(panel1);
                    Retreival.getfoodmenu(dataGridView1, ID, name1, catID, Catname, price, status, image);
                }
                else if (edit == 1)
                {


                    Updation.updatefoodmenu(name_txt.Text, Convert.ToInt16(CateDD.SelectedValue.ToString()), Convert.ToSingle(price_txt.Text), stus,m_id, pictureBox1.Image);
                    Mainclass.resetDisable(panel1);
                    Retreival.getfoodmenu(dataGridView1, ID, name1, catID, Catname, price, status, image);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Retreival.getfoodmenu(dataGridView1, ID, name1, catID, Catname, price, status, image);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure,You want to delete this record ?", "Question.....", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Deletion.delete("st_DeleteMenuItem", "@mid", m_id);
                Mainclass.resetDisable(panel1);
                Retreival.getfoodmenu(dataGridView1, ID, name1, catID, Catname, price, status, image);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                Mainclass.ControlDisable(panel1);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                m_id = Convert.ToInt16(row.Cells["ID"].Value.ToString());
                name_txt.Text = row.Cells["name1"].Value.ToString();
                CateDD.SelectedValue = row.Cells["catID"].Value;
                price_txt.Text = row.Cells["price"].Value.ToString();
                statusDD.SelectedItem = row.Cells["status"].Value.ToString();
               // pictureBox1.Image = Image.FromFile(row.Cells["image"].Value.ToString());
            }
        }

        private void loadbutton_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Image im = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = im;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
