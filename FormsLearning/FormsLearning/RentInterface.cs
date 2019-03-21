using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormsLearning
{
    public partial class RentInterface : Form
    {
        string[] Hno;
        string[] Lno;
        public RentInterface()
        {
            InitializeComponent();
        }
        public RentInterface(string[] results1,string[] results2)
        {
            InitializeComponent();
            Hno = results1;
            Lno = results2;
        }

        private void RentInterface_Load(object sender, EventArgs e)
        {

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            MainInterface.f.Show();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string payway;
            if (CashButton.Checked == true)
            {
                payway = "现金";
            }
            else  if(BankButton.Checked == true)
            {
                payway = "银行卡";
            }
            else
            {
                payway = "支付宝";
            }

            SqlCommand cmd;
            for(int i=0;i<Hno.Length;i++)
            {
                string sql = "insert into dbo.Rent values ('" +
                    Lno[i] + "','" +DataSourses.BuyerId + "','"+ Hno[i] + "','" + NumIpt.Text.Trim() + "','" +
                    UseforIpt.Text.Trim() + "','"+StartIpt.Text.Trim() + "','"+TimeIpt.Text.Trim()+
                    "','"+payway+"');";
                cmd = new SqlCommand();
                cmd.Connection = MainInterface.customer;
                cmd.CommandText = sql; 
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
            }
  
                
        }
    }
}
