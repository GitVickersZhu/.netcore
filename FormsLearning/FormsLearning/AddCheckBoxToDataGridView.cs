using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLearning
{
    class AddCheckBoxToDataGridView
    {
        public static System.Windows.Forms.DataGridView dgv;
        public static void AddFullSelect()
        {
            if (dgv.Rows.Count < 1)
            {
                return;
            }
            System.Windows.Forms.CheckBox ckBox = new System.Windows.Forms.CheckBox();
            ckBox.Text = "全选";
            ckBox.Checked = true;
            System.Drawing.Rectangle rect =
                dgv.GetCellDisplayRectangle(0, -1, true);
            ckBox.Size = new System.Drawing.Size(dgv.Columns[0].Width, 18);
            ckBox.Location = rect.Location;
            ckBox.CheckedChanged += new EventHandler(ckBox_CheckedChanged);
            dgv.Controls.Add(ckBox);
        }
        static void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells[0].Value = ((System.Windows.Forms.CheckBox)sender).Checked;
            }
            dgv.EndEdit();
        }
    }
}
