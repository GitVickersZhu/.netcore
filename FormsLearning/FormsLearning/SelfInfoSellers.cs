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
    public partial class SelfInfoSellers : Form
    {
        SqlConnection newConn;
        SqlCommand cmd;
        DataTable tbl;
        public SelfInfoSellers()
        {
            InitializeComponent();
            cmd = new SqlCommand();
            tbl = new DataTable();
            newConn = new SqlConnection(SellerWorkstageInterface.connsql);
            newConn.Open();
            NameLabel.Text = LoginInterface.MainUser.Trim();

            tbl.Clear();
            string displayvalues = "use Vickers select Lsex from dbo.Landlord where Lname ='" + NameLabel.Text.Trim() + "';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(displayvalues, SellerWorkstageInterface.connsql);
            dataAdapter.Fill(tbl);
            if (tbl.Rows[0]["Lsex"].ToString().Trim() != "男" && tbl.Rows[0]["Lsex"].ToString().Trim() != "女")
            {
                LsexDisplay.Text = "请点击填写";
            }
            else
            {
                LsexDisplay.Text = tbl.Rows[0]["Lsex"].ToString().Trim();
            }
            dataAdapter = null;

            tbl.Clear();
            displayvalues = "use Vickers select Lphone from dbo.Landlord where Lname ='" + NameLabel.Text.Trim() + "';";
            dataAdapter = new SqlDataAdapter(displayvalues, SellerWorkstageInterface.connsql);
            dataAdapter.Fill(tbl);
            if (tbl.Rows[0].IsNull("Lphone"))
            {
                DtelDisplay.Text = "请点击填写";
            }
            else
            {
                DtelDisplay.Text = tbl.Rows[0]["Lphone"].ToString().Trim();
            }
            dataAdapter = null;

            tbl.Clear();
            displayvalues = "use Vickers select Laddress from dbo.Landlord where Lname ='" + NameLabel.Text.Trim() + "';";
            dataAdapter = new SqlDataAdapter(displayvalues, SellerWorkstageInterface.connsql);
            dataAdapter.Fill(tbl);
            if (tbl.Rows[0].IsNull("Laddress"))
            {
                CaddrDisplay.Text = "请点击填写";
            }
            else
            {
                CaddrDisplay.Text = tbl.Rows[0]["Laddress"].ToString().Trim();
            }
            dataAdapter = null;

            tbl.Clear();
            displayvalues = "use Vickers select Linfor from dbo.Landlord where Lname = '" + NameLabel.Text.Trim() + "'; ";
            dataAdapter = new SqlDataAdapter(displayvalues, SellerWorkstageInterface.connsql);
            dataAdapter.Fill(tbl);
            if (tbl.Rows[0].IsNull("Linfor"))
            {
                CinfoDisplay.Text = "请点击填写";
            }
            else
            {
                CinfoDisplay.Text = tbl.Rows[0]["Linfor"].ToString().Trim();

            }
            dataAdapter = null;


        }

        private void SelfInfoSellers_Load(object sender, EventArgs e)
        {

        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            SellerWorkstageInterface.f.Show();

            
        }

        private void LsexDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbl.Clear();

            string GetLsex = Interaction.InputBox("您的性别", "性别", "", -1, -1);
            string sql = "use Vickers update Landlord set Lsex = '" + GetLsex.Trim() + "' where Lname = '" +
                LoginInterface.MainUser.Trim() + "';";
            cmd = new SqlCommand();
            cmd.Connection = SellerWorkstageInterface.sellers;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            string displayvalues = "use Vickers select Lsex from dbo.Landlord where Lname ='" + NameLabel.Text.Trim() + "';";
            //Console.WriteLine(displayvalues);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(displayvalues, newConn);
            dataAdapter.Fill(tbl);
            LsexDisplay.Text = tbl.Rows[0]["Lsex"].ToString().Trim();
            dataAdapter = null;
        }

        private void DtelDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbl.Clear();

            string GetLtel = Interaction.InputBox("您的电话", "电话", "", -1, -1);
            string sql = "use Vickers update Landlord set Lphone = '" + GetLtel.Trim() + "' where Lname = '" +
                LoginInterface.MainUser.Trim() + "';";
            cmd = new SqlCommand();
            cmd.Connection = SellerWorkstageInterface.sellers;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            string displayvalues = "use Vickers select Lphone from dbo.Landlord where Lname ='" + NameLabel.Text.Trim() + "';";
            //Console.WriteLine(displayvalues);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(displayvalues, newConn);
            dataAdapter.Fill(tbl);
            DtelDisplay.Text = tbl.Rows[0]["Lphone"].ToString().Trim();
            dataAdapter = null;
        }

        private void CstudyDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void CjopDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LhmtnDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void CaddrDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbl.Clear();
            string GetLaddr = Interaction.InputBox("您的地址", "地址", "", -1, -1);
            string sql = "use Vickers update Landlord set Laddress = '" + GetLaddr.Trim() + "' where Lname = '" +
                LoginInterface.MainUser.Trim() + "';";
            cmd = new SqlCommand();
            cmd.Connection = SellerWorkstageInterface.sellers;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            string displayvalues = "use Vickers select Laddress from dbo.Landlord where Lname ='" + NameLabel.Text.Trim() + "';";
            //Console.WriteLine(displayvalues);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(displayvalues, newConn);
            dataAdapter.Fill(tbl);
            CaddrDisplay.Text = tbl.Rows[0]["Laddress"].ToString().Trim();
            dataAdapter = null;
        }

        private void CinfoDisplay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbl.Clear();
            string GetLinfo = Interaction.InputBox("您的备注", "备注", "", -1, -1);
            string sql = "use Vickers update Landlord set Linfor = '" + GetLinfo.Trim() + "' where Lname = '" +
                LoginInterface.MainUser.Trim() + "';";
            cmd = new SqlCommand();
            cmd.Connection = SellerWorkstageInterface.sellers;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd = null;
            string displayvalues = "use Vickers select Linfor from dbo.Landlord where Lname ='" + NameLabel.Text.Trim() + "';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(displayvalues, newConn);
            dataAdapter.Fill(tbl);
            CinfoDisplay.Text = tbl.Rows[0]["Linfor"].ToString().Trim();
            dataAdapter = null;
        }

        private void NameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
