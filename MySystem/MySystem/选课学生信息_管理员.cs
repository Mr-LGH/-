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
    public partial class Course_Student_Info : Form
    {
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public int no;                     //当前选中行
        public int Cno;
        public bool tag = false;            //判定课余量是否+1
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        public Course_Student_Info()
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

        private void Search_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            string spec;
            string dept = Search_dept.SelectedItem.ToString();
            string sql = String.Format("select * from 专业信息 where 所属院系='{0}'", dept);
            Search_spec.Text = "";
            Search_spec.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    spec = reader.GetString(1);
                    Search_spec.Items.Add(spec);
                }
            }
        }

        private void Search_spec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _class = "";
            string spec = Search_spec.SelectedItem.ToString();
            string sql = String.Format("select * from 班级信息 where 所属专业='{0}'", spec);
            Search_class.Text = "";
            Search_class.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    _class = reader.GetString(1);
                    Search_class.Items.Add(_class);
                }
            }
        }

        private string D_Search()               //判定搜索条件
        {
            string sql;
            Cno = Course_Msg_Mag.Current_Cno;
            string dept = Search_dept.Text;
            string spec = Search_spec.Text;
            string _class = Search_class.Text;
            string Sno = Search_no.Text;
            if (dept != "")
            {
                if (spec != "")
                {
                    if (_class != "")
                    {
                        if (Sno != "")
                        {
                            sql = String.Format("select 学籍信息_学生.学号,学籍信息_学生.姓名,学籍信息_学生.院系,学籍信息_学生.专业,学籍信息_学生.班级 from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.学号='{0}' and 学籍信息_学生.班级='{1}' and 学籍信息_学生.专业='{2}' and 选课成绩信息.课程号='{3}'", Sno, _class, spec,Cno);
                            string sql_Num = String.Format("select count(*) from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.学号='{0}' and 学籍信息_学生.班级='{1}' and 学籍信息_学生.专业='{2}' and 选课成绩信息.课程号='{3}'", Sno, _class, spec, Cno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                        else
                        {
                            sql = String.Format("select 学籍信息_学生.学号,学籍信息_学生.姓名,学籍信息_学生.院系,学籍信息_学生.专业,学籍信息_学生.班级 from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.班级='{0}' and 学籍信息_学生.专业='{1}' and 选课成绩信息.课程号='{2}'", _class, spec,Cno);
                            string sql_Num = String.Format("select count(*) from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.班级='{0}' and 学籍信息_学生.专业='{1}' and 选课成绩信息.课程号='{2}'", _class, spec, Cno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                    }
                    else
                    {
                        if (Sno != "")
                        {
                            sql = String.Format("select 学籍信息_学生.学号,学籍信息_学生.姓名,学籍信息_学生.院系,学籍信息_学生.专业,学籍信息_学生.班级 from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.学号='{0}' and 学籍信息_学生.专业='{1}' and 选课成绩信息.课程号='{2}'", Sno, spec,Cno);
                            string sql_Num = String.Format("select count(*) from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.学号='{0}' and 学籍信息_学生.专业='{1}' and 选课成绩信息.课程号='{2}'", Sno, spec, Cno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                        else
                        {
                            sql = String.Format("select 学籍信息_学生.学号,学籍信息_学生.姓名,学籍信息_学生.院系,学籍信息_学生.专业,学籍信息_学生.班级 from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.专业='{0}' and 选课成绩信息.课程号='{1}'", spec,Cno);
                            string sql_Num = String.Format("select count(*) from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.专业='{0}' and 选课成绩信息.课程号='{1}'", spec, Cno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                    }
                }
                else
                {
                    if (Sno != "")
                    {
                        sql = String.Format("select 学籍信息_学生.学号,学籍信息_学生.姓名,学籍信息_学生.院系,学籍信息_学生.专业,学籍信息_学生.班级 from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.学号='{0}' and 学籍信息_学生.院系='{1}' and 选课成绩信息.课程号='{2}'", Sno, dept,Cno);
                        string sql_Num = String.Format("select count(*) from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.学号='{0}' and 学籍信息_学生.院系='{1}' and 选课成绩信息.课程号='{2}'", Sno, dept, Cno);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                    else
                    {
                        sql = String.Format("select 学籍信息_学生.学号,学籍信息_学生.姓名,学籍信息_学生.院系,学籍信息_学生.专业,学籍信息_学生.班级 from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.院系='{0}' and 选课成绩信息.课程号='{1}'", dept,Cno);
                        string sql_Num = String.Format("select count(*) from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.院系='{0}' and 选课成绩信息.课程号='{1}'", dept, Cno);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                }
            }
            else
            {
                if (Sno != "")
                {
                    sql = String.Format("select 学籍信息_学生.学号,学籍信息_学生.姓名,学籍信息_学生.院系,学籍信息_学生.专业,学籍信息_学生.班级 from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.学号='{0}' and 选课成绩信息.课程号='{1}'", Sno,Cno);
                    string sql_Num = String.Format("select count(*) from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 学籍信息_学生.学号='{0}' and 选课成绩信息.课程号='{1}'", Sno, Cno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select 学籍信息_学生.学号,学籍信息_学生.姓名,学籍信息_学生.院系,学籍信息_学生.专业,学籍信息_学生.班级 from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号 and 选课成绩信息.课程号='{0}'",Cno);
                    string sql_Num = String.Format("select count(*) from 学籍信息_学生,选课成绩信息 where 学籍信息_学生.学号=选课成绩信息.学号");
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
                            dataGridView1.Rows[index].Cells[1].Value = reader.GetString(1);
                            dataGridView1.Rows[index].Cells[2].Value = reader.GetString(2);
                            dataGridView1.Rows[index].Cells[3].Value = reader.GetString(3);
                            dataGridView1.Rows[index].Cells[4].Value = reader.GetString(4);
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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                no = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);       //选中的学号
                
            }  
        }

        private void Add_Spare()                //课余量+1
        {
            string sql = String.Format("update 课程信息管理 set 课余量=课余量+1 where 课程号='{0}'", Cno);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    tag = true;
                }
            }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = String.Format("delete from 选课成绩信息 where 学号='{0}' and 课程号='{1}'", no,Cno);
            DialogResult dr = MessageBox.Show("删除该条选课信息，并将该学生从本课程中移除？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();            //打开数据库连接
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int n = comm.ExecuteNonQuery();
                    if (n <= 0)
                    {
                        MessageBox.Show("数据删除失败！", "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Add_Spare();
                        if(tag)
                        {
                            MessageBox.Show("课程课余量更新成功！", "更新成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        MessageBox.Show("数据删除成功！", "更新成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ShowMsg(Current_page);
                    }
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

        private void Course_Student_Info_Load(object sender, EventArgs e)
        {
            Add_Dept();
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }
    }
}
