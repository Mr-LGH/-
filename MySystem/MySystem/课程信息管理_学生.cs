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

    public partial class CourseMag : Form
    {
        public static int Current_Cno;
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public bool tag = false;              //全选按钮是否启用
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        public CourseMag()
        {
            InitializeComponent();
        }

        private void Search_required_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tag = Search_required.SelectedItem.ToString();
            if (tag == "必修")
            {
                Search_class.Text = "";
                Search_class.Items.Clear();
                Search_class.Items.Add("专业必修");
                Search_class.Items.Add("公共必修");
            }
            else if (tag == "选修")
            {
                Search_class.Text = "";
                Search_class.Items.Clear();
                Search_class.Items.Add("专业选修");
                Search_class.Items.Add("公共选修");
            }
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

        private string D_Search()               //判定搜索条件
        {
            string sql;
            string Requit = Search_required.Text;
            string _class = Search_class.Text;
            string Cno = SearchNo.Text;
            if (Requit != "")
            {
                if (_class != "")
                {
                    if (Cno != "")
                    {
                        sql = String.Format("select * from 课程信息管理 where 课程号='{1}' and 课程类别='{2}' and 课程号 in(select 课程号 from 选课成绩信息 where 学号='{0}')", MySystem.Program.UserNo, Cno, _class);
                        string sql_Num = String.Format("select count(*) from 课程信息管理 where 课程号='{1}' and 课程类别='{2}' and 课程号 in(select 课程号 from 选课成绩信息 where 学号='{0}')", MySystem.Program.UserNo, Cno, _class);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                    else
                    {
                        sql = String.Format("select * from 课程信息管理 where 课程类别='{1}' and 课程号 in(select 课程号 from 选课成绩信息 where 学号='{0}')", MySystem.Program.UserNo, _class);
                        string sql_Num = String.Format("select count(*) from 课程信息管理 where 课程类别='{1}' and 课程号 in(select 课程号 from 选课成绩信息 where 学号='{0}')", MySystem.Program.UserNo, _class);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                }
                else
                {
                    if (Cno != "")
                    {
                        sql = String.Format("select * from 课程信息管理 where 课程号='{1}' and 是否必修='{2}'and 课程号 in(select 课程号 from 选课成绩信息 where 学号='{0}')", MySystem.Program.UserNo, Cno, Requit);
                        string sql_Num = String.Format("select count(*) from 课程信息管理 where 课程号='{1}' and 是否必修='{2}'and 课程号 in(select 课程号 from 选课成绩信息 where 学号='{0}')", MySystem.Program.UserNo, Cno, Requit);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                    else
                    {
                        sql = String.Format("select * from 课程信息管理 where 是否必修='{1}'and 课程号 in(select 课程号 from 选课成绩信息 where 学号='{0}')", MySystem.Program.UserNo, Requit);
                        string sql_Num = String.Format("select count(*) from 课程信息管理 where 是否必修='{1}'and 课程号 in(select 课程号 from 选课成绩信息 where 学号='{0}')", MySystem.Program.UserNo, Requit);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                }
            }
            else
            {
                if (Cno != "")
                {
                    sql = String.Format("select * from 课程信息管理 where 课程号='{1}' and 课程号 in(select 课程号 from 选课成绩信息 where 学号='{0}')", MySystem.Program.UserNo, Cno);
                    string sql_Num = String.Format("select count(*) from 课程信息管理 where 课程号='{1}' and 课程号 in(select 课程号 from 选课成绩信息 where 学号='{0}')", MySystem.Program.UserNo, Cno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select * from 课程信息管理 where 课程号 in(select 课程号 from 选课成绩信息 where 学号='{0}')", MySystem.Program.UserNo);
                    string sql_Num = String.Format("select count(*) from 课程信息管理 where 课程号 in(select 课程号 from 选课成绩信息 where 学号='{0}')", MySystem.Program.UserNo);
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
                            dataGridView1.Rows[index].Cells[1].Value = reader.GetInt32(0);
                            dataGridView1.Rows[index].Cells[2].Value = reader.GetString(1);
                            dataGridView1.Rows[index].Cells[3].Value = reader.GetString(2);
                            dataGridView1.Rows[index].Cells[4].Value = reader.GetString(3);
                            dataGridView1.Rows[index].Cells[5].Value = reader.GetInt32(4);
                            dataGridView1.Rows[index].Cells[6].Value = reader.GetInt32(5);
                            dataGridView1.Rows[index].Cells[7].Value = reader.GetInt32(6);
                            dataGridView1.Rows[index].Cells[8].Value = reader.GetDateTime(9);
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

        private void Count_class(int no)                //课余量-1
        {
            string sql = String.Format("update 课程信息管理 set 课余量=课余量+1 where 课程号='{0}'", no);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0) { }
            }
        }

        private void Posting_class()            //移除课程
        {
            bool btag = false;
            int count = dataGridView1.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[0];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    int Cno = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    string sql = String.Format("delete from 选课成绩信息 where 课程号='{1}' and 学号='{0}'", MySystem.Program.UserNo,Cno);
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();            //打开数据库连接
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = comm.ExecuteNonQuery();
                        if (n > 0)
                        {
                            Count_class(Cno);
                            continue;
                        }
                        else
                        {
                            btag = true;
                            break;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            if (!btag)
            {
                MessageBox.Show("课程移除成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowMsg(Current_page);
            }
            else
            {
                MessageBox.Show("课程移除失败，数据库异常！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowMsg(Current_page);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool flag = false;
            DialogResult dr = MessageBox.Show("将所选课程从课表中移除？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[0];
                    Boolean lag = Convert.ToBoolean(checkCell.Value);
                    if (lag == true)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("请选择要移除的课程！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Posting_class();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                if (!tag)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = "true";//如果为true则为选中,false未选中
                    }
                    tag = true;
                }
                else
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = "false";//如果为true则为选中,false未选中
                    }
                    tag = false;
                }
            }
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

        private void CourseMag_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

    }
}
