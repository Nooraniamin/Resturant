using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ "\\rms_connect"))
            {
                setting obj = new setting();
                Mainclass.showWindow(obj, this);
            }
            else
            {
                Sample2 Is = new Sample2();
                Mainclass.showWindow(Is, this);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting sa = new setting();
            Mainclass.showWindow(sa, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sample2 Is = new Sample2();
            Mainclass.showWindow(Is, this);
        }
    }
}