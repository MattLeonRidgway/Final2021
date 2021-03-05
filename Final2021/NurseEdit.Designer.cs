
namespace Final2021
{
    partial class NurseEdit
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmBxClinicEDIT = new System.Windows.Forms.ComboBox();
            this.cmBxDepartEDIT = new System.Windows.Forms.ComboBox();
            this.cmBxTypeEDIT = new System.Windows.Forms.ComboBox();
            this.cmBxStatusEDIT = new System.Windows.Forms.ComboBox();
            this.groupBxSexEDIT = new System.Windows.Forms.GroupBox();
            this.radioBtnEditMale = new System.Windows.Forms.RadioButton();
            this.radioBtnEditFemale = new System.Windows.Forms.RadioButton();
            this.btnFillInEDIT = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtBxEditNote = new System.Windows.Forms.TextBox();
            this.txtBxEditEmail = new System.Windows.Forms.TextBox();
            this.txtBxEditLName = new System.Windows.Forms.TextBox();
            this.txtBxEditMName = new System.Windows.Forms.TextBox();
            this.btnEditSAVE = new System.Windows.Forms.Button();
            this.txtBxEditFName = new System.Windows.Forms.TextBox();
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
            this.dataSetSelectNurse = new Final2021.DataSet.DataSetSelectNurse();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nurseTableAdapter = new Final2021.DataSet.DataSetSelectNurseTableAdapters.NurseTableAdapter();
            this.dataSetNurseEditStatus = new Final2021.DataSet.DataSetNurseEditStatus();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new Final2021.DataSet.DataSetNurseEditStatusTableAdapters.StatusTableAdapter();
            this.dataSetNurseEditType = new Final2021.DataSetNurseEditType();
            this.nurseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nurseTypeTableAdapter = new Final2021.DataSetNurseEditTypeTableAdapters.NurseTypeTableAdapter();
            this.dataSetNurseEditDepartment = new Final2021.DataSet.DataSetNurseEditDepartment();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new Final2021.DataSet.DataSetNurseEditDepartmentTableAdapters.DepartmentTableAdapter();
            this.dataSetNurseEditClinic = new Final2021.DataSet.DataSetNurseEditClinic();
            this.clinicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicTableAdapter = new Final2021.DataSet.DataSetNurseEditClinicTableAdapters.ClinicTableAdapter();
            this.groupBxSexEDIT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSelectNurse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseEditStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseEditType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseEditDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseEditClinic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 83;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(414, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 82;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 415);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 81;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.nurseBindingSource;
            this.comboBox1.DisplayMember = "NurseEmail";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 21);
            this.comboBox1.TabIndex = 171;
            this.comboBox1.ValueMember = "NurseID";
            // 
            // cmBxClinicEDIT
            // 
            this.cmBxClinicEDIT.DataSource = this.clinicBindingSource;
            this.cmBxClinicEDIT.DisplayMember = "Clinic";
            this.cmBxClinicEDIT.FormattingEnabled = true;
            this.cmBxClinicEDIT.Location = new System.Drawing.Point(359, 265);
            this.cmBxClinicEDIT.Name = "cmBxClinicEDIT";
            this.cmBxClinicEDIT.Size = new System.Drawing.Size(197, 21);
            this.cmBxClinicEDIT.TabIndex = 170;
            this.cmBxClinicEDIT.ValueMember = "ClinicID";
            // 
            // cmBxDepartEDIT
            // 
            this.cmBxDepartEDIT.DataSource = this.departmentBindingSource;
            this.cmBxDepartEDIT.DisplayMember = "Department";
            this.cmBxDepartEDIT.FormattingEnabled = true;
            this.cmBxDepartEDIT.Location = new System.Drawing.Point(359, 240);
            this.cmBxDepartEDIT.Name = "cmBxDepartEDIT";
            this.cmBxDepartEDIT.Size = new System.Drawing.Size(197, 21);
            this.cmBxDepartEDIT.TabIndex = 169;
            this.cmBxDepartEDIT.ValueMember = "DepartmentID";
            // 
            // cmBxTypeEDIT
            // 
            this.cmBxTypeEDIT.DataSource = this.nurseTypeBindingSource;
            this.cmBxTypeEDIT.DisplayMember = "Type";
            this.cmBxTypeEDIT.FormattingEnabled = true;
            this.cmBxTypeEDIT.Location = new System.Drawing.Point(357, 215);
            this.cmBxTypeEDIT.Name = "cmBxTypeEDIT";
            this.cmBxTypeEDIT.Size = new System.Drawing.Size(197, 21);
            this.cmBxTypeEDIT.TabIndex = 168;
            this.cmBxTypeEDIT.ValueMember = "TypeID";
            // 
            // cmBxStatusEDIT
            // 
            this.cmBxStatusEDIT.DataSource = this.statusBindingSource;
            this.cmBxStatusEDIT.DisplayMember = "StatusType";
            this.cmBxStatusEDIT.FormattingEnabled = true;
            this.cmBxStatusEDIT.Location = new System.Drawing.Point(359, 190);
            this.cmBxStatusEDIT.Name = "cmBxStatusEDIT";
            this.cmBxStatusEDIT.Size = new System.Drawing.Size(197, 21);
            this.cmBxStatusEDIT.TabIndex = 167;
            this.cmBxStatusEDIT.ValueMember = "StatusID";
            // 
            // groupBxSexEDIT
            // 
            this.groupBxSexEDIT.Controls.Add(this.radioBtnEditMale);
            this.groupBxSexEDIT.Controls.Add(this.radioBtnEditFemale);
            this.groupBxSexEDIT.Location = new System.Drawing.Point(359, 165);
            this.groupBxSexEDIT.Name = "groupBxSexEDIT";
            this.groupBxSexEDIT.Size = new System.Drawing.Size(152, 19);
            this.groupBxSexEDIT.TabIndex = 166;
            this.groupBxSexEDIT.TabStop = false;
            // 
            // radioBtnEditMale
            // 
            this.radioBtnEditMale.AutoSize = true;
            this.radioBtnEditMale.Location = new System.Drawing.Point(6, 3);
            this.radioBtnEditMale.Name = "radioBtnEditMale";
            this.radioBtnEditMale.Size = new System.Drawing.Size(48, 17);
            this.radioBtnEditMale.TabIndex = 72;
            this.radioBtnEditMale.TabStop = true;
            this.radioBtnEditMale.Text = "Male";
            this.radioBtnEditMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnEditFemale
            // 
            this.radioBtnEditFemale.AutoSize = true;
            this.radioBtnEditFemale.Location = new System.Drawing.Point(87, 3);
            this.radioBtnEditFemale.Name = "radioBtnEditFemale";
            this.radioBtnEditFemale.Size = new System.Drawing.Size(59, 17);
            this.radioBtnEditFemale.TabIndex = 73;
            this.radioBtnEditFemale.TabStop = true;
            this.radioBtnEditFemale.Text = "Female";
            this.radioBtnEditFemale.UseVisualStyleBackColor = true;
            // 
            // btnFillInEDIT
            // 
            this.btnFillInEDIT.Location = new System.Drawing.Point(75, 46);
            this.btnFillInEDIT.Name = "btnFillInEDIT";
            this.btnFillInEDIT.Size = new System.Drawing.Size(75, 23);
            this.btnFillInEDIT.TabIndex = 165;
            this.btnFillInEDIT.Text = "Fill In";
            this.btnFillInEDIT.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(50, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 13);
            this.label24.TabIndex = 164;
            this.label24.Text = "Select Nurse to edit";
            // 
            // txtBxEditNote
            // 
            this.txtBxEditNote.Location = new System.Drawing.Point(359, 317);
            this.txtBxEditNote.Name = "txtBxEditNote";
            this.txtBxEditNote.Size = new System.Drawing.Size(209, 20);
            this.txtBxEditNote.TabIndex = 163;
            // 
            // txtBxEditEmail
            // 
            this.txtBxEditEmail.Location = new System.Drawing.Point(359, 290);
            this.txtBxEditEmail.Name = "txtBxEditEmail";
            this.txtBxEditEmail.Size = new System.Drawing.Size(209, 20);
            this.txtBxEditEmail.TabIndex = 162;
            // 
            // txtBxEditLName
            // 
            this.txtBxEditLName.Location = new System.Drawing.Point(359, 142);
            this.txtBxEditLName.Name = "txtBxEditLName";
            this.txtBxEditLName.Size = new System.Drawing.Size(209, 20);
            this.txtBxEditLName.TabIndex = 161;
            // 
            // txtBxEditMName
            // 
            this.txtBxEditMName.Location = new System.Drawing.Point(359, 116);
            this.txtBxEditMName.Name = "txtBxEditMName";
            this.txtBxEditMName.Size = new System.Drawing.Size(209, 20);
            this.txtBxEditMName.TabIndex = 160;
            // 
            // btnEditSAVE
            // 
            this.btnEditSAVE.Location = new System.Drawing.Point(414, 353);
            this.btnEditSAVE.Name = "btnEditSAVE";
            this.btnEditSAVE.Size = new System.Drawing.Size(75, 23);
            this.btnEditSAVE.TabIndex = 159;
            this.btnEditSAVE.Text = "Save";
            this.btnEditSAVE.UseVisualStyleBackColor = true;
            // 
            // txtBxEditFName
            // 
            this.txtBxEditFName.Location = new System.Drawing.Point(359, 90);
            this.txtBxEditFName.Name = "txtBxEditFName";
            this.txtBxEditFName.Size = new System.Drawing.Size(209, 20);
            this.txtBxEditFName.TabIndex = 158;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 157;
            this.label13.Text = "Notes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(274, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 156;
            this.label14.Text = "Email";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(274, 268);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 155;
            this.label15.Text = "Clinic";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(274, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 154;
            this.label16.Text = "Department";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(271, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 153;
            this.label17.Text = "Type";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(271, 193);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 152;
            this.label18.Text = "Status";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(277, 174);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 151;
            this.label19.Text = "Sex";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(271, 145);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 150;
            this.label20.Text = "Last Name";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(271, 119);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 149;
            this.label21.Text = "Middle Name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(272, 97);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 148;
            this.label22.Text = "First Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(410, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 24);
            this.label23.TabIndex = 147;
            this.label23.Text = "EDIT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 42);
            this.label1.TabIndex = 146;
            this.label1.Text = "Nurse";
            // 
            // dataSetSelectNurse
            // 
            this.dataSetSelectNurse.DataSetName = "DataSetSelectNurse";
            this.dataSetSelectNurse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataMember = "Nurse";
            this.nurseBindingSource.DataSource = this.dataSetSelectNurse;
            // 
            // nurseTableAdapter
            // 
            this.nurseTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetNurseEditStatus
            // 
            this.dataSetNurseEditStatus.DataSetName = "DataSetNurseEditStatus";
            this.dataSetNurseEditStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.dataSetNurseEditStatus;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetNurseEditType
            // 
            this.dataSetNurseEditType.DataSetName = "DataSetNurseEditType";
            this.dataSetNurseEditType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nurseTypeBindingSource
            // 
            this.nurseTypeBindingSource.DataMember = "NurseType";
            this.nurseTypeBindingSource.DataSource = this.dataSetNurseEditType;
            // 
            // nurseTypeTableAdapter
            // 
            this.nurseTypeTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetNurseEditDepartment
            // 
            this.dataSetNurseEditDepartment.DataSetName = "DataSetNurseEditDepartment";
            this.dataSetNurseEditDepartment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.dataSetNurseEditDepartment;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetNurseEditClinic
            // 
            this.dataSetNurseEditClinic.DataSetName = "DataSetNurseEditClinic";
            this.dataSetNurseEditClinic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicBindingSource
            // 
            this.clinicBindingSource.DataMember = "Clinic";
            this.clinicBindingSource.DataSource = this.dataSetNurseEditClinic;
            // 
            // clinicTableAdapter
            // 
            this.clinicTableAdapter.ClearBeforeFill = true;
            // 
            // NurseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmBxClinicEDIT);
            this.Controls.Add(this.cmBxDepartEDIT);
            this.Controls.Add(this.cmBxTypeEDIT);
            this.Controls.Add(this.cmBxStatusEDIT);
            this.Controls.Add(this.groupBxSexEDIT);
            this.Controls.Add(this.btnFillInEDIT);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtBxEditNote);
            this.Controls.Add(this.txtBxEditEmail);
            this.Controls.Add(this.txtBxEditLName);
            this.Controls.Add(this.txtBxEditMName);
            this.Controls.Add(this.btnEditSAVE);
            this.Controls.Add(this.txtBxEditFName);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHome);
            this.Name = "NurseEdit";
            this.Text = "NurseEdit";
            this.Load += new System.EventHandler(this.NurseEdit_Load);
            this.groupBxSexEDIT.ResumeLayout(false);
            this.groupBxSexEDIT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSelectNurse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseEditStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseEditType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseEditDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurseEditClinic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmBxClinicEDIT;
        private System.Windows.Forms.ComboBox cmBxDepartEDIT;
        private System.Windows.Forms.ComboBox cmBxTypeEDIT;
        private System.Windows.Forms.ComboBox cmBxStatusEDIT;
        private System.Windows.Forms.GroupBox groupBxSexEDIT;
        private System.Windows.Forms.RadioButton radioBtnEditMale;
        private System.Windows.Forms.RadioButton radioBtnEditFemale;
        private System.Windows.Forms.Button btnFillInEDIT;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtBxEditNote;
        private System.Windows.Forms.TextBox txtBxEditEmail;
        private System.Windows.Forms.TextBox txtBxEditLName;
        private System.Windows.Forms.TextBox txtBxEditMName;
        private System.Windows.Forms.Button btnEditSAVE;
        private System.Windows.Forms.TextBox txtBxEditFName;
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
        private DataSet.DataSetSelectNurse dataSetSelectNurse;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private DataSet.DataSetSelectNurseTableAdapters.NurseTableAdapter nurseTableAdapter;
        private DataSet.DataSetNurseEditStatus dataSetNurseEditStatus;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private DataSet.DataSetNurseEditStatusTableAdapters.StatusTableAdapter statusTableAdapter;
        private DataSetNurseEditType dataSetNurseEditType;
        private System.Windows.Forms.BindingSource nurseTypeBindingSource;
        private DataSetNurseEditTypeTableAdapters.NurseTypeTableAdapter nurseTypeTableAdapter;
        private DataSet.DataSetNurseEditDepartment dataSetNurseEditDepartment;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DataSet.DataSetNurseEditDepartmentTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private DataSet.DataSetNurseEditClinic dataSetNurseEditClinic;
        private System.Windows.Forms.BindingSource clinicBindingSource;
        private DataSet.DataSetNurseEditClinicTableAdapters.ClinicTableAdapter clinicTableAdapter;
    }
}