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
    public partial class ScoreInfoMag : Form
    {
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        public ScoreInfoMag()
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

        private string D_Search()               //判定搜索条件
        {
            string sql;
            string Cno = txtCno.Text;
            string Sno = txtSno.Text;
            if (Sno != "")
            {
                if (Cno != "")
                {
                    sql = String.Format("select * from 选课成绩信息 where 学号='{0}' and 课程号='{1}'",Sno, Cno);
                    string sql_Num = String.Format("select count(*) from 选课成绩信息 where 学号='{0}' and 课程号='{1}'", Sno, Cno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select * from 选课成绩信息 where 学号='{0}'", Sno);
                    string sql_Num = String.Format("select count(*) from 选课成绩信息 where 学号='{0}'", Sno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
            }
            else
            {
                if (Cno != "")
                {
                    sql = String.Format("select * from 选课成绩信息 where 课程号='{0}'",Cno);
                    string sql_Num = String.Format("select count(*) from 选课成绩信息 where 课程号='{0}'", Cno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select * from 选课成绩信息");
                    string sql_Num = String.Format("select count(*) from 选课成绩信息");
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
                            dataGridView1.Rows[index].Cells[0].Value = reader.GetInt32(0);
                            dataGridView1.Rows[index].Cells[1].Value = reader.GetInt32(1);
                            dataGridView1.Rows[index].Cells[2].Value = reader.GetString(2);
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

        private void Update_dgv()
        {
            int Sno;
            int Cno;
            string score;
            bool tag = false;
            bool flag = true;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                score = dataGridView1.Rows[i].Cells[2].Value.ToString();
                if (score=="待录入")
                    continue;
                else
                {
                    try
                    {
                        int Grade = Convert.ToInt32(score);
                        if (Grade < 0 || Grade > 100)
                        {
                            tag = true;
                            dataGridView1.Rows[i].Cells[2].Selected = true;
                        }
                    }
                    catch(FormatException ex)
                    {
                        tag = true;
                        dataGridView1.Rows[i].Cells[2].Selected = true;
                    }
                }
            }
            if (tag)
            {
                MessageBox.Show("分数应是大于0且小于100的整数，请确定数据是否正确！", "数据格式错误！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    Sno = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    Cno = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    score = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string sql = String.Format("update 选课成绩信息 set 成绩='{2}' where 学号='{0}' and 课程号='{1}'",Sno, Cno, score);
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
                            flag = false;
                        }
                    }
                }
                if (flag)
                {
                    ShowMsg(Current_page);
                    MessageBox.Show("更新成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("更新失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_dgv();
        }

        private void btnCancel_Update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("取消当前所有更新操作？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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

        private void ScoreInfoMag_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

    }
}
