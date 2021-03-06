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
    public partial class DoctorEdit : Form
    {
        DoctorClass doc = new DoctorClass();
        public DoctorEdit()
        {
            InitializeComponent();
        }
      //  string radioSex = null;
        //    foreach (Control contrl in this.groupDxRdBtns.Controls)
          //  {
            //    if (contrl is RadioButton)
              //  {
                //    RadioButton radBtn = contrl as RadioButton;
                  //  if (radBtn.Checked)
                   // {
                    //    radioSex = radBtn.Text;
                   // }
            //}
    
        private void btnHome_Click(object sender, EventArgs e)
        {

            Form1 home = new Form1();
            home.Show();
            Hide();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBxEmailEDIT.Clear();
            txtBxFNameEDIT.Clear();
            txtBxLNameEDIT.Clear();
            txtBxMNameEDIT.Clear();
            txtBxNoteEDIT.Clear();

        }

        private void DoctorEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEditDoctorClinic.Clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.dataSetEditDoctorClinic.Clinic);
            // TODO: This line of code loads data into the 'dataSetEditDoctorDepartment.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetEditDoctorDepartment.Department);
            // TODO: This line of code loads data into the 'dataSetEditDoctorType.DoctorType' table. You can move, or remove it, as needed.
            this.doctorTypeTableAdapter.Fill(this.dataSetEditDoctorType.DoctorType);
            // TODO: This line of code loads data into the 'dataSetEditDoctorStatus.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.dataSetEditDoctorStatus.Status);
            // TODO: This line of code loads data into the 'dataSetEditSelect.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.dataSetEditSelect.Doctor);

        }

        private void btnFillInSELECTEDDoc_Click(object sender, EventArgs e)
        {//doc.Status = Int32.Parse(cmboxStatus.SelectedValue.ToString());
            int getDocID = Int32.Parse(cmBoxSelectDoctor.SelectedValue.ToString());
            doc.getDoctor(getDocID);
            txtBxFNameEDIT.Text = doc.FName;
            txtBxMNameEDIT.Text = doc.MName;
            txtBxLNameEDIT.Text = doc.LName;

            cmBxStatusEDIT.SelectedIndex = doc.Status;
            cmBxTypeEDIT.SelectedIndex = doc.Type;
            cmBxDepartmentEDIT.SelectedIndex = doc.Department;



        }
    }
}
