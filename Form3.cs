using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wage_adjustment
{
    public partial class Form3 : Form
    { //private string account;
        /*        public void Getaccount(string account)
                {
                    this.Text = account;
                }*/

        private string name, account;
        private int oldwage, newwage;
        public Form3(string name,string account,int oldwage,int newwage)
        {
            InitializeComponent();
            this.name = name;
            this.account = account;
            this.oldwage = oldwage;
            this.newwage = newwage;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          //  Form1 frm;
          //  frm = (Form1)this.Owner;
            this.Text = "hi萨瓦迪卡"+this.name;
            //   frm.MyEvent += new MyDel(Getaccount);
            // this.Text = "hello";
            label3.Text = oldwage.ToString();
            label4.Text = newwage.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
