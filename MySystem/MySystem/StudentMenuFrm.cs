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
    public partial class StudentMenuFrm : Form
    {
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        public StudentMenuFrm()
        {
            InitializeComponent();
        }


        private bool is_Verify()            //判断身份是否已通过管理员验证
        {
            string sql = String.Format("select 身份验证 from [User] where 用户ID='{0}' and 用户权限='学生'", MySystem.Program.UserNo);
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

        private bool Info_Verify()          //判断是否完善学籍信息
        {
            string sql = String.Format("select * from 学籍信息_学生 where 学号='{0}'", MySystem.Program.UserNo);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void SInfo_student_Click(object sender, EventArgs e)        //学籍信息_个人管理
        {
            if(is_Verify())
            {
                StudentInfo frm = new StudentInfo();            
                frm.MdiParent = this;
                frm.Show();
                tssMsg.Text = frm.Text;
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void SInfo_Login_Click(object sender, EventArgs e)          //登录信息_个人管理
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

        private void SJC_Info_Click(object sender, EventArgs e)             //奖惩信息_个人管理
        {
            if (is_Verify())
            {
                if (Info_Verify())
                {
                    JCFrm frm = new JCFrm();
                    frm.MdiParent = this;
                    frm.Show();
                    tssMsg.Text = frm.Text;
                }
                else
                {
                    MessageBox.Show("请先完善学籍信息", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 成绩管理CToolStripMenuItem_Click(object sender, EventArgs e)   //成绩查询
        {
            if (is_Verify())
            {
                if (Info_Verify())
                {
                    ScoreMagFrm.S_no_Search = MySystem.Program.UserNo;
                    ScoreMagFrm frm = new ScoreMagFrm();
                    frm.MdiParent = this;
                    frm.Show();
                    tssMsg.Text = frm.Text;
                }
                else
                {
                    MessageBox.Show("请先完善学籍信息", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void 添加课程AToolStripMenuItem_Click(object sender, EventArgs e)           //置入课程_选课系统
        {
            if (is_Verify())
            {
                if (Info_Verify())
                {
                    Posting_Course_Student frm = new Posting_Course_Student();
                    frm.MdiParent = this;
                    frm.Show();
                    tssMsg.Text = frm.Text;
                }
                else
                {
                    MessageBox.Show("请先完善学籍信息", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 课程信息管理TToolStripMenuItem_Click(object sender, EventArgs e)       //课表信息管理_选课系统
        {
            if (is_Verify())
            {
                if (Info_Verify())
                {
                    CourseMag frm = new CourseMag();
                    frm.MdiParent = this;
                    frm.Show();
                    tssMsg.Text = frm.Text;
                }
                else
                {
                    MessageBox.Show("请先完善学籍信息", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)               //关于
        {
            AboutFrm frm = new AboutFrm();                  //添加关于子框体
            frm.MdiParent = this;
            frm.Show();
            tssMsg.Text = frm.Text;
        }

        private void 注销DToolStripMenuItem_Click(object sender, EventArgs e)               //注销_设置
        {
            DialogResult dr = MessageBox.Show("是否注销当前账号？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                MySystem.Program.mainRestart = true;
                this.Close();
            }
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)              //退出_设置
        {
            this.Close();
        }

        private void 申请请假ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                if (Info_Verify())
                {
                    Qingjia_mag_stu frm = new Qingjia_mag_stu();
                    frm.MdiParent = this;
                    frm.Show();
                    tssMsg.Text = frm.Text;
                }
                else
                {
                    MessageBox.Show("请先完善学籍信息", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                }
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

        private void 请假记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                if (Info_Verify())
                {
                    QJ_Msg_Student frm = new QJ_Msg_Student();
                    frm.MdiParent = this;
                    frm.Show();
                    tssMsg.Text = frm.Text;
                }
                else
                {
                    MessageBox.Show("请先完善学籍信息", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void tsbStuMsgMag_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                StudentInfo frm = new StudentInfo();
                frm.MdiParent = this;
                frm.Show();
                tssMsg.Text = frm.Text;
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbNewCourse_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                if (Info_Verify())
                {
                    Posting_Course_Student frm = new Posting_Course_Student();
                    frm.MdiParent = this;
                    frm.Show();
                    tssMsg.Text = frm.Text;
                }
                else
                {
                    MessageBox.Show("请先完善学籍信息", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbCurMsgMag_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                if (Info_Verify())
                {
                    CourseMag frm = new CourseMag();
                    frm.MdiParent = this;
                    frm.Show();
                    tssMsg.Text = frm.Text;
                }
                else
                {
                    MessageBox.Show("请先完善学籍信息", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("身份未通过管理员验证!若有疑问，请邮件消息至管理员邮箱：2296760936@qq.com", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbScoreMsg_Click(object sender, EventArgs e)
        {
            if (is_Verify())
            {
                if (Info_Verify())
                {
                    ScoreMagFrm.S_no_Search = MySystem.Program.UserNo;
                    ScoreMagFrm frm = new ScoreMagFrm();
                    frm.MdiParent = this;
                    frm.Show();
                    tssMsg.Text = frm.Text;
                }
                else
                {
                    MessageBox.Show("请先完善学籍信息", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void StudentMenuFrm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
