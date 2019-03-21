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
    public partial class LoginInterface : Form
    {
        public static Form f;
        public static string MainUser;
        public string sqlkey;
        DataTable dttb = new DataTable();
        DataSet dtst = new DataSet();
        DataSourses identi_tools = new DataSourses();
        public static SqlConnection initConn;
        public LoginInterface()
        {
            InitializeComponent();
            f = this;
            sqlkey = "server=.;database=Vickers;integrated security=SSPI";
            initConn = new SqlConnection();
          
           
           initConn.ConnectionString = sqlkey;
           initConn.Open();
           string getUsers = "select * from dbo.Users";
           SqlDataAdapter dataAdapter = new SqlDataAdapter(getUsers,initConn);
           dataAdapter.Fill(dttb);
           dataAdapter.Fill(dtst);


            //initConn.Close();

        }



        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (AccInBox.Text.Length == 0)
            {
                LoginError.SetError(AccInBox, "Not Null!!");
            }
            if (PwdInBox.Text.Length == 0)
            {
                LoginError.SetError(PwdInBox, "空のインプットができません");
            }
            //else
            //{
            //    try
            //    {
            //        int i = Int32.Parse(PwdBox.Text.Trim());
            //        LoginError.SetError(PwdBox,"");
            //    }
            //    catch
            //    {
            //        LoginError.SetError(PwdBox,"数字のパスワードを入力してください");
            //    }
            //}

            //if (AccInBox.Text == "vickerszhu" && PwdInBox.Text == "database")
            //{
            //    this.AcceptButton = ConnectButton;
            //    sqlkey = "server=.;database=Vickers;uid=" + AccInBox.Text + ";pwd=" + PwdInBox.Text + ";";
            //    MainInterface f = new MainInterface(sqlkey);
            //    f.Show();
            //    this.Hide();
            //}
            if(PwdInBox.Text.Trim() == identi_tools.UsersSavedBuyers(dttb,AccInBox.Text.Trim()))
            {
                initConn.Close();
                this.AcceptButton = ConnectButton;
                sqlkey = "server=.;database=Vickers;uid=" + AccInBox.Text + ";pwd=" + PwdInBox.Text + ";";
                MainUser = AccInBox.Text.Trim();
                MainInterface f = new MainInterface(sqlkey);
                initConn.Close();
                f.Show();
                this.Hide();
            }
            else if(PwdInBox.Text == identi_tools.UsersSavedSellers(dttb, AccInBox.Text.Trim()))
            {
                initConn.Close();
                this.AcceptButton = ConnectButton;
                sqlkey = "server=.;database=Vickers;uid=" + AccInBox.Text + ";pwd=" + PwdInBox.Text + ";";
                MainUser = AccInBox.Text.Trim();
                SellerWorkstageInterface f = new SellerWorkstageInterface(sqlkey);
                initConn.Close();
                f.Show();
                this.Hide();
            }

        }

        private void AccInBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PwdInBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {
            PwdInBox.PasswordChar = '♂';
        }

        private void loginInterface_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupInterface fo = new SignupInterface();
            fo.Show();
            this.Hide();
        }

        private void groupBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

    }
}
