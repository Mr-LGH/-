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
    public partial class UserLoginInfoMag : Form
    {
        public bool Edit_tag = false;               //当前是否为可编辑状态
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public string Cno_old="";                 //编辑解锁时赋值
        public string Old_class;               //权限类别
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

        private string D_Search()               //判定搜索条件
        {
            string sql;
            string _class = Search_class.Text;
            string no = SearchNo.Text;
            if (_class != "")
            {
                if (no != "")
                {
                    sql = String.Format("select * from [User] where 用户权限='{0}' and 用户ID='{1}'",_class, no);
                    string sql_Num = String.Format("select count(*) from [User] where 用户权限='{0}' and 用户ID='{1}'", _class, no);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select * from [User] where 用户权限='{0}'", _class);
                    string sql_Num = String.Format("select count(*) from [User] where 用户权限='{0}'", _class);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
            }
            else
            {
                if (no != "")
                {
                    sql = String.Format("select * from [User] where 用户权限='学生' or 用户权限='教师' and 用户ID='{0}'", no);
                    string sql_Num = String.Format("select count(*) from [User] where 用户ID='{0}'", no);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select * from [User] where 用户权限='学生' or 用户权限='教师'");
                    string sql_Num = String.Format("select count(*) from [User] where 用户权限='学生' or 用户权限='教师'");
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
                            dataGridView1.Rows[index].Cells[5].Value = reader.GetBoolean(5);
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

        private void Update_Node()                                   //管理：更新
        {
            bool ftag = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    string name = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string Pwd = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string id = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    Boolean flag = Convert.ToBoolean(dataGridView1.Rows[i].Cells[5].Value);
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("数据不能为空", "数据格式错误！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows[i].Selected = true;
                    ftag = true;
                }
            }

            if (!ftag)
            {
                bool tag = true;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    int no = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    string name = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string Pwd = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string id = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    Boolean flag = Convert.ToBoolean(dataGridView1.Rows[i].Cells[5].Value);
                    string sql = String.Format("update [User] set 用户名='{1}',用户密码='{2}',用户权限='{3}',身份验证='{4}' where 用户ID='{0}'", no, name, Pwd, id, flag);
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
                            tag = false;
                            break;
                        }
                    }
                }
                if (tag)
                {
                    MessageBox.Show("更新成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowMsg(Current_page);
                }
                else
                {
                    MessageBox.Show("更新失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public UserLoginInfoMag()
        {
            InitializeComponent();
        }

        private void UserLoginInfoMag_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("更新当前页所有修改数据？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.OK)
            {
                Update_Node();
            }
            
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("取消当前页所有更新操作？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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

        private void Delete_Node()
        {
            string sql = String.Format("delete from [User] where 用户ID='{0}' and 用户权限='{1}'", Cno_old,Old_class);
            DialogResult dr = MessageBox.Show("删除该用户登录信息？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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
                        ShowMsg(Current_page);
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                Cno_old = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();       //选中的ID、权限
                Old_class = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();       
            }  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Cno_old == "")
            {
                MessageBox.Show("请选择要删除的用户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
