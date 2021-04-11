
namespace Final2021
{
    partial class DoctorReview
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
            this.lstBxDocREv = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstBxDepart = new System.Windows.Forms.ListBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReviewDoctorDepartment = new Final2021.DataSet.DataSetReviewDoctorDepartment();
            this.label3 = new System.Windows.Forms.Label();
            this.departmentTableAdapter = new Final2021.DataSet.DataSetReviewDoctorDepartmentTableAdapters.DepartmentTableAdapter();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnSaved = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReviewDoctorDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor Review List";
            // 
            // lstBxDocREv
            // 
            this.lstBxDocREv.FormattingEnabled = true;
            this.lstBxDocREv.Location = new System.Drawing.Point(160, 53);
            this.lstBxDocREv.Name = "lstBxDocREv";
            this.lstBxDocREv.Size = new System.Drawing.Size(503, 342);
            this.lstBxDocREv.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 117);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 35);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Doctor By Department";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 415);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(112, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(204, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstBxDepart
            // 
            this.lstBxDepart.DataSource = this.departmentBindingSource;
            this.lstBxDepart.DisplayMember = "Department";
            this.lstBxDepart.FormattingEnabled = true;
            this.lstBxDepart.Location = new System.Drawing.Point(12, 81);
            this.lstBxDepart.Name = "lstBxDepart";
            this.lstBxDepart.Size = new System.Drawing.Size(120, 30);
            this.lstBxDepart.TabIndex = 11;
            this.lstBxDepart.ValueMember = "DepartmentID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.dataSetReviewDoctorDepartment;
            // 
            // dataSetReviewDoctorDepartment
            // 
            this.dataSetReviewDoctorDepartment.DataSetName = "DataSetReviewDoctorDepartment";
            this.dataSetReviewDoctorDepartment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select Department";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(12, 159);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(120, 39);
            this.btnGen.TabIndex = 14;
            this.btnGen.Text = "Make List";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Visible = false;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnSaved
            // 
            this.btnSaved.Location = new System.Drawing.Point(669, 185);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(119, 23);
            this.btnSaved.TabIndex = 27;
            this.btnSaved.Text = "View All Saved";
            this.btnSaved.UseVisualStyleBackColor = true;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // DoctorReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaved);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstBxDepart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lstBxDocREv);
            this.Controls.Add(this.label1);
            this.Name = "DoctorReview";
            this.Text = "DoctorReview";
            this.Load += new System.EventHandler(this.DoctorReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReviewDoctorDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBxDocREv;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstBxDepart;
        private System.Windows.Forms.Label label3;
        private DataSet.DataSetReviewDoctorDepartment dataSetReviewDoctorDepartment;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DataSet.DataSetReviewDoctorDepartmentTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnSaved;
    }
}