namespace ProgramKadrowy
{
    partial class Main
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
            this.dgvEmployeesGrid = new System.Windows.Forms.DataGridView();
            this.btAddEmployee = new System.Windows.Forms.Button();
            this.btEditEmployee = new System.Windows.Forms.Button();
            this.btRefreshGridView = new System.Windows.Forms.Button();
            this.cbSortListIsActive = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeesGrid
            // 
            this.dgvEmployeesGrid.AllowUserToDeleteRows = false;
            this.dgvEmployeesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeesGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeesGrid.Location = new System.Drawing.Point(0, 42);
            this.dgvEmployeesGrid.Name = "dgvEmployeesGrid";
            this.dgvEmployeesGrid.RowHeadersVisible = false;
            this.dgvEmployeesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeesGrid.Size = new System.Drawing.Size(869, 420);
            this.dgvEmployeesGrid.TabIndex = 0;
            // 
            // btAddEmployee
            // 
            this.btAddEmployee.Location = new System.Drawing.Point(13, 13);
            this.btAddEmployee.Name = "btAddEmployee";
            this.btAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btAddEmployee.TabIndex = 1;
            this.btAddEmployee.Text = "Dodaj";
            this.btAddEmployee.UseVisualStyleBackColor = true;
            this.btAddEmployee.Click += new System.EventHandler(this.btAddEmployee_Click);
            // 
            // btEditEmployee
            // 
            this.btEditEmployee.Location = new System.Drawing.Point(126, 13);
            this.btEditEmployee.Name = "btEditEmployee";
            this.btEditEmployee.Size = new System.Drawing.Size(75, 23);
            this.btEditEmployee.TabIndex = 2;
            this.btEditEmployee.Text = "Edytuj";
            this.btEditEmployee.UseVisualStyleBackColor = true;
            this.btEditEmployee.Click += new System.EventHandler(this.btEditEmployee_Click);
            // 
            // btRefreshGridView
            // 
            this.btRefreshGridView.Location = new System.Drawing.Point(245, 13);
            this.btRefreshGridView.Name = "btRefreshGridView";
            this.btRefreshGridView.Size = new System.Drawing.Size(75, 23);
            this.btRefreshGridView.TabIndex = 3;
            this.btRefreshGridView.Text = "Odśwież";
            this.btRefreshGridView.UseVisualStyleBackColor = true;
            this.btRefreshGridView.Click += new System.EventHandler(this.btRefreshGridView_Click);
            // 
            // cbSortListIsActive
            // 
            this.cbSortListIsActive.FormattingEnabled = true;
            this.cbSortListIsActive.Location = new System.Drawing.Point(457, 12);
            this.cbSortListIsActive.Name = "cbSortListIsActive";
            this.cbSortListIsActive.Size = new System.Drawing.Size(121, 21);
            this.cbSortListIsActive.TabIndex = 4;
            this.cbSortListIsActive.SelectedIndexChanged += new System.EventHandler(this.cbSortListIsActive_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sortowanie";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(870, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSortListIsActive);
            this.Controls.Add(this.btRefreshGridView);
            this.Controls.Add(this.btEditEmployee);
            this.Controls.Add(this.btAddEmployee);
            this.Controls.Add(this.dgvEmployeesGrid);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program kadrowy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeesGrid;
        private System.Windows.Forms.Button btAddEmployee;
        private System.Windows.Forms.Button btEditEmployee;
        private System.Windows.Forms.Button btRefreshGridView;
        private System.Windows.Forms.ComboBox cbSortListIsActive;
        private System.Windows.Forms.Label label1;
    }
}

