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
using Microsoft.VisualBasic;

namespace FormsLearning
{
    public partial class SelfInfoBuyers : Form
    {
        SqlConnection newConn;
        SqlCommand cmd;
        DataTable tbl;
        public SelfInfoBuyers()
        {
            InitializeComponent();

            cmd = new SqlCommand();
            tbl = new DataTable();
            newConn = new SqlConnection(MainInterface.connsql);
            newConn.Open();

            NameLabel.Text = LoginInterface.MainUser.Trim();
            try
            {
                tbl.Clear();
                string displayvalues1 = "use Vickers select Csex from dbo.Customer where Cname ='" + NameLabel.Text.Trim() + "';";
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(displayvalues1, MainInterface.connsql);
                dataAdapter1.Fill(tbl);
                CsexDisplay.Text = tbl.Rows[0][0].ToString().Trim();
                if (CsexDisplay.Text.Trim() !="男"&& CsexDisplay.Text.Trim()!="女")
                {
                    CsexDisplay.Text = "请点击填写";
                }
                dataAdapter1 = null;
            }
            catch
            {
                MessageBox.Show("您需要填入性别");
            }
            

            tbl.Clear();
            string displayvalues = "use Vickers select Cage from dbo.Customer where Cname = '" + NameLabel.Text.Trim() + "'; ";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(displayvalues, MainInterface.connsql);
            dataAdapter.Fill(tbl);
            if (tbl.Rows[0].IsNull("Cage"))
            {
                CageDisplay.Text = "请点击填写";
            }
            else
            {
                DateTime tm = (DateTime)tbl.Rows[0]["Cage"];
                CageDisplay.Text = tm.ToString().Trim();
            }
            dataAdapter = null;


            tbl.Clear();
            displayvalues = "use Vickers select Cphone from dbo.Customer where Cname = '" + NameLabel.Text.Trim() + "'; ";
            dataAdapter = new SqlDataAdapter(displayvalues, MainInterface.connsql);
            dataAdapter.Fill(tbl);
            if (tbl.Rows[0].IsNull("Cphone"))
            {
                CtelDisplay.Text = "请点击填写";
            }
            else
            {
                CtelDisplay.Text = tbl.Rows[0]["Cphone"].ToString().Trim();

            }
            dataAdapter = null;

            tbl.Clear();
            displayvalues = "use Vickers select Cstudy from dbo.Customer where Cname = '" + NameLabel.Text.Trim() + "'; ";
            dataAdapter = new SqlDataAdapter(displayvalues, MainInterface.connsql);
            dataAdapter.Fill(tbl);
            if (tbl.Rows[0].IsNull("Cstudy"))
            {
                CtelDisplay.Text = "请点击填写";
            }
            else
            {
                CstudyDisplay.Text = tbl.Rows[0]["Cstudy"].ToString().Trim();

            }
            dataAdapter = null;

            tbl.Clear();
            displayvalues = "use Vickers select Cjob from dbo.Customer where Cname = '" + NameLabel.Text.Trim() + "'; ";
            dataAdapter = new SqlDataAdapter(displayvalues, MainInterface.connsql);
            dataAdapter.Fill(tbl);
            if (tbl.Rows[0].IsNull("Cjob"))
            {
                CtelDisplay.Text = "请点击填写";
            }
            else
            {
                CjopDisplay.Text = tbl.Rows[0]["Cjob"].ToString().Trim();

            }
            dataAdapter = null;

            tbl.Clear();
            displayvalues = "use Vickers select Caddress from dbo.Customer where Cname = '" + NameLabel.Text.Trim() + "'; ";
            dataAdapter = new SqlDataAdapter(displayvalues, MainInterface.connsql);
            dataAdapter.Fill(tbl);
            if (tbl.Rows[0].IsNull("Caddress"))
            {
                CaddrDisplay.Text = "请点击填写";
            }
            else
            {
                CaddrDisplay.Text = tbl.Rows[0]["Caddress"].ToString().Trim();

            }
            dataAdapter = null;

            tbl.Clear();
            displayvalues = "use Vickers select Cinfor from dbo.Customer where Cname = '" + NameLabel.Text.Trim() + "'; ";
            dataAdapter = new SqlDataAdapter(displayvalues, MainInterface.connsql);
            dataAdapter.Fill(tbl);
            if (tbl.Rows[0].IsNull("Cinfor"))
            {
                CinfoDisplay.Text = "请点击填写";
            }
            else
            {
                CinfoDisplay.Text = tbl.Rows[0]["Cinfor"].ToString().Trim();

            }
            dataAdapter = null;


        }
 

        private void SelfInfoBuyers_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            newConn.Close();
            MainInterface.f.Show();
        }

        private void NameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void CnoDisplay_Click(object sender, EventArgs e)
        {

        }

        private void CsexDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbl.Clear();

