using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriaratma
{
    public partial class Form1: Form
    {
        private DataSet dataSet = new DataSet();
        private DataTable dataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
            InitializeDataset();
        }
        private void InitializeDataset()
        {
            dataTable.Columns.Add("Ad", typeof(string));
            dataSet.Tables.Add(dataTable);

            dataTable.Rows.Add("güneş");
            dataTable.Rows.Add("ALPARSLAN");
            dataTable.Rows.Add("Yağmur");
            dataTable.Rows.Add("ZARİNA");
            dataTable.Rows.Add("ASLAn");
            dataTable.Rows.Add("şENay");
            dataTable.Rows.Add("deparTman");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = txtarama.Text.Trim().ToLower();
            veri.Items.Clear();
            var results = dataTable.AsEnumerable().Where(row => row.Field<string>("Ad").ToLower().Contains(searchText)).Select(row => row.Field<string>("Ad")).ToList();
            for (int i = 0; i < results.Count; i++)
            {
                veri.Items.Add(results[i]);
            }
            if (veri.Items.Count == 0)
            {
                veri.Items.Add("Böyle Bir Veri Bulunamadı.");
            }
        }
    }
}
