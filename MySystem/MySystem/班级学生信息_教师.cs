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
    public partial class Student_Teacher_Mag : Form
    {
        public bool Edit_tag = false;               //当前是否为可编辑状态
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public string _dept;
        public string _spec;
        public string _class;
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";

        public Student_Teacher_Mag()
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
            string Sno = Stu_No.Text;
            Search_Info();
            if (Sno != "")
            {
                sql = String.Format("select * from 学籍信息_学生 where 院系='{0}' and 专业='{1}' and 班级='{2}' and 学号='{3}'", _dept,_spec,_class,Sno);
                string sql_Num = String.Format("select count(*) from 学籍信息_学生 where 院系='{0}' and 专业='{1}' and 班级='{2}' and 学号='{3}'", _dept, _spec, _class, Sno);
                Count_Node = _Count(sql_Num);
                return sql;
            }
            else
            {
                sql = String.Format("select * from 学籍信息_学生 where 院系='{0}' and 专业='{1}' and 班级='{2}'", _dept,_spec,_class);
                string sql_Num = String.Format("select count(*) from 学籍信息_学生 where 院系='{0}' and 专业='{1}' and 班级='{2}'", _dept,_spec,_class);
                Count_Node = _Count(sql_Num);
                return sql;
            }
            
        }

        private void Search_Info()
        {
            string sql = String.Format("select * from 班级信息 where 带班教师='{0}'", MySystem.Program.UserNo);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    _dept = reader.GetString(2);
                    _spec = reader.GetString(3);
                    _class = reader.GetString(1);
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
            label19.Text = "总共" + Count_Node + "条记录，当前第" + Current_page + "页，共" + Count_page + "页，每页10条记录";
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
                    clear_Info();
                }
            }
        }

        private void ShowInfo(int no)         //选中的学号信息显示
        {
            string sql = String.Format("select * from 学籍信息_学生 where 学号='{0}'", no);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())                              //学生已注册过
                {
                    txtSno.Text = reader.GetInt32(0).ToString();
                    txtSname.Text = reader.GetString(1);
                    txtSsex.Text= reader.GetString(2);
                    Apartment.Text = reader.GetString(3);
                    Phone.Text = reader.GetString(4);
                    dateEntry.Value = reader.GetDateTime(5);
                    txtBrithday.Value = reader.GetDateTime(6);
                    cboClass.Text = reader.GetString(7);
                    cboDept.Text = reader.GetString(8);
                    cboSpec.Text = reader.GetString(9);
                    Hobby.Text= reader.GetString(10);
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
            int Sno;
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                Sno = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);       //选中的学号
                ShowInfo(Sno);
            }
        }

        private void clear_Info()                                   //清除学籍信息界面
        {
            txtSno.Text = "";
            txtSname.Text = "";
            txtSsex.Text = "";
            Apartment.Text = "";
            Phone.Text = "";
            dateEntry.Text = "";
            txtBrithday.Text = "";
            cboClass.Text = "";
            cboDept.Text = "";
            cboSpec.Text = "";
            Hobby.Text = "";
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

        private void btnScore_Click(object sender, EventArgs e)
        {
            if (txtSno.Text == "")
            {
                MessageBox.Show("请选择要查看的学生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ScoreMagFrm.S_no_Search = Convert.ToInt32(txtSno.Text);
                ScoreMagFrm frm = new ScoreMagFrm();
                frm.Show();
            }
        }

        private void Student_Teacher_Mag_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }


    }
}
