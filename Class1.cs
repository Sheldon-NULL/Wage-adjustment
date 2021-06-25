using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Wage_adjustment
{
   public static class Class1
    {
       static  string connString = @"Data Source=.; Initial Catalog=wade adjust;User ID=sa;Pwd=1274773226";
        private static SqlConnection conn= new SqlConnection(connString);
        public static SqlConnection Open()
        {

            //打开数据库连接
                
               
          //      string connString = @"Data Source=.; Initial Catalog=wade adjust;User ID=sa;Pwd=1274773226";
            //   string connString = @"Data Source=.\sqlexpress; Initial Catalog=wade adjust;Integrated Security=true";
            try
            {
               // if (conn == null)
               // { SqlConnection conn = new SqlConnection(connString); }//不知道为啥非要加括号

                conn.Open();
            }
            catch (Exception ex)//登录失败，报错并记录
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //this.Tag = false;

            }
            return conn;
        }   
        public static void Close()
        {
            conn.Close();
        }


    }
}
