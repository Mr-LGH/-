namespace MySystem
{
    partial class ClassMagFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Page = new System.Windows.Forms.TextBox();
            this.btnJump = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SearchSpec = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SearchDept = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCteacher = new System.Windows.Forms.ComboBox();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.cboSpec = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEditor = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(33, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 444);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导航条";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(23, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(327, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "班级编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "班级名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Page);
            this.groupBox3.Controls.Add(this.btnJump);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnLast);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Controls.Add(this.btnUp);
            this.groupBox3.Controls.Add(this.btnFirst);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(33, 506);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 139);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "浏览";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "页";
            // 
            // Page
            // 
            this.Page.Location = new System.Drawing.Point(70, 92);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(37, 30);
            this.Page.TabIndex = 6;
            // 
            // btnJump
            // 
            this.btnJump.BackColor = System.Drawing.Color.Pink;
            this.btnJump.Location = new System.Drawing.Point(214, 86);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(87, 38);
            this.btnJump.TabIndex = 5;
            this.btnJump.Text = "跳转";
            this.btnJump.UseVisualStyleBackColor = false;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "第";
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Pink;
            this.btnLast.Location = new System.Drawing.Point(158, 34);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(39, 36);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = "》";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Pink;
            this.btnNext.Location = new System.Drawing.Point(113, 34);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(39, 36);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Pink;
            this.btnUp.Location = new System.Drawing.Point(68, 34);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(39, 36);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "<";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Pink;
            this.btnFirst.Location = new System.Drawing.Point(23, 34);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(39, 36);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "《";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchNo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Controls.Add(this.SearchSpec);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.SearchDept);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(426, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 164);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询";
            // 
            // SearchNo
            // 
            this.SearchNo.Location = new System.Drawing.Point(136, 107);
            this.SearchNo.Name = "SearchNo";
            this.SearchNo.Size = new System.Drawing.Size(98, 30);
            this.SearchNo.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "班级编号：";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Pink;
            this.btnDisplay.Location = new System.Drawing.Point(392, 92);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(87, 38);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "查询";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // SearchSpec
            // 
            this.SearchSpec.FormattingEnabled = true;
            this.SearchSpec.Location = new System.Drawing.Point(383, 41);
            this.SearchSpec.Name = "SearchSpec";
            this.SearchSpec.Size = new System.Drawing.Size(121, 28);
            this.SearchSpec.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(268, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "所在专业：";
            // 
            // SearchDept
            // 
            this.SearchDept.FormattingEnabled = true;
            this.SearchDept.Location = new System.Drawing.Point(136, 41);
            this.SearchDept.Name = "SearchDept";
            this.SearchDept.Size = new System.Drawing.Size(98, 28);
            this.SearchDept.TabIndex = 1;
            this.SearchDept.SelectedIndexChanged += new System.EventHandler(this.SearchDept_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(41, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "所在院：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCteacher);
            this.groupBox4.Controls.Add(this.cboDept);
            this.groupBox4.Controls.Add(this.cboSpec);
            this.groupBox4.Controls.Add(this.txtNum);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtCname);
            this.groupBox4.Controls.Add(this.txtCno);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(426, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(609, 255);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "班级信息";
            // 
            // txtCteacher
            // 
            this.txtCteacher.FormattingEnabled = true;
            this.txtCteacher.Location = new System.Drawing.Point(146, 189);
            this.txtCteacher.Name = "txtCteacher";
            this.txtCteacher.Size = new System.Drawing.Size(136, 28);
            this.txtCteacher.TabIndex = 24;
            // 
            // cboDept
            // 
            this.cboDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Location = new System.Drawing.Point(410, 63);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(163, 28);
            this.cboDept.TabIndex = 23;
            this.cboDept.SelectedIndexChanged += new System.EventHandler(this.cboDept_SelectedIndexChanged);
            // 
            // cboSpec
            // 
            this.cboSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpec.FormattingEnabled = true;
            this.cboSpec.Location = new System.Drawing.Point(410, 120);
            this.cboSpec.Name = "cboSpec";
            this.cboSpec.Size = new System.Drawing.Size(163, 28);
            this.cboSpec.TabIndex = 22;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(410, 189);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(163, 30);
            this.txtNum.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "所属院系：";
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(146, 120);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(136, 30);
            this.txtCname.TabIndex = 18;
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(146, 63);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(136, 30);
            this.txtCno.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "所属专业：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "班级人数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "带班教师编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "班级名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "班级编号：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Controls.Add(this.btnAdd);
            this.groupBox5.Controls.Add(this.btnUpdate);
            this.groupBox5.Controls.Add(this.btnEditor);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(426, 506);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(609, 139);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "管理";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Pink;
            this.btnDelete.Location = new System.Drawing.Point(410, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Pink;
            this.btnAdd.Location = new System.Drawing.Point(272, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Pink;
            this.btnUpdate.Location = new System.Drawing.Point(146, 53);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 38);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEditor
            // 
            this.btnEditor.BackColor = System.Drawing.Color.Pink;
            this.btnEditor.Location = new System.Drawing.Point(24, 53);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(87, 38);
            this.btnEditor.TabIndex = 0;
            this.btnEditor.Text = "编辑";
            this.btnEditor.UseVisualStyleBackColor = false;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label7});
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1075, 30);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(428, 25);
            this.label7.Text = "总共0条记录，当前第1页，共1页，每页10条记录";
            // 
            // ClassMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1075, 713);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClassMagFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班级管理_管理员";
            this.Load += new System.EventHandler(this.ClassMagFrm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Page;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SearchNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ComboBox SearchSpec;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox SearchDept;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.ComboBox cboSpec;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label7;
        private System.Windows.Forms.ComboBox txtCteacher;
    }
}