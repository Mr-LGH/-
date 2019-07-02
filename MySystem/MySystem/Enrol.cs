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
    public partial class EnrolFrm : Form
    {
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        public EnrolFrm()
        {
            InitializeComponent();
        }
        private void Search_User()              //搜索用户
        {
            string User_Grade;
            if (rdoStudent.Checked)
                User_Grade = "学生";                    //学生用户注册
            else
                User_Grade = "教师";                  //教师用户注册
            string sql = String.Format("select count(*) from [User] where 用户ID='{0}'and 用户权限='{1}'", txtNo.Text, User_Grade);  //SQL语句
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = (int)comm.ExecuteScalar();
                if (n > 0)
                {
                    MessageBox.Show("该用户已存在，若非本人注册，请联系管理员进行确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserPassWord.Text = "";
                    SurePassWord.Text = "";
                    UserName.Focus();
                }
                else
                {
                    Creat_User();
                }
            }
        }
        private void Creat_User()               //创建用户
        {
            int No = Convert.ToInt32(txtNo.Text);
            string userName = UserName.Text;
            string passWord = UserPassWord.Text;
            string surePassWord = SurePassWord.Text;
            string User_Grade;                              //用户权限,管理员内定
            string time = System.DateTime.Now.ToString();
            if (rdoStudent.Checked)
                User_Grade = "学生";                    //学生用户注册
            else
                User_Grade = "教师";                  //教师用户注册
            string sql = String.Format("insert into [User](用户ID,用户名,用户密码,用户权限,用户注册时间,身份验证) values('{0}','{1}','{2}','{3}','{4}','{5}')",No,userName, passWord,User_Grade,time,0);
            //User是关键字，当作为表名使用时需[User]

            if (passWord == surePassWord)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int n = comm.ExecuteNonQuery();             //执行添加命令，返回更新的行数
                    if (n > 0)
                    {
                       
                        DialogResult dr=MessageBox.Show("添加用户成功！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(dr== DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("添加用户失败！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("前后两次输入的密码不一致！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            Search_User();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            UserPassWord.Text = "";
            SurePassWord.Text="";
            UserName.Focus();
        }

        private void EnrolFrm_Load(object sender, EventArgs e)
        {
            txtNo.Focus();
        }
    }
}
