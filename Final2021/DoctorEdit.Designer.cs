
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
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDoctorEditStatus = new Final2021.DataSet.DataSetDoctorEditStatus();
            this.doctorTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEditDoctorType = new Final2021.DataSet.DataSetEditDoctorType();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEditDoctorDepartment = new Final2021.DataSet.DataSetEditDoctorDepartment();
            this.clinicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEditDoctorClinic = new Final2021.DataSet.DataSetEditDoctorClinic();
            this.cmBoxSelectDoctor = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSelectDoctor = new Final2021.DataSet.DataSetSelectDoctor();
            this.btnFillInSELECTEDDoc = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBxNoteEDIT = new System.Windows.Forms.TextBox();
            this.txtBxEmailEDIT = new System.Windows.Forms.TextBox();
            this.txtBxLNameEDIT = new System.Windows.Forms.TextBox();
            this.txtBxMNameEDIT = new System.Windows.Forms.TextBox();
            this.txtBxFNameEDIT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.dataSetStatus = new Final2021.DataSet.DataSetStatus();
            this.dataSetStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new Final2021.DataSet.DataSetDoctorEditStatusTableAdapters.StatusTableAdapter();
            this.doctorTypeTableAdapter = new Final2021.DataSet.DataSetEditDoctorTypeTableAdapters.DoctorTypeTableAdapter();
            this.departmentTableAdapter = new Final2021.DataSet.DataSetEditDoctorDepartmentTableAdapters.DepartmentTableAdapter();
            this.clinicTableAdapter = new Final2021.DataSet.DataSetEditDoctorClinicTableAdapters.ClinicTableAdapter();
            this.doctorTableAdapter = new Final2021.DataSet.DataSetSelectDoctorTableAdapters.DoctorTableAdapter();
            this.btnDoctorDelete = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmBxClinicEDIT = new System.Windows.Forms.ComboBox();
            this.cmBxDepartmentEDIT = new System.Windows.Forms.ComboBox();
            this.cmBxTypeEDIT = new System.Windows.Forms.ComboBox();
            this.cmBxStatusEDIT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDoctorEditStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorClinic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSelectDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(504, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 135;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(400, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 134;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(296, 415);
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
            this.btnEDITSave.Click += new System.EventHandler(this.btnEDITSave_Click);
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.dataSetDoctorEditStatus;
            // 
            // dataSetDoctorEditStatus
            // 
            this.dataSetDoctorEditStatus.DataSetName = "DataSetDoctorEditStatus";
            this.dataSetDoctorEditStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorTypeBindingSource
            // 
            this.doctorTypeBindingSource.DataMember = "DoctorType";
            this.doctorTypeBindingSource.DataSource = this.dataSetEditDoctorType;
            // 
            // dataSetEditDoctorType
            // 
            this.dataSetEditDoctorType.DataSetName = "DataSetEditDoctorType";
            this.dataSetEditDoctorType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.dataSetEditDoctorDepartment;
            // 
            // dataSetEditDoctorDepartment
            // 
            this.dataSetEditDoctorDepartment.DataSetName = "DataSetEditDoctorDepartment";
            this.dataSetEditDoctorDepartment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicBindingSource
            // 
            this.clinicBindingSource.DataMember = "Clinic";
            this.clinicBindingSource.DataSource = this.dataSetEditDoctorClinic;
            // 
            // dataSetEditDoctorClinic
            // 
            this.dataSetEditDoctorClinic.DataSetName = "DataSetEditDoctorClinic";
            this.dataSetEditDoctorClinic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmBoxSelectDoctor
            // 
            this.cmBoxSelectDoctor.DataSource = this.doctorBindingSource;
            this.cmBoxSelectDoctor.DisplayMember = "DoctorEmail";
            this.cmBoxSelectDoctor.FormattingEnabled = true;
            this.cmBoxSelectDoctor.Location = new System.Drawing.Point(12, 24);
            this.cmBoxSelectDoctor.Name = "cmBoxSelectDoctor";
            this.cmBoxSelectDoctor.Size = new System.Drawing.Size(207, 21);
            this.cmBoxSelectDoctor.TabIndex = 168;
            this.cmBoxSelectDoctor.ValueMember = "DoctorID";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.dataSetSelectDoctor;
            // 
            // dataSetSelectDoctor
            // 
            this.dataSetSelectDoctor.DataSetName = "DataSetSelectDoctor";
            this.dataSetSelectDoctor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFillInSELECTEDDoc
            // 
            this.btnFillInSELECTEDDoc.Location = new System.Drawing.Point(239, 22);
            this.btnFillInSELECTEDDoc.Name = "btnFillInSELECTEDDoc";
            this.btnFillInSELECTEDDoc.Size = new System.Drawing.Size(75, 23);
            this.btnFillInSELECTEDDoc.TabIndex = 166;
            this.btnFillInSELECTEDDoc.Text = "Fill In";
            this.btnFillInSELECTEDDoc.UseVisualStyleBackColor = true;
            this.btnFillInSELECTEDDoc.Click += new System.EventHandler(this.btnFillInSELECTEDDoc_Click);
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
            this.txtBxNoteEDIT.Location = new System.Drawing.Point(371, 310);
            this.txtBxNoteEDIT.Name = "txtBxNoteEDIT";
            this.txtBxNoteEDIT.Size = new System.Drawing.Size(209, 20);
            this.txtBxNoteEDIT.TabIndex = 164;
            // 
            // txtBxEmailEDIT
            // 
            this.txtBxEmailEDIT.Location = new System.Drawing.Point(371, 283);
            this.txtBxEmailEDIT.Name = "txtBxEmailEDIT";
            this.txtBxEmailEDIT.Size = new System.Drawing.Size(209, 20);
            this.txtBxEmailEDIT.TabIndex = 163;
            // 
            // txtBxLNameEDIT
            // 
            this.txtBxLNameEDIT.Location = new System.Drawing.Point(371, 141);
            this.txtBxLNameEDIT.Name = "txtBxLNameEDIT";
            this.txtBxLNameEDIT.Size = new System.Drawing.Size(209, 20);
            this.txtBxLNameEDIT.TabIndex = 162;
            // 
            // txtBxMNameEDIT
            // 
            this.txtBxMNameEDIT.Location = new System.Drawing.Point(371, 115);
            this.txtBxMNameEDIT.Name = "txtBxMNameEDIT";
            this.txtBxMNameEDIT.Size = new System.Drawing.Size(209, 20);
            this.txtBxMNameEDIT.TabIndex = 161;
            // 
            // txtBxFNameEDIT
            // 
            this.txtBxFNameEDIT.Location = new System.Drawing.Point(371, 89);
            this.txtBxFNameEDIT.Name = "txtBxFNameEDIT";
            this.txtBxFNameEDIT.Size = new System.Drawing.Size(209, 20);
            this.txtBxFNameEDIT.TabIndex = 160;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 310);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 159;
            this.label13.Text = "Notes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(286, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 158;
            this.label14.Text = "Email";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(283, 144);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 152;
            this.label20.Text = "Last Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(283, 118);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 151;
            this.label21.Text = "Middle Name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(284, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 150;
            this.label22.Text = "First Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(434, 55);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 24);
            this.label23.TabIndex = 149;
            this.label23.Text = "EDIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 42);
            this.label1.TabIndex = 173;
            this.label1.Text = "Doctor";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataSetStatus
            // 
            this.dataSetStatus.DataSetName = "DataSetStatus";
            this.dataSetStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetStatusBindingSource
            // 
            this.dataSetStatusBindingSource.DataSource = this.dataSetStatus;
            this.dataSetStatusBindingSource.Position = 0;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // doctorTypeTableAdapter
            // 
            this.doctorTypeTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // clinicTableAdapter
            // 
            this.clinicTableAdapter.ClearBeforeFill = true;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // btnDoctorDelete
            // 
            this.btnDoctorDelete.Location = new System.Drawing.Point(37, 218);
            this.btnDoctorDelete.Name = "btnDoctorDelete";
            this.btnDoctorDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDoctorDelete.TabIndex = 174;
            this.btnDoctorDelete.Text = "Deleted Selected";
            this.btnDoctorDelete.UseVisualStyleBackColor = true;
            this.btnDoctorDelete.Click += new System.EventHandler(this.btnDoctorDelete_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(289, 175);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 154;
            this.label18.Text = "Status";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(283, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 155;
            this.label17.Text = "Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(283, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 156;
            this.label16.Text = "Department";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(286, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 157;
            this.label15.Text = "Clinic";
            // 
            // cmBxClinicEDIT
            // 
            this.cmBxClinicEDIT.DataSource = this.clinicBindingSource;
            this.cmBxClinicEDIT.DisplayMember = "Clinic";
            this.cmBxClinicEDIT.FormattingEnabled = true;
            this.cmBxClinicEDIT.Location = new System.Drawing.Point(371, 253);
            this.cmBxClinicEDIT.Name = "cmBxClinicEDIT";
            this.cmBxClinicEDIT.Size = new System.Drawing.Size(209, 21);
            this.cmBxClinicEDIT.TabIndex = 169;
            this.cmBxClinicEDIT.ValueMember = "ClinicID";
            // 
            // cmBxDepartmentEDIT
            // 
            this.cmBxDepartmentEDIT.DataSource = this.departmentBindingSource;
            this.cmBxDepartmentEDIT.DisplayMember = "Department";
            this.cmBxDepartmentEDIT.FormattingEnabled = true;
            this.cmBxDepartmentEDIT.Location = new System.Drawing.Point(371, 226);
            this.cmBxDepartmentEDIT.Name = "cmBxDepartmentEDIT";
            this.cmBxDepartmentEDIT.Size = new System.Drawing.Size(209, 21);
            this.cmBxDepartmentEDIT.TabIndex = 170;
            this.cmBxDepartmentEDIT.ValueMember = "DepartmentID";
            // 
            // cmBxTypeEDIT
            // 
            this.cmBxTypeEDIT.DataSource = this.doctorTypeBindingSource;
            this.cmBxTypeEDIT.DisplayMember = "Type";
            this.cmBxTypeEDIT.FormattingEnabled = true;
            this.cmBxTypeEDIT.Location = new System.Drawing.Point(371, 201);
            this.cmBxTypeEDIT.Name = "cmBxTypeEDIT";
            this.cmBxTypeEDIT.Size = new System.Drawing.Size(209, 21);
            this.cmBxTypeEDIT.TabIndex = 171;
            this.cmBxTypeEDIT.ValueMember = "TypeID";
            // 
            // cmBxStatusEDIT
            // 
            this.cmBxStatusEDIT.DataSource = this.statusBindingSource;
            this.cmBxStatusEDIT.DisplayMember = "StatusType";
            this.cmBxStatusEDIT.FormattingEnabled = true;
            this.cmBxStatusEDIT.Location = new System.Drawing.Point(371, 172);
            this.cmBxStatusEDIT.Name = "cmBxStatusEDIT";
            this.cmBxStatusEDIT.Size = new System.Drawing.Size(209, 21);
            this.cmBxStatusEDIT.TabIndex = 172;
            this.cmBxStatusEDIT.ValueMember = "StatusID";
            // 
            // DoctorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoctorDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBxStatusEDIT);
            this.Controls.Add(this.cmBxTypeEDIT);
            this.Controls.Add(this.cmBxDepartmentEDIT);
            this.Controls.Add(this.cmBxClinicEDIT);
            this.Controls.Add(this.cmBoxSelectDoctor);
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
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDoctorEditStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDoctorClinic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSelectDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetStatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEDITSave;
        private System.Windows.Forms.ComboBox cmBoxSelectDoctor;
        private System.Windows.Forms.Button btnFillInSELECTEDDoc;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBxNoteEDIT;
        private System.Windows.Forms.TextBox txtBxEmailEDIT;
        private System.Windows.Forms.TextBox txtBxLNameEDIT;
        private System.Windows.Forms.TextBox txtBxMNameEDIT;
        private System.Windows.Forms.TextBox txtBxFNameEDIT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.BindingSource dataSetStatusBindingSource;
        private DataSet.DataSetStatus dataSetStatus;
        private DataSet.DataSetDoctorEditStatus dataSetDoctorEditStatus;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private DataSet.DataSetDoctorEditStatusTableAdapters.StatusTableAdapter statusTableAdapter;
        private DataSet.DataSetEditDoctorType dataSetEditDoctorType;
        private System.Windows.Forms.BindingSource doctorTypeBindingSource;
        private DataSet.DataSetEditDoctorTypeTableAdapters.DoctorTypeTableAdapter doctorTypeTableAdapter;
        private DataSet.DataSetEditDoctorDepartment dataSetEditDoctorDepartment;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DataSet.DataSetEditDoctorDepartmentTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private DataSet.DataSetEditDoctorClinic dataSetEditDoctorClinic;
        private System.Windows.Forms.BindingSource clinicBindingSource;
        private DataSet.DataSetEditDoctorClinicTableAdapters.ClinicTableAdapter clinicTableAdapter;
        private DataSet.DataSetSelectDoctor dataSetSelectDoctor;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private DataSet.DataSetSelectDoctorTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.Button btnDoctorDelete;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmBxClinicEDIT;
        private System.Windows.Forms.ComboBox cmBxDepartmentEDIT;
        private System.Windows.Forms.ComboBox cmBxTypeEDIT;
        private System.Windows.Forms.ComboBox cmBxStatusEDIT;
    }
}