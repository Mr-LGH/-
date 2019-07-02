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
    public partial class Dept_Msg_Mag : Form
    {
        public bool Edit_tag = false;               //当前是否为可编辑状态
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public int Dno_old;                 //编辑解锁时赋值
        public string Dname_old;            //
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";

        public Dept_Msg_Mag()
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

        private void Lock_Control()             //锁定控件
        {
            txtDno.ReadOnly = true;
            txtDname.ReadOnly = true;
            txtDInfo.ReadOnly = true;
            txtSpec.ReadOnly = true;
            Edit_tag = false;
            btnEditor.Enabled = true;
        }
        private void Lock_Remove()             //解除控件锁定
        {
            txtDno.ReadOnly = false;
            txtDname.ReadOnly = false;
            txtDInfo.ReadOnly = false;
            txtSpec.ReadOnly = false;
            Edit_tag = true;
            btnEditor.Enabled = false;
        }
        private string D_Search()               //判定搜索条件
        {
            string sql;
            string select = SearchSelect.Text;
            
            if(select!="")
            {
                if(select=="全部")
                {
                    sql = String.Format("select * from 院系信息");
                    string sql_Num = String.Format("select count(*) from 院系信息");
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else if(select=="院系号")
                {
                    int Dno = Convert.ToInt32(txtDid.Text);
                    sql = String.Format("select * from 院系信息 where 院系号='{0}'", Dno);
                    string sql_Num = String.Format("select count(*) from 院系信息 where 院系号='{0}'", Dno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    string Dname = txtDid.Text;
                    sql = String.Format("select * from 院系信息 where 院系名称='{0}'", Dname);
                    string sql_Num = String.Format("select count(*) from 院系信息 where 院系名称='{0}'", Dname);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
            }
            else
            {
                sql = String.Format("select * from 院系信息");
                string sql_Num = String.Format("select count(*) from 院系信息");
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
                    MessageBox.Show("暂无信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ShowInfo(int no)         //选中的院系号院系信息显示
        {
            string sql = String.Format("select * from 院系信息 where 院系号='{0}'", no);
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
            Dname_old = txtDname.Text;
            Dno_old = Convert.ToInt32(txtDno.Text);
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
            int Dno;
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                Dno = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);       //选中的院系号
                ShowInfo(Dno);
            }
        }

        private void btnEditor_Click(object sender, EventArgs e)    //管理：编辑
        {
            Lock_Remove();
        }

        private void clear_Info()                                   //清除院系信息界面
        {
            txtDname.Text = "";
            txtDno.Text = "";
            txtDsnum.Text = "";
            txtDtnum.Text = "";
            txtSpec.Text = "";
            txtDInfo.Text = "";
        }

        private void dept_name_update(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
            }
        }

        private void Update_Node()                                   //管理：更新
        {
            string Dname = txtDname.Text;
            string Dno = txtDno.Text;
            string Ddept = txtDInfo.Text;
            
            string sql = String.Format("update 院系信息 set 院系号='{1}',院系名称='{2}',院系简介='{3}' where 院系号='{0}'", Dno_old, Dno, Dname, Ddept);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    string sql_spec = String.Format("update 专业信息 set 所属院系='{1}' where 所属院系='{0}'", Dname_old, Dname);
                    string sql_class = String.Format("update 班级信息 set 所属院系='{1}' where 所属院系='{0}'", Dname_old, Dname);
                    string sql_student = String.Format("update 学籍信息_学生 set 院系='{1}' where 院系='{0}'", Dname_old, Dname);
                    string sql_teacher = String.Format("update 个人信息_教师 set 所属院系='{1}' where 所属院系='{0}'", Dname_old, Dname);
                    //同步更新该院系相关的专业、班级、学生信息
                    dept_name_update(sql_spec);         
                    dept_name_update(sql_class);
                    dept_name_update(sql_student);
                    dept_name_update(sql_teacher); 
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

        private void btnUpdate_Click(object sender, EventArgs e)     //按钮：更新
        {
            if (Edit_tag)
            {
                int Dno = Convert.ToInt32(txtDno.Text);
                if (Dno == Dno_old)                    //学号未更改
                {
                    Update_Node();
                }
                else
                {
                    string sql = String.Format("select count(*) from 院系信息 where 院系号='{0}'", Dno);
                    dataGridView1.Rows.Clear();
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();            //打开数据库连接
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = (int)comm.ExecuteScalar();
                        if (n > 0)
                        {
                            MessageBox.Show("该院系号所代表的院系已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtDno.Focus();
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

        private void Creat_Node()                                   //管理：添加院系
        {
            string Dname = txtDname.Text;
            string Dno = txtDno.Text;
            string Ddept = txtDInfo.Text;
            
            string sql = String.Format("insert into 院系信息(院系号,院系名称,教师规模,学生规模,院系简介,所设专业) values('{0}','{1}','{2}','{3}','{4}','{5}')", Dno, Dname, 0,0,Ddept, "");
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
                int Dno = Convert.ToInt32(txtDno.Text);
                string sql = String.Format("select count(*) from 院系信息 where 院系号='{0}'", Dno);
                dataGridView1.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();            //打开数据库连接
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int n = (int)comm.ExecuteScalar();
                    if (n > 0)
                    {
                        MessageBox.Show("该院系号所代表的班级已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDno.Focus();
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
            int Dno = Dno_old;
            string sql = String.Format("delete from 院系信息 where 院系号='{0}'", Dno);
            DialogResult dr = MessageBox.Show("删除"+txtDname.Text+"信息？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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
            if (txtDno.Text == "")
            {
                MessageBox.Show("请选择要删除的院系！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Delete_Node();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Current_page = 1;
            ShowMsg(Current_page);
        }

        private void btnUp_Click(object sender, EventArgs e)
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

        private void btnNext_Click(object sender, EventArgs e)
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

        private void btnLast_Click(object sender, EventArgs e)
        {
            Current_page = Count_page;
            ShowMsg(Current_page);
        }

        private void btnJump_Click(object sender, EventArgs e)
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

        private void Dept_Msg_Mag_Load(object sender, EventArgs e)
        {
            Lock_Control();
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

    }
}
