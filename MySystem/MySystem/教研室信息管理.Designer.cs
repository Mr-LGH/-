namespace MySystem
{
    partial class Research_Msg_Mag
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEditor = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.txtMag = new System.Windows.Forms.TextBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Page = new System.Windows.Forms.TextBox();
            this.btnJump = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(42, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(416, 394);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导航条";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(42, 53);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(336, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Controls.Add(this.btnAdd);
            this.groupBox5.Controls.Add(this.btnUpdate);
            this.groupBox5.Controls.Add(this.btnEditor);
            this.groupBox5.Location = new System.Drawing.Point(520, 467);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(646, 104);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "管理";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Pink;
            this.btnDelete.Location = new System.Drawing.Point(442, 41);
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
            this.btnAdd.Location = new System.Drawing.Point(297, 41);
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
            this.btnUpdate.Location = new System.Drawing.Point(165, 41);
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
            this.btnEditor.Location = new System.Drawing.Point(28, 41);
            this.btnEditor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(84, 28);
            this.btnEditor.TabIndex = 0;
            this.btnEditor.Text = "编辑";
            this.btnEditor.UseVisualStyleBackColor = false;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.txtMag);
            this.groupBox4.Controls.Add(this.txtCname);
            this.groupBox4.Controls.Add(this.txtCno);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(520, 160);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(646, 299);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "教研室信息";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtInfo);
            this.groupBox6.Location = new System.Drawing.Point(344, 29);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(276, 250);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "研究方向";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(18, 30);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(240, 208);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "";
            // 
            // txtMag
            // 
            this.txtMag.Location = new System.Drawing.Point(164, 218);
            this.txtMag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMag.Name = "txtMag";
            this.txtMag.Size = new System.Drawing.Size(112, 28);
            this.txtMag.TabIndex = 19;
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(164, 144);
            this.txtCname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(112, 28);
            this.txtCname.TabIndex = 18;
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(164, 76);
            this.txtCno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(112, 28);
            this.txtCno.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "教研室主任：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "编号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchNo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Location = new System.Drawing.Point(520, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(646, 84);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询";
            // 
            // SearchNo
            // 
            this.SearchNo.Location = new System.Drawing.Point(168, 30);
            this.SearchNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchNo.Name = "SearchNo";
            this.SearchNo.Size = new System.Drawing.Size(110, 28);
            this.SearchNo.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "教研室编号：";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Pink;
            this.btnDisplay.Location = new System.Drawing.Point(406, 29);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(84, 28);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "查询";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label7});
            this.statusStrip1.Location = new System.Drawing.Point(0, 599);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1237, 30);
            this.statusStrip1.TabIndex = 38;
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
            this.groupBox3.Location = new System.Drawing.Point(42, 457);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 114);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "浏览";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "页";
            // 
            // Page
            // 
            this.Page.Location = new System.Drawing.Point(271, 39);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(37, 30);
            this.Page.TabIndex = 6;
            // 
            // btnJump
            // 
            this.btnJump.BackColor = System.Drawing.Color.Pink;
            this.btnJump.Location = new System.Drawing.Point(349, 33);
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
            this.label9.Location = new System.Drawing.Point(236, 42);
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
            // Research_Msg_Mag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1237, 629);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Research_Msg_Mag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教研室信息管理";
            this.Load += new System.EventHandler(this.教研室信息管理_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.TextBox txtMag;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SearchNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Page;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnFirst;
    }
}