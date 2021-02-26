
namespace Final2021
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDocAddEdit = new System.Windows.Forms.Button();
            this.btnAddEditNurse = new System.Windows.Forms.Button();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.btnDocRev = new System.Windows.Forms.Button();
            this.btnNurseRev = new System.Windows.Forms.Button();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Review";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 226);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDocAddEdit
            // 
            this.btnDocAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocAddEdit.Location = new System.Drawing.Point(57, 344);
            this.btnDocAddEdit.Name = "btnDocAddEdit";
            this.btnDocAddEdit.Size = new System.Drawing.Size(211, 38);
            this.btnDocAddEdit.TabIndex = 2;
            this.btnDocAddEdit.Text = "Doctor Add and Edit";
            this.btnDocAddEdit.UseVisualStyleBackColor = true;
            this.btnDocAddEdit.Click += new System.EventHandler(this.btnDocAddEdit_Click);
            // 
            // btnAddEditNurse
            // 
            this.btnAddEditNurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditNurse.Location = new System.Drawing.Point(489, 345);
            this.btnAddEditNurse.Name = "btnAddEditNurse";
            this.btnAddEditNurse.Size = new System.Drawing.Size(211, 38);
            this.btnAddEditNurse.TabIndex = 3;
            this.btnAddEditNurse.Text = "Nurse Add and Edit";
            this.btnAddEditNurse.UseVisualStyleBackColor = true;
            this.btnAddEditNurse.Click += new System.EventHandler(this.btnAddEditNurse_Click);
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInfo.Location = new System.Drawing.Point(239, 400);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(158, 38);
            this.btnAddInfo.TabIndex = 4;
            this.btnAddInfo.Text = "Add Information";
            this.btnAddInfo.UseVisualStyleBackColor = true;
            this.btnAddInfo.Click += new System.EventHandler(this.btnAddInfo_Click);
            // 
            // btnDocRev
            // 
            this.btnDocRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocRev.Location = new System.Drawing.Point(85, 299);
            this.btnDocRev.Name = "btnDocRev";
            this.btnDocRev.Size = new System.Drawing.Size(158, 38);
            this.btnDocRev.TabIndex = 5;
            this.btnDocRev.Text = "Doctor Review";
            this.btnDocRev.UseVisualStyleBackColor = true;
            this.btnDocRev.Click += new System.EventHandler(this.btnDocRev_Click);
            // 
            // btnNurseRev
            // 
            this.btnNurseRev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNurseRev.Location = new System.Drawing.Point(512, 300);
            this.btnNurseRev.Name = "btnNurseRev";
            this.btnNurseRev.Size = new System.Drawing.Size(158, 38);
            this.btnNurseRev.TabIndex = 6;
            this.btnNurseRev.Text = "Nurse Review";
            this.btnNurseRev.UseVisualStyleBackColor = true;
            this.btnNurseRev.Click += new System.EventHandler(this.btnNurseRev_Click);
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInfo.Location = new System.Drawing.Point(410, 400);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(158, 38);
            this.btnEditInfo.TabIndex = 7;
            this.btnEditInfo.Text = "Edit Information";
            this.btnEditInfo.UseVisualStyleBackColor = true;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(609, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 38);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditInfo);
            this.Controls.Add(this.btnNurseRev);
            this.Controls.Add(this.btnDocRev);
            this.Controls.Add(this.btnAddInfo);
            this.Controls.Add(this.btnAddEditNurse);
            this.Controls.Add(this.btnDocAddEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HOME";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDocAddEdit;
        private System.Windows.Forms.Button btnAddEditNurse;
        private System.Windows.Forms.Button btnAddInfo;
        private System.Windows.Forms.Button btnDocRev;
        private System.Windows.Forms.Button btnNurseRev;
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.Button btnExit;
    }
}

