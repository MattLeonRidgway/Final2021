using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The application closed  successfully.", "Closed", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void btnDocRev_Click(object sender, EventArgs e)
        {
            DoctorReview dreview = new DoctorReview();
            dreview.Show();
            Hide();
        }

        private void btnNurseRev_Click(object sender, EventArgs e)
        {
           NurseReview nreview = new NurseReview();
            nreview.Show();
            Hide();
        }

        private void btnDocAddEdit_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
           doc.Show();
            Hide();
        }

        private void btnAddEditNurse_Click(object sender, EventArgs e)
        {
            Nurse nurs = new Nurse();
            nurs.Show();
            Hide();
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            AddData add = new AddData();
            add.Show();
            Hide();
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
           EditData edit = new EditData();
            edit.Show();
            Hide();
        }
    }
}
