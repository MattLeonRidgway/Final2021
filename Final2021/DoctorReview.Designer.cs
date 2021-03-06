
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstBxDocREv = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSelectSave = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnSaveForms = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstBxDepart = new System.Windows.Forms.ListBox();
            this.lstBxClinic = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.lstBxDocREv.Location = new System.Drawing.Point(177, 53);
            this.lstBxDocREv.Name = "lstBxDocREv";
            this.lstBxDocREv.Size = new System.Drawing.Size(405, 290);
            this.lstBxDocREv.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(370, 349);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(76, 41);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSelectSave
            // 
            this.btnSelectSave.Location = new System.Drawing.Point(481, 349);
            this.btnSelectSave.Name = "btnSelectSave";
            this.btnSelectSave.Size = new System.Drawing.Size(103, 41);
            this.btnSelectSave.TabIndex = 3;
            this.btnSelectSave.Text = "Select and Save";
            this.btnSelectSave.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(44, 411);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(695, 320);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(75, 23);
            this.btnEmail.TabIndex = 5;
            this.btnEmail.Text = "Email Forms";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // btnSaveForms
            // 
            this.btnSaveForms.Location = new System.Drawing.Point(695, 280);
            this.btnSaveForms.Name = "btnSaveForms";
            this.btnSaveForms.Size = new System.Drawing.Size(75, 23);
            this.btnSaveForms.TabIndex = 6;
            this.btnSaveForms.Text = "Save Forms";
            this.btnSaveForms.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(144, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(236, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstBxDepart
            // 
            this.lstBxDepart.FormattingEnabled = true;
            this.lstBxDepart.Location = new System.Drawing.Point(33, 224);
            this.lstBxDepart.Name = "lstBxDepart";
            this.lstBxDepart.Size = new System.Drawing.Size(120, 30);
            this.lstBxDepart.TabIndex = 11;
            // 
            // lstBxClinic
            // 
            this.lstBxClinic.FormattingEnabled = true;
            this.lstBxClinic.Location = new System.Drawing.Point(33, 311);
            this.lstBxClinic.Name = "lstBxClinic";
            this.lstBxClinic.Size = new System.Drawing.Size(120, 30);
            this.lstBxClinic.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select Department";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Select Clinic";
            // 
            // DoctorReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstBxClinic);
            this.Controls.Add(this.lstBxDepart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveForms);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSelectSave);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lstBxDocREv);
            this.Controls.Add(this.label1);
            this.Name = "DoctorReview";
            this.Text = "DoctorReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBxDocREv;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSelectSave;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnSaveForms;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstBxDepart;
        private System.Windows.Forms.ListBox lstBxClinic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}