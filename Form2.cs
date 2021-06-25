using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data.Odbc;
using System.IO;
using System.Configuration;

namespace Wage_adjustment
{
    public partial class Form2 : Form
    {
        /*        public void Getaccount(string account)
                {
                    this.Text = account;
                }*/

        private string name, account;
        public Form2(string name,string account)
        {
            InitializeComponent();
            this.name = name;
            this.account = account;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“wade_adjustDataSet.teacher”中。您可以根据需要移动或删除它。
            this.teacherTableAdapter.Fill(this.wade_adjustDataSet.teacher);
            // TODO: 这行代码将数据加载到表“wade_adjustDataSet.teacher”中。您可以根据需要移动或删除它。
            this.teacherTableAdapter.Fill(this.wade_adjustDataSet.teacher);
            // TODO: 这行代码将数据加载到表“wade_adjustDataSet.teacher”中。您可以根据需要移动或删除它。
            this.teacherTableAdapter.Fill(this.wade_adjustDataSet.teacher);

            // Form1 frm = (Form1)this.Owner;
            //     this.Text = "hi";
            this.Text = "hi萨瓦迪卡"+this.name;
            //   frm.MyEvent += new MyDel(Getaccount);
        //    we();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int owage,nwage;
            int year,tno;
            //Boolean flag=true;
            string connString = @"Data Source=.; Initial Catalog=wade adjust;User ID=sa;Pwd=1274773226";
            SqlConnection conn2 = new SqlConnection(connString);
            conn2.Open();
            try
            {
                SqlConnection conn = Class1.Open();
                string sql = String.Format("select * from teacher ");
                SqlCommand comm = new SqlCommand(sql, conn2);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                   // flag = reader.Read();
                //    if (flag) break;
                  //  if (reader.Read())
                   // {
                        // DateTime date = DateTime.Now;
                        year = (DateTime.Now - reader.GetDateTime(7)).Days /365;//假设每一年都是365天，不考虑闰年的影响
                        tno = reader.GetInt32(0);
                        string sql1 = string.Format($"update teacher set year={year} where tno={tno}");
                        SqlCommand comm1 = new SqlCommand(sql1, conn);
                        comm1.ExecuteNonQuery();//计算工龄，并存入数据库
                        owage = reader.GetInt32(4);
                    //     departments = reader.GetInt32(8);
                    if (owage < 26000)
                    {
                        /*                        string sql3 = string.Format($"select  departments from teacher where tno={tno} ");
                                                SqlCommand comm3 = new SqlCommand(sql3, conn);
                                                departments = (int)comm3.ExecuteScalar();*/
                       nwage = owage + reader.GetInt32(8) * 100 + year * 50;
                    //    nwage = owage + int.Parse( reader.GetString(8)) * 100 + year * 50;
                        //                    MessageBox.Show( reader.GetValue(8).ToString());
                        //                        nwage = q*100+owage + year * 50;
                        nwage = nwage > 26000 ? 26000 : nwage;
                    }
                    else
                    { nwage = owage; }
                        string sql2 = string.Format($"update teacher set newwage={nwage} where tno={tno} ");
                        SqlCommand comm2 = new SqlCommand(sql2, conn);
                        comm2.ExecuteNonQuery();
                    // }
                   // if (flag) break;
                }
                     reader.Close();
                /*                string sql = String.Format("declare @Owage int,@Nwage int,@departments smallint" +
                                                           "declare upda cursor for" +
                                                            "select * from teacher " +
                                                             "order by oldwage desc" +
                                                             "open upda" +
                                                             "fetch next from upda into @Owage,@Nwage" +
                                                             "select @Owage=oldwage,@Nwage=newwage while @@fetch_status=0" +
                                                             "begin" +
                                                             "if @Owage<26000");*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Class1.Close();
                this.teacherTableAdapter.Fill(this.wade_adjustDataSet.teacher);
            }
        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teacherTableAdapter.FillBy(this.wade_adjustDataSet.teacher);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teacherTableAdapter.FillBy1(this.wade_adjustDataSet.teacher);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teacherTableAdapter.FillBy2(this.wade_adjustDataSet.teacher);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.teacherTableAdapter.FillBy2(this.wade_adjustDataSet.teacher);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            /*            we();
                           da.Update(ds, "teacher");*/
 
        }

