using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sample2 : Form
    {
        public Sample2()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(Mainclass.checkControl(panel1).Count == 0)
            {
                if(Retreival.isValidUser(u_name_txt.Text,p_txt.Text))
                {
                    Items IT = new Items();
                    Mainclass.showWindow(IT,this, MDI.ActiveForm);
                    
                }
                else
                {

                }
                
            }
            
        }

        private void u_name_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void p_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
