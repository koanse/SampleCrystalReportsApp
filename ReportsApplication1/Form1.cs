using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dictDataSetTableAdapters.WGTableAdapter gta = new ReportsApplication1.dictDataSetTableAdapters.WGTableAdapter();
            //gta.Fill(dictDataSet.WG);
            dictDataSetTableAdapters.WordsTableAdapter wta = new ReportsApplication1.dictDataSetTableAdapters.WordsTableAdapter();
            wta.Fill(dictDataSet.Words);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
        }
    }
}