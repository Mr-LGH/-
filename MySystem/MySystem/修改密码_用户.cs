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
    public partial class Pwd_Update : Form
    {
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        public Pwd_Update()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void _Update()
        {
            string user=MySystem.Program.UserId ;
            int no=MySystem.Program.UserNo;
            string userName=MySystem.Program.UserName ;
            
            string _pwd = Pwd_old.Text;
            string _pwd_new = Pwd_new.Text;
            string _pwd_new_Re = Pwd_Re_new.Text;
            if(_pwd==MySystem.Program.Pwd)
            {
                if(_pwd_new==_pwd_new_Re)
                {
                    string sql = String.Format("update [User] set 用户密码='{1}' where 用户名='{0}' and 用户权限='{2}'and 用户ID='{3}'", userName, _pwd_new, user, no);
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();            //打开数据库连接
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = comm.ExecuteNonQuery();
                        if (n <= 0)
                        {
                            MessageBox.Show("数据更新失败，请检查数据格式！", "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("数据更新成功！", "更新成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("前后两次输入的密码不一致！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("旧密码错误！请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Pwd_old.Focus();
            }
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            _Update();
        }
    }
}
