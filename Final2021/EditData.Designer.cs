
namespace Final2021
{
    partial class EditData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDoctorType = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNurseType = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClinic = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtBxStatus = new System.Windows.Forms.TextBox();
            this.txtBxDoctorType = new System.Windows.Forms.TextBox();
            this.txtBxNurseType = new System.Windows.Forms.TextBox();
            this.txtBxDepartment = new System.Windows.Forms.TextBox();
            this.txtBxClinic = new System.Windows.Forms.TextBox();
            this.cmboxStatus = new System.Windows.Forms.ComboBox();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEditStaus = new Final2021.DataSet.DataSetEditStaus();
            this.cmboxDoctorType = new System.Windows.Forms.ComboBox();
            this.doctorTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEditDataDoctorType = new Final2021.DataSet.DataSetEditDataDoctorType();
            this.doctorTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmBoxDepartmnet = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEditDepartment = new Final2021.DataSet.DataSetEditDepartment();
            this.cmboxClinic = new System.Windows.Forms.ComboBox();
            this.clinicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEditClinic = new Final2021.DataSet.DataSetEditClinic();
            this.cmBxNurseType = new System.Windows.Forms.ComboBox();
            this.nurseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEditNurseType = new Final2021.DataSet.DataSetEditNurseType();
            this.statusTableAdapter = new Final2021.DataSet.DataSetEditStausTableAdapters.StatusTableAdapter();
            this.doctorTypeTableAdapter = new Final2021.DataSet.DataSetEditDoctorTypeTableAdapters.DoctorTypeTableAdapter();
            this.nurseTypeTableAdapter = new Final2021.DataSet.DataSetEditNurseTypeTableAdapters.NurseTypeTableAdapter();
            this.departmentTableAdapter = new Final2021.DataSet.DataSetEditDepartmentTableAdapters.DepartmentTableAdapter();
            this.clinicTableAdapter = new Final2021.DataSet.DataSetEditClinicTableAdapters.ClinicTableAdapter();
            this.doctorTypeTableAdapter1 = new Final2021.DataSet.DataSetEditDataDoctorTypeTableAdapters.DoctorTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditStaus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDataDoctorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditClinic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditNurseType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "STATUS";
            // 
            // btnStatus
            // 
            this.btnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.Location = new System.Drawing.Point(546, 109);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(118, 31);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.Text = "Save Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doctor Type";
            // 
            // btnDoctorType
            // 
            this.btnDoctorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorType.Location = new System.Drawing.Point(546, 155);
            this.btnDoctorType.Name = "btnDoctorType";
            this.btnDoctorType.Size = new System.Drawing.Size(147, 31);
            this.btnDoctorType.TabIndex = 6;
            this.btnDoctorType.Text = "Save Doctor Type";
            this.btnDoctorType.UseVisualStyleBackColor = true;
            this.btnDoctorType.Click += new System.EventHandler(this.btnDoctorType_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nurse Type";
            // 
            // btnNurseType
            // 
            this.btnNurseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNurseType.Location = new System.Drawing.Point(546, 195);
            this.btnNurseType.Name = "btnNurseType";
            this.btnNurseType.Size = new System.Drawing.Size(147, 33);
            this.btnNurseType.TabIndex = 9;
            this.btnNurseType.Text = "Save Nurse Type";
            this.btnNurseType.UseVisualStyleBackColor = true;
            this.btnNurseType.Click += new System.EventHandler(this.btnNurseType_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department";
            // 
            // btnDepartment
            // 
            this.btnDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.Location = new System.Drawing.Point(546, 237);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(172, 33);
            this.btnDepartment.TabIndex = 11;
            this.btnDepartment.Text = "Save Department";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Clinic";
            // 
            // btnClinic
            // 
            this.btnClinic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinic.Location = new System.Drawing.Point(546, 279);
            this.btnClinic.Name = "btnClinic";
            this.btnClinic.Size = new System.Drawing.Size(172, 31);
            this.btnClinic.TabIndex = 14;
            this.btnClinic.Text = "Save Clinic";
            this.btnClinic.UseVisualStyleBackColor = true;
            this.btnClinic.Click += new System.EventHandler(this.btnClinic_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(442, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(350, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(250, 389);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 16;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtBxStatus
            // 
            this.txtBxStatus.Location = new System.Drawing.Point(370, 109);
            this.txtBxStatus.Name = "txtBxStatus";
            this.txtBxStatus.Size = new System.Drawing.Size(155, 20);
            this.txtBxStatus.TabIndex = 24;
            // 
            // txtBxDoctorType
            // 
            this.txtBxDoctorType.Location = new System.Drawing.Point(370, 161);
            this.txtBxDoctorType.Name = "txtBxDoctorType";
            this.txtBxDoctorType.Size = new System.Drawing.Size(155, 20);
            this.txtBxDoctorType.TabIndex = 25;
            // 
            // txtBxNurseType
            // 
            this.txtBxNurseType.Location = new System.Drawing.Point(370, 202);
            this.txtBxNurseType.Name = "txtBxNurseType";
            this.txtBxNurseType.Size = new System.Drawing.Size(155, 20);
            this.txtBxNurseType.TabIndex = 26;
            // 
            // txtBxDepartment
            // 
            this.txtBxDepartment.Location = new System.Drawing.Point(370, 244);
            this.txtBxDepartment.Name = "txtBxDepartment";
            this.txtBxDepartment.Size = new System.Drawing.Size(155, 20);
            this.txtBxDepartment.TabIndex = 27;
            // 
            // txtBxClinic
            // 
            this.txtBxClinic.Location = new System.Drawing.Point(370, 290);
            this.txtBxClinic.Name = "txtBxClinic";
            this.txtBxClinic.Size = new System.Drawing.Size(155, 20);
            this.txtBxClinic.TabIndex = 28;
            // 
            // cmboxStatus
            // 
            this.cmboxStatus.DataSource = this.statusBindingSource;
            this.cmboxStatus.DisplayMember = "StatusType";
            this.cmboxStatus.FormattingEnabled = true;
            this.cmboxStatus.Location = new System.Drawing.Point(145, 108);
            this.cmboxStatus.Name = "cmboxStatus";
            this.cmboxStatus.Size = new System.Drawing.Size(197, 21);
            this.cmboxStatus.TabIndex = 138;
            this.cmboxStatus.ValueMember = "StatusID";
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.dataSetEditStaus;
            // 
            // dataSetEditStaus
            // 
            this.dataSetEditStaus.DataSetName = "DataSetEditStaus";
            this.dataSetEditStaus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmboxDoctorType
            // 
            this.cmboxDoctorType.DataSource = this.doctorTypeBindingSource1;
            this.cmboxDoctorType.DisplayMember = "Type";
            this.cmboxDoctorType.FormattingEnabled = true;
            this.cmboxDoctorType.Location = new System.Drawing.Point(145, 165);
            this.cmboxDoctorType.Name = "cmboxDoctorType";
            this.cmboxDoctorType.Size = new System.Drawing.Size(197, 21);
            this.cmboxDoctorType.TabIndex = 139;
            this.cmboxDoctorType.ValueMember = "TypeID";
            // 
            // doctorTypeBindingSource1
            // 
            this.doctorTypeBindingSource1.DataMember = "DoctorType";
            this.doctorTypeBindingSource1.DataSource = this.dataSetEditDataDoctorType;
            // 
            // dataSetEditDataDoctorType
            // 
            this.dataSetEditDataDoctorType.DataSetName = "DataSetEditDataDoctorType";
            this.dataSetEditDataDoctorType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmBoxDepartmnet
            // 
            this.cmBoxDepartmnet.DataSource = this.departmentBindingSource;
            this.cmBoxDepartmnet.DisplayMember = "Department";
            this.cmBoxDepartmnet.FormattingEnabled = true;
            this.cmBoxDepartmnet.Location = new System.Drawing.Point(145, 256);
            this.cmBoxDepartmnet.Name = "cmBoxDepartmnet";
            this.cmBoxDepartmnet.Size = new System.Drawing.Size(197, 21);
            this.cmBoxDepartmnet.TabIndex = 140;
            this.cmBoxDepartmnet.ValueMember = "DepartmentID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.dataSetEditDepartment;
            // 
            // dataSetEditDepartment
            // 
            this.dataSetEditDepartment.DataSetName = "DataSetEditDepartment";
            this.dataSetEditDepartment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmboxClinic
            // 
            this.cmboxClinic.DataSource = this.clinicBindingSource;
            this.cmboxClinic.DisplayMember = "Clinic";
            this.cmboxClinic.FormattingEnabled = true;
            this.cmboxClinic.Location = new System.Drawing.Point(145, 294);
            this.cmboxClinic.Name = "cmboxClinic";
            this.cmboxClinic.Size = new System.Drawing.Size(197, 21);
            this.cmboxClinic.TabIndex = 141;
            this.cmboxClinic.ValueMember = "ClinicID";
            // 
            // clinicBindingSource
            // 
            this.clinicBindingSource.DataMember = "Clinic";
            this.clinicBindingSource.DataSource = this.dataSetEditClinic;
            // 
            // dataSetEditClinic
            // 
            this.dataSetEditClinic.DataSetName = "DataSetEditClinic";
            this.dataSetEditClinic.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmBxNurseType
            // 
            this.cmBxNurseType.DataSource = this.nurseTypeBindingSource;
            this.cmBxNurseType.DisplayMember = "Type";
            this.cmBxNurseType.FormattingEnabled = true;
            this.cmBxNurseType.Location = new System.Drawing.Point(145, 206);
            this.cmBxNurseType.Name = "cmBxNurseType";
            this.cmBxNurseType.Size = new System.Drawing.Size(197, 21);
            this.cmBxNurseType.TabIndex = 142;
            this.cmBxNurseType.ValueMember = "TypeID";
            // 
            // nurseTypeBindingSource
            // 
            this.nurseTypeBindingSource.DataMember = "NurseType";
            this.nurseTypeBindingSource.DataSource = this.dataSetEditNurseType;
            // 
            // dataSetEditNurseType
            // 
            this.dataSetEditNurseType.DataSetName = "DataSetEditNurseType";
            this.dataSetEditNurseType.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // doctorTypeTableAdapter
            // 
            this.doctorTypeTableAdapter.ClearBeforeFill = true;
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
            // doctorTypeTableAdapter1
            // 
            this.doctorTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // EditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmBxNurseType);
            this.Controls.Add(this.cmboxClinic);
            this.Controls.Add(this.cmBoxDepartmnet);
            this.Controls.Add(this.cmboxDoctorType);
            this.Controls.Add(this.cmboxStatus);
            this.Controls.Add(this.txtBxClinic);
            this.Controls.Add(this.txtBxDepartment);
            this.Controls.Add(this.txtBxNurseType);
            this.Controls.Add(this.txtBxDoctorType);
            this.Controls.Add(this.txtBxStatus);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnClinic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNurseType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDoctorType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditData";
            this.Text = "EditData";
            this.Load += new System.EventHandler(this.EditData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditStaus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDataDoctorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditClinic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEditNurseType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDoctorType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNurseType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClinic;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtBxStatus;
        private System.Windows.Forms.TextBox txtBxDoctorType;
        private System.Windows.Forms.TextBox txtBxNurseType;
        private System.Windows.Forms.TextBox txtBxDepartment;
        private System.Windows.Forms.TextBox txtBxClinic;
        private System.Windows.Forms.ComboBox cmboxStatus;
        private System.Windows.Forms.ComboBox cmboxDoctorType;
        private System.Windows.Forms.ComboBox cmBoxDepartmnet;
        private System.Windows.Forms.ComboBox cmboxClinic;
        private System.Windows.Forms.ComboBox cmBxNurseType;
        private DataSet.DataSetEditStaus dataSetEditStaus;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private DataSet.DataSetEditStausTableAdapters.StatusTableAdapter statusTableAdapter;
     
        private System.Windows.Forms.BindingSource doctorTypeBindingSource;
        private DataSet.DataSetEditDoctorTypeTableAdapters.DoctorTypeTableAdapter doctorTypeTableAdapter;
        private DataSet.DataSetEditNurseType dataSetEditNurseType;
        private System.Windows.Forms.BindingSource nurseTypeBindingSource;
        private DataSet.DataSetEditNurseTypeTableAdapters.NurseTypeTableAdapter nurseTypeTableAdapter;
        private DataSet.DataSetEditDepartment dataSetEditDepartment;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DataSet.DataSetEditDepartmentTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private DataSet.DataSetEditClinic dataSetEditClinic;
        private System.Windows.Forms.BindingSource clinicBindingSource;
        private DataSet.DataSetEditClinicTableAdapters.ClinicTableAdapter clinicTableAdapter;
        private DataSet.DataSetEditDataDoctorType dataSetEditDataDoctorType;
        private System.Windows.Forms.BindingSource doctorTypeBindingSource1;
        private DataSet.DataSetEditDataDoctorTypeTableAdapters.DoctorTypeTableAdapter doctorTypeTableAdapter1;
    }
}