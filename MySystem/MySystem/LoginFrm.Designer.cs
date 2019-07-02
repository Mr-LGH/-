namespace MySystem
{
    partial class LForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LForm));
            this.lblMain = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnrol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoManager = new System.Windows.Forms.RadioButton();
            this.rdoTeacher = new System.Windows.Forms.RadioButton();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("楷体", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMain.Image = ((System.Drawing.Image)(resources.GetObject("lblMain.Image")));
            this.lblMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMain.Location = new System.Drawing.Point(71, 69);
            this.lblMain.Name = "lblMain";
            this.lblMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMain.Size = new System.Drawing.Size(364, 48);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "  教学管理系统";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUser.Image = ((System.Drawing.Image)(resources.GetObject("lblUser.Image")));
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUser.Location = new System.Drawing.Point(99, 324);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(142, 24);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "   用户名：";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Image = ((System.Drawing.Image)(resources.GetObject("lblPwd.Image")));
            this.lblPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPwd.Location = new System.Drawing.Point(99, 398);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(142, 24);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "   密  码：";
            this.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point(265, 322);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 34);
            this.txtName.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.Location = new System.Drawing.Point(265, 396);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(187, 34);
            this.txtPwd.TabIndex = 2;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Pink;
            this.btnYes.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnYes.Location = new System.Drawing.Point(106, 602);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(96, 34);
            this.btnYes.TabIndex = 6;
            this.btnYes.Text = "确定";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Pink;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(218, 602);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnrol
            // 
            this.btnEnrol.BackColor = System.Drawing.Color.Pink;
            this.btnEnrol.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnrol.Location = new System.Drawing.Point(329, 602);
            this.btnEnrol.Name = "btnEnrol";
            this.btnEnrol.Size = new System.Drawing.Size(96, 34);
            this.btnEnrol.TabIndex = 8;
            this.btnEnrol.Text = "注册";
            this.btnEnrol.UseVisualStyleBackColor = false;
            this.btnEnrol.Click += new System.EventHandler(this.btnEnrol_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoManager);
            this.groupBox1.Controls.Add(this.rdoTeacher);
            this.groupBox1.Controls.Add(this.rdoStudent);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(116, 475);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 78);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // rdoManager
            // 
            this.rdoManager.AutoSize = true;
            this.rdoManager.Location = new System.Drawing.Point(190, 37);
            this.rdoManager.Name = "rdoManager";
            this.rdoManager.Size = new System.Drawing.Size(103, 28);
            this.rdoManager.TabIndex = 5;
            this.rdoManager.Text = "管理员";
            this.rdoManager.UseVisualStyleBackColor = true;
            // 
            // rdoTeacher
            // 
            this.rdoTeacher.AutoSize = true;
            this.rdoTeacher.Location = new System.Drawing.Point(102, 37);
            this.rdoTeacher.Name = "rdoTeacher";
            this.rdoTeacher.Size = new System.Drawing.Size(79, 28);
            this.rdoTeacher.TabIndex = 4;
            this.rdoTeacher.Text = "教师";
            this.rdoTeacher.UseVisualStyleBackColor = true;
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Checked = true;
            this.rdoStudent.Location = new System.Drawing.Point(21, 37);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(79, 28);
            this.rdoStudent.TabIndex = 3;
            this.rdoStudent.TabStop = true;
            this.rdoStudent.Text = "学生";
            this.rdoStudent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(75, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "  学/编  号：";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNo.Location = new System.Drawing.Point(265, 244);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(187, 34);
            this.txtNo.TabIndex = 0;
            // 
            // LForm
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(572, 688);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnrol);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblMain);
            this.Name = "LForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.LForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnrol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoManager;
        private System.Windows.Forms.RadioButton rdoTeacher;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNo;
    }
}

