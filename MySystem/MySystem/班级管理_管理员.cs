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
    public partial class ClassMagFrm : Form
    {
        public bool Edit_tag=false;               //当前是否为可编辑状态
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public int Cno_old;                 //编辑解锁时赋值
        public int Count;                   //修改设计的学生人数
        public string Cclass_old;
        public string Cdept_old;
        public string Cspec_old;
        public string Tno_old;
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
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
        public ClassMagFrm()
        {
            InitializeComponent();
        }
        private void Add_Dept()                    //为复选框添加院系信息     
        {
            string dept;
            string sql = String.Format("select * from 院系信息");
            SearchDept.Items.Clear();
            cboDept.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    dept = reader.GetString(1);
                    cboDept.Items.Add(dept);
                    SearchDept.Items.Add(dept);
                }
            }
        }
        private void ClassMagFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
            Add_Dept();
            Lock_Control();
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)//为班级信息栏复选框添加专业信息
        {
            cboSpec.Text = "";
            string spec;
            string dept = cboDept.SelectedItem.ToString();
            string sql = String.Format("select * from 专业信息 where 所属院系='{0}'", dept);
            cboSpec.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    spec = reader.GetString(1);
                    cboSpec.Items.Add(spec);
                }
            }
            
        }
        private void Teacher_change()
        {
            string sql = String.Format("select * from 个人信息_教师 where 所带班级='暂无'");
            txtCteacher.Text = "";
            txtCteacher.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    string teacher = reader.GetInt32(0).ToString();
                    txtCteacher.Items.Add(teacher);
                }
            }
        }
        private void SearchDept_SelectedIndexChanged(object sender, EventArgs e)        //为查询栏复选框添加专业信息
        {
            SearchSpec.Text = "";
            string spec;
            string dept = SearchDept.SelectedItem.ToString();
            string sql = String.Format("select * from 专业信息 where 所属院系='{0}'", dept);
            SearchSpec.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    spec = reader.GetString(1);
                    SearchSpec.Items.Add(spec);
                }
            }
        }

        private string D_Search()               //判定搜索条件
        {
            string sql;
            string dept=SearchDept.Text;
            string spec=SearchSpec.Text;
            string Cno=SearchNo.Text;
            if(dept!="")
            {
                if(spec!="")
                {
                    if(Cno!="")
                    {
                        sql = String.Format("select * from 班级信息 where 班级编号='{0}'", Cno);
                        string sql_Num = String.Format("select count(*) from 班级信息 where 班级编号='{0}'", Cno);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                    else
                    {
                        sql = String.Format("select * from 班级信息 where 所属专业='{0}'", spec);
                        string sql_Num = String.Format("select count(*) from 班级信息 where 所属专业='{0}'", spec);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                }
                else
                {
                    if (Cno != "")
                    {
                        sql = String.Format("select * from 班级信息 where 班级编号='{0}'", Cno);
                        string sql_Num = String.Format("select count(*) from 班级信息 where 班级编号='{0}'", Cno);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                    else
                    {
                        sql = String.Format("select * from 班级信息 where 所属院系='{0}'", dept);
                        string sql_Num = String.Format("select count(*) from 班级信息 where 所属院系='{0}'", dept);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                }
            }
            else
            {
                if (Cno != "")
                {
                    sql = String.Format("select * from 班级信息 where 班级编号='{0}'", Cno);
                    string sql_Num = String.Format("select count(*) from 班级信息 where 班级编号='{0}'", Cno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select * from 班级信息");
                    string sql_Num = String.Format("select count(*) from 班级信息");
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
            Teacher_change();
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
        
        private void Lock_Control()             //锁定控件
        {
            groupBox4.Enabled = false;
            Edit_tag = false;
            btnEditor.Enabled = true; 
        }
        private void Lock_Remove()             //解除控件锁定
        {
            groupBox4.Enabled = true;
            Edit_tag = true;
            btnEditor.Enabled = false;
        }

        private void ShowInfo(int no)         //选中的班级号班级信息显示
        {
            string sql = String.Format("select * from 班级信息 where 班级编号='{0}'", no);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if(reader.Read())
                {
                    txtCno.Text = reader.GetInt32(0).ToString();
                    txtCname.Text=reader.GetString(1);
                    cboDept.Text = reader.GetString(2);
                    cboSpec.Text = reader.GetString(3);
                    txtCteacher.Text = reader.GetString(4);
                    txtNum.Text = reader.GetInt32(5).ToString();
                }
            }
            Cno_old = Convert.ToInt32(txtCno.Text);
            Cdept_old = cboDept.Text;
            Cspec_old = cboSpec.Text;
            Cclass_old = txtCname.Text;
            Tno_old = txtCteacher.Text;
            Lock_Control();
        }
        private void btnDisplay_Click(object sender, EventArgs e)   //显示第一页
        {
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)    //判定选中的表中单元格
        {
            int Cno;
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                Cno = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);       //选中的班级号
                ShowInfo(Cno);
            }  
        }

        private void btnEditor_Click(object sender, EventArgs e)      //管理：编辑
        {
            Lock_Remove();
        }

        private void clear_Info()                                   //清除班级信息界面
        {
            txtCname.Text = "";
            txtCno.Text = "";
            txtNum.Text = "";
            txtCteacher.Text = "";
            cboDept.Text = "";
            cboSpec.Text = "";
        }

        private void class_name_update(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                Count = n;
            }
        }
        private void SCount_Dept(string name, int i)               
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
        private void T_NO_Update(string Tno, string _Cno)
        {
            string sql = String.Format("update 个人信息_教师 set 所带班级='{1}' where 编号='{0}'", Tno, _Cno);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
            }
        }
        
        private void Update_Node()                                   //管理：更新
        {
            string Cname = txtCname.Text;
            int Cno =Convert.ToInt32(txtCno.Text);
            string Cdept = cboDept.SelectedItem.ToString();
            string Cspec=cboSpec.SelectedItem.ToString();
            string Cteacher = txtCteacher.Text;
            string sql = String.Format("update 班级信息 set 班级编号='{1}',班级名称='{2}',所属院系='{3}',所属专业='{4}',带班教师='{5}' where 班级编号='{0}'", Cno_old, Cno, Cname, Cdept, Cspec,Cteacher);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    string sql_student = String.Format("update 学籍信息_学生 set 专业='{3}',院系='{4}',班级='{5}' where 专业='{0}' and 院系='{1}' and 班级='{2}'", Cspec_old,Cdept_old,Cclass_old,Cspec,Cdept,Cname);
                    //同步更新该专业相关的学生信息
                    class_name_update(sql_student);
                    //同步更新院系学生规模
                    SCount_Dept(Cdept_old, -Count);
                    SCount_Dept(Cdept, Count);
                    SCount_Dept(Cspec_old, -Count);
                    SCount_Dept(Cspec, Count);
                    if (Cteacher==Tno_old)          //带班教师没换
                    {
                        T_NO_Update(Cteacher, Cno.ToString());
                    }
                    else
                    {
                        T_NO_Update(Tno_old, "暂无");
                        T_NO_Update(Cteacher, Cno.ToString());
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
        private void btnUpdate_Click(object sender, EventArgs e)    //管理：更新
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
                    string sql = String.Format("select count(*) from 班级信息 where 班级编号='{0}'", Cno);
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();            //打开数据库连接
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = (int)comm.ExecuteScalar();
                        if (n > 0)
                        {
                            MessageBox.Show("该班级编号所代表的班级已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string Cno = txtCno.Text;
            string Cdept = cboDept.Text;
            string Cspec = cboSpec.Text;
            string Cteacher = txtCteacher.Text;
            string sql = String.Format("insert into 班级信息(班级编号,班级名称,所属院系,所属专业,带班教师,班级人数) values('{0}','{1}','{2}','{3}','{4}','{5}')", Cno, Cname, Cdept, Cspec, Cteacher,0);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    T_NO_Update(Cteacher, Cno);
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
                string sql = String.Format("select count(*) from 班级信息 where 班级编号='{0}'", Cno);
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();            //打开数据库连接
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int n = (int)comm.ExecuteScalar();
                    if (n > 0)
                    {
                        MessageBox.Show("该班级编号所代表的班级已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string Tno = Tno_old;
            string sql= String.Format("delete from 班级信息 where 班级编号='{0}'", Cno);
            DialogResult dr = MessageBox.Show("删除该班级信息？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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
                        T_NO_Update(Tno, "暂无");
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
            if(txtCno.Text=="")
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
            if(Current_page==1)
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
