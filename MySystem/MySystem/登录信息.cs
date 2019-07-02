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
    public partial class SLoginMag : Form
    {
        public int No = MySystem.Program.UserNo;
        public string Grade = MySystem.Program.UserId;
        public SLoginMag()
        {
            InitializeComponent();
        }
        private void Dispay()
        {
            string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
            string sql = String.Format("select * from [User] where 用户ID='{0}'and 用户权限='{1}'", No, Grade);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    lblSno.Text = reader.GetString(1);
                    string str=reader.GetString(2);
                    string x = "";
                    for (int i = 0; i < str.Length;i++ )
                    {
                        x += "*";
                    }
                    lblSPwd.Text = x;
                    lblTime.Text = reader.GetString(4);          //第四列
                }
            }
        }
        private void SLoginMag_Load(object sender, EventArgs e)
        {
            Dispay();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            Pwd_Update frm = new Pwd_Update();
            frm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
