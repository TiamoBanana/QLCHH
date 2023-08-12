using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ReportHoaDon : Form
    {
        public ReportHoaDon()
        {
            InitializeComponent();
        }

        private void ReportHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
            ("Data Source= DESKTOP-GJBE31F\\SQLEXPRESS;  Initial Catalog=QLCHH; Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from HOADON", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HOADON");
            ReportDataSource report = new ReportDataSource();
            report.Name = "HOADON";
            report.Value = ds.Tables[0];
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(report);
            this.reportViewer1.RefreshReport();
  
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
