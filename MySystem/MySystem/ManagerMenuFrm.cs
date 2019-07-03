using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySystem
{
    public partial class ManagerMenuFrm : Form
    {
        public ManagerMenuFrm()
        {
            InitializeComponent();
        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserLoginInfoMag frm = new UserLoginInfoMag();
            frm.MdiParent = this;
            frm.Show();
            tssMsg.Text = frm.Text;

        }

        private void 成绩信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreInfoMag frm = new ScoreInfoMag();
            frm.MdiParent = this;
            frm.Show();
            tssMsg.Text = frm.Text;
        }

        private void 全体学生信息输出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllStudentInfo frm = new AllStudentInfo();
            frm.MdiParent = this;
            frm.Show();
            tssMsg.Text = frm.Text;
        }

        private void 全体教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllTeacherInfo frm = new AllTeacherInfo();
            frm.MdiParent = this;
            frm.Show();
            tssMsg.Text = frm.Text;
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutFrm frm = new AboutFrm();
            frm.MdiParent = this;
            frm.Show();
            tssMsg.Text = frm.Text;
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dept_Msg_Mag frm = new Dept_Msg_Mag();
            frm.MdiParent = this;
            frm.Show();
            tssMsg.Text = frm.Text;
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 添加及修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 查询输出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 奖惩信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JC_Msg_Mag frm = new JC_Msg_Mag();
            frm.MdiParent = this;
            frm.Show();
            tssMsg.Text = frm.Text;
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否注销当前账号？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                MySystem.Program.mainRestart = true;
                this.Close();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 专业管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spec_Msg_Mag frm = new Spec_Msg_Mag();
            frm.MdiParent = this;
            frm.Show();
            tssMsg.Text = frm.Text;
        }

        private void 本科ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course_Msg_Mag frm = new Course_Msg_Mag();
            frm.MdiParent = this;
            frm.Show();
            tssMsg.Text = frm.Text;
        }

        private void 班级管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassMagFrm frm = new ClassMagFrm();
            frm.MdiParent = this;
            frm.Show();
            tssMsg.Text = frm.Text;
        }

        private void 个人信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 学院2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Research_Msg_Mag frm = new Research_Msg_Mag();
            frm.MdiParent = this;
            frm.Show();
            tssMsg.Text = frm.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolTimer.Text = "当前时间" + System.DateTime.Now.ToString() + "       ";
        }

        private void ManagerMenuFrm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

    }
}
