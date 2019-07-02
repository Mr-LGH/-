using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySystem
{
    
    static class Program
    {
        public static bool mainRestart;         //注销信号

        public static string UserId;                //用户身份，判断登录用户身份，分别打开相应系统界面
        public static string UserName;              //用户姓名
        public static string Pwd;
        public static int UserNo;                   //学号
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            do
            {
                mainRestart = false;
                using (LForm login=new LForm())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        if (UserId == "学生")
                            Application.Run(new StudentMenuFrm());
                        else if (UserId == "教师")
                            Application.Run(new TeacherMenuFrm());
                        else
                            Application.Run(new ManagerMenuFrm());
                    }
                }
            } while (mainRestart);
        }
    }
}
