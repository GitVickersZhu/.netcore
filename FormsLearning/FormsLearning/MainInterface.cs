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
    public partial class MainInterface : Form
    {
        public static Form f;

        public static SqlConnection customer;

        private DataTable dataTable;

        private DataSet dataSet;

        private DgvBt Dgv;

        private DataSourses DS;

        public static string connsql;
        public MainInterface(string sql_transfer)
        {
            InitializeComponent();
            connsql = sql_transfer;

            f = this;

            customer = new SqlConnection
            {
                ConnectionString = sql_transfer
            };
            customer.Open();

            dataTable = new DataTable();

            dataSet = new DataSet();

            Dgv = new DgvBt();

            DS = new DataSourses();

            

            ConfirmChosenButton.Visible = false;

            Dgv.dgv = DisplayView;

            DisplayView.Visible = false;
        }

        private void DisplayView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                //获取控件的值

                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)Dgv.dgv.Rows[e.RowIndex].Cells["cb_check"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true)
                {
                    checkCell.Value = false;
                }
                else
                {
                    checkCell.Value = true;
                }
            }
        }

        private void SearchallToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

        private void SearchMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainInterface_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosed(e);
            Application.Exit(e);
        }

        private void BetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DS.ClickInit(DisplayView,dataTable,dataSet);

            string sql = "select * from dbo.Users";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql,customer);


            dataAdapter.Fill(dataSet);

            dataAdapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count;j++)

                    Console.WriteLine(dataTable.Rows[i][j].ToString());           
            }
        }

        private void ConfirmChosenButton_Click(object sender, EventArgs e)
        {
            string[] results = new string[this.DisplayView.Rows.Count];
            string[] lord = new string[this.DisplayView.Rows.Count];
            int Rcount = 0;
            if (this.DisplayView.DataSource != null)
            {
                for(int i=0;i<this.DisplayView.Rows.Count;i++)
                {
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)Dgv.dgv.Rows[i].Cells["cb_check"];
                    Boolean flag = Convert.ToBoolean(checkCell.Value);
                    if (flag == true)
                    {
                        Console.WriteLine(dataTable.Rows[i]["Lno"].ToString().Trim());
                        results[Rcount] = dataTable.Rows[i]["Hno"].ToString().Trim();
                        lord[Rcount++] = dataTable.Rows[i]["Lno"].ToString().Trim();

                    }
                    else
                    {
                        CurrencyManager cm = (CurrencyManager)BindingContext[DisplayView.DataSource];
                        cm.SuspendBinding();

                        DisplayView.Rows[i].Visible = false;

                        cm.ResumeBinding();
                    }
                }
            }

            this.Hide();
            RentInterface fo = new RentInterface(results,lord);
            fo.Show();

        }

        private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmChosenButton.Visible = false;
            DisplayView.Visible = false;
        }

        private void SelfInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelfInfoBuyers f = new SelfInfoBuyers();
            f.Show();
        }

        private void SquareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NoDiferLookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DS.ClickInit(DisplayView, dataTable, dataSet);

            ConfirmChosenButton.Visible = true;

            string sql = "select * from dbo.Housing;";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, customer);

            dataAdapter.Fill(dataTable);

            DisplayView.AllowUserToAddRows = false;

            DisplayView.DataSource = dataTable;

            Dgv.Init();
        }

        private void RentRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DS.ClickInit(DisplayView, dataTable, dataSet);

            ConfirmChosenButton.Visible = true;

            string sql = "select * from dbo.Rent where Cno = '" + DataSourses.BuyerId + "';"; ;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, customer);

            dataAdapter.Fill(dataTable);

            DisplayView.AllowUserToAddRows = false;

            DisplayView.DataSource = dataTable;

            Dgv.Init();
        }

        private void RevokeButton_Click(object sender, EventArgs e)
        {
            string[] results = new string[this.DisplayView.Rows.Count];
            string[] lord = new string[this.DisplayView.Rows.Count];
            int Rcount = 0;
            if (this.DisplayView.DataSource != null)
            {
                for (int i = 0; i < this.DisplayView.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)Dgv.dgv.Rows[i].Cells["cb_check"];
                    Boolean flag = Convert.ToBoolean(checkCell.Value);
                    if (flag == true)
                    {
                        results[Rcount] = dataTable.Rows[i]["Cno"].ToString().Trim();
                        lord[Rcount++] = dataTable.Rows[i]["Hno"].ToString().Trim();

                    }
                    else
                    {
                        CurrencyManager cm = (CurrencyManager)BindingContext[DisplayView.DataSource];
                        cm.SuspendBinding();

                        DisplayView.Rows[i].Visible = false;

                        cm.ResumeBinding();
                    }
                }
            }
            for(int i=0;i<results.Length;i++)
            {
                string sql = "delete from dbo.Rent where Cno = '" + results[i] + "'" +
                    "and Hno = '"+lord[i]+"';";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = customer;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;

            }

        }

        private void PactSentButton_Click(object sender, EventArgs e)
        {
            string[] Cno = new string[this.DisplayView.Rows.Count];
            string[] Hno = new string[this.DisplayView.Rows.Count];
            string[] Lno = new string[this.DisplayView.Rows.Count];
            string[] Rstart = new string[this.DisplayView.Rows.Count];
            string[] Rtime = new string[this.DisplayView.Rows.Count];

            int Rcount = 0;
            if (this.DisplayView.DataSource != null)
            {
                for (int i = 0; i < this.DisplayView.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)Dgv.dgv.Rows[i].Cells["cb_check"];
                    Boolean flag = Convert.ToBoolean(checkCell.Value);
                    if (flag == true)
                    {
                        Cno[Rcount] = dataTable.Rows[i]["Cno"].ToString().Trim();
                        Lno[Rcount] = dataTable.Rows[i]["Lno"].ToString().Trim();
                        Hno[Rcount] = dataTable.Rows[i]["Hno"].ToString().Trim();
                        Rstart[Rcount] = dataTable.Rows[i]["Rstart"].ToString().Trim();
                        Rtime[Rcount++] = dataTable.Rows[i]["Rtime"].ToString().Trim();
                        Console.WriteLine(Cno[Rcount]);

                    }
                    else
                    {
                        CurrencyManager cm = (CurrencyManager)BindingContext[DisplayView.DataSource];
                        cm.SuspendBinding();

                        DisplayView.Rows[i].Visible = false;

                        cm.ResumeBinding();
                    }
                }
                for (int i = 0; i < Cno.Length; i++)
                {
                    string sql = "insert into dbo.Pacttemp values ('" +
                        Hno[i] + "','" + Lno[i] + "','" + Cno[i] + "','" + Rstart[i] + "','" +
                        Rtime[i] + "');";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = customer;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd = null;

                }
            }
        }

        private void PackLookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DS.ClickInit(DisplayView, dataTable, dataSet);

            ConfirmChosenButton.Visible = false;

            string sql = "select * from dbo.Pact where Cno = '"+DataSourses.BuyerId+"';";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, customer);

            dataAdapter.Fill(dataTable);

            DisplayView.AllowUserToAddRows = false;

            DisplayView.DataSource = dataTable;
        }
    }
}
