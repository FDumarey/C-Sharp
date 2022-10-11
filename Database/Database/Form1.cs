using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet.Titles' table. You can move, or remove it, as needed.
            this.titlesTableAdapter.Fill(this.booksDataSet.Titles);
            btnFirst.PerformClick();
        }

        private void UpdateTitle()
        {
            this.Text = "Books Database - Record " + (dataTable1BindingSource.Position + 1).ToString() + " of " + dataTable1BindingSource.Count.ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            btnFirst.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            dataTable1BindingSource.MoveFirst();
            UpdateTitle();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnFirst.Enabled = true;
            btnPrevious.Enabled = true;
            dataTable1BindingSource.MoveNext();
            if (dataTable1BindingSource.Position == dataTable1BindingSource.Count-1)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            UpdateTitle();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            dataTable1BindingSource.MovePrevious();
            if (dataTable1BindingSource.Position == 0)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
            }
            UpdateTitle();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            btnFirst.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            dataTable1BindingSource.MoveLast();
            UpdateTitle();
        }
    }
}
