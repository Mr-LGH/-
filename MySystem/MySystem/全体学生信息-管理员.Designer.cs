namespace MySystem
{
    partial class AllStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllStudentInfo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.Stu_No = new System.Windows.Forms.TextBox();
            this.lelSno = new System.Windows.Forms.Label();
            this.Stu_Class = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Stu_Spec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Stu_Dept = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.cboSpec = new System.Windows.Forms.ComboBox();
            this.txtBrithday = new System.Windows.Forms.DateTimePicker();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.dateEntry = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Apartment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnJump = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.Page = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEditor = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label19 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(30, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(363, 516);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "学号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(22, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(416, 568);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导航条";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Controls.Add(this.Stu_No);
            this.groupBox2.Controls.Add(this.lelSno);
            this.groupBox2.Controls.Add(this.Stu_Class);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Stu_Spec);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Stu_Dept);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(475, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(762, 132);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Pink;
            this.btnDisplay.Location = new System.Drawing.Point(586, 64);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(84, 28);
            this.btnDisplay.TabIndex = 15;
            this.btnDisplay.Text = "查询";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Stu_No
            // 
            this.Stu_No.Location = new System.Drawing.Point(377, 82);
            this.Stu_No.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Stu_No.Name = "Stu_No";
            this.Stu_No.Size = new System.Drawing.Size(136, 28);
            this.Stu_No.TabIndex = 9;
            // 
            // lelSno
            // 
            this.lelSno.AutoSize = true;
            this.lelSno.Location = new System.Drawing.Point(312, 89);
            this.lelSno.Name = "lelSno";
            this.lelSno.Size = new System.Drawing.Size(66, 19);
            this.lelSno.TabIndex = 8;
            this.lelSno.Text = "学号：";
            // 
            // Stu_Class
            // 
            this.Stu_Class.FormattingEnabled = true;
            this.Stu_Class.Location = new System.Drawing.Point(106, 82);
            this.Stu_Class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Stu_Class.Name = "Stu_Class";
            this.Stu_Class.Size = new System.Drawing.Size(136, 26);
            this.Stu_Class.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "所在班：";
            // 
            // Stu_Spec
            // 
            this.Stu_Spec.FormattingEnabled = true;
            this.Stu_Spec.Location = new System.Drawing.Point(377, 25);
            this.Stu_Spec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Stu_Spec.Name = "Stu_Spec";
            this.Stu_Spec.Size = new System.Drawing.Size(136, 26);
            this.Stu_Spec.TabIndex = 3;
            this.Stu_Spec.SelectedIndexChanged += new System.EventHandler(this.Stu_Spec_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "所在专业：";
            // 
            // Stu_Dept
            // 
            this.Stu_Dept.FormattingEnabled = true;
            this.Stu_Dept.Location = new System.Drawing.Point(106, 26);
            this.Stu_Dept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Stu_Dept.Name = "Stu_Dept";
            this.Stu_Dept.Size = new System.Drawing.Size(136, 26);
            this.Stu_Dept.TabIndex = 1;
            this.Stu_Dept.SelectedIndexChanged += new System.EventHandler(this.Stu_Dept_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "所在院：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.txtSname);
            this.groupBox4.Controls.Add(this.txtSno);
            this.groupBox4.Controls.Add(this.cboClass);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.cboSpec);
            this.groupBox4.Controls.Add(this.txtBrithday);
            this.groupBox4.Controls.Add(this.cboDept);
            this.groupBox4.Controls.Add(this.dateEntry);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.Phone);
            this.groupBox4.Controls.Add(this.Apartment);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(475, 153);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(762, 508);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " 学籍信息";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox6);
            this.groupBox6.Controls.Add(this.checkBox3);
            this.groupBox6.Controls.Add(this.checkBox5);
            this.groupBox6.Controls.Add(this.checkBox2);
            this.groupBox6.Controls.Add(this.checkBox4);
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Location = new System.Drawing.Point(445, 398);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(245, 105);
            this.groupBox6.TabIndex = 57;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " ";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(156, 68);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(69, 23);
            this.checkBox6.TabIndex = 32;
            this.checkBox6.Text = "其他";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(156, 23);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(69, 23);
            this.checkBox3.TabIndex = 32;
            this.checkBox3.Text = "音乐";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(84, 68);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(69, 23);
            this.checkBox5.TabIndex = 31;
            this.checkBox5.Text = "旅游";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(84, 23);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 23);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "体育";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 68);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(69, 23);
            this.checkBox4.TabIndex = 30;
            this.checkBox4.Text = "上网";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 23);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 23);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "阅读";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(114, 105);
            this.txtSname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(157, 28);
            this.txtSname.TabIndex = 56;
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(115, 43);
            this.txtSno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(156, 28);
            this.txtSno.TabIndex = 55;
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "16软件工程二班",
            "17软件工程二班",
            "18软件工程二班"});
            this.cboClass.Location = new System.Drawing.Point(445, 351);
            this.cboClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(164, 26);
            this.cboClass.TabIndex = 51;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoFemale);
            this.groupBox5.Controls.Add(this.rdoMale);
            this.groupBox5.Location = new System.Drawing.Point(115, 157);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(194, 54);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " ";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(109, 17);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(49, 23);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(11, 17);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(49, 23);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // cboSpec
            // 
            this.cboSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpec.FormattingEnabled = true;
            this.cboSpec.Location = new System.Drawing.Point(445, 278);
            this.cboSpec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSpec.Name = "cboSpec";
            this.cboSpec.Size = new System.Drawing.Size(164, 26);
            this.cboSpec.TabIndex = 47;
            this.cboSpec.SelectedIndexChanged += new System.EventHandler(this.cboSpec_SelectedIndexChanged);
            // 
            // txtBrithday
            // 
            this.txtBrithday.Location = new System.Drawing.Point(115, 449);
            this.txtBrithday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrithday.Name = "txtBrithday";
            this.txtBrithday.Size = new System.Drawing.Size(173, 28);
            this.txtBrithday.TabIndex = 46;
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(445, 211);
            this.cboDept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(164, 26);
            this.cboDept.TabIndex = 45;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // dateEntry
            // 
            this.dateEntry.Location = new System.Drawing.Point(114, 379);
            this.dateEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateEntry.Name = "dateEntry";
            this.dateEntry.Size = new System.Drawing.Size(174, 28);
            this.dateEntry.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 150);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(115, 306);
            this.Phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(164, 28);
            this.Phone.TabIndex = 42;
            // 
            // Apartment
            // 
            this.Apartment.Location = new System.Drawing.Point(114, 239);
            this.Apartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Apartment.Name = "Apartment";
            this.Apartment.Size = new System.Drawing.Size(164, 28);
            this.Apartment.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(373, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 19);
            this.label11.TabIndex = 40;
            this.label11.Text = "爱好：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 19);
            this.label10.TabIndex = 39;
            this.label10.Text = "院系：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "专业：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "入学日期：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 19);
            this.label12.TabIndex = 36;
            this.label12.Text = "电话：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 19);
            this.label13.TabIndex = 35;
            this.label13.Text = "住宿地址：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 19);
            this.label14.TabIndex = 34;
            this.label14.Text = "性别：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 456);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 19);
            this.label15.TabIndex = 33;
            this.label15.Text = "出生日期：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(373, 354);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 19);
            this.label16.TabIndex = 32;
            this.label16.Text = "班级：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(43, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 19);
            this.label17.TabIndex = 31;
            this.label17.Text = "姓名：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 19);
            this.label18.TabIndex = 30;
            this.label18.Text = "学号：";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.btnJump);
            this.groupBox7.Controls.Add(this.btnFirst);
            this.groupBox7.Controls.Add(this.Page);
            this.groupBox7.Controls.Add(this.btnUp);
            this.groupBox7.Controls.Add(this.btnNext);
            this.groupBox7.Controls.Add(this.btnLast);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Location = new System.Drawing.Point(22, 589);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(435, 72);
            this.groupBox7.TabIndex = 29;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "浏览";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(253, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 19);
            this.label20.TabIndex = 7;
            this.label20.Text = "页";
            // 
            // btnJump
            // 
            this.btnJump.BackColor = System.Drawing.Color.Pink;
            this.btnJump.Location = new System.Drawing.Point(296, 29);
            this.btnJump.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(84, 28);
            this.btnJump.TabIndex = 5;
            this.btnJump.Text = "跳转";
            this.btnJump.UseVisualStyleBackColor = false;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Pink;
            this.btnFirst.Location = new System.Drawing.Point(17, 29);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(30, 28);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "《";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // Page
            // 
            this.Page.Location = new System.Drawing.Point(215, 30);
            this.Page.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(30, 28);
            this.Page.TabIndex = 6;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Pink;
            this.btnUp.Location = new System.Drawing.Point(55, 29);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(30, 28);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "<";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Pink;
            this.btnNext.Location = new System.Drawing.Point(92, 29);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 28);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Pink;
            this.btnLast.Location = new System.Drawing.Point(129, 29);
            this.btnLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(30, 28);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "》";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(184, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 19);
            this.label21.TabIndex = 4;
            this.label21.Text = "第";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnEditor);
            this.groupBox3.Location = new System.Drawing.Point(1243, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(155, 632);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "管理";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Pink;
            this.btnDelete.Location = new System.Drawing.Point(27, 440);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Pink;
            this.btnAdd.Location = new System.Drawing.Point(27, 307);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Pink;
            this.btnUpdate.Location = new System.Drawing.Point(27, 197);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 28);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEditor
            // 
            this.btnEditor.BackColor = System.Drawing.Color.Pink;
            this.btnEditor.Location = new System.Drawing.Point(27, 64);
            this.btnEditor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(84, 28);
            this.btnEditor.TabIndex = 0;
            this.btnEditor.Text = "编辑";
            this.btnEditor.UseVisualStyleBackColor = false;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label19});
            this.statusStrip1.Location = new System.Drawing.Point(0, 667);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1458, 30);
            this.statusStrip1.TabIndex = 59;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(428, 25);
            this.label19.Text = "总共0条记录，当前第1页，共1页，每页10条记录";
            // 
            // AllStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1458, 697);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AllStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "全体学生信息_管理员";
            this.Load += new System.EventHandler(this.AllStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Stu_No;
        private System.Windows.Forms.Label lelSno;
        private System.Windows.Forms.ComboBox Stu_Class;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Stu_Spec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Stu_Dept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.ComboBox cboSpec;
        private System.Windows.Forms.DateTimePicker txtBrithday;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.DateTimePicker dateEntry;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Apartment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Page;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label19;

    }
}