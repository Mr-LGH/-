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
    public partial class AllStudentInfo : Form
    {
        public bool Edit_tag = false;               //当前是否为可编辑状态
        public int Count_Node;              //总记录数
        public int Count_page;              //总页数
        public int Current_page;            //当前页

        public int Sno_old;                 //编辑解锁时赋值，记录修改前的学号、专业、院系信息
        public string Class_old;
        public string Spec_old;                
        public string Dept_old;
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";

        public AllStudentInfo()
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
            Stu_Dept.Items.Clear();
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
                    Stu_Dept.Items.Add(dept);
                }
            }
        }

        private void AllStudentInfo_Load(object sender, EventArgs e)
        {
            Add_Dept();
            Lock_Control();
            dataGridView1.AllowUserToAddRows = false;
            Current_page = 1;
            ShowMsg(Current_page);
        }

        private void Stu_Dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            string spec;
            string dept = Stu_Dept.SelectedItem.ToString();
            string sql = String.Format("select * from 专业信息 where 所属院系='{0}'", dept);
            Stu_Spec.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    spec = reader.GetString(1);
                    Stu_Spec.Items.Add(spec);
                }
            }
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            string spec="";
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

        private void cboSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _class = "";
            string spec = cboSpec.SelectedItem.ToString();
            string sql = String.Format("select * from 班级信息 where 所属专业='{0}'", spec);
            cboClass.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    _class= reader.GetString(1);
                    cboClass.Items.Add(_class);
                }
            }
        }

        private void Stu_Spec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _class = "";
            string spec = Stu_Spec.SelectedItem.ToString();
            string sql = String.Format("select * from 班级信息 where 所属专业='{0}'", spec);
            Stu_Class.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    _class = reader.GetString(1);
                    Stu_Class.Items.Add(_class);
                }
            }
        }

        private void SCount_Dept(string name, int i)                //+1
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
        private void SCount_Spec(string name, int i)                //+1
        {
            string sql = String.Format("update 专业信息 set 学生规模=学生规模+{0} where 专业名称='{1}'", i, name);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0) { }
            }
        }

        private void SCount_Class(string Sname, string Cname, int i)          //更新班级人数
        {
            string sql = String.Format("update 班级信息 set 班级人数=班级人数+{0} where 所属专业='{1}' and 班级名称='{2}'", i, Sname, Cname);
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
            string dept = Stu_Dept.Text;
            string spec = Stu_Spec.Text;
            string _class = Stu_Class.Text;
            string Sno = Stu_No.Text;
            if (dept != "")
            {
                if (spec != "")
                {
                    if (_class != "")
                    {
                        if (Sno != "")
                        {
                            sql = String.Format("select * from 学籍信息_学生 where 院系='{0}' and 专业='{1}' and 班级='{2}' and 学号='{3}'",dept,spec,_class, Sno);
                            string sql_Num = String.Format("select count(*) from 学籍信息_学生 where 院系='{0}' and 专业='{1}' and 班级='{2}' and 学号='{3}'", dept, spec, _class, Sno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                        else
                        {
                            sql = String.Format("select * from 学籍信息_学生 where 院系='{0}' and 专业='{1}' and 班级='{2}'", dept, spec, _class);
                            string sql_Num = String.Format("select count(*) from 学籍信息_学生 where 院系='{0}' and 专业='{1}' and 班级='{2}'", dept, spec, _class);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                    }
                    else
                    {
                        if (Sno != "")
                        {
                            sql = String.Format("select * from 学籍信息_学生 where 院系='{0}' and 专业='{1}' and 学号='{2}'",dept,spec,Sno);
                            string sql_Num = String.Format("select count(*) from 学籍信息_学生 where 院系='{0}' and 专业='{1}' and 学号='{2}'", dept, spec, Sno);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                        else
                        {
                            sql = String.Format("select * from 学籍信息_学生 where 院系='{0}' and 专业='{1}'", dept, spec);
                            string sql_Num = String.Format("select count(*) from 学籍信息_学生 where 院系='{0}' and 专业='{1}'", dept, spec);
                            Count_Node = _Count(sql_Num);
                            return sql;
                        }
                    }
                }
                else
                {
                    if (Sno != "")
                    {
                        sql = String.Format("select * from 学籍信息_学生 where 院系='{0}' and 学号='{1}'", dept,Sno);
                        string sql_Num = String.Format("select count(*) from 学籍信息_学生 where 院系='{0}' and 学号='{1}'", dept, Sno);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                    else
                    {
                        sql = String.Format("select * from 学籍信息_学生 where 院系='{0}'", dept);
                        string sql_Num = String.Format("select count(*) from 学籍信息_学生 where 院系='{0}'", dept);
                        Count_Node = _Count(sql_Num);
                        return sql;
                    }
                }
            }
            else
            {
                if (Sno != "")
                {
                    sql = String.Format("select * from 学籍信息_学生 where 学号='{0}'", Sno);
                    string sql_Num = String.Format("select count(*) from 学籍信息_学生 where 学号='{0}'", Sno);
                    Count_Node = _Count(sql_Num);
                    return sql;
                }
                else
                {
                    sql = String.Format("select * from 学籍信息_学生");
                    string sql_Num = String.Format("select count(*) from 学籍信息_学生");
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
                    string sex = reader.GetString(2);
                    if (sex == "男")
                        rdoMale.Checked = true;
                    else
                        rdoFemale.Checked = true;
                    Apartment.Text = reader.GetString(3);
                    Phone.Text = reader.GetString(4);
                    dateEntry.Value = reader.GetDateTime(5);
                    txtBrithday.Value = reader.GetDateTime(6);
                    cboClass.Text = reader.GetString(7);
                    cboDept.Text = reader.GetString(8);
                    cboSpec.Text = reader.GetString(9);
                    string[] hobbies = new string[6];
                    hobbies = reader.GetString(10).Split('、');     //用‘、’分解爱好
                    checkBox1.Checked = false; checkBox2.Checked = false;
                    checkBox3.Checked = false; checkBox4.Checked = false;
                    checkBox5.Checked = false; checkBox6.Checked = false;
                    foreach (string s in hobbies)
                    {
                        switch (s)
                        {
                            case "阅读": checkBox1.Checked = true; break;
                            case "体育": checkBox2.Checked = true; break;
                            case "音乐": checkBox3.Checked = true; break;
                            case "上网": checkBox4.Checked = true; break;
                            case "旅游": checkBox5.Checked = true; break;
                            case "其他": checkBox6.Checked = true; break;
                        }
                    }
                }
            }
            Sno_old = Convert.ToInt32(txtSno.Text);
            Class_old = cboClass.Text;
            Spec_old = cboSpec.Text;
            Dept_old = cboDept.Text;
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
            int Sno;
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                Sno = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);       //选中的学号
                ShowInfo(Sno);
            }
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            Lock_Remove();
        }

        private void clear_Info()                                   //清除学籍信息界面
        {
            txtSno.Text = "";
            txtSname.Text = "";          
            rdoMale.Checked = true;
            Apartment.Text = "";
            Phone.Text = "";
            dateEntry.Text = "";
            txtBrithday.Text = "";
            cboClass.Text = "";
            cboDept.Text = "";
            cboSpec.Text = "";
            checkBox1.Checked = false; 
            checkBox2.Checked = false;
            checkBox3.Checked = false; 
            checkBox4.Checked = false;
            checkBox5.Checked = false; 
            checkBox6.Checked = false;
        }

        private void Update_Node()                                   //管理：更新
        {
            int Sno=Convert.ToInt32(txtSno.Text);
            string name = txtSname.Text;
            string sex;
            if (rdoMale.Checked)
                sex = rdoMale.Text;
            else
                sex = rdoFemale.Text;
            string address = Apartment.Text;
            string phone = Phone.Text;
            System.DateTime data1 = dateEntry.Value;
            System.DateTime data2 = txtBrithday.Value;
            string _class = cboClass.Text;
            string _dept = cboDept.Text;
            string _spec = cboSpec.Text;

            string hobby = "";
            if (checkBox1.Checked) hobby += checkBox1.Text;
            if (checkBox2.Checked) hobby += "、" + checkBox2.Text;
            if (checkBox3.Checked) hobby += "、" + checkBox3.Text;
            if (checkBox4.Checked) hobby += "、" + checkBox4.Text;
            if (checkBox5.Checked) hobby += "、" + checkBox5.Text;
            if (checkBox6.Checked) hobby += "、" + checkBox6.Text;
            string sql = String.Format("update 学籍信息_学生 set 学号='{0}',姓名='{1}',性别='{2}',住宿地址='{3}',电话='{4}',入学日期='{5}',出生日期='{6}',班级='{7}',院系='{8}',专业='{9}',爱好='{10}' where 学号='{11}'", Sno, name, sex, address, phone, data1, data2, _class, _dept, _spec, hobby,Sno_old);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    SCount_Spec(Spec_old, -1);          //修改专业学生规模
                    SCount_Spec(_spec, 1);

                    SCount_Dept(Dept_old, -1);          //修改院系学生规模
                    SCount_Dept(_dept, 1);

                    SCount_Class(Spec_old, Class_old, -1);
                    SCount_Class(_spec, _class, 1);
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
                    string sql = String.Format("select count(*) from 学籍信息_学生 where 学号='{0}'", Sno);
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();            //打开数据库连接
                        SqlCommand comm = new SqlCommand(sql, conn);
                        int n = (int)comm.ExecuteScalar();
                        if (n > 0)
                        {
                            MessageBox.Show("该学号所代表的学生已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Creat_Node()                                   //管理：添加班级
        {
            int no = Convert.ToInt32(txtSno.Text);
            string name = txtSname.Text;
            string sex;
            if (rdoMale.Checked)
                sex = rdoMale.Text;
            else
                sex = rdoFemale.Text;
            string address = Apartment.Text;
            string phone = Phone.Text;
            System.DateTime data1 = dateEntry.Value;
            System.DateTime data2 = txtBrithday.Value;
            string _class = cboClass.SelectedItem.ToString();
            string _dept = cboDept.SelectedItem.ToString();
            string _spec = cboSpec.SelectedItem.ToString();

            string hobby = "";
            if (checkBox1.Checked) hobby += checkBox1.Text;
            if (checkBox2.Checked) hobby += "、" + checkBox2.Text;
            if (checkBox3.Checked) hobby += "、" + checkBox3.Text;
            if (checkBox4.Checked) hobby += "、" + checkBox4.Text;
            if (checkBox5.Checked) hobby += "、" + checkBox5.Text;
            if (checkBox6.Checked) hobby += "、" + checkBox6.Text;

            string sql = String.Format("insert into [学籍信息_学生](学号,姓名,性别,住宿地址,电话,入学日期,出生日期,班级,院系,专业,爱好) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", no, name, sex, address, phone, data1, data2, _class, _dept, _spec, hobby);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    SCount_Spec(_spec, 1);                  //该专业学生规模加1
                    SCount_Dept(_dept, 1);                  //该院系学生规模加1
                    SCount_Class(_spec, _class, 1);
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
                string sql = String.Format("select count(*) from 学籍信息_学生 where 学号='{0}'", Sno);
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();            //打开数据库连接
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int n = (int)comm.ExecuteScalar();
                    if (n > 0)
                    {
                        MessageBox.Show("该学号所代表的学生已存在，请确认！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Delete_Node()
        {
            int no = Sno_old;
            string _class = Class_old;
            string _dept = Dept_old;
            string _spec = Spec_old;
            string sql = String.Format("delete from 学籍信息_学生 where 学号='{0}'", no);
            DialogResult dr = MessageBox.Show("删除该学生信息？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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
                        SCount_Spec(_spec, -1);                  //该专业学生规模加1
                        SCount_Dept(_dept, -1);                  //该院系学生规模加1
                        SCount_Class(_spec, _class, -1);
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



    }
}