            string GetCsex = Interaction.InputBox("您的性别", "性别", "", -1, -1);
            string sql = "use Vickers update Customer set Csex = '" + GetCsex.Trim() + "' where Cname = '" +
                LoginInterface.MainUser.Trim() + "';";
            cmd = new SqlCommand();
            cmd.Connection = MainInterface.customer;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            string displayvalues = "use Vickers select Csex from dbo.Customer where Cname ='" + NameLabel.Text.Trim() + "';";
            //Console.WriteLine(displayvalues);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(displayvalues, newConn);
            dataAdapter.Fill(tbl);
            CsexDisplay.Text = tbl.Rows[0][0].ToString().Trim();
            dataAdapter = null;

        }

        private void CageDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbl.Clear();

            string GetCage = Interaction.InputBox("您的年龄", "年龄", "", -1, -1);
            string sql = "use Vickers update Customer set Cage = '" + GetCage.Trim() + "' where Cname = '" +
                LoginInterface.MainUser.Trim() + "';";
            cmd = new SqlCommand();
            cmd.Connection = MainInterface.customer;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            string displayvalues = "use Vickers select Cage from dbo.Customer where Cname ='" + NameLabel.Text.Trim() + "';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(displayvalues, newConn);
            dataAdapter.Fill(tbl);
            DateTime tm = (DateTime)tbl.Rows[0]["Cage"];
            CageDisplay.Text = tm.ToString().Trim();
            dataAdapter = null;
        }

        private void CtelDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbl.Clear();
            string GetCtel = Interaction.InputBox("您的联系方式", "联系方式", "", -1, -1);
            string sql = "use Vickers update Customer set Cphone = '" + GetCtel.Trim() + "' where Cname = '" +
                LoginInterface.MainUser.Trim() + "';";
            cmd = new SqlCommand();
            cmd.Connection = MainInterface.customer;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            string displayvalues = "use Vickers select Cphone from dbo.Customer where Cname ='" + NameLabel.Text.Trim() + "';";
            Console.WriteLine(displayvalues);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(displayvalues, newConn);
            dataAdapter.Fill(tbl);
            CtelDisplay.Text = tbl.Rows[0]["Cphone"].ToString().Trim();
            dataAdapter = null;
        }

        private void CstudyDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbl.Clear();
            string GetCstudy = Interaction.InputBox("您的学历", "学历", "", -1, -1);
            string sql = "use Vickers update Customer set Cstudy = '" + GetCstudy.Trim() + "' where Cname = '" +
                LoginInterface.MainUser.Trim() + "';";
            cmd = new SqlCommand();
            cmd.Connection = MainInterface.customer;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            string displayvalues = "use Vickers select Cstudy from dbo.Customer where Cname ='" + NameLabel.Text.Trim() + "';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(displayvalues, newConn);
            dataAdapter.Fill(tbl);
            CstudyDisplay.Text = tbl.Rows[0]["Cstudy"].ToString().Trim();
            dataAdapter = null;
        }

        private void CjopDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbl.Clear();
            string GetCjob = Interaction.InputBox("您的工作", "工作", "", -1, -1);
            string sql = "use Vickers update Customer set Cjob = '" + GetCjob.Trim() + "' where Cname = '" +
                LoginInterface.MainUser.Trim() + "';";
            cmd = new SqlCommand();
            cmd.Connection = MainInterface.customer;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            string displayvalues = "use Vickers select Cjob from dbo.Customer where Cname ='" + NameLabel.Text.Trim() + "';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(displayvalues, newConn);
            dataAdapter.Fill(tbl);
            CjopDisplay.Text = tbl.Rows[0]["Cjob"].ToString().Trim();
            dataAdapter = null;
        }

        private void CaddrDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbl.Clear();
            string GetCaddr = Interaction.InputBox("您的地址", "地址", "", -1, -1);
            string sql = "use Vickers update Customer set Caddress = '" + GetCaddr.Trim() + "' where Cname = '" +
                LoginInterface.MainUser.Trim() + "';";
            cmd = new SqlCommand();
            cmd.Connection = MainInterface.customer;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            string displayvalues = "use Vickers select Caddress from dbo.Customer where Cname ='" + NameLabel.Text.Trim() + "';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(displayvalues, newConn);
            dataAdapter.Fill(tbl);
            CaddrDisplay.Text = tbl.Rows[0]["Caddress"].ToString().Trim();
            dataAdapter = null;
        }

        private void CinfoDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbl.Clear();
            string GetCinfo = Interaction.InputBox("您的备注", "备注", "", -1, -1);
            string sql = "use Vickers update Customer set Cinfor = '" + GetCinfo.Trim() + "' where Cname = '" +
                LoginInterface.MainUser.Trim() + "';";
            cmd = new SqlCommand();
            cmd.Connection = MainInterface.customer;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            string displayvalues = "use Vickers select Cinfor from dbo.Customer where Cname ='" + NameLabel.Text.Trim() + "';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(displayvalues, newConn);
            dataAdapter.Fill(tbl);
            CinfoDisplay.Text = tbl.Rows[0]["Cinfor"].ToString().Trim();
            dataAdapter = null;
        }
    }
}
