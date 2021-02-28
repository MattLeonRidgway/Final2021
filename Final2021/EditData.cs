using System;
using System.Windows.Forms;

namespace Final2021
{
    public partial class EditData : Form
    {
        public EditData()
        {
            InitializeComponent();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Hide();
        }

        private void EditData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetNurseType.NurseType' table. You can move, or remove it, as needed.
            this.nurseTypeTableAdapter.Fill(this.dataSetNurseType.NurseType);
            // TODO: This line of code loads data into the 'dataSet.Doctor' table. You can move, or remove it, as needed.
     

        }
    }
}
