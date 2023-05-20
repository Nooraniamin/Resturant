namespace WindowsFormsApp1
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passworderror_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.unameerror_lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.RoleDD = new System.Windows.Forms.ComboBox();
            this.roleerror_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addresserror_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.phoneerror_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.nameerror_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(314, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 544);
            this.panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1068, 405);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNO,
            this.ID,
            this.name1,
            this.Username,
            this.Password,
            this.Phone,
            this.Address,
            this.RoleID,
            this.Role});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SNO
            // 
            this.SNO.HeaderText = "";
            this.SNO.MinimumWidth = 6;
            this.SNO.Name = "SNO";
            this.SNO.ReadOnly = true;
            this.SNO.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // name1
            // 
            this.name1.HeaderText = "Name";
            this.name1.MinimumWidth = 6;
            this.name1.Name = "name1";
            this.name1.ReadOnly = true;
            this.name1.Width = 125;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 125;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // RoleID
            // 
            this.RoleID.HeaderText = "RoleID";
            this.RoleID.MinimumWidth = 6;
            this.RoleID.Name = "RoleID";
            this.RoleID.Visible = false;
            this.RoleID.Width = 125;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 125;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1068, 66);
            this.panel5.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(-311, -61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 38);
            this.button7.TabIndex = 2;
            this.button7.Text = "<<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-152, -55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Welcome";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button6.Location = new System.Drawing.Point(647, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 66);
            this.button6.TabIndex = 6;
            this.button6.Text = "&VIEW";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(808, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 77);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sea&rch";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.Location = new System.Drawing.Point(495, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 66);
            this.button4.TabIndex = 4;
            this.button4.Text = "&DELETE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Location = new System.Drawing.Point(336, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 66);
            this.button3.TabIndex = 4;
            this.button3.Text = "&SAVE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Location = new System.Drawing.Point(169, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "&EDIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "&ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1068, 73);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.passworderror_lbl);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.password_txt);
            this.panel1.Controls.Add(this.unameerror_lbl);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.uname);
            this.panel1.Controls.Add(this.RoleDD);
            this.panel1.Controls.Add(this.roleerror_lbl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.addresserror_lbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.address_txt);
            this.panel1.Controls.Add(this.phoneerror_lbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.phone_txt);
            this.panel1.Controls.Add(this.nameerror_lbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.name_txt);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 544);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // passworderror_lbl
            // 
            this.passworderror_lbl.AutoSize = true;
            this.passworderror_lbl.ForeColor = System.Drawing.Color.White;
            this.passworderror_lbl.Location = new System.Drawing.Point(273, 424);
            this.passworderror_lbl.Name = "passworderror_lbl";
            this.passworderror_lbl.Size = new System.Drawing.Size(12, 16);
            this.passworderror_lbl.TabIndex = 19;
            this.passworderror_lbl.Text = "*";
            this.passworderror_lbl.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 415);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Password";
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(15, 444);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(270, 22);
            this.password_txt.TabIndex = 17;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            // 
            // unameerror_lbl
            // 
            this.unameerror_lbl.AutoSize = true;
            this.unameerror_lbl.ForeColor = System.Drawing.Color.White;
            this.unameerror_lbl.Location = new System.Drawing.Point(270, 352);
            this.unameerror_lbl.Name = "unameerror_lbl";
            this.unameerror_lbl.Size = new System.Drawing.Size(12, 16);
            this.unameerror_lbl.TabIndex = 16;
            this.unameerror_lbl.Text = "*";
            this.unameerror_lbl.Visible = false;
            this.unameerror_lbl.Click += new System.EventHandler(this.unameerror_lbl_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Username";
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(15, 380);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(270, 22);
            this.uname.TabIndex = 14;
            this.uname.TextChanged += new System.EventHandler(this.uname_TextChanged);
            // 
            // RoleDD
            // 
            this.RoleDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoleDD.FormattingEnabled = true;
            this.RoleDD.Location = new System.Drawing.Point(12, 325);
            this.RoleDD.Name = "RoleDD";
            this.RoleDD.Size = new System.Drawing.Size(273, 24);
            this.RoleDD.TabIndex = 13;
            this.RoleDD.SelectedIndexChanged += new System.EventHandler(this.RoleDD_SelectedIndexChanged);
            // 
            // roleerror_lbl
            // 
            this.roleerror_lbl.AutoSize = true;
            this.roleerror_lbl.ForeColor = System.Drawing.Color.White;
            this.roleerror_lbl.Location = new System.Drawing.Point(273, 306);
            this.roleerror_lbl.Name = "roleerror_lbl";
            this.roleerror_lbl.Size = new System.Drawing.Size(12, 16);
            this.roleerror_lbl.TabIndex = 12;
            this.roleerror_lbl.Text = "*";
            this.roleerror_lbl.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Role";
            // 
            // addresserror_lbl
            // 
            this.addresserror_lbl.AutoSize = true;
            this.addresserror_lbl.ForeColor = System.Drawing.Color.White;
            this.addresserror_lbl.Location = new System.Drawing.Point(273, 254);
            this.addresserror_lbl.Name = "addresserror_lbl";
            this.addresserror_lbl.Size = new System.Drawing.Size(12, 16);
            this.addresserror_lbl.TabIndex = 10;
            this.addresserror_lbl.Text = "*";
            this.addresserror_lbl.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address";
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(12, 273);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(270, 22);
            this.address_txt.TabIndex = 8;
            this.address_txt.TextChanged += new System.EventHandler(this.address_txt_TextChanged);
            // 
            // phoneerror_lbl
            // 
            this.phoneerror_lbl.AutoSize = true;
            this.phoneerror_lbl.ForeColor = System.Drawing.Color.White;
            this.phoneerror_lbl.Location = new System.Drawing.Point(273, 201);
            this.phoneerror_lbl.Name = "phoneerror_lbl";
            this.phoneerror_lbl.Size = new System.Drawing.Size(12, 16);
            this.phoneerror_lbl.TabIndex = 7;
            this.phoneerror_lbl.Text = "*";
            this.phoneerror_lbl.Visible = false;
            this.phoneerror_lbl.Click += new System.EventHandler(this.phoneerror_lbl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone";
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(12, 220);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(270, 22);
            this.phone_txt.TabIndex = 5;
            this.phone_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // nameerror_lbl
            // 
            this.nameerror_lbl.AutoSize = true;
            this.nameerror_lbl.ForeColor = System.Drawing.Color.White;
            this.nameerror_lbl.Location = new System.Drawing.Point(276, 139);
            this.nameerror_lbl.Name = "nameerror_lbl";
            this.nameerror_lbl.Size = new System.Drawing.Size(12, 16);
            this.nameerror_lbl.TabIndex = 4;
            this.nameerror_lbl.Text = "*";
            this.nameerror_lbl.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(12, 168);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(270, 22);
            this.name_txt.TabIndex = 2;
            this.name_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 73);
            this.panel3.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 38);
            this.button5.TabIndex = 2;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameerror_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addresserror_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.Label phoneerror_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label passworderror_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label unameerror_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.ComboBox RoleDD;
        private System.Windows.Forms.Label roleerror_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
    }
}