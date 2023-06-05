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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Floors a = new Floors();
            Mainclass.showWindow(a, MDI.ActiveForm);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roles IT = new roles();
            Mainclass.showWindow(IT, MDI.ActiveForm);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User IT = new User();
            Mainclass.showWindow(IT, MDI.ActiveForm);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer IT = new Customer();
            Mainclass.showWindow(IT, MDI.ActiveForm);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FoodCate IT = new FoodCate();
            Mainclass.showWindow(IT, MDI.ActiveForm);
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FoodMenu IT = new FoodMenu();
            Mainclass.showWindow(IT,MDI.ActiveForm);
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Order IT = new Order();
            Mainclass.showWindow(IT, MDI.ActiveForm);
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tables IT = new Tables();
            Mainclass.showWindow (IT, MDI.ActiveForm);
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = Retreival.USER;
        }
    }
}
