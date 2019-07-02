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
    public partial class T_InfoFrm : Form
    {
        public bool Edit_tag = false;               //当前是否为可编辑状态
        public string Dept_old;
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";

        public T_InfoFrm()
        {
            InitializeComponent();
        }

        private void Add_Dept()                    //为复选框添加院系信息     
        {
            string dept;
            string sql = String.Format("select * from 院系信息");
            T_dept.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    dept = reader.GetString(1);
                    T_dept.Items.Add(dept);
                }
            }
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

        private void Lock_Control()
        {
            T_name.ReadOnly = true;
            groupBox5.Enabled = false;
            T_zhicheng.Enabled = false;
            T_xuewei.Enabled = false;
            T_Brithday.Enabled = false;
            T_Year.ReadOnly = true;
            T_dept.Enabled = false;

            Edit_tag = false;
            btnUpdate.Enabled = true;
        }

        private void Lock_Remove()
        {
            T_name.ReadOnly = false;
            groupBox5.Enabled = true;
            T_zhicheng.Enabled = true;
            T_xuewei.Enabled = true;
            T_Brithday.Enabled = true;
            T_Year.ReadOnly = false;
            T_dept.Enabled = true;

            Edit_tag = true;
            btnUpdate.Enabled = false;
        }

        private void ShowInfo()         //选中的编号教师信息显示
        {
            string sql = String.Format("select * from 个人信息_教师 where 编号='{0}'", MySystem.Program.UserNo);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())                              //学生已注册过
                {
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
                    if (C_no == "暂无")
                    {
                        T_class.Text = C_no;
                    }
                    else
                    {
                        Search_Class_name(C_no);
                    }
                }
                else
                {
                    MessageBox.Show("您还没有进行注册！请先注册个人信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    T_name.Focus();
                }
            }
            Dept_old = T_dept.Text;
            Lock_Control();
        }

        private void T_InfoFrm_Load(object sender, EventArgs e)
        {
            T_no.Text = MySystem.Program.UserNo.ToString();
            Add_Dept();
            Lock_Control();
            ShowInfo();
        }

        private void SCount_Dept(string name, int i)                //院系教师规模+i
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Lock_Remove();
        }

        private void Update_Node()                                   //更新
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

            string sql = String.Format("update 个人信息_教师 set 编号='{0}',姓名='{1}',性别='{2}',职称='{3}',学位='{4}',出生日期='{5}',工作年月='{6}',所属院系='{7}' where 编号='{8}'", Tno, Tname, sex, Tzhicheng, Txuewei, data, _year, Tdept, MySystem.Program.UserNo);
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
                    this.Close();
                }
                else
                {
                    MessageBox.Show("更新失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void Creat_Node()                                   //添加
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

            string sql = String.Format("insert into 个人信息_教师(编号,姓名,性别,职称,学位,出生日期,工作年月,所属院系,所带班级) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", Tno, Tname, sex, Tzhicheng, Txuewei, data, _year, Tdept, "暂无");
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();
                if (n > 0)
                {
                    SCount_Dept(Tdept, 1);                  //该院系学生规模加1
                    MessageBox.Show("添加成功！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Lock_Control();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)      //信息更新
        {
            if (Edit_tag)
            {
                int no = Convert.ToInt32(T_no.Text);
                string sql = String.Format("select * from 个人信息_教师 where 编号='{0}'", no);
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    SqlDataReader reader = comm.ExecuteReader();

                    if (reader.Read())                      //若信息不存在，则创建，否则，更新数据
                    {
                        Update_Node();
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


















    }
}
