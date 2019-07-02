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
    public partial class Research_Msg_Mag : Form
    {
        public bool Edit_tag = false;               //当前是否为可编辑状态
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public int Cno_old;                 //编辑解锁时赋值
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        public Research_Msg_Mag()
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

        private void 教研室信息管理_Load(object sender, EventArgs e)
        {
            Lock_Control();
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

        private string D_Search()               //判定搜索条件
        {
            string sql;
            string Cno = SearchNo.Text;

            if (Cno != "")
            {
                sql = String.Format("select * from 教研室信息 where 编号='{0}'", Cno);
                string sql_Num = String.Format("select count(*) from 教研室信息 where 编号='{0}'", Cno);
                Count_Node = _Count(sql_Num);
                return sql;
            }
            else
            {
                sql = String.Format("select * from 教研室信息");
                string sql_Num = String.Format("select count(*) from 教研室信息");
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
                    clear_Info();
                    MessageBox.Show("暂无信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Lock_Control()             //锁定控件
        {
            txtCno.ReadOnly = true;
            txtCname.ReadOnly = true;
            txtMag.ReadOnly = true;
            txtInfo.ReadOnly = true;
            Edit_tag = false;
            btnEditor.Enabled = true;
        }
        private void Lock_Remove()             //解除控件锁定
        {
            txtCno.ReadOnly = false;
            txtCname.ReadOnly = false;
            txtMag.ReadOnly = false;
            txtInfo.ReadOnly = false;
            Edit_tag = true;
            btnEditor.Enabled = false;
        }

        private void ShowInfo(int no)         //选中的班级号班级信息显示
        {
            string sql = String.Format("select * from 教研室信息 where 编号='{0}'", no);
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
            Cno_old = Convert.ToInt32(txtCno.Text);
            Lock_Control();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cno;
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                Cno = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);       //选中的班级号
                ShowInfo(Cno);
            }  
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            Lock_Remove();
        }

        private void clear_Info()                                   //清除班级信息界面
        {
            txtCname.Text = "";
            txtCno.Text = "";
            txtMag.Text = "";
            txtInfo.Text = "";
        }

        private void Update_Node()                                   //管理：更新
        {
            string Cname = txtCname.Text;
            int Cno = Convert.ToInt32(txtCno.Text);
            string Mag = txtMag.Text;
            string Info = txtInfo.Text;
            string sql = String.Format("update 教研室信息 set 编号='{1}',名称='{2}',教研室主任='{3}',研究方向='{4}' where 编号='{0}'", Cno_old, Cno, Cname, Mag, Info);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("更新成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Info();
                    Lock_Control();
                    ShowMsg(Current_page);
                }
                else
                {
                    MessageBox.Show("更新失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Edit_tag)
            {
                int Cno = Convert.ToInt32(txtCno.Text);
                if (Cno == Cno_old)                    //学号未更改
                {
                    Update_Node();
                }
                else
                {
                    string sql = String.Format("select count(*) from 教研室信息 where 编号='{0}'", Cno);
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();            //打开数据库连接
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = (int)comm.ExecuteScalar();
                        if (n > 0)
                        {
                            MessageBox.Show("该编号所代表的教研室已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCno.Focus();
                        }
                        else
                        {
                            Update_Node();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("当前为不可编辑状态！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Creat_Node()                                   //管理：添加班级
        {
            string Cname = txtCname.Text;
            int Cno = Convert.ToInt32(txtCno.Text);
            string Mag = txtMag.Text;
            string Info = txtInfo.Text;
            string sql = String.Format("insert into 教研室信息(编号,名称,教研室主任,研究方向) values('{0}','{1}','{2}','{3}')", Cno, Cname, Mag, Info);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("添加成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Info();
                    Lock_Control();
                    ShowMsg(Count_page);
                }
                else
                {
                    MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Edit_tag)
            {
                int Cno = Convert.ToInt32(txtCno.Text);
                string sql = String.Format("select count(*) from 教研室信息 where 编号='{0}'", Cno);
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();            //打开数据库连接
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int n = (int)comm.ExecuteScalar();
                    if (n > 0)
                    {
                        MessageBox.Show("该编号所代表的教研室已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCno.Focus();
                    }
                    else
                    {
                        Creat_Node();
                    }
                }
            }
            else
            {
                MessageBox.Show("当前为不可编辑状态！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Delete_Node()
        {
            int Cno = Cno_old;
            string sql = String.Format("delete from 教研室信息 where 编号='{0}'", Cno);
            DialogResult dr = MessageBox.Show("删除该教研室信息？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("数据删除成功！", "更新成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        clear_Info();
                        Lock_Control();
                        ShowMsg(Current_page);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCno.Text == "")
            {
                MessageBox.Show("请选择要删除的班级！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Delete_Node();
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

    }
}
