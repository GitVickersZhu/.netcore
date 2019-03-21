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
    public partial class SignupInterface : Form
    {
        DataSourses DsControl;


        public SignupInterface()
        {
            InitializeComponent();
            DsControl = new DataSourses(1);
        }

        private void SignupGroup_Enter(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (BuyerButton.Checked == true && SellerButton.Checked == false)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = LoginInterface.initConn;
                string id = IdBox.Text.ToString().Trim();
                string usnm = UsernameBox.Text.ToString().Trim();
                string pwd = PwdBox.Text.ToString().Trim();
                string BuyerId = DsControl.CreateCustomerId().Trim();
                string sql_key = "use Vickers " +
                    "create login " + usnm + " with password = '" + pwd + "';" +
                    "create user " + usnm + " for login " + usnm + " with default_schema=dbo;" +
                    "alter role buyers add member " + usnm + ";" +
                    "insert into dbo.Users values('" +
                    id + "','" + BuyerId + "',null,'" + usnm + "','" + pwd + "');" +
                    "insert into dbo.Customer values ('" +
                    BuyerId + "','" + usnm + "',null,null,'" + id.Trim() + "',null,null,null,null,null,null,null);";

                cmd.CommandText = sql_key;
                cmd.ExecuteNonQuery();
                MessageBox.Show("添加成功！请关闭该页面");
            }
            if(SellerButton.Checked == true && BuyerButton.Checked == false)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = LoginInterface.initConn;
                string id = IdBox.Text.ToString().Trim();
                string usnm = UsernameBox.Text.ToString().Trim();
                string pwd = PwdBox.Text.ToString().Trim();
                string LandlordId = DsControl.CreateLandlordId().Trim();
                string sql_key = "use Vickers " +
                    "create login " + usnm + " with password = '" + pwd + "';" +
                    "create user " + usnm + " for login " + usnm + " with default_schema=dbo;" +
                    "alter role sellers add member " + usnm + ";" +
                    "insert into dbo.Users values('" +
                    id + "',null,'" + LandlordId + "','" + usnm + "','" + pwd + "');" +
                    "insert into dbo.Landlord values ('" +
                    LandlordId + "','" + usnm + "',null,null,'" + id.Trim() + "',null,null,null,null,null);";

                cmd.CommandText = sql_key;
                cmd.ExecuteNonQuery();
                MessageBox.Show("添加成功！请关闭该页面");
            }



            

        }

        private void SignupInterface_Load(object sender, EventArgs e)
        {

        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            LoginInterface.f.Show();
        }

        private void BuyerButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SellerButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void IdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
