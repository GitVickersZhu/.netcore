using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLearning
{
    class DgvBt
    {
        public DataGridView dgv;

        public void Init()
        {
            DataGridViewCheckBoxColumn columncb = new DataGridViewCheckBoxColumn();
            columncb.HeaderText = "选择";
            columncb.Name = "cb_check";
            columncb.TrueValue = true;
            columncb.FalseValue = false;
            //column9.DataPropertyName = "IsScienceNature";
            columncb.DataPropertyName = "IsChecked";
            dgv.Columns.Insert(0,columncb);
            SetAllRowChecked();
        }

        private void SetAllRowChecked()
        {
            // DataGridCell cel=(sender as DataGridCell).
            int count = Convert.ToInt16(dgv.Rows.Count.ToString());
            for (int i = 0; i < count; i++)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)dgv.Rows[i].Cells["cb_check"];
                Boolean flag = Convert.ToBoolean(checkCell.Value);
                if (flag == true) //查找被选择的数据行
                {
                    checkCell.Value = false;
                }
                continue;
            }
        }

    }
}
