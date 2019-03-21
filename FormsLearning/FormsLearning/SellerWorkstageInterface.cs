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
using System.Globalization;
using Microsoft.VisualBasic;

namespace FormsLearning
{
    public partial class SellerWorkstageInterface : Form
    {
        public static Form f;

        public static string connsql;

        public static SqlConnection sellers;

        public static DataTable tbl;

        private static DataSet dataSet;

        private DgvBt dgv;

        private DataSourses DsControl;

        public SellerWorkstageInterface(string sql_transfer)
        {
            InitializeComponent();

            sellers = new SqlConnection
            {
                ConnectionString = sql_transfer
            };
            connsql = sql_transfer;

            sellers.Open();

            tbl = new DataTable();

            dataSet = new DataSet();

            DsControl = new DataSourses();

            dgv = new DgvBt();

            f = this;

            DataGridViewLeft.Visible = false;

            DataGridViewRight.Visible = false;


            
        }

        private void HouseLookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewLeft.Visible = true;
            DsControl.ClickInit(DataGridViewLeft,tbl,dataSet);
            dgv.dgv = DataGridViewLeft;

            string sql = "select * from dbo.Housing where Lno = '"+DataSourses.SellerId+"';";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql,sellers);
            dataAdapter.Fill(tbl);
            DataGridViewLeft.AllowUserToAddRows = false;

            DataGridViewLeft.DataSource = tbl;
            dgv.Init();


        }

        private void SelfInfoSellersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelfInfoSellers fo = new SelfInfoSellers();
            fo.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Application.Exit(e);
            sellers.Close();
        }

        private void SellerWorkstageInterface_Load(object sender, EventArgs e)
        {

        }

        private void HouseAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddHouseInterface fo = new AddHouseInterface();
            fo.Show();

        }

        private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewLeft.Visible = false;

            DataGridViewRight.Visible = false;
        }

        private void DataGridViewLeft_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                //获取控件的值

                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dgv.dgv.Rows[e.RowIndex].Cells["cb_check"];
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

        private void DataGridViewRight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                //获取控件的值

                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dgv.dgv.Rows[e.RowIndex].Cells["cb_check"];
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

        private void RentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DsControl.ClickInit(DataGridViewLeft,tbl,dataSet);
            dgv.dgv = DataGridViewLeft;

            string sql = "select * from dbo.Rent where Lno = '" + DataSourses.SellerId + "';";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql,sellers);

            dataAdapter.Fill(tbl);

            DataGridViewLeft.AllowUserToAddRows = false;

            DataGridViewLeft.DataSource = tbl;
            dgv.Init();
        }

        private void PactRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DsControl.ClickInit(DataGridViewLeft, tbl, dataSet);
            DsControl.ClickInit(DataGridViewRight, tbl, dataSet);

            DataGridViewRight.Visible = true;

            dgv.dgv = DataGridViewRight;

            string sql = "select * from dbo.Pacttemp where Lno = '" + DataSourses.SellerId + "';";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, sellers);

            dataAdapter.Fill(tbl);

            DataGridViewRight.AllowUserToAddRows = false;

            DataGridViewRight.DataSource = tbl;
            dgv.Init();
        }

        private void AddPactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string GetPno = Interaction.InputBox("您的合同号", "合同号", "", -1, -1).Trim();
            if (GetPno.Trim() == null) return;

            string[] Cno = new string[this.DataGridViewRight.Rows.Count];
            string[] Hno = new string[this.DataGridViewRight.Rows.Count];
            string[] Lno = new string[this.DataGridViewRight.Rows.Count];
            string[] Rstart = new string[this.DataGridViewRight.Rows.Count];
            string[] Rtime = new string[this.DataGridViewRight.Rows.Count];

            int Rcount = 0;
            if (this.DataGridViewRight.DataSource != null)
            {
                for (int i = 0; i < this.DataGridViewRight.Rows.Count; i++)
                {

                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dgv.dgv.Rows[i].Cells["cb_check"];
                    Boolean flag = Convert.ToBoolean(checkCell.Value);
                    if (flag == true)
                    {
                        Cno[Rcount] = tbl.Rows[i]["Cno"].ToString().Trim();
                        Lno[Rcount] = tbl.Rows[i]["Lno"].ToString().Trim();
                        Hno[Rcount] = tbl.Rows[i]["Hno"].ToString().Trim();
                        //Rstart[Rcount] = tbl.Rows[i]["Pstart"].ToString().Trim();
                        DateTime tm = (DateTime)tbl.Rows[i]["Pstart"];
                        Rstart[Rcount] = tm.ToShortDateString().ToString().Trim();
                        Rtime[Rcount++] = tbl.Rows[i]["Ptime"].ToString().Trim();

                    }
                    else
                    {
                        CurrencyManager cm = (CurrencyManager)BindingContext[DataGridViewRight.DataSource];
                        cm.SuspendBinding();

                        DataGridViewRight.Rows[i].Visible = false;

                        cm.ResumeBinding();
                    }
                }


                for (int i = 0; i < Cno.Length; i++)
                {


                    string sql = "insert into dbo.Pact values ('" +
                        GetPno + "','" + Hno[i] + "','" + Lno[i] + "','" + Cno[i] + "','" + Rstart[i] + "','" +
                        Rtime[i] + "');";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sellers;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd = null;

                }
                MessageBox.Show("添加成功！！！");
            }

        }

        private void PactLookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DsControl.ClickInit(DataGridViewLeft, tbl, dataSet);

            DataGridViewRight.Visible = true;
            DsControl.ClickInit(DataGridViewRight, tbl, dataSet);

            dgv.dgv = DataGridViewRight;

            string sql = "select * from dbo.Pact where Lno = '" + DataSourses.SellerId + "';";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, sellers);

            dataAdapter.Fill(tbl);

            DataGridViewRight.AllowUserToAddRows = false;

            DataGridViewRight.DataSource = tbl;
            dgv.Init();
        }
    }

}
