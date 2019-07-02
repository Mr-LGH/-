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
    public partial class Spec_Msg_Display : Form
    {
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";

        public Spec_Msg_Display()
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

        private void Search_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = false;
            Search_spec.Text = "";
            string spec;
            string dept = Search_dept.SelectedItem.ToString();
            string sql = String.Format("select * from 专业信息 where 所属院系='{0}'", dept);
            Search_spec.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    flag = true;
                    spec = reader.GetString(1);
                    Search_spec.Items.Add(spec);
                }
            }
            if (!flag)
            {
                MessageBox.Show("该院系暂无专业信息！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowInfo(string dept,string spec)         //选中的专业号专业信息显示
        {
            string sql = String.Format("select * from 专业信息 where 专业名称='{0}' and 所属院系='{1}'", spec,dept);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    txtSno.Text = reader.GetInt32(0).ToString();
                    txtSname.Text = reader.GetString(1);
                    cboSdept.Text = reader.GetString(2);
                    txtSsnum.Text = reader.GetInt32(3).ToString();
                    NumYear.Text = reader.GetInt32(4).ToString();
                    txtSInfo.Text = reader.GetString(5);
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string _dept = Search_dept.Text;
            string _spec = Search_spec.Text;
            if (_dept == "")
            {
                MessageBox.Show("请选择要查看的专业所属院系！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(_spec=="")
                {
                    MessageBox.Show("请选择要查看的专业！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ShowInfo(_dept,_spec);
            }
        }

        private void Spec_Msg_Display_Load(object sender, EventArgs e)
        {
            Add_Dept();
        }


    }
}
