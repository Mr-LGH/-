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
    public partial class dept_msg_Display : Form
    {
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";

        public dept_msg_Display()
        {
            InitializeComponent();
        }

        private void Add_Dept()                    //为复选框添加院系信息     
        {
            string dept;
            string sql = String.Format("select * from 院系信息");
            Search_dept.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    dept = reader.GetString(1);
                    Search_dept.Items.Add(dept);
                }
            }
        }

        private void ShowInfo(string dept)         //选中的院系号院系信息显示
        {
            
            string sql = String.Format("select * from 院系信息 where 院系名称='{0}'", dept);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    txtDno.Text = reader.GetInt32(0).ToString();
                    txtDname.Text = reader.GetString(1);
                    txtDtnum.Text = reader.GetInt32(2).ToString();
                    txtDsnum.Text = reader.GetInt32(3).ToString();
                    txtSpec.Text = reader.GetString(5);
                    txtDInfo.Text = reader.GetString(4);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string _dept = Search_dept.Text;
            if(_dept=="")
            {
                MessageBox.Show("请选择要查看的院系！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ShowInfo(_dept);
            }
        }

        private void dept_msg_Display_Load(object sender, EventArgs e)
        {
            Add_Dept();
        }




    }
}
