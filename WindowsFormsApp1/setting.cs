using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.IO;
using System.Security.AccessControl;
namespace WindowsFormsApp1
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void p_txt_TextChanged(object sender, EventArgs e)
        {
            if (databasetxt.Text == "")
            {
                database_error.Visible = true;
            }
            else
            {
                database_error.Visible = false;
            }
        }

        private void servertxt_TextChanged(object sender, EventArgs e)
        {
            if (servertxt.Text == "")
            {
                server_error.Visible = true;
            }
            else
            {
                server_error.Visible = false;
            }
        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                if (usertxt.Text == "")
                {
                    user_error.Visible = true;
                }
                else
                {
                    user_error.Visible = false;
                }
            }
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                if (passwordtxt.Text == "")
                {
                    password_error.Visible = true;
                }
                else
                {
                    password_error.Visible = false;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                user_error.Visible = false;
                password_error.Visible = false;
                usertxt.Enabled = false;
                passwordtxt.Enabled = false;
            }
            else
            {
                usertxt.Enabled = true;
                passwordtxt.Enabled = true;
            }
        }
        public void updateConfigFile(string con)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in xmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    xElement.FirstChild.Attributes[2].Value = con;
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionString");
        }
        string connection;
        private void saveConnection()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\rms_connect";
            File.WriteAllText(path, connection);
        }
        private void Login_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (servertxt.Text == "")
                {
                    server_error.Visible = true;
                }
                else
                {
                    server_error.Visible = false;
                }
                if (databasetxt.Text == "")
                {
                    database_error.Visible = true;
                }
                else
                {
                    database_error.Visible = false;
                }
                if (server_error.Visible || database_error.Visible)
                {
                    Mainclass.showMessge("Fields with * are mandatory.", "Error");
                }
                else
                {
                    connection = "Data Source" + servertxt.Text + ";Initial Catalog=" + databasetxt.Text + ";Integrated Security=true;MultipleActiveResultSets= true;";
                    string con = "Data Source=192.168.100.11,1433;Initial Catalog=rms;ID=rms;Password=1234567";
                    saveConnection();
                    updateConfigFile(connection);
                    DialogResult dr = MessageBox.Show("Setting saved successfully");
                    ConfigurationManager.RefreshSection("connectionString");
                    if(dr == DialogResult.OK) 
                    {
                        Sample2 Is = new Sample2();
                        Mainclass.showWindow(Is, this, MDI.ActiveForm);

                    }

                }
            }
            else
            {
                if (servertxt.Text == "")
                {
                    server_error.Visible = true;
                }
                else
                {
                    server_error.Visible = false;
                }
                if (databasetxt.Text == "")
                {
                    database_error.Visible = true;
                }
                else
                {
                    database_error.Visible = false;
                }
                if (server_error.Visible || database_error.Visible)
                {
                    Mainclass.showMessge("Fields with * are mandatory.", "Error");
                }
                else
                {
                    connection = "Data Source" + servertxt.Text + "1433;Initial Catalog=" + databasetxt.Text +";User ID="+usertxt.Text+";Password="+passwordtxt.Text+";MultipleActiveResultSets= true;";
                    updateConfigFile(connection);
                    DialogResult dr = MessageBox.Show("Setting saved successfully");
                    ConfigurationManager.RefreshSection("connectionString");
                    if (dr == DialogResult.OK)
                    {
                        Sample2 Is = new Sample2();
                        Mainclass.showWindow(Is, this, MDI.ActiveForm);

                    }
                }

            }
        }
    }
}