        private void dataGridView1_ColumnHeaderCellChanged(object sender, DataGridViewColumnEventArgs e)
        {

        }

        DataTable dt = new DataTable();
        //string connString = "Data Source=LAPTOP-CC6CKURH;Initial Catalog=db_text;Integrated Security=true;MultipleActiveResultSets=true;";
       // SqlConnection conn;
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            DataSet ds = ReadExcel(findpath());
            List<string> list = (from DataRow row in ds.Tables["table1"].Rows
                                 select String.Format
                                                  ("insert into teacher(tno,tname,account,password,oldwage,newwage,tsex,service,departments,year) " +
                                                     "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                                                      row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9])).ToList();
            //string strConnect = ConfigurationManager.ConnectionStrings["SqlServerConnString"].ToString();
            //或strConnect="Data Source=.;Initial Catalog=test;Persist Security Info=True;User ID=***;Password=***;MultipleActiveResultSets=true";
            // SqlConnection conn = new SqlConnection(strConnect);
            SqlConnection conn = Class1.Open();
            // conn.Open();
            foreach (string item in list)
            {
                SqlCommand comn = new SqlCommand(item, conn);
                comn.ExecuteNonQuery();
            }
            Class1.Close();*/
            string connString = @"Data Source=.; Initial Catalog=wade adjust;User ID=sa;Pwd=1274773226";
            SqlConnection conn = new SqlConnection(connString);
            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string fileName = fd.FileName;
                bind(fileName);
                //  conn = new SqlConnection(GetConnectString());
                //  conn.Open();
          
                if (dataGridView1.Rows.Count > 0)
                {
                    DataRow dr = null;
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        dr = dt.Rows[i];
                        insertToSql(dr);
                    }
                    //  conn.Close();
                  
                    MessageBox.Show("导入成功！");
                }
                else
                {
                    MessageBox.Show("没有数据！");
                }
                conn.Close();
            }

        }
        private void insertToSql(DataRow dr)
        {
        
        //excel表中的列名和数据库中的列名一定要对应  
        string tno = dr["tno"].ToString();
            string tname = dr["tname"].ToString();
            string account = dr["account"].ToString();
            string password = dr["password"].ToString();
            string oldwage = dr["oldwage"].ToString();
            string newwage = dr["newwage"].ToString();
            string tsex = dr["tsex"].ToString();
            string service = dr["service"].ToString();
            string departments = dr["departments"].ToString();
            string year = dr["year"].ToString();
            int a1 = Convert.ToInt32(tno);
            string a2 = tname;
            string a3 = account;
            string a4 = password;
            int a5 = Convert.ToInt32(oldwage);
            int a6 = Convert.ToInt32(newwage);
            int a7 = Convert.ToInt16(tsex);
            DateTime a8 = Convert.ToDateTime(service);
            int a9 = Convert.ToInt32(departments);
            int a10 = Convert.ToInt32(year);
            string sql = string.Format($"insert into teacher values({a1},'{a2}','{a3}','{a4}',{a5},{a6},{a7},'{a8}',{a9},{a10})");

            string connString = @"Data Source=.; Initial Catalog=wade adjust;User ID=sa;Pwd=1274773226";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
           
              SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)//登录失败，报错并记录
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //this.Tag = false;

            }
            finally
            {
                // Class1.Close();
                conn.Close();
            }
        }
        /*
                public static DataTable CSVToDataTable(string strFileFullPath)
                  {
                      if (string.IsNullOrEmpty(strFileFullPath))
                     {
                         return null;
                     }
                     DataTable dt = new DataTable();
                     try
                    {
                         //得到路径
                        string strFilePath = Path.GetDirectoryName(strFileFullPath);
                         //得到文件名
                         string strFileName = Path.GetFileNameWithoutExtension(strFileFullPath);
                         //读取CSV文件
                         string connString = @"Driver={Microsoft Text Driver (*.txt; *.csv)};Dbq=" + strFilePath + ";Extensions=asc,csv,tab,txt;";
                         using (OdbcConnection odbcConn = new OdbcConnection(connString))
                         {
                            odbcConn.Open();
                             OdbcCommand oleComm = new OdbcCommand();
                            oleComm.Connection = odbcConn;
                            oleComm.CommandText = "select * from [" + strFileName + "#csv]";
                            OdbcDataAdapter adapter = new OdbcDataAdapter(oleComm);
                            adapter.Fill(dt);
                            dt.TableName = strFileName;
                            odbcConn.Close();
                         }
                    }
                    catch (Exception)
                    {
                           throw;
                     }
                    return dt;
                }*/
        // private static string path;
        /*        private  string findpath()
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    if (ofd.ShowDialog() != DialogResult.OK)
                        return null;
                    //   string filename = dialog.FileName;
                    //   OpenFileDialog ofd = new OpenFileDialog();//创建一个文件对话框
                    //           ofd.InitialDirectory = @"E:\音乐";//设置初始目录
                    ofd.Filter = "xlsx|*.xlsx|所有文件|*.*";//文件类型筛选器
                    ofd.Title = "请选择excel表";
                    //   ofd.Multiselect = true;//允许多选
                  //  ofd.ShowDialog();//显示对话框

                    //    string[] path = ofd.FileNames;//获取选中的文件路径
                    string path = ofd.FileName;//获取选中的文件路径
                    return path;
                }
                public static DataSet ReadExcel(string path)
                {
                    try
                    {

                        //  string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties='Excel 8.0;HDR=False;IMEX=1'";
                        string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=" +path + ";" + "Extended Properties=\"Excel 12.0 Xml;HDR=No\"";
                        OleDbConnection oleConn = new OleDbConnection(strConn);
                        oleConn.Open();
                        string sql = "select * from [Sheet1$]";
                        OleDbDataAdapter oleDaExcel = new OleDbDataAdapter(sql, oleConn);
                        DataSet oleDsExcel = new DataSet();
                        oleDaExcel.Fill(oleDsExcel, "table1");
                        oleConn.Close();
                        return oleDsExcel;
                    }
                    catch (Exception)
                    {
                        return null;
                        throw;
                    }
                }*/

        //导出文件
        public static bool dt2csv(DataTable dt, string strFilePath, string tableheader, string columname)
        {
            try
            {
                string strBufferLine = "";
                StreamWriter strmWriterObj = new StreamWriter(strFilePath, false, System.Text.Encoding.UTF8);
                strmWriterObj.WriteLine(tableheader);
                strmWriterObj.WriteLine(columname);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    strBufferLine = "";
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (j > 0)
                            strBufferLine += ",";
                        strBufferLine += dt.Rows[i][j].ToString();
                    }
                    strmWriterObj.WriteLine(strBufferLine);
                }
                strmWriterObj.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable myTable = new DataTable();
            string connString = @"Data Source=.; Initial Catalog=wade adjust;User ID=sa;Pwd=1274773226";
            SqlConnection myConnection = new SqlConnection(connString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand("select * from teacher ", myConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = myCommand;
            DataSet myDs = new DataSet();
            adapter.Fill(myDs);
            myTable = myDs.Tables[0];
            dataGridView1.DataSource = myTable;
            string path = AppDomain.CurrentDomain.BaseDirectory + @"" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
            if (dt2csv(myTable, path, "教师工资信息", "tno,tname,account,password,oldwage,newwage,tsex,service,departments,year"))
            {
                MessageBox.Show("导出成功,文件位置:" + path);
            }
            else
            {
                MessageBox.Show("导出失败");
            }
        }

        private void bind(string fileName)
        {


            // string strConn = "Data Source=LAPTOP-CC6CKURH;Initial Catalog=db_text;Integrated Security=true;MultipleActiveResultSets=true;";
            string connString = @"Data Source=.; Initial Catalog=wade adjust;User ID=sa;Pwd=1274773226";
            SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM [teacher]", connString);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                dt = ds.Tables[0];
                this.dataGridView1.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败！" + err.ToString());
            }
        }
    }
}
