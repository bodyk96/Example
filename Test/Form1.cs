using System;
using System.Windows.Forms;
using Patterns.AbstractFactory;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            DataSource ds = new DataSource(DataType.DB);
            txtData.Text = ds.GetDataFromSource();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            DataSource ds = new DataSource(DataType.File);
            txtData.Text = ds.GetDataFromSource();
        }
    }
}