
namespace Final2021
{
    partial class Nurse
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
            this.txtBxNote = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxLName = new System.Windows.Forms.TextBox();
            this.txtBxMName = new System.Windows.Forms.TextBox();
            this.editAddNurse = new System.Windows.Forms.Button();
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmboxStatus = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetNurseAddStatus = new Final2021.DataSet.DataSetNurseAddStatus();
            this.cmboxType = new System.Windows.Forms.ComboBox();
            this.nurseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetNurseTypeAdd = new Final2021.DataSet.DataSetNurseTypeAdd();
            this.cmboxDepartment = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetNurseDepartmentAdd = new Final2021.DataSet.DataSetNurseDepartmentAdd();
            this.cmboxClinic = new System.Windows.Forms.ComboBox();
            this.clinicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetNurseClinicAdd = new Final2021.DataSet.DataSetNurseClinicAdd();
            this.statusTableAdapter = new Final2021.DataSet.DataSetNurseAddStatusTableAdapters.StatusTableAdapter();
            this.nurseTypeTableAdapter = new Final2021.DataSet.DataSetNurseTypeAddTableAdapters.NurseTypeTableAdapter();
            this.departmentTableAdapter = new Final2021.DataSet.DataSetNurseDepartmentAddTableAdapters.DepartmentTableAdapter();
            this.clinicTableAdapter = new Final2021.DataSet.DataSetNurseClinicAddTableAdapters.ClinicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseAddStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseTypeAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseDepartmentAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseClinicAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxNote
            // 
            this.txtBxNote.Location = new System.Drawing.Point(342, 313);
            this.txtBxNote.Name = "txtBxNote";
            this.txtBxNote.Size = new System.Drawing.Size(197, 20);
            this.txtBxNote.TabIndex = 42;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(342, 286);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(197, 20);
            this.txtBxEmail.TabIndex = 41;
            // 
            // txtBxLName
            // 
            this.txtBxLName.Location = new System.Drawing.Point(344, 146);
            this.txtBxLName.Name = "txtBxLName";
            this.txtBxLName.Size = new System.Drawing.Size(197, 20);
            this.txtBxLName.TabIndex = 40;
            // 
            // txtBxMName
            // 
            this.txtBxMName.Location = new System.Drawing.Point(344, 120);
            this.txtBxMName.Name = "txtBxMName";
            this.txtBxMName.Size = new System.Drawing.Size(197, 20);
            this.txtBxMName.TabIndex = 39;
            // 
            // editAddNurse
            // 
            this.editAddNurse.Location = new System.Drawing.Point(388, 350);
            this.editAddNurse.Name = "editAddNurse";
            this.editAddNurse.Size = new System.Drawing.Size(75, 23);
            this.editAddNurse.TabIndex = 38;
            this.editAddNurse.Text = "ADD";
            this.editAddNurse.UseVisualStyleBackColor = true;
            this.editAddNurse.Click += new System.EventHandler(this.editAddNurse_Click);
            // 
            // txtBxFName
            // 
            this.txtBxFName.Location = new System.Drawing.Point(344, 94);
            this.txtBxFName.Name = "txtBxFName";
            this.txtBxFName.Size = new System.Drawing.Size(197, 20);
            this.txtBxFName.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(257, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Notes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Clinic";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "ADD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 42);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nurse";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(290, 415);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 77;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(481, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 80;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(388, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 79;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmboxStatus
            // 
            this.cmboxStatus.DataSource = this.statusBindingSource;
            this.cmboxStatus.DisplayMember = "StatusType";
            this.cmboxStatus.FormattingEnabled = true;
            this.cmboxStatus.Location = new System.Drawing.Point(344, 172);
            this.cmboxStatus.Name = "cmboxStatus";
            this.cmboxStatus.Size = new System.Drawing.Size(197, 21);
            this.cmboxStatus.TabIndex = 81;
            this.cmboxStatus.ValueMember = "StatusID";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.dataSetNurseAddStatus;
            // 
            // dataSetNurseAddStatus
            // 
            this.dataSetNurseAddStatus.DataSetName = "DataSetNurseAddStatus";
            this.dataSetNurseAddStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmboxType
            // 
            this.cmboxType.DataSource = this.nurseTypeBindingSource;
            this.cmboxType.DisplayMember = "Type";
            this.cmboxType.FormattingEnabled = true;
            this.cmboxType.Location = new System.Drawing.Point(342, 206);
            this.cmboxType.Name = "cmboxType";
            this.cmboxType.Size = new System.Drawing.Size(197, 21);
            this.cmboxType.TabIndex = 82;
            this.cmboxType.ValueMember = "TypeID";
            // 
            // nurseTypeBindingSource
            // 
            this.nurseTypeBindingSource.DataMember = "NurseType";
            this.nurseTypeBindingSource.DataSource = this.dataSetNurseTypeAdd;
            // 
            // dataSetNurseTypeAdd
            // 
            this.dataSetNurseTypeAdd.DataSetName = "DataSetNurseTypeAdd";
            this.dataSetNurseTypeAdd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmboxDepartment
            // 
            this.cmboxDepartment.DataSource = this.departmentBindingSource;
            this.cmboxDepartment.DisplayMember = "Department";
            this.cmboxDepartment.FormattingEnabled = true;
            this.cmboxDepartment.Location = new System.Drawing.Point(344, 233);
            this.cmboxDepartment.Name = "cmboxDepartment";
            this.cmboxDepartment.Size = new System.Drawing.Size(197, 21);
            this.cmboxDepartment.TabIndex = 83;
            this.cmboxDepartment.ValueMember = "DepartmentID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.dataSetNurseDepartmentAdd;
            // 
            // dataSetNurseDepartmentAdd
            // 
            this.dataSetNurseDepartmentAdd.DataSetName = "DataSetNurseDepartmentAdd";
            this.dataSetNurseDepartmentAdd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmboxClinic
            // 
            this.cmboxClinic.DataSource = this.clinicBindingSource;
            this.cmboxClinic.DisplayMember = "Clinic";
            this.cmboxClinic.FormattingEnabled = true;
            this.cmboxClinic.Location = new System.Drawing.Point(344, 259);
            this.cmboxClinic.Name = "cmboxClinic";
            this.cmboxClinic.Size = new System.Drawing.Size(197, 21);
            this.cmboxClinic.TabIndex = 84;
            this.cmboxClinic.ValueMember = "ClinicID";
            // 
            // clinicBindingSource
            // 
            this.clinicBindingSource.DataMember = "Clinic";
            this.clinicBindingSource.DataSource = this.dataSetNurseClinicAdd;
            // 
            // dataSetNurseClinicAdd
            // 
            this.dataSetNurseClinicAdd.DataSetName = "DataSetNurseClinicAdd";
            this.dataSetNurseClinicAdd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // nurseTypeTableAdapter
            // 
            this.nurseTypeTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // clinicTableAdapter
            // 
            this.clinicTableAdapter.ClearBeforeFill = true;
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmboxClinic);
            this.Controls.Add(this.cmboxDepartment);
            this.Controls.Add(this.cmboxType);
            this.Controls.Add(this.cmboxStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtBxNote);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtBxLName);
            this.Controls.Add(this.txtBxMName);
            this.Controls.Add(this.editAddNurse);
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
            this.Name = "Nurse";
            this.Text = "Nurse";
            this.Load += new System.EventHandler(this.Nurse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseAddStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseTypeAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseDepartmentAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseClinicAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxNote;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxLName;
        private System.Windows.Forms.TextBox txtBxMName;
        private System.Windows.Forms.Button editAddNurse;
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
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmboxStatus;

        private System.Windows.Forms.ComboBox cmboxType;
        private System.Windows.Forms.ComboBox cmboxDepartment;
        private System.Windows.Forms.ComboBox cmboxClinic;
        private DataSet.DataSetNurseAddStatus dataSetNurseAddStatus;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private DataSet.DataSetNurseAddStatusTableAdapters.StatusTableAdapter statusTableAdapter;
        private DataSet.DataSetNurseTypeAdd dataSetNurseTypeAdd;
        private System.Windows.Forms.BindingSource nurseTypeBindingSource;
        private DataSet.DataSetNurseTypeAddTableAdapters.NurseTypeTableAdapter nurseTypeTableAdapter;
        private DataSet.DataSetNurseDepartmentAdd dataSetNurseDepartmentAdd;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DataSet.DataSetNurseDepartmentAddTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private DataSet.DataSetNurseClinicAdd dataSetNurseClinicAdd;
        private System.Windows.Forms.BindingSource clinicBindingSource;
        private DataSet.DataSetNurseClinicAddTableAdapters.ClinicTableAdapter clinicTableAdapter;
    }
}