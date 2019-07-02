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
    public partial class StudentInfo : Form
    {
        string spec_old;                //记录修改前的专业名称
        string dept_old;
        string class_old;
        public bool Edit_tag = false;               //当前是否为可编辑状态
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";

        private void Add_Dept_spec()                    //为复选框添加院系信息     
        {
            string dept;
            string sql = String.Format("select * from 院系信息");
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
                }
            }
            
        }
        private void display()                          //学籍信息显示
        {
            string sql = String.Format("select * from 学籍信息_学生 where 学号='{0}'", MySystem.Program.UserNo);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())                              //学生已注册过
                {
                    txtStudentName.Text = reader.GetString(1);
                    string sex = reader.GetString(2);
                    if (sex == "男")
                        rdoMale.Checked=true;
                    else
                        rdoFemale.Checked=true;
                    Apartment.Text = reader.GetString(3);
                    Phone.Text = reader.GetString(4);
                    dateEntry.Value = reader.GetDateTime(5);
                    txtBrithday.Value = reader.GetDateTime(6);
                    cboClass.Text = reader.GetString(7);
                    class_old = reader.GetString(7);
                    cboDept.Text = reader.GetString(8);
                    dept_old = reader.GetString(8);
                    cboSpec.Text = reader.GetString(9);
                    spec_old = reader.GetString(9);
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
                    Lock_Info();
                }
                else
                {
                    MessageBox.Show("你还没有进行注册！请先注册学籍信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtStudentName.Focus();
                }
            }
        }

        private void SCount_Dept(string name, int i)                
        {
            string sql = String.Format("update 院系信息 set 学生规模=学生规模+{0} where 院系名称='{1}'", i,name);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0){}
            }
        }
        private void SCount_Spec(string name, int i)                //
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

        private void SCount_Class(string Sname,string Cname,int i)          //更新班级人数
        {
            string sql = String.Format("update 班级信息 set 班级人数=班级人数+{0} where 所属专业='{1}' and 班级名称='{2}'", i,Sname, Cname);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0) { }
            }
        }

        private void Creat_Student()               //创建用户
        {
            int no = Convert.ToInt32(lblSno.Text);
            string name = txtStudentName.Text;
            string sex;
            string address = Apartment.Text;
            string phone = Phone.Text;
            System.DateTime data1 = dateEntry.Value;
            System.DateTime data2 = txtBrithday.Value;
            string _class = cboClass.SelectedItem.ToString();
            string _dept = cboDept.SelectedItem.ToString();
            string _spec = cboSpec.SelectedItem.ToString();
            string hobby = "";
            
            if (rdoMale.Checked)
                sex = rdoMale.Text;
            else
                sex = rdoFemale.Text;
            if (checkBox1.Checked) hobby += checkBox1.Text;
            if (checkBox2.Checked) hobby += "、" + checkBox2.Text;
            if (checkBox3.Checked) hobby += "、" + checkBox3.Text;
            if (checkBox4.Checked) hobby += "、" + checkBox4.Text;
            if (checkBox5.Checked) hobby += "、" + checkBox5.Text;
            if (checkBox6.Checked) hobby += "、" + checkBox6.Text;

            string sql = String.Format("insert into [学籍信息_学生](学号,姓名,性别,住宿地址,电话,入学日期,出生日期,班级,院系,专业,爱好) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", no,name,sex,address,phone,data1,data2,_class,_dept,_spec,hobby);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();             //执行添加命令，返回更新的行数
                if (n > 0)
                {
                    SCount_Spec(_spec, 1);                  //该专业学生规模加1
                    SCount_Dept(_dept, 1);                  //该院系学生规模加1
                    SCount_Class(_spec, _class, 1);
                    DialogResult dr = MessageBox.Show("更新学籍信息成功！", "更新成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("更新信息失败！", "更新失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void Update_student()               //更新用户
        {
            int no = Convert.ToInt32(lblSno.Text);
            string name = txtStudentName.Text;
            string sex;
            string address = Apartment.Text;
            string phone = Phone.Text;
            System.DateTime data1 = dateEntry.Value;
            System.DateTime data2 = txtBrithday.Value;
            string _class = cboClass.Text;
            string _dept = cboDept.SelectedItem.ToString();
            string _spec = cboSpec.SelectedItem.ToString();
            string hobby = "";

            if (rdoMale.Checked)
                sex = rdoMale.Text;
            else
                sex = rdoFemale.Text;
            if (checkBox1.Checked) hobby += checkBox1.Text;
            if (checkBox2.Checked) hobby += "、" + checkBox2.Text;
            if (checkBox3.Checked) hobby += "、" + checkBox3.Text;
            if (checkBox4.Checked) hobby += "、" + checkBox4.Text;
            if (checkBox5.Checked) hobby += "、" + checkBox5.Text;
            if (checkBox6.Checked) hobby += "、" + checkBox6.Text;
            string sql = String.Format("update 学籍信息_学生 set 学号='{0}',姓名='{1}',性别='{2}',住宿地址='{3}',电话='{4}',入学日期='{5}',出生日期='{6}',班级='{7}',院系='{8}',专业='{9}',爱好='{10}' where 学号='{0}'", no, name, sex, address, phone, data1, data2, _class, _dept, _spec, hobby);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n <= 0)
                {
                    MessageBox.Show("数据更新失败，请检查数据格式！", "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SCount_Spec(spec_old, -1);          //修改专业学生规模
                    SCount_Spec(_spec, 1);

                    SCount_Dept(dept_old, -1);          //修改院系学生规模
                    SCount_Dept(_dept, 1);

                    SCount_Class(spec_old,class_old, -1);
                    SCount_Class(_spec,_class, 1);
                    MessageBox.Show("数据更新成功！", "更新成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
        }
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)      //学籍信息更新
        {
            if (Edit_tag)
            {
                int no = Convert.ToInt32(lblSno.Text);
                string sql = String.Format("select * from 学籍信息_学生 where 学号='{0}'", no);
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    SqlDataReader reader = comm.ExecuteReader();

                    if (reader.Read())                      //若信息不存在，则创建，否则，更新数据
                    {
                        Update_student();
                    }
                    else
                    {
                        Creat_Student();
                    }
                }
            }
            else
            {
                MessageBox.Show("当前为不可编辑状态！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            lblSno.Text = MySystem.Program.UserNo.ToString();
            Add_Dept_spec();
            Lock_Info();
            display();
        }

        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void cboSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _class;
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
                    _class = reader.GetString(1);
                    cboClass.Items.Add(_class);
                }
            }
        }
    
        private void Lock_Info()
        {
            txtStudentName.ReadOnly = true;
            groupBox2.Enabled = false;
            Apartment.ReadOnly = true;
            Phone.ReadOnly = true;
            dateEntry.Enabled = false;
            txtBrithday.Enabled = false;
            cboClass.Enabled = false;
            cboSpec.Enabled = false;
            cboDept.Enabled = false;
            groupBox1.Enabled = false;

            Edit_tag = false;
            btnUpdate.Enabled = true;
        }

        private void Lock_Cancel()
        {
            txtStudentName.ReadOnly = false;
            groupBox2.Enabled = true;
            Apartment.ReadOnly = false;
            Phone.ReadOnly = false;
            dateEntry.Enabled = true;
            txtBrithday.Enabled = true;
            cboClass.Enabled = true;
            cboSpec.Enabled = true;
            cboDept.Enabled = true;
            groupBox1.Enabled = true;

            Edit_tag = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Lock_Cancel();
        }
    }
}
