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


namespace Wage_adjustment
{
 //  public delegate void MyDel(string value);
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
          
        }

        private void forget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员进行修改密码");
        }

    

        private void reset_Click(object sender, EventArgs e)
        {
            t2.Text = "";
            t1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //   public delegate void MyDel(string value);
        //  public event MyDel MyEvent;
        private string name;
        public string Name
        {
            set => name = value;
            get => name;
        }
        private void login_Click(object sender, EventArgs e)
        {   //打开数据库连接
            string userName = t1.Text;
            string userPsd = t2.Text;
            //var userName2 = Convert.ToInt32(userName);
            //       string connString = @"Data Source=.; Initial Catalog=wade adjust;User ID=sa;Pwd=1274773226";
            //   string connString = @"Data Source=.\sqlexpress; Initial Catalog=wade adjust;Integrated Security=true";
            //    SqlConnection conn = new SqlConnection(connString);
            
            string sql1 = String.Format($"select count(*) from [admin] where adminaccount='{userName}'and adminpassword='{userPsd}'");
            string sql2 = String.Format($"select count(*) from [teacher] where account='{userName}'and password='{userPsd}'");
            string sql3 = String.Format($"select * from [admin] where adminaccount='{userName}'and adminpassword='{userPsd}'");
            string sql4 = String.Format($"select * from [teacher] where account='{userName}'and password='{userPsd}'");
            //    string sql3 = String.Format($"select * from [admin] ");
            int oldwage=0,newwage=0;
            try
            {
                // conn.Open();
                string connString = @"Data Source=.; Initial Catalog=wade adjust;User ID=sa;Pwd=1274773226";
                SqlConnection conn1 = new SqlConnection(connString);
                conn1.Open();
                SqlConnection conn = Class1.Open();
                SqlCommand comm1 = new SqlCommand(sql1, conn);
                SqlCommand comm2 = new SqlCommand(sql2, conn);
                SqlCommand comm3 = new SqlCommand(sql3, conn);
                SqlCommand comm4 = new SqlCommand(sql4, conn1);
                int n1 = (int)comm1.ExecuteScalar();
                int n2 = (int)comm2.ExecuteScalar();
                SqlDataReader reader1 = comm3.ExecuteReader();
                SqlDataReader reader2 = comm4.ExecuteReader();
                //Class2 cl = new Class2();
                //判断管理员
                if (n1 == 1)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Tag = true;
                   // reader2.Read();
                    if (reader1.Read())
                    //   if (true)
                    {
                        Name = reader1.GetString(1);
                     //   MyEvent(reader2.GetString(1));
                     //    MessageBox.Show(reader2.GetString(1));
                    }
                    Form2 frm = new Form2(Name,userName);
                    //  frm.Parent = this;
                    frm.Show();
                    this.Hide();

                }
                //判断教师
                else if (n2 == 1)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Tag = true;
                    if (reader2.Read())
               //     if (true)
                    {
                       Name = reader2.GetString(2);
                        oldwage = reader2.GetInt32(4);
                        //if ((bool)reader2.GetValue(5))
                        //数据库里面新工资有数据的时候，就不能加这条
                        { newwage = reader2.GetInt32(5); }
                        // string str2 = reader2.GetString(2);
                        //    MessageBox.Show(str2);
                        //  MyEvent(reader1.GetString(2));
                    }
                  
                    Form3 frm3 = new Form3(Name, userName,oldwage,newwage);
                 //   frm3.Parent = this;
                    frm3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("账号或密码错误，请重新输入");
                }
                reader1.Close();
                reader2.Close();

            }
/*            catch (Exception ex)//登录失败，报错并记录
            {
                MessageBox.Show(ex.Message,"操作数据库出错！",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.Tag = false;
                
            }*/
            finally
            {
                // conn.Close();
                Class1.Close();



            }
  /*          if (t1.Text == "admin" && t2.Text == "Sheldon") ;
            {
                Form2 frm = new Form2();
                frm.Parent = this;
                frm.Show();
                    
            }
            else if (true)
            {
                Form3 frm3 = new Form3();
                frm3.Parent = this;
                frm3.Show();
            }
            else
            {
                MessageBox.Show("账号或密码错误，请重新输入");
            }
  */
        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
