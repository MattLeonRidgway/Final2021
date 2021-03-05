
namespace Final2021
{
    partial class DoctorEdit
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEDITSave = new System.Windows.Forms.Button();
            this.cmBxStatusEDIT = new System.Windows.Forms.ComboBox();
            this.cmBxTypeEDIT = new System.Windows.Forms.ComboBox();
            this.cmBxDepartmentEDIT = new System.Windows.Forms.ComboBox();
            this.cmBxClinicEDIT = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEditSelect = new Final2021.DataSet.DataSetEditSelect();
            this.groupBxSexEDIT = new System.Windows.Forms.GroupBox();
            this.radioBtnMaleEDIT = new System.Windows.Forms.RadioButton();
            this.radioBtnFemaleEDIt = new System.Windows.Forms.RadioButton();
            this.btnFillInSELECTEDDoc = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBxNoteEDIT = new System.Windows.Forms.TextBox();
            this.txtBxEmailEDIT = new System.Windows.Forms.TextBox();
            this.txtBxLNameEDIT = new System.Windows.Forms.TextBox();
            this.txtBxMNameEDIT = new System.Windows.Forms.TextBox();
            this.txtBxFNameEDIT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.doctorTableAdapter = new Final2021.DataSet.DataSetEditSelectTableAdapters.DoctorTableAdapter();
            this.dataSetEditDoctorStatus = new Final2021.DataSet.DataSetEditDoctorStatus();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new Final2021.DataSet.DataSetEditDoctorStatusTableAdapters.StatusTableAdapter();
            this.dataSetEditDoctorType = new Final2021.DataSet.DataSetEditDoctorType();
            this.doctorTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTypeTableAdapter = new Final2021.DataSet.DataSetEditDoctorTypeTableAdapters.DoctorTypeTableAdapter();
            this.dataSetEditDoctorDepartment = new Final2021.DataSet.DataSetEditDoctorDepartment();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new Final2021.DataSet.DataSetEditDoctorDepartmentTableAdapters.DepartmentTableAdapter();
            this.dataSetEditDoctorClinic = new Final2021.DataSet.DataSetEditDoctorClinic();
            this.clinicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicTableAdapter = new Final2021.DataSet.DataSetEditDoctorClinicTableAdapters.ClinicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditSelect)).BeginInit();
            this.groupBxSexEDIT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorClinic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(696, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 135;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(371, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 134;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(37, 415);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 133;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEDITSave
            // 
            this.btnEDITSave.Location = new System.Drawing.Point(371, 360);
            this.btnEDITSave.Name = "btnEDITSave";
            this.btnEDITSave.Size = new System.Drawing.Size(75, 23);
            this.btnEDITSave.TabIndex = 132;
            this.btnEDITSave.Text = "Save";
            this.btnEDITSave.UseVisualStyleBackColor = true;
            // 
            // cmBxStatusEDIT
            // 
            this.cmBxStatusEDIT.DataSource = this.statusBindingSource;
            this.cmBxStatusEDIT.DisplayMember = "StatusType";
            this.cmBxStatusEDIT.FormattingEnabled = true;
            this.cmBxStatusEDIT.Location = new System.Drawing.Point(315, 187);
            this.cmBxStatusEDIT.Name = "cmBxStatusEDIT";
            this.cmBxStatusEDIT.Size = new System.Drawing.Size(197, 21);
            this.cmBxStatusEDIT.TabIndex = 172;
            this.cmBxStatusEDIT.ValueMember = "StatusID";
            // 
            // cmBxTypeEDIT
            // 
            this.cmBxTypeEDIT.DataSource = this.doctorTypeBindingSource;
            this.cmBxTypeEDIT.DisplayMember = "Type";
            this.cmBxTypeEDIT.FormattingEnabled = true;
            this.cmBxTypeEDIT.Location = new System.Drawing.Point(315, 212);
            this.cmBxTypeEDIT.Name = "cmBxTypeEDIT";
            this.cmBxTypeEDIT.Size = new System.Drawing.Size(197, 21);
            this.cmBxTypeEDIT.TabIndex = 171;
            this.cmBxTypeEDIT.ValueMember = "TypeID";
            // 
            // cmBxDepartmentEDIT
            // 
            this.cmBxDepartmentEDIT.DataSource = this.departmentBindingSource;
            this.cmBxDepartmentEDIT.DisplayMember = "Department";
            this.cmBxDepartmentEDIT.FormattingEnabled = true;
            this.cmBxDepartmentEDIT.Location = new System.Drawing.Point(315, 237);
            this.cmBxDepartmentEDIT.Name = "cmBxDepartmentEDIT";
            this.cmBxDepartmentEDIT.Size = new System.Drawing.Size(197, 21);
            this.cmBxDepartmentEDIT.TabIndex = 170;
            this.cmBxDepartmentEDIT.ValueMember = "DepartmentID";
            // 
            // cmBxClinicEDIT
            // 
            this.cmBxClinicEDIT.DataSource = this.clinicBindingSource;
            this.cmBxClinicEDIT.DisplayMember = "Clinic";
            this.cmBxClinicEDIT.FormattingEnabled = true;
            this.cmBxClinicEDIT.Location = new System.Drawing.Point(315, 264);
            this.cmBxClinicEDIT.Name = "cmBxClinicEDIT";
            this.cmBxClinicEDIT.Size = new System.Drawing.Size(197, 21);
            this.cmBxClinicEDIT.TabIndex = 169;
            this.cmBxClinicEDIT.ValueMember = "ClinicID";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.doctorBindingSource;
            this.comboBox1.DisplayMember = "DoctorEmail";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 21);
            this.comboBox1.TabIndex = 168;
            this.comboBox1.ValueMember = "DoctorID";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.dataSetEditSelect;
            // 
            // dataSetEditSelect
            // 
            this.dataSetEditSelect.DataSetName = "DataSetEditSelect";
            this.dataSetEditSelect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBxSexEDIT
            // 
            this.groupBxSexEDIT.Controls.Add(this.radioBtnMaleEDIT);
            this.groupBxSexEDIT.Controls.Add(this.radioBtnFemaleEDIt);
            this.groupBxSexEDIT.Location = new System.Drawing.Point(317, 154);
            this.groupBxSexEDIT.Name = "groupBxSexEDIT";
            this.groupBxSexEDIT.Size = new System.Drawing.Size(176, 30);
            this.groupBxSexEDIT.TabIndex = 167;
            this.groupBxSexEDIT.TabStop = false;
            // 
            // radioBtnMaleEDIT
            // 
            this.radioBtnMaleEDIT.AutoSize = true;
            this.radioBtnMaleEDIT.Location = new System.Drawing.Point(6, 10);
            this.radioBtnMaleEDIT.Name = "radioBtnMaleEDIT";
            this.radioBtnMaleEDIT.Size = new System.Drawing.Size(48, 17);
            this.radioBtnMaleEDIT.TabIndex = 123;
            this.radioBtnMaleEDIT.TabStop = true;
            this.radioBtnMaleEDIT.Text = "Male";
            this.radioBtnMaleEDIT.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemaleEDIt
            // 
            this.radioBtnFemaleEDIt.AutoSize = true;
            this.radioBtnFemaleEDIt.Location = new System.Drawing.Point(95, 10);
            this.radioBtnFemaleEDIt.Name = "radioBtnFemaleEDIt";
            this.radioBtnFemaleEDIt.Size = new System.Drawing.Size(59, 17);
            this.radioBtnFemaleEDIt.TabIndex = 124;
            this.radioBtnFemaleEDIt.TabStop = true;
            this.radioBtnFemaleEDIt.Text = "Female";
            this.radioBtnFemaleEDIt.UseVisualStyleBackColor = true;
            // 
            // btnFillInSELECTEDDoc
            // 
            this.btnFillInSELECTEDDoc.Location = new System.Drawing.Point(246, 24);
            this.btnFillInSELECTEDDoc.Name = "btnFillInSELECTEDDoc";
            this.btnFillInSELECTEDDoc.Size = new System.Drawing.Size(75, 23);
            this.btnFillInSELECTEDDoc.TabIndex = 166;
            this.btnFillInSELECTEDDoc.Text = "Fill In";
            this.btnFillInSELECTEDDoc.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(61, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(104, 13);
            this.label24.TabIndex = 165;
            this.label24.Text = "Select Doctor to edit";
            // 
            // txtBxNoteEDIT
            // 
            this.txtBxNoteEDIT.Location = new System.Drawing.Point(315, 319);
            this.txtBxNoteEDIT.Name = "txtBxNoteEDIT";
            this.txtBxNoteEDIT.Size = new System.Drawing.Size(209, 20);
            this.txtBxNoteEDIT.TabIndex = 164;
            // 
            // txtBxEmailEDIT
            // 
            this.txtBxEmailEDIT.Location = new System.Drawing.Point(315, 292);
            this.txtBxEmailEDIT.Name = "txtBxEmailEDIT";
            this.txtBxEmailEDIT.Size = new System.Drawing.Size(209, 20);
            this.txtBxEmailEDIT.TabIndex = 163;
            // 
            // txtBxLNameEDIT
            // 
            this.txtBxLNameEDIT.Location = new System.Drawing.Point(315, 129);
            this.txtBxLNameEDIT.Name = "txtBxLNameEDIT";
            this.txtBxLNameEDIT.Size = new System.Drawing.Size(209, 20);
            this.txtBxLNameEDIT.TabIndex = 162;
            // 
            // txtBxMNameEDIT
            // 
            this.txtBxMNameEDIT.Location = new System.Drawing.Point(315, 103);
            this.txtBxMNameEDIT.Name = "txtBxMNameEDIT";
            this.txtBxMNameEDIT.Size = new System.Drawing.Size(209, 20);
            this.txtBxMNameEDIT.TabIndex = 161;
            // 
            // txtBxFNameEDIT
            // 
            this.txtBxFNameEDIT.Location = new System.Drawing.Point(315, 77);
            this.txtBxFNameEDIT.Name = "txtBxFNameEDIT";
            this.txtBxFNameEDIT.Size = new System.Drawing.Size(209, 20);
            this.txtBxFNameEDIT.TabIndex = 160;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 159;
            this.label13.Text = "Notes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(230, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 158;
            this.label14.Text = "Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(230, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 157;
            this.label15.Text = "Clinic";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(227, 237);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 156;
            this.label16.Text = "Department";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(227, 214);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 155;
            this.label17.Text = "Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(233, 190);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 154;
            this.label18.Text = "Status";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(233, 166);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 153;
            this.label19.Text = "Sex";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(227, 132);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 152;
            this.label20.Text = "Last Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(227, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 151;
            this.label21.Text = "Middle Name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(228, 84);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 150;
            this.label22.Text = "First Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(378, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 24);
            this.label23.TabIndex = 149;
            this.label23.Text = "EDIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 42);
            this.label1.TabIndex = 173;
            this.label1.Text = "Doctor";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetEditDoctorStatus
            // 
            this.dataSetEditDoctorStatus.DataSetName = "DataSetEditDoctorStatus";
            this.dataSetEditDoctorStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.dataSetEditDoctorStatus;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetEditDoctorType
            // 
            this.dataSetEditDoctorType.DataSetName = "DataSetEditDoctorType";
            this.dataSetEditDoctorType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorTypeBindingSource
            // 
            this.doctorTypeBindingSource.DataMember = "DoctorType";
            this.doctorTypeBindingSource.DataSource = this.dataSetEditDoctorType;
            // 
            // doctorTypeTableAdapter
            // 
            this.doctorTypeTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetEditDoctorDepartment
            // 
            this.dataSetEditDoctorDepartment.DataSetName = "DataSetEditDoctorDepartment";
            this.dataSetEditDoctorDepartment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.dataSetEditDoctorDepartment;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetEditDoctorClinic
            // 
            this.dataSetEditDoctorClinic.DataSetName = "DataSetEditDoctorClinic";
            this.dataSetEditDoctorClinic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicBindingSource
            // 
            this.clinicBindingSource.DataMember = "Clinic";
            this.clinicBindingSource.DataSource = this.dataSetEditDoctorClinic;
            // 
            // clinicTableAdapter
            // 
            this.clinicTableAdapter.ClearBeforeFill = true;
            // 
            // DoctorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBxStatusEDIT);
            this.Controls.Add(this.cmBxTypeEDIT);
            this.Controls.Add(this.cmBxDepartmentEDIT);
            this.Controls.Add(this.cmBxClinicEDIT);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBxSexEDIT);
            this.Controls.Add(this.btnFillInSELECTEDDoc);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtBxNoteEDIT);
            this.Controls.Add(this.txtBxEmailEDIT);
            this.Controls.Add(this.txtBxLNameEDIT);
            this.Controls.Add(this.txtBxMNameEDIT);
            this.Controls.Add(this.txtBxFNameEDIT);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnEDITSave);
            this.Name = "DoctorEdit";
            this.Text = "DoctorEdit";
            this.Load += new System.EventHandler(this.DoctorEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditSelect)).EndInit();
            this.groupBxSexEDIT.ResumeLayout(false);
            this.groupBxSexEDIT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorClinic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEDITSave;
        private System.Windows.Forms.ComboBox cmBxStatusEDIT;
        private System.Windows.Forms.ComboBox cmBxTypeEDIT;
        private System.Windows.Forms.ComboBox cmBxDepartmentEDIT;
        private System.Windows.Forms.ComboBox cmBxClinicEDIT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBxSexEDIT;
        private System.Windows.Forms.RadioButton radioBtnMaleEDIT;
        private System.Windows.Forms.RadioButton radioBtnFemaleEDIt;
        private System.Windows.Forms.Button btnFillInSELECTEDDoc;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBxNoteEDIT;
        private System.Windows.Forms.TextBox txtBxEmailEDIT;
        private System.Windows.Forms.TextBox txtBxLNameEDIT;
        private System.Windows.Forms.TextBox txtBxMNameEDIT;
        private System.Windows.Forms.TextBox txtBxFNameEDIT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Data.DataSet dataSet1;
        private DataSet.DataSetEditSelect dataSetEditSelect;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private DataSet.DataSetEditSelectTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private DataSet.DataSetEditDoctorStatus dataSetEditDoctorStatus;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private DataSet.DataSetEditDoctorStatusTableAdapters.StatusTableAdapter statusTableAdapter;
        private DataSet.DataSetEditDoctorType dataSetEditDoctorType;
        private System.Windows.Forms.BindingSource doctorTypeBindingSource;
        private DataSet.DataSetEditDoctorTypeTableAdapters.DoctorTypeTableAdapter doctorTypeTableAdapter;
        private DataSet.DataSetEditDoctorDepartment dataSetEditDoctorDepartment;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DataSet.DataSetEditDoctorDepartmentTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private DataSet.DataSetEditDoctorClinic dataSetEditDoctorClinic;
        private System.Windows.Forms.BindingSource clinicBindingSource;
        private DataSet.DataSetEditDoctorClinicTableAdapters.ClinicTableAdapter clinicTableAdapter;
    }
}