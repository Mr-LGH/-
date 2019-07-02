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
    public partial class Course_Msg_Mag : Form
    {
        public static int Current_Cno;
        public bool Edit_tag = false;               //当前是否为可编辑状态
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public int Cno_old;                 //编辑解锁时赋值
        public int Count_Zong_old;
        public int Count_Yu_old;
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        public Course_Msg_Mag()
        {
            InitializeComponent();
        }

        private void Search_required_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tag=Search_required.SelectedItem.ToString();
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

        private void cboRequited_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tag = cboRequited.SelectedItem.ToString();
            if (tag == "必修")
            {
                cboClass.Text = "";
                cboClass.Items.Clear();
                cboClass.Items.Add("专业必修");
                cboClass.Items.Add("公共必修");
            }
            else if (tag == "选修")
            {
                cboClass.Text = "";
                cboClass.Items.Clear();
                cboClass.Items.Add("专业选修");
                cboClass.Items.Add("公共选修");
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

        private void 课程管理_管理员_Load(object sender, EventArgs e)
        {
            Lock_Control();
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
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
                        sql = String.Format("select * from 课程信息管理 where 课程号='{0}' and 课程类别='{1}'", Cno,_class);
                        string sql_Num = String.Format("select count(*) from 课程信息管理 where 课程号='{0}' and 课程类别='{1}'", Cno, _class);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                    else
                    {
                        sql = String.Format("select * from 课程信息管理 where 课程类别='{0}'", _class);
                        string sql_Num = String.Format("select count(*) from 课程信息管理 where 课程类别='{0}'", _class);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                }
                else
                {
                    if (Cno != "")
                    {
                        sql = String.Format("select * from 课程信息管理 where 课程号='{0}' and 是否必修='{1}'", Cno, Requit);
                        string sql_Num = String.Format("select count(*) from 课程信息管理 where 课程号='{0}' and 是否必修='{1}'", Cno, Requit);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                    else
                    {
                        sql = String.Format("select * from 课程信息管理 where 是否必修='{0}'", Requit);
                        string sql_Num = String.Format("select count(*) from 课程信息管理 where 是否必修='{0}'", Requit);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                }
            }
            else
            {
                if (Cno != "")
                {
                    sql = String.Format("select * from 课程信息管理 where 课程号='{0}'", Cno);
                    string sql_Num = String.Format("select count(*) from 课程信息管理 where 课程号='{0}'", Cno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select * from 课程信息管理");
                    string sql_Num = String.Format("select count(*) from 课程信息管理");
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

        private void ShowInfo(int no)         //选中的课程号课程信息显示
        {
            string sql = String.Format("select * from 课程信息管理 where 课程号='{0}'", no);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    txtCno.Text = reader.GetInt32(0).ToString();
                    txtCname.Text = reader.GetString(1);
                    cboRequited.Text = reader.GetString(2);
                    cboClass.Text = reader.GetString(3);
                    num1.Value = reader.GetInt32(4);
                    num2.Value = reader.GetInt32(5);
                    num3.Value = reader.GetInt32(6);
                    num4.Value = reader.GetInt32(7);
                    num5.Value = reader.GetInt32(8);
                    Start_Course.Value = reader.GetDateTime(9);
                }
            }
            Cno_old = Convert.ToInt32(txtCno.Text);
            Current_Cno = Convert.ToInt32(txtCno.Text);
            Count_Zong_old = Convert.ToInt32(num4.Value);
            Count_Yu_old = Convert.ToInt32(num5.Value);
            Lock_Control();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Cno;
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                Cno = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);       //选中的课程号
                ShowInfo(Cno);
                btnUpdate.Enabled = true;
            }  
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            Lock_Remove();
        }

        private void clear_Info()                                   //清除课程信息界面
        {
            txtCno.Text = "";
            txtCname.Text = "";
            cboRequited.Text = "";
            cboClass.Text = "";
            num1.Value = 1;
            num2.Value = 32;
            num3.Value = 18;
            num4.Value = 0;
            num5.Value = 0;
            Start_Course.Text = "";
        }

        private void Update_Node()                                   //管理：更新
        {
            string Cname = txtCname.Text;
            int Cno =Convert.ToInt32(txtCno.Text);
            string Requited = cboRequited.SelectedItem.ToString();
            string _class = cboClass.SelectedItem.ToString();
            int n1=Convert.ToInt32(num1.Value);
            int n2=Convert.ToInt32(num2.Value);
            int n3=Convert.ToInt32(num3.Value);
            int n4=Convert.ToInt32(num4.Value);
            int x = n4-Count_Zong_old;
            int n5=Count_Yu_old+x;
            System.DateTime data1 = Start_Course.Value;
            string sql = String.Format("update 课程信息管理 set 课程号='{1}',课程名='{2}',是否必修='{3}',课程类别='{4}',学分='{5}',理论学时='{6}',实验学时='{7}',课容量='{8}',课余量='{9}',开课时间='{10}' where 课程号='{0}'", Cno_old, Cno, Cname, Requited, _class, n1,n2,n3,n4,n5,data1);
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
                    string sql = String.Format("select count(*) from 课程信息管理 where 课程号='{0}'", Cno);
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();            //打开数据库连接
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = (int)comm.ExecuteScalar();
                        if (n > 0)
                        {
                            MessageBox.Show("该课程号所代表的课程已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Creat_Node()                                   //管理：添加课程
        {
            string Cname = txtCname.Text;
            int Cno =Convert.ToInt32(txtCno.Text);
            string Requited = cboRequited.SelectedItem.ToString();
            string _class = cboClass.SelectedItem.ToString();
            int n1 = Convert.ToInt32(num1.Value);
            int n2 = Convert.ToInt32(num2.Value);
            int n3 = Convert.ToInt32(num3.Value);
            int n4 = Convert.ToInt32(num4.Value);
            int n5 = n4;                                            //课程刚创建时课余量等于课容量
            System.DateTime data1 = Start_Course.Value;
            string sql = String.Format("insert into 课程信息管理(课程号,课程名,是否必修,课程类别,学分,理论学时,实验学时,课容量,课余量,开课时间) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", Cno, Cname, Requited, _class, n1, n2, n3, n4, n5, data1);
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
                string sql = String.Format("select count(*) from 课程信息管理 where 课程号='{0}'", Cno);
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();            //打开数据库连接
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int n = (int)comm.ExecuteScalar();
                    if (n > 0)
                    {
                        MessageBox.Show("该课程号所代表的课程已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string sql = String.Format("delete from 课程信息管理 where 课程号='{0}'", Cno);
            DialogResult dr = MessageBox.Show("删除该课程信息？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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

        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            if (txtCno.Text == "")
            {
                MessageBox.Show("请选择要查看的课程！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Course_Student_Info frm = new Course_Student_Info();
                frm.Show();
            }
        }
    }
}
