
namespace Final2021
{
    partial class Doctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtBxNotes = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxLName = new System.Windows.Forms.TextBox();
            this.txtBxMName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBxFName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmboxClinic = new System.Windows.Forms.ComboBox();
            this.cmBoxDepartmnet = new System.Windows.Forms.ComboBox();
            this.cmboxType = new System.Windows.Forms.ComboBox();
            this.cmboxStatus = new System.Windows.Forms.ComboBox();
            this.dataSetStatus = new Final2021.DataSet.DataSetStatus();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new Final2021.DataSet.DataSetStatusTableAdapters.StatusTableAdapter();
            this.dataSetDoctorType = new Final2021.DataSet.DataSetDoctorType();
            this.doctorTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTypeTableAdapter = new Final2021.DataSet.DataSetDoctorTypeTableAdapters.DoctorTypeTableAdapter();
            this.dataSetDepartment = new Final2021.DataSet.DataSetDepartment();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new Final2021.DataSet.DataSetDepartmentTableAdapters.DepartmentTableAdapter();
            this.dataSetClinic = new Final2021.DataSet.DataSetClinic();
            this.clinicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicTableAdapter = new Final2021.DataSet.DataSetClinicTableAdapters.ClinicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDoctorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClinic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(11, 412);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 128;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtBxNotes
            // 
            this.txtBxNotes.Location = new System.Drawing.Point(318, 312);
            this.txtBxNotes.Name = "txtBxNotes";
            this.txtBxNotes.Size = new System.Drawing.Size(197, 20);
            this.txtBxNotes.TabIndex = 95;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(318, 286);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(197, 20);
            this.txtBxEmail.TabIndex = 94;
            // 
            // txtBxLName
            // 
            this.txtBxLName.Location = new System.Drawing.Point(318, 141);
            this.txtBxLName.Name = "txtBxLName";
            this.txtBxLName.Size = new System.Drawing.Size(197, 20);
            this.txtBxLName.TabIndex = 93;
            // 
            // txtBxMName
            // 
            this.txtBxMName.Location = new System.Drawing.Point(318, 115);
            this.txtBxMName.Name = "txtBxMName";
            this.txtBxMName.Size = new System.Drawing.Size(197, 20);
            this.txtBxMName.TabIndex = 92;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(363, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 91;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBxFName
            // 
            this.txtBxFName.Location = new System.Drawing.Point(318, 89);
            this.txtBxFName.Name = "txtBxFName";
            this.txtBxFName.Size = new System.Drawing.Size(197, 20);
            this.txtBxFName.TabIndex = 90;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(233, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 89;
            this.label12.Text = "Notes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 88;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 87;
            this.label10.Text = "Clinic";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 86;
            this.label9.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 85;
            this.label8.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 79;
            this.label2.Text = "ADD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 42);
            this.label1.TabIndex = 78;
            this.label1.Text = "Doctor";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(716, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 131;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(363, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 130;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmboxClinic
            // 
            this.cmboxClinic.DataSource = this.clinicBindingSource;
            this.cmboxClinic.DisplayMember = "Clinic";
            this.cmboxClinic.FormattingEnabled = true;
            this.cmboxClinic.Location = new System.Drawing.Point(318, 259);
            this.cmboxClinic.Name = "cmboxClinic";
            this.cmboxClinic.Size = new System.Drawing.Size(197, 21);
            this.cmboxClinic.TabIndex = 134;
            this.cmboxClinic.ValueMember = "ClinicID";
            // 
            // cmBoxDepartmnet
            // 
            this.cmBoxDepartmnet.DataSource = this.departmentBindingSource;
            this.cmBoxDepartmnet.DisplayMember = "Department";
            this.cmBoxDepartmnet.FormattingEnabled = true;
            this.cmBoxDepartmnet.Location = new System.Drawing.Point(318, 234);
            this.cmBoxDepartmnet.Name = "cmBoxDepartmnet";
            this.cmBoxDepartmnet.Size = new System.Drawing.Size(197, 21);
            this.cmBoxDepartmnet.TabIndex = 135;
            this.cmBoxDepartmnet.ValueMember = "DepartmentID";
            // 
            // cmboxType
            // 
            this.cmboxType.DataSource = this.doctorTypeBindingSource;
            this.cmboxType.DisplayMember = "Type";
            this.cmboxType.FormattingEnabled = true;
            this.cmboxType.Location = new System.Drawing.Point(318, 203);
            this.cmboxType.Name = "cmboxType";
            this.cmboxType.Size = new System.Drawing.Size(197, 21);
            this.cmboxType.TabIndex = 136;
            this.cmboxType.ValueMember = "TypeID";
            // 
            // cmboxStatus
            // 
            this.cmboxStatus.DataSource = this.statusBindingSource;
            this.cmboxStatus.DisplayMember = "StatusType";
            this.cmboxStatus.FormattingEnabled = true;
            this.cmboxStatus.Location = new System.Drawing.Point(318, 173);
            this.cmboxStatus.Name = "cmboxStatus";
            this.cmboxStatus.Size = new System.Drawing.Size(197, 21);
            this.cmboxStatus.TabIndex = 137;
            this.cmboxStatus.ValueMember = "StatusID";
            this.cmboxStatus.SelectedIndexChanged += new System.EventHandler(this.cmboxStatus_SelectedIndexChanged_1);
            // 
            // dataSetStatus
            // 
            this.dataSetStatus.DataSetName = "DataSetStatus";
            this.dataSetStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.dataSetStatus;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetDoctorType
            // 
            this.dataSetDoctorType.DataSetName = "DataSetDoctorType";
            this.dataSetDoctorType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorTypeBindingSource
            // 
            this.doctorTypeBindingSource.DataMember = "DoctorType";
            this.doctorTypeBindingSource.DataSource = this.dataSetDoctorType;
            // 
            // doctorTypeTableAdapter
            // 
            this.doctorTypeTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetDepartment
            // 
            this.dataSetDepartment.DataSetName = "DataSetDepartment";
            this.dataSetDepartment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.dataSetDepartment;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetClinic
            // 
            this.dataSetClinic.DataSetName = "DataSetClinic";
            this.dataSetClinic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicBindingSource
            // 
            this.clinicBindingSource.DataMember = "Clinic";
            this.clinicBindingSource.DataSource = this.dataSetClinic;
            // 
            // clinicTableAdapter
            // 
            this.clinicTableAdapter.ClearBeforeFill = true;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 455);
            this.Controls.Add(this.cmboxStatus);
            this.Controls.Add(this.cmboxType);
            this.Controls.Add(this.cmBoxDepartmnet);
            this.Controls.Add(this.cmboxClinic);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtBxNotes);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtBxLName);
            this.Controls.Add(this.txtBxMName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBxFName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDoctorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClinic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtBxNotes;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxLName;
        private System.Windows.Forms.TextBox txtBxMName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBxFName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmboxClinic;
  

        private System.Windows.Forms.ComboBox cmBoxDepartmnet;
        private System.Windows.Forms.ComboBox cmboxType;
        private System.Windows.Forms.ComboBox cmboxStatus;
        private DataSet.DataSetStatus dataSetStatus;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private DataSet.DataSetStatusTableAdapters.StatusTableAdapter statusTableAdapter;
        private DataSet.DataSetDoctorType dataSetDoctorType;
        private System.Windows.Forms.BindingSource doctorTypeBindingSource;
        private DataSet.DataSetDoctorTypeTableAdapters.DoctorTypeTableAdapter doctorTypeTableAdapter;
        private DataSet.DataSetDepartment dataSetDepartment;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DataSet.DataSetDepartmentTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private DataSet.DataSetClinic dataSetClinic;
        private System.Windows.Forms.BindingSource clinicBindingSource;
        private DataSet.DataSetClinicTableAdapters.ClinicTableAdapter clinicTableAdapter;
    }
}