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
    public partial class Research_Msg_Display : Form
    {
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        
        public Research_Msg_Display()
        {
            InitializeComponent();
        }

        private void Add_Node()                    //为复选框添加教研室   
        {
            bool flag = false;
            string Node;
            string sql = String.Format("select * from 教研室信息");
            Search_select.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    flag = true;
                    Node = reader.GetString(1);
                    Search_select.Items.Add(Node);
                }
            }
            if(!flag)
            {
                MessageBox.Show("暂无任何教研室信息！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowInfo(string Name)         
        {
            string sql = String.Format("select * from 教研室信息 where 名称='{0}'", Name);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    txtCno.Text = reader.GetInt32(0).ToString();
                    txtCname.Text = reader.GetString(1);
                    txtMag.Text = reader.GetString(2);
                    txtInfo.Text = reader.GetString(3);
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string _name = Search_select.Text;
            if (_name == "")
            {
                MessageBox.Show("请选择要查看的教研室！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ShowInfo(_name);
            }
        }

        private void 教研室信息_教学资源_Load(object sender, EventArgs e)
        {
            Add_Node();
        }





    }
}
