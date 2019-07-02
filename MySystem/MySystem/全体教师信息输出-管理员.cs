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
    public partial class AllTeacherInfo : Form
    {
        public bool Edit_tag = false;               //当前是否为可编辑状态
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public int Tno_old;
        public string Dept_old;
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        public AllTeacherInfo()
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

        private void Add_Dept()                    //为复选框添加院系信息     
        {
            string dept;
            string sql = String.Format("select * from 院系信息");
            Search_dept.Items.Clear();
            T_dept.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    dept = reader.GetString(1);
                    Search_dept.Items.Add(dept);
                    T_dept.Items.Add(dept);
                }
            }
        }

        private void AllTeacherInfo_Load(object sender, EventArgs e)
        {
            Add_Dept();
            Lock_Control();
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

        private void SCount_Dept(string name, int i)                //+1
        {
            string sql = String.Format("update 院系信息 set 教师规模=教师规模+{0} where 院系名称='{1}'", i, name);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0) { }
            }
        }

        private string D_Search()               //判定搜索条件
        {
            string sql;
            string zhicheng = Search_zhicheng.Text;
            string dept = Search_dept.Text;
            string xuewei = Search_xuewei.Text;
            string Tno = Search_No.Text;
            if (dept != "")
            {
                if (zhicheng != "")
                {
                    if (xuewei != "")
                    {
                        if (Tno != "")
                        {
                            sql = String.Format("select * from 个人信息_教师 where 所属院系='{0}' and 学位='{1}' and 职称='{2}' and 编号='{3}'", dept, xuewei, zhicheng, Tno);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 所属院系='{0}' and 学位='{1}' and 职称='{2}' and 编号='{3}'", dept, xuewei, zhicheng, Tno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                        else
                        {
                            sql = String.Format("select * from 个人信息_教师 where 所属院系='{0}' and 学位='{1}' and 职称='{2}'", dept, xuewei, zhicheng);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 所属院系='{0}' and 学位='{1}' and 职称='{2}'", dept, xuewei, zhicheng);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                    }
                    else
                    {
                        if (Tno != "")
                        {
                            sql = String.Format("select * from 个人信息_教师 where 所属院系='{0}' and 职称='{1}' and 编号='{2}'", dept, zhicheng, Tno);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 所属院系='{0}' and 职称='{1}' and 编号='{2}'", dept, zhicheng, Tno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                        else
                        {
                            sql = String.Format("select * from 个人信息_教师 where 所属院系='{0}' and 职称='{1}'", dept, zhicheng);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 所属院系='{0}' and 职称='{1}'", dept, zhicheng);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                    }
                }
                else
                {
                    if (xuewei != "")
                    {
                        if (Tno != "")
                        {
                            sql = String.Format("select * from 个人信息_教师 where 所属院系='{0}' and 学位='{1}'and 编号='{2}'", dept, xuewei, Tno);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 所属院系='{0}' and 学位='{1}' and 编号='{2}'", dept, xuewei, Tno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                        else
                        {
                            sql = String.Format("select * from 个人信息_教师 where 所属院系='{0}' and 学位='{1}'", dept, xuewei);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 所属院系='{0}' and 学位='{1}'", dept, xuewei);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                    }
                    else
                    {
                        if (Tno != "")
                        {
                            sql = String.Format("select * from 个人信息_教师 where 所属院系='{0}' and 编号='{1}'", dept, Tno);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 所属院系='{0}' and 编号='{1}'", dept, Tno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                        else
                        {
                            sql = String.Format("select * from 个人信息_教师 where 所属院系='{0}'", dept);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 所属院系='{0}'", dept);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                    }
                }
            }
            else
            {
                if (zhicheng != "")
                {
                    if (xuewei != "")
                    {
                        if (Tno != "")
                        {
                            sql = String.Format("select * from 个人信息_教师 where 学位='{0}' and 职称='{1}' and 编号='{2}'", xuewei, zhicheng, Tno);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 学位='{0}' and 职称='{1}' and 编号='{2}'", xuewei, zhicheng, Tno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                        else
                        {
                            sql = String.Format("select * from 个人信息_教师 where 学位='{0}' and 职称='{1}'", xuewei, zhicheng);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 学位='{0}' and 职称='{1}'", xuewei, zhicheng);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                    }
                    else
                    {
                        if (Tno != "")
                        {
                            sql = String.Format("select * from 个人信息_教师 where 职称='{0}' and 编号='{1}'", zhicheng, Tno);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 职称='{0}' and 编号='{1}'", zhicheng, Tno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                        else
                        {
                            sql = String.Format("select * from 个人信息_教师 where 职称='{0}'", zhicheng);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 职称='{0}'", zhicheng);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                    }
                }
                else
                {
                    if (xuewei != "")
                    {
                        if (Tno != "")
                        {
                            sql = String.Format("select * from 个人信息_教师 where 学位='{0}'and 编号='{1}'", xuewei, Tno);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 学位='{0}' and 编号='{1}'", xuewei, Tno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                        else
                        {
                            sql = String.Format("select * from 个人信息_教师 where 学位='{0}'", xuewei);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 学位='{0}'", xuewei);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                    }
                    else
                    {
                        if (Tno != "")
                        {
                            sql = String.Format("select * from 个人信息_教师 where 编号='{0}'", Tno);
                            string sql_Num = String.Format("select count(*) from 个人信息_教师 where 编号='{0}'", Tno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                        else
                        {
                            sql = String.Format("select * from 个人信息_教师");
                            string sql_Num = String.Format("select count(*) from 个人信息_教师");
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                    }
                }
            }
        }

        private void ShowMsg(int i)             //显示第i页
        {
            int index;
            bool tag = false;
            string sql = D_Search();
            int x;
            if (Count_Node % 20 == 0)
                x = 0;
            else
                x = 1;
            Count_page = Count_Node / 20 + x;
            label19.Text = "总共" + Count_Node + "条记录，当前第" + Current_page + "页，共" + Count_page + "页，每页20条记录";
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
                    for (int k = ((i - 1) * 20 + 1); k <= i * 20; k++)
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

        private void Search_Class_name(string Cno)
        {
            string sql = String.Format("select * from 班级信息 where 班级编号='{0}'", Convert.ToInt32(Cno));
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())                              //学生已注册过
                {
                    T_class.Text = reader.GetString(1);
                }
            }
        }
        private void ShowInfo(int no)         //选中的编号教师信息显示
        {
            string sql = String.Format("select * from 个人信息_教师 where 编号='{0}'", no);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())                              //学生已注册过
                {
                    T_no.Text = reader.GetInt32(0).ToString();
                    T_name.Text = reader.GetString(1);
                    string sex = reader.GetString(2);
                    if (sex == "男")
                        rdoMale.Checked = true;
                    else
                        rdoFemale.Checked = true;
                    T_zhicheng.Text = reader.GetString(3);
                    T_xuewei.Text = reader.GetString(4);
                    T_Brithday.Value = reader.GetDateTime(5);
                    T_Year.Value = reader.GetInt32(6);
                    T_dept.Text = reader.GetString(7);
                    string C_no = reader.GetString(8);
                    if(C_no=="暂无")
                    {
                        T_class.Text = C_no;
                    }
                    else
                    {
                        Search_Class_name(C_no);
                    }
                }
            }
            Tno_old = Convert.ToInt32(T_no.Text);
            Dept_old = T_dept.Text;
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
            int Tno;
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                Tno = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);       //选中的编号
                ShowInfo(Tno);
            }
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            Lock_Remove();
        }

        private void clear_Info()                                   //清除信息界面
        {
            T_no.Text = "";
            T_name.Text = "";
            rdoMale.Checked = true;
            T_zhicheng.Text = "";
            T_xuewei.Text = "";
            T_Brithday.Text = "";
            T_dept.Text = "";
            T_Year.Value = 0;
            T_class.Text = "";
        }

        private void Update_Node()                                   //管理：更新
        {
            int Tno =Convert.ToInt32(T_no.Text);
            string Tname = T_name.Text;
            string sex;
            if (rdoMale.Checked)
                sex = rdoMale.Text;
            else
                sex = rdoFemale.Text;
            string Tzhicheng = T_zhicheng.SelectedItem.ToString();
            string Txuewei = T_xuewei.SelectedItem.ToString();
            string Tdept = T_dept.SelectedItem.ToString();
            int  _year=Convert.ToInt32(T_Year.Value);
            System.DateTime data = T_Brithday.Value;
            
            string sql = String.Format("update 个人信息_教师 set 编号='{0}',姓名='{1}',性别='{2}',职称='{3}',学位='{4}',出生日期='{5}',工作年月='{6}',所属院系='{7}' where 编号='{8}'", Tno, Tname, sex, Tzhicheng, Txuewei, data, _year, Tdept, Tno_old);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    
                    SCount_Dept(Dept_old, -1);          //修改院系教师规模
                    SCount_Dept(Tdept, 1);

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
                int Tno = Convert.ToInt32(T_no.Text);
                if (Tno == Tno_old)                    //学号未更改
                {
                    Update_Node();
                }
                else
                {
                    string sql = String.Format("select count(*) from 个人信息_教师 where 学号='{0}'", Tno);
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();            //打开数据库连接
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = (int)comm.ExecuteScalar();
                        if (n > 0)
                        {
                            MessageBox.Show("该编号所代表的教师已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            T_no.Focus();
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

        private void Creat_Node()                                   //管理：添加
        {
            int Tno = Convert.ToInt32(T_no.Text);
            string Tname = T_name.Text;
            string sex;
            if (rdoMale.Checked)
                sex = rdoMale.Text;
            else
                sex = rdoFemale.Text;
            string Tzhicheng = T_zhicheng.SelectedItem.ToString();
            string Txuewei = T_xuewei.SelectedItem.ToString();
            string Tdept = T_dept.SelectedItem.ToString();
            int _year = Convert.ToInt32(T_Year.Value);
            System.DateTime data = T_Brithday.Value;

            string sql = String.Format("insert into 个人信息_教师(编号,姓名,性别,职称,学位,出生日期,工作年月,所属院系,所带班级) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", Tno, Tname, sex, Tzhicheng, Txuewei, data, _year, Tdept,"暂无");
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    SCount_Dept(Tdept, 1);                  //该院系学生规模加1
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
                int Tno = Convert.ToInt32(T_no.Text);
                string sql = String.Format("select count(*) from 个人信息_教师 where 编号='{0}'", Tno);
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();            //打开数据库连接
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int n = (int)comm.ExecuteScalar();
                    if (n > 0)
                    {
                        MessageBox.Show("该编号所代表的教师已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        T_no.Focus();
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
            int no = Tno_old;
            string _dept = Dept_old;
            string sql = String.Format("delete from 个人信息_教师 where 编号='{0}'", no);
            DialogResult dr = MessageBox.Show("删除该教师信息？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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
                        SCount_Dept(_dept, -1);                  //该院系学生规模加1
                        //班级信息
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
            if (T_no.Text == "")
            {
                MessageBox.Show("请选择要删除的教师！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void T_dept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
