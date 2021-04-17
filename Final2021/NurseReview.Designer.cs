
namespace Final2021
{
    partial class NurseReview
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
            this.lstBxNurseRev = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstBxDepart = new System.Windows.Forms.ListBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReviewDepartmentNurse = new Final2021.DataSetReviewDepartmentNurse();
            this.departmentTableAdapter = new Final2021.DataSetReviewDepartmentNurseTableAdapters.DepartmentTableAdapter();
            this.lstBxType = new System.Windows.Forms.ListBox();
            this.nurseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetNurse = new Final2021.DataSetNurse();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMakeList = new System.Windows.Forms.Button();
            this.nurseTypeTableAdapter = new Final2021.DataSetNurseTableAdapters.NurseTypeTableAdapter();
            this.btnSaved = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReviewDepartmentNurse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(273, 415);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lstBxNurseRev
            // 
            this.lstBxNurseRev.FormattingEnabled = true;
            this.lstBxNurseRev.Location = new System.Drawing.Point(167, 49);
            this.lstBxNurseRev.Name = "lstBxNurseRev";
            this.lstBxNurseRev.Size = new System.Drawing.Size(513, 342);
            this.lstBxNurseRev.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nurse Review List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 168);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(145, 34);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Nurse By Department";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(460, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(368, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Select Department";
            // 
            // lstBxDepart
            // 
            this.lstBxDepart.DataSource = this.departmentBindingSource;
            this.lstBxDepart.DisplayMember = "Department";
            this.lstBxDepart.FormattingEnabled = true;
            this.lstBxDepart.Location = new System.Drawing.Point(12, 65);
            this.lstBxDepart.Name = "lstBxDepart";
            this.lstBxDepart.Size = new System.Drawing.Size(145, 30);
            this.lstBxDepart.TabIndex = 20;
            this.lstBxDepart.ValueMember = "DepartmentID";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.dataSetReviewDepartmentNurse;
            // 
            // dataSetReviewDepartmentNurse
            // 
            this.dataSetReviewDepartmentNurse.DataSetName = "DataSetReviewDepartmentNurse";
            this.dataSetReviewDepartmentNurse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // lstBxType
            // 
            this.lstBxType.DataSource = this.nurseTypeBindingSource;
            this.lstBxType.DisplayMember = "Type";
            this.lstBxType.FormattingEnabled = true;
            this.lstBxType.Location = new System.Drawing.Point(12, 129);
            this.lstBxType.Name = "lstBxType";
            this.lstBxType.Size = new System.Drawing.Size(145, 30);
            this.lstBxType.TabIndex = 23;
            this.lstBxType.ValueMember = "TypeID";
            // 
            // nurseTypeBindingSource
            // 
            this.nurseTypeBindingSource.DataMember = "NurseType";
            this.nurseTypeBindingSource.DataSource = this.dataSetNurse;
            // 
            // dataSetNurse
            // 
            this.dataSetNurse.DataSetName = "DataSetNurse";
            this.dataSetNurse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Select Nurse Type";
            // 
            // btnMakeList
            // 
            this.btnMakeList.Location = new System.Drawing.Point(12, 209);
            this.btnMakeList.Name = "btnMakeList";
            this.btnMakeList.Size = new System.Drawing.Size(145, 28);
            this.btnMakeList.TabIndex = 25;
            this.btnMakeList.Text = "Make List";
            this.btnMakeList.UseVisualStyleBackColor = true;
            this.btnMakeList.Visible = false;
            this.btnMakeList.Click += new System.EventHandler(this.btnMakeList_Click);
            // 
            // nurseTypeTableAdapter
            // 
            this.nurseTypeTableAdapter.ClearBeforeFill = true;
            // 
            // btnSaved
            // 
            this.btnSaved.Location = new System.Drawing.Point(686, 179);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(102, 23);
            this.btnSaved.TabIndex = 26;
            this.btnSaved.Text = "View All Saved";
            this.btnSaved.UseVisualStyleBackColor = true;
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // NurseReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaved);
            this.Controls.Add(this.btnMakeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstBxDepart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lstBxNurseRev);
            this.Controls.Add(this.label1);
            this.Name = "NurseReview";
            this.Text = "NurseReview";
            this.Load += new System.EventHandler(this.NurseReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReviewDepartmentNurse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetNurse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ListBox lstBxNurseRev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBxDepart;
        private DataSetReviewDepartmentNurse dataSetReviewDepartmentNurse;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DataSetReviewDepartmentNurseTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.ListBox lstBxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMakeList;
        private DataSetNurse dataSetNurse;
        private System.Windows.Forms.BindingSource nurseTypeBindingSource;
        private DataSetNurseTableAdapters.NurseTypeTableAdapter nurseTypeTableAdapter;
        private System.Windows.Forms.Button btnSaved;
    }
}