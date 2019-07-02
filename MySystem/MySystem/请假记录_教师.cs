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
    public partial class QJ_Msg_Teacher : Form
    {
        public bool Edit_tag = false;               //当前是否为可编辑状态
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public int Cno;
        public int ID_old = -1;                 //编辑解锁时赋值
        public string Old_status;               //权限类别
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        public QJ_Msg_Teacher()
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

        private void Search_Cno()
        {
            string sql = String.Format("select 班级编号 from 班级信息 where 带班教师='{0}'", MySystem.Program.UserNo);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())                              //学生已注册过
                {
                    Cno = reader.GetInt32(0);
                }
            }
        }

        private string D_Search()               //判定搜索条件
        {
            string sql;
            string _status = Search_status.Text;
            string no = SearchNo.Text;
            Search_Cno();
            if (_status != "")
            {
                if (no != "")
                {
                    sql = String.Format("select * from 请假记录 where 状态='{0}' and 学号='{1}' and 班级号='{2}'", _status, no,Cno);
                    string sql_Num = String.Format("select count(*) from 请假记录 where 状态='{0}' and 学号='{1}' and 班级号='{2}'", _status, no, Cno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select * from 请假记录 where 状态='{0}' and 班级号='{1}'", _status,Cno);
                    string sql_Num = String.Format("select count(*) from 请假记录 where 状态='{0}' and 班级号='{1}'", _status, Cno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
            }
            else
            {
                if (no != "")
                {
                    sql = String.Format("select * from 请假记录 where 学号='{0}' and 班级号='{1}'", no, Cno);
                    string sql_Num = String.Format("select count(*) from 请假记录 where 学号='{0}' and 班级号='{1}'", no, Cno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select * from 请假记录 where 班级号='{0}'", Cno);
                    string sql_Num = String.Format("select count(*) from 请假记录 where 班级号='{0}'", Cno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
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
                            dataGridView1.Rows[index].Cells[0].Value = reader.GetInt32(1);
                            dataGridView1.Rows[index].Cells[1].Value = reader.GetString(2);
                            dataGridView1.Rows[index].Cells[2].Value = reader.GetString(3);
                            dataGridView1.Rows[index].Cells[3].Value = reader.GetString(4);
                            dataGridView1.Rows[index].Cells[4].Value = reader.GetDateTime(5);
                            dataGridView1.Rows[index].Cells[5].Value = reader.GetDateTime(6);
                            dataGridView1.Rows[index].Cells[6].Value = reader.GetString(7);
                            dataGridView1.Rows[index].Cells[7].Value = reader.GetString(8);
                            dataGridView1.Rows[index].Cells[8].Value = reader.GetString(9);     //状态
                            dataGridView1.Rows[index].Cells[9].Value = reader.GetInt32(0);
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

        private void Update_Node()                                   //管理：更新
        {
            bool ftag = false;
            
            if (!ftag)
            {
                bool tag = true;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string _status = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    string _id = dataGridView1.Rows[i].Cells[9].Value.ToString();
                    string sql = String.Format("update 请假记录 set 状态='{1}' where ID='{0}'", _id,_status);
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();            //打开数据库连接
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = comm.ExecuteNonQuery();
                        if (n > 0)
                        {
                            continue;
                        }
                        else
                        {
                            tag = false;
                            break;
                        }
                    }
                }
                if (tag)
                {
                    MessageBox.Show("更新成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowMsg(Current_page);
                }
                else
                {
                    MessageBox.Show("更新失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("更新当前页所有修改记录？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                Update_Node();
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("取消当前页所有更新操作？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                ShowMsg(Current_page);
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
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

        private void QJ_Msg_Teacher_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }
    }
}
