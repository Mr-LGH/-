namespace MySystem
{
    partial class StudentMenuFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMenuFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人管理PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SInfo_student = new System.Windows.Forms.ToolStripMenuItem();
            this.SInfo_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.SJC_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加课程AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息管理TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请假系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.申请请假ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.请假记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级信息MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.院系ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.专业ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教研室ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbStuMsgMag = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNewCourse = new System.Windows.Forms.ToolStripButton();
            this.tsbCurMsgMag = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbScoreMsg = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理SToolStripMenuItem,
            this.个人管理PToolStripMenuItem,
            this.成绩管理CToolStripMenuItem,
            this.课程管理CToolStripMenuItem,
            this.请假系统ToolStripMenuItem,
            this.班级信息MToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1624, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理SToolStripMenuItem
            // 
            this.系统管理SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出EToolStripMenuItem,
            this.注销DToolStripMenuItem});
            this.系统管理SToolStripMenuItem.Name = "系统管理SToolStripMenuItem";
            this.系统管理SToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.系统管理SToolStripMenuItem.Text = "系统管理（&S）";
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出EToolStripMenuItem.Image")));
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.退出EToolStripMenuItem.Text = "退出（&E）";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // 注销DToolStripMenuItem
            // 
            this.注销DToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("注销DToolStripMenuItem.Image")));
            this.注销DToolStripMenuItem.Name = "注销DToolStripMenuItem";
            this.注销DToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.注销DToolStripMenuItem.Text = "注销（&D）";
            this.注销DToolStripMenuItem.Click += new System.EventHandler(this.注销DToolStripMenuItem_Click);
            // 
            // 个人管理PToolStripMenuItem
            // 
            this.个人管理PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SInfo_student,
            this.SInfo_Login,
            this.SJC_Info});
            this.个人管理PToolStripMenuItem.Name = "个人管理PToolStripMenuItem";
            this.个人管理PToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.个人管理PToolStripMenuItem.Text = "个人管理（&P）";
            // 
            // SInfo_student
            // 
            this.SInfo_student.Image = ((System.Drawing.Image)(resources.GetObject("SInfo_student.Image")));
            this.SInfo_student.Name = "SInfo_student";
            this.SInfo_student.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SInfo_student.Size = new System.Drawing.Size(340, 30);
            this.SInfo_student.Text = "学籍信息（&S）";
            this.SInfo_student.Click += new System.EventHandler(this.SInfo_student_Click);
            // 
            // SInfo_Login
            // 
            this.SInfo_Login.Image = ((System.Drawing.Image)(resources.GetObject("SInfo_Login.Image")));
            this.SInfo_Login.Name = "SInfo_Login";
            this.SInfo_Login.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.SInfo_Login.Size = new System.Drawing.Size(340, 30);
            this.SInfo_Login.Text = "登录信息";
            this.SInfo_Login.Click += new System.EventHandler(this.SInfo_Login_Click);
            // 
            // SJC_Info
            // 
            this.SJC_Info.Image = ((System.Drawing.Image)(resources.GetObject("SJC_Info.Image")));
            this.SJC_Info.Name = "SJC_Info";
            this.SJC_Info.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.SJC_Info.Size = new System.Drawing.Size(340, 30);
            this.SJC_Info.Text = "奖惩信息";
            this.SJC_Info.Click += new System.EventHandler(this.SJC_Info_Click);
            // 
            // 成绩管理CToolStripMenuItem
            // 
            this.成绩管理CToolStripMenuItem.Name = "成绩管理CToolStripMenuItem";
            this.成绩管理CToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.成绩管理CToolStripMenuItem.Text = "成绩查询（&S）";
            this.成绩管理CToolStripMenuItem.Click += new System.EventHandler(this.成绩管理CToolStripMenuItem_Click);
            // 
            // 课程管理CToolStripMenuItem
            // 
            this.课程管理CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加课程AToolStripMenuItem,
            this.课程信息管理TToolStripMenuItem});
            this.课程管理CToolStripMenuItem.Name = "课程管理CToolStripMenuItem";
            this.课程管理CToolStripMenuItem.Size = new System.Drawing.Size(151, 29);
            this.课程管理CToolStripMenuItem.Text = "选课系统（&C）";
            // 
            // 添加课程AToolStripMenuItem
            // 
            this.添加课程AToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("添加课程AToolStripMenuItem.Image")));
            this.添加课程AToolStripMenuItem.Name = "添加课程AToolStripMenuItem";
            this.添加课程AToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.添加课程AToolStripMenuItem.Size = new System.Drawing.Size(324, 30);
            this.添加课程AToolStripMenuItem.Text = "置入课程";
            this.添加课程AToolStripMenuItem.Click += new System.EventHandler(this.添加课程AToolStripMenuItem_Click);
            // 
            // 课程信息管理TToolStripMenuItem
            // 
            this.课程信息管理TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("课程信息管理TToolStripMenuItem.Image")));
            this.课程信息管理TToolStripMenuItem.Name = "课程信息管理TToolStripMenuItem";
            this.课程信息管理TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.课程信息管理TToolStripMenuItem.Size = new System.Drawing.Size(324, 30);
            this.课程信息管理TToolStripMenuItem.Text = "课表信息管理（&T）";
            this.课程信息管理TToolStripMenuItem.Click += new System.EventHandler(this.课程信息管理TToolStripMenuItem_Click);
            // 
            // 请假系统ToolStripMenuItem
            // 
            this.请假系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.申请请假ToolStripMenuItem,
            this.请假记录ToolStripMenuItem});
            this.请假系统ToolStripMenuItem.Name = "请假系统ToolStripMenuItem";
            this.请假系统ToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.请假系统ToolStripMenuItem.Text = "请假系统";
            // 
            // 申请请假ToolStripMenuItem
            // 
            this.申请请假ToolStripMenuItem.Name = "申请请假ToolStripMenuItem";
            this.申请请假ToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.申请请假ToolStripMenuItem.Text = "申请请假";
            this.申请请假ToolStripMenuItem.Click += new System.EventHandler(this.申请请假ToolStripMenuItem_Click);
            // 
            // 请假记录ToolStripMenuItem
            // 
            this.请假记录ToolStripMenuItem.Name = "请假记录ToolStripMenuItem";
            this.请假记录ToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.请假记录ToolStripMenuItem.Text = "请假记录";
            this.请假记录ToolStripMenuItem.Click += new System.EventHandler(this.请假记录ToolStripMenuItem_Click);
            // 
            // 班级信息MToolStripMenuItem
            // 
            this.班级信息MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.院系ToolStripMenuItem,
            this.专业ToolStripMenuItem,
            this.教研室ToolStripMenuItem});
            this.班级信息MToolStripMenuItem.Name = "班级信息MToolStripMenuItem";
            this.班级信息MToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.班级信息MToolStripMenuItem.Text = "教学资源";
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
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.帮助HToolStripMenuItem.Text = "帮助（&H）";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关于AToolStripMenuItem.Image")));
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.关于AToolStripMenuItem.Text = "关于（&A）";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStuMsgMag,
            this.toolStripSeparator1,
            this.tsbNewCourse,
            this.tsbCurMsgMag,
            this.toolStripSeparator2,
            this.tsbScoreMsg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1624, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbStuMsgMag
            // 
            this.tsbStuMsgMag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStuMsgMag.Image = ((System.Drawing.Image)(resources.GetObject("tsbStuMsgMag.Image")));
            this.tsbStuMsgMag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStuMsgMag.Name = "tsbStuMsgMag";
            this.tsbStuMsgMag.Size = new System.Drawing.Size(44, 44);
            this.tsbStuMsgMag.Text = "个人信息管理";
            this.tsbStuMsgMag.Click += new System.EventHandler(this.tsbStuMsgMag_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // tsbNewCourse
            // 
            this.tsbNewCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewCourse.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewCourse.Image")));
            this.tsbNewCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewCourse.Name = "tsbNewCourse";
            this.tsbNewCourse.Size = new System.Drawing.Size(44, 44);
            this.tsbNewCourse.Text = "课程置入";
            this.tsbNewCourse.Click += new System.EventHandler(this.tsbNewCourse_Click);
            // 
            // tsbCurMsgMag
            // 
            this.tsbCurMsgMag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCurMsgMag.Image = ((System.Drawing.Image)(resources.GetObject("tsbCurMsgMag.Image")));
            this.tsbCurMsgMag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCurMsgMag.Name = "tsbCurMsgMag";
            this.tsbCurMsgMag.Size = new System.Drawing.Size(44, 44);
            this.tsbCurMsgMag.Text = "课程信息管理";
            this.tsbCurMsgMag.Click += new System.EventHandler(this.tsbCurMsgMag_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // tsbScoreMsg
            // 
            this.tsbScoreMsg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbScoreMsg.Image = ((System.Drawing.Image)(resources.GetObject("tsbScoreMsg.Image")));
            this.tsbScoreMsg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScoreMsg.Name = "tsbScoreMsg";
            this.tsbScoreMsg.Size = new System.Drawing.Size(44, 44);
            this.tsbScoreMsg.Text = "成绩查询";
            this.tsbScoreMsg.Click += new System.EventHandler(this.tsbScoreMsg_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolTimer,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.tssMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 726);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1624, 30);
            this.statusStrip1.TabIndex = 2;
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
            this.toolStripStatusLabel2.Text = "权限级别：学生           ";
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
            // toolTimer
            // 
            this.toolTimer.Name = "toolTimer";
            this.toolTimer.Size = new System.Drawing.Size(207, 25);
            this.toolTimer.Text = "toolStripStatusLabel4";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StudentMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 756);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentMenuFrm";
            this.Text = "教学管理系统";
            this.Load += new System.EventHandler(this.StudentMenuFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人管理PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SInfo_student;
        private System.Windows.Forms.ToolStripMenuItem SInfo_Login;
        private System.Windows.Forms.ToolStripMenuItem SJC_Info;
        private System.Windows.Forms.ToolStripMenuItem 成绩管理CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程管理CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加课程AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息管理TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级信息MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbStuMsgMag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNewCourse;
        private System.Windows.Forms.ToolStripButton tsbCurMsgMag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbScoreMsg;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tssMsg;
        private System.Windows.Forms.ToolStripMenuItem 请假系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 申请请假ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 请假记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 院系ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 专业ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教研室ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolTimer;
        private System.Windows.Forms.Timer timer1;
    }
}