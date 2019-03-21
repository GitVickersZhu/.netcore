using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FormsLearning
{
    class DataSourses
    {

        public static string BuyerCount;
        public static string SellerCount;
        public static string HouseCount;
        public static string BuyerId;
        public static string SellerId;
        public static string PactId;
        public DataSourses() { }
        public DataSourses(int judge)
        {
            Random rd = new Random();
            rd.Next(1000000000,2000000000);
            BuyerCount = rd.Next(1000000000, 2000000000).ToString();
            SellerCount = rd.Next(1000000000, 2000000000).ToString();
            HouseCount = rd.Next(1000000000, 2000000000).ToString();



        }
        ~DataSourses()
        {
        }

        public void GetSellersInfo (SqlConnection conn , DataTable table)
        {

        }
        public void RemoveEmpty(DataTable dt)
        {
            List<DataRow> removelist = new List<DataRow>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool IsNull = true;
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (!string.IsNullOrEmpty(dt.Rows[i][j].ToString().Trim()))
                    {
                        IsNull = false;
                    }
                }
                if (IsNull)
                {
                    removelist.Add(dt.Rows[i]);
                }
            }
            for (int i = 0; i < removelist.Count; i++)
            {
                dt.Rows.Remove(removelist[i]);
            }
        }
        public void ClickInit(DataGridView DisplayView,DataTable dataTable,DataSet dataSet)
        {
            DisplayView.Columns.Clear();
            DisplayView.DataSource = null;
            dataSet.Clear();
            dataTable.Columns.Clear();
            dataTable.Clear();
            DisplayView.Visible = true;
        }

        public string UsersSavedBuyers(DataTable Sourses,string login)
        {

            for (int i = 0; i < Sourses.Rows.Count; i++)
            {


                if ( Sourses.Rows[i].IsNull("Seller") && login.Trim() == Sourses.Rows[i][3].ToString().Trim())
                {
                    BuyerId = Sourses.Rows[i]["Buyer"].ToString().Trim();
                    return Sourses.Rows[i][4].ToString().Trim();

                }
         
            }
            return null;

        }
        public string UsersSavedSellers(DataTable Sourses, string login)
        {

            for (int i = 0; i < Sourses.Rows.Count; i++)
            {

                if (login.Trim() == Sourses.Rows[i][3].ToString().Trim() && Sourses.Rows[i].IsNull("Buyer"))
                {
                    SellerId = Sourses.Rows[i]["Seller"].ToString().Trim();
                    return Sourses.Rows[i][4].ToString().Trim();
                }

            }
            return null;

        }

        public  string CreateCustomerId()
        {
            long buytemp = long.Parse(BuyerCount);
            buytemp++;
            BuyerCount = buytemp.ToString();

            return BuyerCount;
        }
        public string CreateLandlordId()
        {
            long sellertemp = long.Parse(SellerCount);
            sellertemp++;
            SellerCount = sellertemp.ToString();

            return SellerCount;
        }

        public string CreateHouseId()
        {
            long housetemp = long.Parse(HouseCount);
            housetemp++;
            HouseCount = housetemp.ToString();

            return HouseCount;
        }



    }
}
