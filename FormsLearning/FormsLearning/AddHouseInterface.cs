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
    public partial class AddHouseInterface : Form
    {
        DataSourses DsControl;
        public AddHouseInterface()
        {
            InitializeComponent();

            DsControl = new DataSourses(1);
        }

        private void AddHouseInterface_Load(object sender, EventArgs e)
        {

        }

        private void ComIpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AreaIpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void FloorIpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModelIpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NrtrIpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void StateIpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TmIpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void FeeIpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepositIpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MagicIpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string frn;
            if(Frn.Checked == true)
            {
                frn = "是";
            }
            else
            {
                frn = "否";
            }

            string Hno = DsControl.CreateHouseId();
            MessageBox.Show("123");
            string sql = "insert into dbo.Housing values" +
                "('" + Hno.Trim() + "','"+DataSourses.SellerCount+"','" +
                ComIpt.Text.Trim() + "','" + AreaIpt.Text.Trim() + "','" + FloorIpt.Text.Trim() + "','" +
                ModelIpt.Text.Trim() + "','" + frn + "','" + NrtrIpt.Text.Trim() + "','" + StateIpt.Text.Trim() +
                "','" + TmIpt.Text.Trim() + "','" + MagicIpt.Text.Trim() + "','" + FeeIpt.Text.Trim() + "','" +
                DepositIpt.Text.Trim() + "'); ";
                //+
                //"update dbo.Housing set Lno = Landlord.Lno where ";
            Console.WriteLine(sql);


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SellerWorkstageInterface.sellers;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sucessful!!!");
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            SellerWorkstageInterface.f.Show();
        }
    }
}
