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
    public partial class JCFrm : Form
    {

        public bool Edit_tag = false;               //当前是否为可编辑状态
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        public JCFrm()
        {
            InitializeComponent();
        }

        private int _Count(string sql)                //查询总记录数
        {

            dataGridView1.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = (int)comm.ExecuteScalar();
                return n;
            }
        }

        private void cboJC_tag_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Jc_tag = cboJC_tag.SelectedItem.ToString();
            if (Jc_tag == "奖")
            {
                cboClass_Tag.Text = "";
                cboClass_Tag.Items.Clear();
                cboClass_Tag.Items.Add("院级");
                cboClass_Tag.Items.Add("校级");
                cboClass_Tag.Items.Add("省级");
                cboClass_Tag.Items.Add("国家级");

            }
            else if (Jc_tag == "惩")
            {
                cboClass_Tag.Text = "";
                cboClass_Tag.Items.Clear();
                cboClass_Tag.Items.Add("警告");
                cboClass_Tag.Items.Add("记过");
                cboClass_Tag.Items.Add("记大过");
                cboClass_Tag.Items.Add("留校察看");
                cboClass_Tag.Items.Add("开除");
            }
        }

        private string D_Search()               //判定搜索条件
        {
            string sql;
            string Jc_tag = cboJC_tag.Text;
            string Jc_Class = cboClass_Tag.Text;
            if (Jc_tag != "")
            {
                if (Jc_Class != "")
                {
                    sql = String.Format("select * from 奖惩信息_学生 where 学号='{0}' and 奖惩类别='{1}'", MySystem.Program.UserNo, Jc_Class);
                    string sql_Num = String.Format("select count(*) from 奖惩信息_学生 where 学号='{0}' and 奖惩类别='{1}'", MySystem.Program.UserNo, Jc_Class);
                    Count_Node = _Count(sql_Num);
                    return sql;
                    
                }
                else
                {
                    sql = String.Format("select * from 奖惩信息_学生 where 学号='{0}' and 奖或惩='{1}'", MySystem.Program.UserNo, Jc_tag);
                    string sql_Num = String.Format("select count(*) from 奖惩信息_学生 where 学号='{0}' and 奖或惩='{1}'", MySystem.Program.UserNo, Jc_tag);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
            }
            else
            {
                sql = String.Format("select * from 奖惩信息_学生 where 学号='{0}'", MySystem.Program.UserNo);
                string sql_Num = String.Format("select count(*) from 奖惩信息_学生 where 学号='{0}'", MySystem.Program.UserNo);
                Count_Node = _Count(sql_Num);
                return sql;
            }
        }

        private void ShowMsg(int i)             //显示第i页
        {
            int index;
            bool tag = false;
            string sql = D_Search();
            int x;
            if (Count_Node % 10 == 0)
                x = 0;
            else
                x = 1;
            Count_page = Count_Node / 10 + x;
            label7.Text = "总共" + Count_Node + "条记录，当前第" + Current_page + "页，共" + Count_page + "页，每页10条记录";
            dataGridView1.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                int current = 0;
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    current++;
                    for (int k = ((i - 1) * 10 + 1); k <= i * 10; k++)
                    {
                        if (current == k)
                        {
                            index = dataGridView1.Rows.Add();
                            tag = true;
                            dataGridView1.Rows[index].Cells[0].Value = reader.GetInt32(0);
                            dataGridView1.Rows[index].Cells[1].Value = reader.GetDateTime(1);
                            dataGridView1.Rows[index].Cells[2].Value = reader.GetString(2);
                            dataGridView1.Rows[index].Cells[3].Value = reader.GetString(3);
                            dataGridView1.Rows[index].Cells[4].Value = reader.GetString(4);
                            dataGridView1.Rows[index].Cells[5].Value = reader.GetString(5);
                            dataGridView1.Rows[index].Cells[6].Value = reader.GetInt32(6);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    tag = true;
                }
                if (!tag)
                {
                    MessageBox.Show("暂无信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        

        private void JCFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

        private void btnUp_Click(object sender, EventArgs e)        //浏览：上一页
        {
            if (Current_page == 1)
            {
                MessageBox.Show("当前已是第1页", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Current_page--;
                ShowMsg(Current_page);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)      //浏览：下一页
        {
            if (Current_page == Count_page)
            {
                MessageBox.Show("当前已是最后一页", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Current_page++;
                ShowMsg(Current_page);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)      //浏览：尾页
        {
            Current_page = Count_page;
            ShowMsg(Current_page);
        }

        private void btnFirst_Click(object sender, EventArgs e)     //浏览：首页
        {
            Current_page = 1;
            ShowMsg(Current_page);
        }

        private void btnJump_Click(object sender, EventArgs e)      //浏览：跳转
        {
            int n = Convert.ToInt32(Page.Text);
            if (n > Count_page || n < 1)
            {
                MessageBox.Show("页数不符合规范！请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Page.Focus();
            }
            else
            {
                Current_page = n;
                ShowMsg(Current_page);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

        private void cboJC_tag_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string Jc_tag = cboJC_tag.SelectedItem.ToString();
            if (Jc_tag == "奖")
            {
                cboClass_Tag.Text = "";
                cboClass_Tag.Items.Clear();
                cboClass_Tag.Items.Add("院级");
                cboClass_Tag.Items.Add("校级");
                cboClass_Tag.Items.Add("省级");
                cboClass_Tag.Items.Add("国家级");

            }
            else if (Jc_tag == "惩")
            {
                cboClass_Tag.Text = "";
                cboClass_Tag.Items.Clear();
                cboClass_Tag.Items.Add("警告");
                cboClass_Tag.Items.Add("记过");
                cboClass_Tag.Items.Add("记大过");
                cboClass_Tag.Items.Add("留校察看");
                cboClass_Tag.Items.Add("开除");
            }
        }
    }
}
