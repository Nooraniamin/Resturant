using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using System.Drawing;
using System.Threading;
using System.Collections;

namespace WindowsFormsApp1
{
    internal class Mainclass
    {
        public static void sno(DataGridView gv,string snoGV)
        {
            int count = 0; 
            foreach (DataGridViewRow row in gv.Rows) 
            {
                count++;
                row.Cells[snoGV].Value = count;
            }
        }
        private static string path;
        private static string connection()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ "\\rms_connect";
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            else
            {
                return "";
            }
        }
        public static SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=rms;Integrated Security=True");
        public static void showWindow(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }
        public static void showWindow(Form openWin, Form MDI)
        {
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = MDI;
            openWin.Show();
        }
        public static void showMessge(string msg, string type)
        {
            if (type == "Success")
            {
                MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (type == "Error")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void resetEnable(Panel P)
        {
            foreach(Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = true;
                    tb.BackColor= Color.White;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = true;
                    cb.BackColor = Color.White;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = true;
                    rb.BackColor = Color.White;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = true;
                    cb.BackColor = Color.White;
                }
            }
        }
        
        public static void resetDisable(Panel P)
        {
            foreach (Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = "";
                    tb.Enabled = false;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Checked = false;
                    rb.Enabled = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Checked = false;
                    cb.Enabled = false;
                }
            }
        }
        public static void ControlEnable(Panel P)
        {
            foreach (Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = true;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                }
            }
        }
        public static void ControlDisable(Panel P)
        {
            foreach (Control c in P.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Enabled = false;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                }
            }
        }
        public static ArrayList checkControl(Panel P)
        {
            ArrayList arr = new ArrayList();

            foreach (Control c in P.Controls)
            {
                if(c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    if(tb.Text == "")
                    {
                        arr.Add(tb);
                    }
                    else
                    {
                        if(arr.Contains(tb))
                        {
                            arr.Remove(tb);
                        }
                    }
                    if(tb.Text == "")
                    {
                        tb.BackColor = Color.Firebrick;
                    }
                    else
                    {
                        tb.BackColor = Color.White;
                    }
                }
                if(c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    if (cb.SelectedIndex == -1)
                    {
                        arr.Add(cb);
                    }
                    else
                    {
                        if (arr.Contains(cb))
                        {
                            arr.Remove(cb);
                        }
                    }
                    if (cb.SelectedIndex == -1)
                    {
                        cb.BackColor = Color.Firebrick;
                    }
                    else
                    {
                        cb.BackColor = Color.White;
                    }
                }
                if(c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (!rb.Checked)
                    {
                        arr.Add(rb);
                    }
                    else
                    {
                        if(arr.Contains(rb))
                        {
                            arr.Remove(rb);
                        }
                    }
                    if (!rb.Checked)
                    {
                        rb.BackColor = Color.Firebrick;
                    }
                    else
                    {
                        rb.BackColor = Color.White;
                    }
                }
                if(c is  CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (!cb.Checked)
                    {
                        arr.Add(cb);
                    }
                    else
                    {
                        if (arr.Contains(cb))
                        {
                            arr.Remove(cb);
                        }
                    }
                }
            }
            return arr;
        }
    }
    class Designbutton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath .AddEllipse(0,0,ClientSize.Width,ClientSize.Height);
            this.Region = new System.Drawing.Region(graphicsPath);
            base.OnPaint(pevent);
        }
    }
        
}
