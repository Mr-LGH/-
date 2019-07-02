namespace MySystem
{
    partial class T_InfoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T_InfoFrm));
            this.T_Year = new System.Windows.Forms.NumericUpDown();
            this.T_zhicheng = new System.Windows.Forms.ComboBox();
            this.T_class = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.T_dept = new System.Windows.Forms.ComboBox();
            this.T_Brithday = new System.Windows.Forms.DateTimePicker();
            this.T_xuewei = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.T_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.T_no = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.T_Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // T_Year
            // 
            this.T_Year.Location = new System.Drawing.Point(498, 289);
            this.T_Year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.T_Year.Name = "T_Year";
            this.T_Year.Size = new System.Drawing.Size(153, 28);
            this.T_Year.TabIndex = 61;
            // 
            // T_zhicheng
            // 
            this.T_zhicheng.FormattingEnabled = true;
            this.T_zhicheng.Items.AddRange(new object[] {
            "助教",
            "讲师",
            "副教授",
            "教授"});
            this.T_zhicheng.Location = new System.Drawing.Point(148, 365);
            this.T_zhicheng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.T_zhicheng.Name = "T_zhicheng";
            this.T_zhicheng.Size = new System.Drawing.Size(136, 26);
            this.T_zhicheng.TabIndex = 60;
            // 
            // T_class
            // 
            this.T_class.AutoSize = true;
            this.T_class.Location = new System.Drawing.Point(495, 452);
            this.T_class.Name = "T_class";
            this.T_class.Size = new System.Drawing.Size(19, 19);
            this.T_class.TabIndex = 59;
            this.T_class.Text = " ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // T_dept
            // 
            this.T_dept.FormattingEnabled = true;
            this.T_dept.Location = new System.Drawing.Point(498, 365);
            this.T_dept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.T_dept.Name = "T_dept";
            this.T_dept.Size = new System.Drawing.Size(152, 26);
            this.T_dept.TabIndex = 57;
            // 
            // T_Brithday
            // 
            this.T_Brithday.Location = new System.Drawing.Point(148, 532);
            this.T_Brithday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.T_Brithday.MaxDate = new System.DateTime(2018, 11, 10, 0, 0, 0, 0);
            this.T_Brithday.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.T_Brithday.Name = "T_Brithday";
            this.T_Brithday.Size = new System.Drawing.Size(176, 28);
            this.T_Brithday.TabIndex = 56;
            this.T_Brithday.Value = new System.DateTime(2018, 11, 10, 0, 0, 0, 0);
            // 
            // T_xuewei
            // 
            this.T_xuewei.FormattingEnabled = true;
            this.T_xuewei.Items.AddRange(new object[] {
            "硕士",
            "博士"});
            this.T_xuewei.Location = new System.Drawing.Point(148, 449);
            this.T_xuewei.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.T_xuewei.Name = "T_xuewei";
            this.T_xuewei.Size = new System.Drawing.Size(136, 26);
            this.T_xuewei.TabIndex = 55;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoFemale);
            this.groupBox5.Controls.Add(this.rdoMale);
            this.groupBox5.Location = new System.Drawing.Point(155, 233);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(160, 64);
            this.groupBox5.TabIndex = 54;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " ";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(94, 29);
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
            this.rdoMale.Location = new System.Drawing.Point(7, 29);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(49, 23);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // T_name
            // 
            this.T_name.Location = new System.Drawing.Point(148, 161);
            this.T_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.T_name.Name = "T_name";
            this.T_name.Size = new System.Drawing.Size(159, 28);
            this.T_name.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 19);
            this.label10.TabIndex = 52;
            this.label10.Text = "所带班级：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 51;
            this.label8.Text = "所属院系：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 50;
            this.label7.Text = "工作年月：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "出生日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "学  位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "职  称：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "性  别：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 45;
            this.label11.Text = "教师号：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 19);
            this.label12.TabIndex = 44;
            this.label12.Text = "姓  名：";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Pink;
            this.btnUpdate.Location = new System.Drawing.Point(360, 650);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 35);
            this.btnUpdate.TabIndex = 64;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Location = new System.Drawing.Point(155, 650);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 63;
            this.button1.Text = "更新";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // T_no
            // 
            this.T_no.AutoSize = true;
            this.T_no.Location = new System.Drawing.Point(152, 68);
            this.T_no.Name = "T_no";
            this.T_no.Size = new System.Drawing.Size(19, 19);
            this.T_no.TabIndex = 65;
            this.T_no.Text = " ";
            // 
            // T_InfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(701, 744);
            this.Controls.Add(this.T_no);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.T_Year);
            this.Controls.Add(this.T_zhicheng);
            this.Controls.Add(this.T_class);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.T_dept);
            this.Controls.Add(this.T_Brithday);
            this.Controls.Add(this.T_xuewei);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.T_name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "T_InfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人信息_教师";
            this.Load += new System.EventHandler(this.T_InfoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.T_Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown T_Year;
        private System.Windows.Forms.ComboBox T_zhicheng;
        private System.Windows.Forms.Label T_class;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox T_dept;
        private System.Windows.Forms.DateTimePicker T_Brithday;
        private System.Windows.Forms.ComboBox T_xuewei;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox T_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label T_no;
    }
}