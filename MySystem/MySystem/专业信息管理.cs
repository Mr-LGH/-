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
    public partial class Spec_Msg_Mag : Form
    {
        public bool Edit_tag = false;               //当前是否为可编辑状态
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public int Sno_old;                 //编辑解锁时赋值
        public int Count;                   //修改涉及的学生人数
        public string Dept_old;             //修改前所属院系
        public string Sname_old;            //修改前专业名称

        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";

        public Spec_Msg_Mag()
        {
            InitializeComponent();
        }

        private void 专业信息管理_Load(object sender, EventArgs e)
        {
            Add_Dept();
            Lock_Control();
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
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

        private void Add_Dept()                    //为复选框添加院系信息     
        {
            string dept;
            string sql = String.Format("select * from 院系信息");
            SearchDept.Items.Clear();
            cboSdept.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    dept = reader.GetString(1);
                    cboSdept.Items.Add(dept);
                    SearchDept.Items.Add(dept);
                }
            }
        }

        private void Lock_Control()             //锁定控件
        {
            txtSno.ReadOnly = true;
            txtSname.ReadOnly = true;
            txtSInfo.ReadOnly = true;
            NumYear.ReadOnly = true;
            Edit_tag = false;
            btnEditor.Enabled = true;
        }
        private void Lock_Remove()             //解除控件锁定
        {
            txtSno.ReadOnly = false;
            txtSname.ReadOnly = false;
            txtSInfo.ReadOnly = false;
            NumYear.ReadOnly = false;
            Edit_tag = true;
            btnEditor.Enabled = false;
        }

        private string D_Search()               //判定搜索条件
        {
            string sql;
            string dept = SearchDept.Text;
            
            string Sno = SearchNo.Text;
            if (dept != "")
            {
                if (Sno != "")
                {
                    sql = String.Format("select * from 专业信息 where 专业编号='{0}' and 所属院系='{1}'", Sno,dept);
                    string sql_Num = String.Format("select count(*) from 专业信息 where 专业编号='{0}'", Sno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select * from 专业信息 where 所属院系='{0}'", dept);
                    string sql_Num = String.Format("select count(*) from 专业信息 where 所属院系='{0}'", dept);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
            }
            else
            {
                if (Sno != "")
                {
                    sql = String.Format("select * from 专业信息 where 专业编号='{0}'", Sno);
                    string sql_Num = String.Format("select count(*) from 专业信息 where 专业编号='{0}'", Sno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select * from 专业信息");
                    string sql_Num = String.Format("select count(*) from 专业信息");
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

        private void ShowInfo(int no)         //选中的专业号专业信息显示
        {
            string sql = String.Format("select * from 专业信息 where 专业编号='{0}'", no);
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
                    NumYear.Value = reader.GetInt32(4);
                    txtSInfo.Text = reader.GetString(5);
                }
            }

            Sno_old = Convert.ToInt32(txtSno.Text);
            Dept_old = cboSdept.Text;
            Sname_old = txtSname.Text;

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
                Dno = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);       //选中的专业编号
                ShowInfo(Dno);
            }
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            Lock_Remove();
        }

        private void clear_Info()                                   //清除院系信息界面
        {
            txtSname.Text = "";
            txtSno.Text = "";
            txtSsnum.Text = "";
            cboSdept.Text = "";
            NumYear.Value = 1800;
            txtSInfo.Text = "";
        }

        private string Dept_spec(string d)                  //获取当前院系d所设专业信息
        {
            string dept_spec = "";
            string sql = String.Format("select * from 院系信息 where 院系名称='{0}'", d);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    dept_spec = reader.GetString(5);
                }
            }
            return dept_spec;
        }
        private void UpDate_Dept_spec(string d, string s)  //院系d所设专业信息更新
        {
            string sql = String.Format("update 院系信息 set 所设专业='{0}'where 院系名称='{1}'", s, d);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
            }
        }

        private void spec_name_update(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                Count = n;
            }
        }
        private void SCount_Dept(string name, int i)                //
        {
            string sql = String.Format("update 院系信息 set 学生规模=学生规模+{0} where 院系名称='{1}'", i, name);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0) { }
            }
        }
        private void Update_Node()                                   //管理：更新
        {
            string Sname = txtSname.Text;
            string Sno = txtSno.Text;
            string SInfo = txtSInfo.Text;
            int year = Convert.ToInt32(NumYear.Value);
            string Sdept = cboSdept.Text;


            string sql = String.Format("update 专业信息 set 专业编号='{1}',专业名称='{2}',所属院系='{3}',创办年份='{4}',专业特色='{5}' where 专业编号='{0}'", Sno_old, Sno, Sname, Sdept,year,SInfo);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    if(Sdept==Dept_old)
                    {
                        string sql_class = String.Format("update 班级信息 set 所属专业='{1}' where 所属专业='{0}'", Sname_old, Sname);
                        string sql_student = String.Format("update 学籍信息_学生 set 专业='{1}' where 专业='{0}'", Sname_old, Sname);
                        //同步更新该专业相关的专业、班级、学生信息
                        spec_name_update(sql_class);
                        spec_name_update(sql_student); 
                        string spec = Dept_spec(Dept_old);
                        spec = spec.Replace(Sname_old + "、", Sname + "、");
                        UpDate_Dept_spec(Dept_old, spec);
                    }
                    else
                    {

                        string sql_class = String.Format("update 班级信息 set 所属专业='{2}',所属院系='{3}' where 所属专业='{0}' and 所属院系='{1}", Sname_old,Dept_old, Sname,Sdept);
                        string sql_student = String.Format("update 学籍信息_学生 set 专业='{2}',所属院系='{3}' where 专业='{0}' and 所属院系='{1}", Sname_old, Dept_old, Sname, Sdept);
                        //同步更新该专业相关的班级、学生信息
                        spec_name_update(sql_class);
                        spec_name_update(sql_student);
                        //同步更新院系学生规模
                        SCount_Dept(Dept_old, -Count);
                        SCount_Dept(Sdept, Count);

                        string spec = Dept_spec(Dept_old);
                        spec = spec.Replace(Sname_old + "、", "");
                        UpDate_Dept_spec(Dept_old, spec);

                        spec = Dept_spec(Sdept);
                        spec = spec + Sname + "、";
                        UpDate_Dept_spec(Sdept, spec);
                    }
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
                int Sno = Convert.ToInt32(txtSno.Text);
                if (Sno == Sno_old)                    //学号未更改
                {
                    Update_Node();
                }
                else
                {
                    string sql = String.Format("select count(*) from 专业信息 where 专业编号='{0}'", Sno);
                    dataGridView1.Rows.Clear();
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();            //打开数据库连接
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = (int)comm.ExecuteScalar();
                        if (n > 0)
                        {
                            MessageBox.Show("该编号所代表的专业已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSno.Focus();
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

        private void Creat_Node()                                   //管理：添加专业
        {
            string Sname = txtSname.Text;
            string Sno = txtSno.Text;
            string SInfo = txtSInfo.Text;
            int year = Convert.ToInt32(NumYear.Value);
            string Sdept = cboSdept.Text;

            string sql = String.Format("insert into 专业信息(专业编号,专业名称,所属院系,学生规模,创办年份,专业特色) values('{0}','{1}','{2}','{3}','{4}','{5}')", Sno, Sname, Sdept, 0, year, SInfo);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    string spec = Dept_spec(Sdept) + Sname + "、";
                    UpDate_Dept_spec(Sdept, spec);          //将新添加的专业加入所属院系专业中
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
                int Sno = Convert.ToInt32(txtSno.Text);
                string sql = String.Format("select count(*) from 专业信息 where 专业编号='{0}'", Sno);
                dataGridView1.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();            //打开数据库连接
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int n = (int)comm.ExecuteScalar();
                    if (n > 0)
                    {
                        MessageBox.Show("该专业编号所代表的专业已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSno.Focus();
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

        private void Delete_Node()                                  //管理：删除专业
        {
            int Sno = Sno_old;
            string sql = String.Format("delete from 专业信息 where 专业编号='{0}'", Sno);
            DialogResult dr = MessageBox.Show("删除“" + txtSname.Text + "专业”信息？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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
                        string spec = Dept_spec(Dept_old);
                        spec = spec.Replace(Sname_old + "、", "");
                        UpDate_Dept_spec(Dept_old, spec);

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
            if (txtSno.Text == "")
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


    }
}
