namespace ProgramKadrowy
{
    partial class AddEmployee
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
            this.tbEmployeeID = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWorkTemination = new System.Windows.Forms.Label();
            this.rtbRemarks = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpWorkTermination = new System.Windows.Forms.DateTimePicker();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.cbAgreementType = new System.Windows.Forms.ComboBox();
            this.cbIsActiveEmployee = new System.Windows.Forms.CheckBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEmployeeID
            // 
            this.tbEmployeeID.Location = new System.Drawing.Point(123, 12);
            this.tbEmployeeID.Name = "tbEmployeeID";
            this.tbEmployeeID.ReadOnly = true;
            this.tbEmployeeID.Size = new System.Drawing.Size(146, 20);
            this.tbEmployeeID.TabIndex = 0;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(123, 50);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(146, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(123, 81);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(146, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(123, 118);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(146, 20);
            this.tbSalary.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Imię";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wysokość zarobków";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data zatrudnienia";
            // 
            // lblWorkTemination
            // 
            this.lblWorkTemination.AllowDrop = true;
            this.lblWorkTemination.AutoSize = true;
            this.lblWorkTemination.Location = new System.Drawing.Point(11, 383);
            this.lblWorkTemination.Name = "lblWorkTemination";
            this.lblWorkTemination.Size = new System.Drawing.Size(151, 13);
            this.lblWorkTemination.TabIndex = 9;
            this.lblWorkTemination.Text = "Data zakończenia współpracy";
            // 
            // rtbRemarks
            // 
            this.rtbRemarks.Location = new System.Drawing.Point(14, 267);
            this.rtbRemarks.Name = "rtbRemarks";
            this.rtbRemarks.Size = new System.Drawing.Size(255, 96);
            this.rtbRemarks.TabIndex = 10;
            this.rtbRemarks.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Typ umowy";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Uwagi";
            // 
            // dtpWorkTermination
            // 
            this.dtpWorkTermination.Location = new System.Drawing.Point(14, 415);
            this.dtpWorkTermination.Name = "dtpWorkTermination";
            this.dtpWorkTermination.Size = new System.Drawing.Size(255, 20);
            this.dtpWorkTermination.TabIndex = 13;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(123, 154);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(146, 20);
            this.dtpHireDate.TabIndex = 14;
            // 
            // cbAgreementType
            // 
            this.cbAgreementType.FormattingEnabled = true;
            this.cbAgreementType.Location = new System.Drawing.Point(123, 192);
            this.cbAgreementType.Name = "cbAgreementType";
            this.cbAgreementType.Size = new System.Drawing.Size(146, 21);
            this.cbAgreementType.TabIndex = 15;
            // 
            // cbIsActiveEmployee
            // 
            this.cbIsActiveEmployee.AutoSize = true;
            this.cbIsActiveEmployee.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbIsActiveEmployee.Location = new System.Drawing.Point(151, 235);
            this.cbIsActiveEmployee.Name = "cbIsActiveEmployee";
            this.cbIsActiveEmployee.Size = new System.Drawing.Size(118, 17);
            this.cbIsActiveEmployee.TabIndex = 16;
            this.cbIsActiveEmployee.Text = "Aktywny pracownik";
            this.cbIsActiveEmployee.UseVisualStyleBackColor = true;
            this.cbIsActiveEmployee.CheckedChanged += new System.EventHandler(this.cbIsActiveEmployee_CheckedChanged);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(87, 460);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 17;
            this.btCancel.Text = "Anuluj";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(194, 460);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(75, 23);
            this.btConfirm.TabIndex = 18;
            this.btConfirm.Text = "Zatwierdź";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 500);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.cbIsActiveEmployee);
            this.Controls.Add(this.cbAgreementType);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.dtpWorkTermination);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbRemarks);
            this.Controls.Add(this.lblWorkTemination);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbEmployeeID);
            this.MaximumSize = new System.Drawing.Size(300, 539);
            this.MinimumSize = new System.Drawing.Size(300, 539);
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmployeeID;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWorkTemination;
        private System.Windows.Forms.RichTextBox rtbRemarks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpWorkTermination;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.ComboBox cbAgreementType;
        private System.Windows.Forms.CheckBox cbIsActiveEmployee;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btConfirm;
    }
}