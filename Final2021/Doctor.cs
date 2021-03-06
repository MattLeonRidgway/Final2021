﻿using System;
using System.Windows.Forms;

namespace Final2021
{
    public partial class Doctor : Form
    {
        DBConnection connection = new DBConnection();
        DoctorClass doc = new DoctorClass();

        public Doctor()
        {
            InitializeComponent();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetClinic.Clinic' table. You can move, or remove it, as needed.
            this.clinicTableAdapter.Fill(this.dataSetClinic.Clinic);
            // TODO: This line of code loads data into the 'dataSetDepartment.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.dataSetDepartment.Department);
            // TODO: This line of code loads data into the 'dataSetDoctorType.DoctorType' table. You can move, or remove it, as needed.
            this.doctorTypeTableAdapter.Fill(this.dataSetDoctorType.DoctorType);
            // TODO: This line of code loads data into the 'dataSetStatus.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.dataSetStatus.Status);




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

        private void lstBxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmboxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {


        }

      

      

      

       

        private void cmboxStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (ValidateClass.isValidString(txtBxFName.Text))
            {
                doc.FName = txtBxFName.Text;
            }
            else
            {
                txtBxFName.Clear();
                txtBxFName.AppendText("Invalid");
                check = false;
            }
            if (ValidateClass.isValidString(txtBxMName.Text))
            {
                doc.MName = txtBxMName.Text;
            }
            else
            {
                txtBxMName.Clear();
                txtBxMName.AppendText("Invalid");
                check = false;
            }
            if (ValidateClass.isValidString(txtBxLName.Text))
            {
                doc.LName = txtBxLName.Text;
            }
            else
            {
                txtBxLName.Clear();
                txtBxLName.AppendText("Invalid");
                check = false;
            }
           
            if (ValidateClass.isValidEmail(txtBxEmail.Text))
            {
                doc.Email = txtBxEmail.Text;
            }
            else
            {
                txtBxEmail.Clear();
                txtBxEmail.AppendText("Invalid");
                check = false;
            }
            if (ValidateClass.isValidAlphanumeric(txtBxNotes.Text))
            {
                doc.Notes = txtBxNotes.Text;
            }
            else
            {
                txtBxNotes.Clear();
                txtBxNotes.AppendText("Invalid");
                check = false;
            }
            if (check)
            {
                doc.Status = Int32.Parse(cmboxStatus.SelectedValue.ToString());
                doc.Type = Int32.Parse(cmboxType.SelectedValue.ToString());
                doc.Department = Int32.Parse(cmBoxDepartmnet.SelectedValue.ToString());
                doc.Clinic = Int32.Parse(cmboxClinic.SelectedValue.ToString());

                doc.InsertDoctor(doc.FName, doc.MName, doc.LName, doc.Status, doc.Type, doc.Department,
                    doc.Clinic, doc.Email, doc.Notes);
                txtBxEmail.Clear();
                txtBxFName.Clear();
                txtBxLName.Clear();
                txtBxMName.Clear();
                txtBxNotes.Clear();
             
            }
            else
            {
                MessageBox.Show("Correct Errors");
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
