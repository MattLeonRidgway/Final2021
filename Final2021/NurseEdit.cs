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
    public partial class NurseEdit : Form
    {
        public NurseEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBxEditEmail.Clear();
            txtBxEditFName.Clear();
            txtBxEditLName.Clear();
            txtBxEditMName.Clear();
            txtBxEditNote.Clear();
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

        private void NurseEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetNurseEditClinic.Clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.dataSetNurseEditClinic.Clinic);
            // TODO: This line of code loads data into the 'dataSetNurseEditDepartment.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetNurseEditDepartment.Department);
            // TODO: This line of code loads data into the 'dataSetNurseEditType.NurseType' table. You can move, or remove it, as needed.
            this.nurseTypeTableAdapter.Fill(this.dataSetNurseEditType.NurseType);
            // TODO: This line of code loads data into the 'dataSetNurseEditStatus.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.dataSetNurseEditStatus.Status);
            // TODO: This line of code loads data into the 'dataSetSelectNurse.Nurse' table. You can move, or remove it, as needed.
            this.nurseTableAdapter.Fill(this.dataSetSelectNurse.Nurse);

        }
    }
}
