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
    public partial class LForm : Form
    {
        public LForm()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string user;
            string userName = txtName.Text;
            string PassWord = txtPwd.Text;
            int no = Convert.ToInt32(txtNo.Text);
            string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connString);         //创建连接对象

            if (rdoStudent.Checked)
                user = rdoStudent.Text;
            else if (rdoTeacher.Checked)
                user = rdoTeacher.Text;
            else
                user = rdoManager.Text;
            MySystem.Program.UserId = user;
            MySystem.Program.UserNo = no;
            MySystem.Program.Pwd = PassWord;
            MySystem.Program.UserName = userName;
            string sql = String.Format("select count(*) from [User] where 用户名='{0}'and 用户密码='{1}'and 用户权限='{2}'and 用户ID='{3}'", userName, PassWord, user,no);
            try
            {
                conn.Open();                //打开数据库
                SqlCommand comm = new SqlCommand(sql, conn);            //创建Command对象
                int n = (int)comm.ExecuteScalar();                      //执行查询语句，返回匹配的行数
                if (n == 1)
                {
                    MessageBox.Show("成功登录系统！", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.DialogResult = DialogResult.OK;                //触发确定按钮
                    this.Tag = true;                                    //登录成功并记录
                }
                else
                {
                    MessageBox.Show("您输入的用户名或者密码错误！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Tag = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Tag = false;
            }
            finally
            {
                conn.Close();           //关闭数据库连接
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPwd.Text = "";
            txtNo.Focus();
        }

        private void LForm_Load(object sender, EventArgs e)
        {
            txtNo.Focus();
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            EnrolFrm frm = new EnrolFrm();          //创建子窗体对象
            frm.Show();
        }
    }
}
