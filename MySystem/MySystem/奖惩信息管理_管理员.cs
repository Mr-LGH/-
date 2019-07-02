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
    public partial class JC_Msg_Mag : Form
    {
        public bool Edit_tag = false;               //当前是否为可编辑状态
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页
        public int ID_old;                 //编辑解锁时赋值
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        public JC_Msg_Mag()
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

        private void cboJC_tag_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Jc_tag = cboJC_tag.SelectedItem.ToString();
            if(Jc_tag=="奖")
            {
                cboClass_Tag.Text = "";
                cboClass_Tag.Items.Clear();
                cboClass_Tag.Items.Add("院级");
                cboClass_Tag.Items.Add("校级");
                cboClass_Tag.Items.Add("省级");
                cboClass_Tag.Items.Add("国家级");
                
            }
            else if(Jc_tag=="惩")
            {
                cboClass_Tag.Text = "";
                cboClass_Tag.Items.Clear();
                cboClass_Tag.Items.Add("警告");
                cboClass_Tag.Items.Add("记过");
                cboClass_Tag.Items.Add("记大过");
                cboClass_Tag.Items.Add("留校察看");
                cboClass_Tag.Items.Add("开除");
            }
        }

        private void 奖惩信息管理_管理员_Load(object sender, EventArgs e)
        {
            Lock_Control();
            cboClass.Text = "";
            cboClass.Items.Clear();
            cboClass.Items.Add("院级");
            cboClass.Items.Add("校级");
            cboClass.Items.Add("省级");
            cboClass.Items.Add("国家级");
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

        private string D_Search()               //判定搜索条件
        {
            string sql;
            string Jc_tag = cboJC_tag.Text;
            string Jc_Class = cboClass_Tag.Text;
            string Cno = SearchNo.Text;
            if (Jc_tag != "")
            {
                if (Jc_Class != "")
                {
                    if (Cno != "")
                    {
                        sql = String.Format("select * from 奖惩信息_学生 where 学号='{0}' and 奖惩类别='{1}'", Cno,Jc_Class);
                        string sql_Num = String.Format("select count(*) from 奖惩信息_学生 where 学号='{0}' and 奖惩类别='{1}'", Cno, Jc_Class);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                    else
                    {
                        sql = String.Format("select * from 奖惩信息_学生 where 奖惩类别='{0}'", Jc_Class);
                        string sql_Num = String.Format("select count(*) from 奖惩信息_学生 where 奖惩类别='{0}'", Jc_Class);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                }
                else
                {
                    if (Cno != "")
                    {
                        sql = String.Format("select * from 奖惩信息_学生 where 学号='{0}' and 奖或惩='{1}'", Cno, Jc_tag);
                        string sql_Num = String.Format("select count(*) from 奖惩信息_学生 where 学号='{0}' and 奖或惩='{1}'", Cno, Jc_tag);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                    else
                    {
                        sql = String.Format("select * from 奖惩信息_学生 where 奖或惩='{0}'", Jc_tag);
                        string sql_Num = String.Format("select count(*) from 奖惩信息_学生 where 奖或惩='{0}'", Jc_tag);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                }
            }
            else
            {
                if (Cno != "")
                {
                    sql = String.Format("select * from 奖惩信息_学生 where 学号='{0}'", Cno);
                    string sql_Num = String.Format("select count(*) from 奖惩信息_学生 where 学号='{0}'", Cno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select * from 奖惩信息_学生");
                    string sql_Num = String.Format("select count(*) from 奖惩信息_学生");
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
                            dataGridView1.Rows[index].Cells[1].Value = reader.GetDateTime(1);
                            dataGridView1.Rows[index].Cells[2].Value = reader.GetString(2);
                            dataGridView1.Rows[index].Cells[3].Value = reader.GetString(3);
                            dataGridView1.Rows[index].Cells[4].Value = reader.GetString(4);
                            dataGridView1.Rows[index].Cells[5].Value = reader.GetString(5);
                            dataGridView1.Rows[index].Cells[6].Value = reader.GetInt32(6);
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
            groupBox7.Enabled = false;
            Edit_tag = false;
            btnEditor.Enabled = true;
        }
        private void Lock_Remove()             //解除控件锁定
        {
            groupBox7.Enabled = true;
            Edit_tag = true;
            btnEditor.Enabled = false;
        }


        private void ShowInfo(int no)         //选中的班级号班级信息显示
        {
            string sql = String.Format("select * from 奖惩信息_学生 where ID='{0}'", no);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {

                    txtSno.Text = reader.GetInt32(0).ToString();
                    JcData.Value = reader.GetDateTime(1);
                    cboClass.Text = reader.GetString(2);
                    rtbCause.Text = reader.GetString(3);
                    string Jc_tag = reader.GetString(4);
                    if (Jc_tag == "奖")
                        rdoJiang.Checked = true;
                    else
                        rdoCheng.Checked = true;
                    rtbRemark.Text = reader.GetString(5);
                    ID_old = reader.GetInt32(6);
                }
            }
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
            int ID;
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);       //选中的班级号
                ShowInfo(ID);
            }
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            Lock_Remove();
        }

        private void clear_Info()                                   //清除奖惩信息界面
        {
            JcData.Text = "";
            txtSno.Text = "";
            cboClass.Text = "";
            rtbCause.Text = "";
            rtbRemark.Text = "";
            rdoJiang.Checked = true;
        }

        private bool Sno_Exist()                                    //判断学号所代表的学生是否存在
        {
            int Sno =Convert.ToInt32(txtSno.Text);
            string sql = String.Format("select count(*) from 学籍信息_学生 where 学号='{0}'", Sno);
            dataGridView1.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = (int)comm.ExecuteScalar();
                if (n > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void Update_Node()                                   //管理：更新
        {
            string Jc_tag = "";
            if (rdoJiang.Checked)
                Jc_tag = "奖";
            else
                Jc_tag = "惩";
            string Sno = txtSno.Text;
            System.DateTime data = JcData.Value;
            string Class = cboClass.SelectedItem.ToString();
            string Cause = rtbCause.Text;
            string Remake = rtbRemark.Text;
            string sql = String.Format("update 奖惩信息_学生 set 学号='{1}',奖惩日期='{2}',奖惩类别='{3}',奖惩原因='{4}',奖或惩='{5}',备注='{6}' where ID='{0}'", ID_old, Sno, data, Class, Cause, Jc_tag, Remake);
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
                if (Sno_Exist())
                {
                    Update_Node();
                    txtSno.Focus();
                }
                else
                {
                    MessageBox.Show("该学号所代表的学生不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("当前为不可编辑状态！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Creat_Node()                                   //管理：添加班级
        {
            string Jc_tag = "";
            if (rdoJiang.Checked)
                Jc_tag = "奖";
            else
                Jc_tag = "惩";
            string Sno = txtSno.Text;
            System.DateTime data = JcData.Value;
            string Class = cboClass.SelectedItem.ToString();
            string Cause = rtbCause.Text;
            string Remake = rtbRemark.Text;

            string sql = String.Format("insert into 奖惩信息_学生(学号,奖惩日期,奖惩类别,奖惩原因,奖或惩,备注) values('{0}','{1}','{2}','{3}','{4}','{5}')", Sno, data, Class, Cause, Jc_tag, Remake);
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
                if (Sno_Exist())
                {
                    Creat_Node();
                }
                else
                {
                    MessageBox.Show("该学号所代表的学生不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSno.Focus();
                }
            }
            else
            {
                MessageBox.Show("当前为不可编辑状态！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Delete_Node()
        {
            int no = ID_old;
            string sql = String.Format("delete from 奖惩信息_学生 where ID='{0}'", no);
            DialogResult dr = MessageBox.Show("删除该条奖惩信息？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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
            if (txtSno.Text == "")
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

        private void rdoJiang_Click(object sender, EventArgs e)
        {
            cboClass.Text = "";
            cboClass.Items.Clear();
            cboClass.Items.Add("院级");
            cboClass.Items.Add("校级");
            cboClass.Items.Add("省级");
            cboClass.Items.Add("国家级");
        }

        private void rdoCheng_Click(object sender, EventArgs e)
        {
            cboClass.Text = "";
            cboClass.Items.Clear();
            cboClass.Items.Add("警告");
            cboClass.Items.Add("记过");
            cboClass.Items.Add("记大过");
            cboClass.Items.Add("留校察看");
            cboClass.Items.Add("开除");
        }


    }
}
