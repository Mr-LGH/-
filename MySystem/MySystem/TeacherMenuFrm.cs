using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySystem
{
    public partial class TeacherMenuFrm : Form
    {
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        
        public TeacherMenuFrm()
        {
            InitializeComponent();
        }

        private bool is_Verify()
        {
            string sql = String.Format("select 身份验证 from [User] where 用户ID='{0}' and 用户权限='教师'", MySystem.Program.UserNo);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetBoolean(0);
                }
                else
                {
                    return false;
                }
            }
        }

        private void 成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                ScoreInfoMag frm = new ScoreInfoMag();
                frm.MdiParent = this;
                frm.Show();
                tssMsg.Text = frm.Text;
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 全体学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                AllStudentInfo frm = new AllStudentInfo();
                frm.MdiParent = this;
                frm.Show();
                tssMsg.Text = frm.Text;
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutFrm frm = new AboutFrm();
            frm.MdiParent = this;
            frm.Show();
            tssMsg.Text = frm.Text;
        }

        private void 个人信息ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                T_InfoFrm frm = new T_InfoFrm();
                frm.MdiParent = this;
                frm.Show();
                tssMsg.Text = frm.Text;
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 登录信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                SLoginMag frm = new SLoginMag();
                frm.MdiParent = this;
                frm.Show();
                tssMsg.Text = frm.Text;
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否注销当前账号？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                MySystem.Program.mainRestart = true;
                this.Close();
            }
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                Student_Teacher_Mag frm = new Student_Teacher_Mag();
                frm.MdiParent = this;
                frm.Show();
                tssMsg.Text = frm.Text;
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                QJ_Msg_Teacher frm = new QJ_Msg_Teacher();
                frm.MdiParent = this;
                frm.Show();
                tssMsg.Text = frm.Text;
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 院系ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                dept_msg_Display frm = new dept_msg_Display();
                frm.MdiParent = this;
                frm.Show();
                tssMsg.Text = frm.Text;
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 专业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                Spec_Msg_Display frm = new Spec_Msg_Display();
                frm.MdiParent = this;
                frm.Show();
                tssMsg.Text = frm.Text;
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 教研室ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                Research_Msg_Display frm = new Research_Msg_Display();
                frm.MdiParent = this;
                frm.Show();
                tssMsg.Text = frm.Text;
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolTimer.Text = "当前时间" + System.DateTime.Now.ToString() + "       ";
        }

        private void TeacherMenuFrm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

    }
}
