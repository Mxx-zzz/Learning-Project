using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _001
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        DataTable dataTable = new DataTable();
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dataRow;
            dataRow = dataTable.NewRow();
            dataRow["username"] = this.textBox1.Text;
            dataTable.Rows.Add(dataRow);
            Method(dataTable);

        }
        /// <summary>
        /// 显示数据表中的内容
        /// </summary>
        /// <param name="dataTable"></param>
        private void Method(DataTable dataTable)
        {
            listView2.Items.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listView2.Items.Add(dataTable.Rows[i][0].ToString(), 0);
                }
                else
                {
                    listView2.Items.Add(dataTable.Rows[i][0].ToString(), 1);
                }

            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            listView2.View = View.LargeIcon;
            listView2.LargeImageList = imageList1;
            DataColumn dataColumn = new DataColumn();
            dataColumn.DataType = System.Type.GetType("System.String");
            dataColumn.ColumnName = "userName";
            dataTable.Columns.Add(dataColumn);
        }
    }
}
