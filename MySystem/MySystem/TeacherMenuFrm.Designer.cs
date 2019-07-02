namespace MySystem
{
    partial class TeacherMenuFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMenuFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.登录信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级管理CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.教学资源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.院系ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.专业ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教研室ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理SToolStripMenuItem,
            this.个人信息ToolStripMenuItem,
            this.班级管理CToolStripMenuItem,
            this.教学资源ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1526, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理SToolStripMenuItem
            // 
            this.系统管理SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExit,
            this.tsmDelete});
            this.系统管理SToolStripMenuItem.Name = "系统管理SToolStripMenuItem";
            this.系统管理SToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.系统管理SToolStripMenuItem.Text = "系统管理（&S）";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(176, 30);
            this.tsmExit.Text = "退出（&E）";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(176, 30);
            this.tsmDelete.Text = "注销（&D)";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息ToolStripMenuItem2,
            this.登录信息ToolStripMenuItem});
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.个人信息ToolStripMenuItem.Text = "个人管理（&P）";
            // 
            // 个人信息ToolStripMenuItem2
            // 
            this.个人信息ToolStripMenuItem2.Name = "个人信息ToolStripMenuItem2";
            this.个人信息ToolStripMenuItem2.Size = new System.Drawing.Size(166, 30);
            this.个人信息ToolStripMenuItem2.Text = "个人信息";
            this.个人信息ToolStripMenuItem2.Click += new System.EventHandler(this.个人信息ToolStripMenuItem2_Click);
            // 
            // 登录信息ToolStripMenuItem
            // 
            this.登录信息ToolStripMenuItem.Name = "登录信息ToolStripMenuItem";
            this.登录信息ToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.登录信息ToolStripMenuItem.Text = "登录信息";
            this.登录信息ToolStripMenuItem.Click += new System.EventHandler(this.登录信息ToolStripMenuItem_Click);
            // 
            // 班级管理CToolStripMenuItem
            // 
            this.班级管理CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem5});
            this.班级管理CToolStripMenuItem.Name = "班级管理CToolStripMenuItem";
            this.班级管理CToolStripMenuItem.Size = new System.Drawing.Size(151, 29);
            this.班级管理CToolStripMenuItem.Text = "班级管理（&C）";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(204, 30);
            this.toolStripMenuItem1.Text = "学生信息管理";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(204, 30);
            this.toolStripMenuItem5.Text = "学生请假管理";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // 教学资源ToolStripMenuItem
            // 
            this.教学资源ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.院系ToolStripMenuItem,
            this.专业ToolStripMenuItem,
            this.教研室ToolStripMenuItem});
            this.教学资源ToolStripMenuItem.Name = "教学资源ToolStripMenuItem";
            this.教学资源ToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.教学资源ToolStripMenuItem.Text = "教学资源";
            // 
            // 院系ToolStripMenuItem
            // 
            this.院系ToolStripMenuItem.Name = "院系ToolStripMenuItem";
            this.院系ToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.院系ToolStripMenuItem.Text = "院系";
            this.院系ToolStripMenuItem.Click += new System.EventHandler(this.院系ToolStripMenuItem_Click);
            // 
            // 专业ToolStripMenuItem
            // 
            this.专业ToolStripMenuItem.Name = "专业ToolStripMenuItem";
            this.专业ToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.专业ToolStripMenuItem.Text = "专业";
            this.专业ToolStripMenuItem.Click += new System.EventHandler(this.专业ToolStripMenuItem_Click);
            // 
            // 教研室ToolStripMenuItem
            // 
            this.教研室ToolStripMenuItem.Name = "教研室ToolStripMenuItem";
            this.教研室ToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.教研室ToolStripMenuItem.Text = "教研室";
            this.教研室ToolStripMenuItem.Click += new System.EventHandler(this.教研室ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.tssMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1526, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(160, 25);
            this.toolStripStatusLabel1.Text = " 就绪              ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(211, 25);
            this.toolStripStatusLabel2.Text = "权限级别：教师           ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 25);
            // 
            // tssMsg
            // 
            this.tssMsg.Name = "tssMsg";
            this.tssMsg.Size = new System.Drawing.Size(145, 25);
            this.tssMsg.Text = "请选择一个操作";
            // 
            // TeacherMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 661);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeacherMenuFrm";
            this.Text = "教学管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级管理CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教学资源ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tssMsg;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 登录信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 院系ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 专业ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教研室ToolStripMenuItem;
    }
}