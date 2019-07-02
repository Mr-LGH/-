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
    public partial class Qingjia_mag_stu : Form
    {
        public int _Id;
        public string Sname;
        public string connString = @"Data Source=LAPTOP-0AI9IA0M;Initial Catalog=MySystem;User ID=sa;pwd=123456";
        public Qingjia_mag_stu()
        {
            InitializeComponent();
        }
        private void Sname_Search()
        {
            string sql = String.Format("select * from 学籍信息_学生 where 学号='{0}'", MySystem.Program.UserNo);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())                              //学生已注册过
                {
                    Sname=reader.GetString(1);
                }
            }
        }
        private int Cno_Search()
        {
            string _dept="";
            string _spec="";
            string _class="";
            string sql=String.Format("select * from 学籍信息_学生 where 学号='{0}'",MySystem.Program.UserNo);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())                              
                {
                    _dept = reader.GetString(8);
                    _spec = reader.GetString(9);
                    _class = reader.GetString(7);
                }
            }
            sql = String.Format("select 班级编号 from 班级信息 where 所属院系='{0}' and 所属专业='{1}' and 班级名称='{2}'", _dept, _spec, _class);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())                              //学生已注册过
                {
                    return reader.GetInt32(0);
                }
                else
                {
                    return -1;
                }
            }
        }
        private void Display()
        {
            string sql = String.Format("select * from 请假记录 where 学号='{0}' and 状态='申请请假' or 状态='已批准' or 状态='申请销假'", MySystem.Program.UserNo);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    _Id = reader.GetInt32(0);
                    S_no.Text = reader.GetInt32(1).ToString();
                    S_name.Text = reader.GetString(2);
                    S_cause.Text = reader.GetString(3);
                    S_go.Text = reader.GetString(4);
                    Time_start.Value = reader.GetDateTime(5);
                    Time_end.Value = reader.GetDateTime(6);
                    S_phone.Text = reader.GetString(7);
                    Parent_phone.Text = reader.GetString(8);
                    S_status.Text = reader.GetString(9);
                    if (S_status.Text == "已批准")
                    {
                        btnXJ.Enabled = true;
                    }
                }
            }
        }
        
        private bool Lock_Add()                 //判断当前学生是否有状态处于“申请请假”“已批准”“申请销假”的假条
        {
            bool flag=false;
            string sql = String.Format("select * from 请假记录 where 学号='{0}' and (状态='申请请假' or 状态='已批准' or 状态='申请销假')", MySystem.Program.UserNo);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn);
                SqlDataReader reader = comm.ExecuteReader();
                if(reader.Read())
                {
                    flag=true;
                }
            }
            return flag;
        }

        private void Lock_control()             //锁定控件只读
        {
            S_cause.ReadOnly = true;
            S_go.ReadOnly = true;
            Time_start.Enabled = false;
            Time_end.Enabled = false;
            S_phone.ReadOnly = true;
            Parent_phone.ReadOnly = true;
        }
        private void Lock_remove()
        {
            S_cause.ReadOnly = false;
            S_go.ReadOnly = false;
            Time_start.Enabled = true;
            Time_end.Enabled = true;
            S_phone.ReadOnly = false;
            Parent_phone.ReadOnly = false;
        }
        private void btnEditor_Click(object sender, EventArgs e)
        {
            int _no=Convert.ToInt32(S_no.Text);
            string _name=S_name.Text;
            string _cause=S_cause.Text;
            string _go=S_go.Text;
            System.DateTime data1 = Time_start.Value;
            System.DateTime data2 = Time_end.Value;
            string _phone1=S_phone.Text;
            string _phone2=Parent_phone.Text;
            int Cno = Cno_Search();
            string sql = String.Format("insert into 请假记录(学号,姓名,请假原因,去向,开始时间,结束时间,学生联系方式,家长联系方式,状态,班级号) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", _no, _name, _cause, _go, data1, data2, _phone1, _phone2, "申请请假",Cno);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();             //执行添加命令，返回更新的行数
                if (n > 0)
                {
                    
                    DialogResult dr = MessageBox.Show("请假申请提交成功！等待教师审批！", "更新成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("信息提交失败！", "更新失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void 请假_学生_Load(object sender, EventArgs e)
        {
            bool tag = Lock_Add();
            if (tag)
            {
                Lock_control();
                btnQJ.Enabled = false;
                btnXJ.Enabled = false;
                Display();
            }
            else
            {
                btnXJ.Enabled = false;
                Sname_Search();
                S_no.Text = MySystem.Program.UserNo.ToString();
                S_name.Text = Sname;
                S_cause.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = String.Format("update 请假记录 set 状态='申请销假' where ID='{0}'",_Id);
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                int n = comm.ExecuteNonQuery();             //执行添加命令，返回更新的行数
                if (n > 0)
                {
                    DialogResult dr = MessageBox.Show("销假申请提交成功！等待教师审批！", "更新成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }
    }
    
}
