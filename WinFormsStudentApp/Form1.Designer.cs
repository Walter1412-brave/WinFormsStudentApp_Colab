namespace WinFormsStudentApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name=disposing>true if managed resources should be disposed; otherwise, false.</param>
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // lblStudentName
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(20, 20);
            this.lblStudentName.Name = lblStudentName;
            this.lblStudentName.Size = new System.Drawing.Size(85, 15);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = Student Name:;

            // txtStudentName
            this.txtStudentName.Location = new System.Drawing.Point(110, 17);
            this.txtStudentName.Name = txtStudentName;
            this.txtStudentName.Size = new System.Drawing.Size(150, 23);
            this.txtStudentName.TabIndex = 1;

            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();

            // lblCourseName
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(20, 50);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(81, 15);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "Course Name:";

            // txtCourseName
            this.txtCourseName.Location = new System.Drawing.Point(110, 47);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(150, 23);
            this.txtCourseName.TabIndex = 3;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Name = Form1;
            this.Text = Form1;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
