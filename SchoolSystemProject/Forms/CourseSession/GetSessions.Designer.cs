﻿namespace SchoolSystemProject.Forms.CourseSession
{
    partial class GetSessions
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
            StudentsLabel = new Label();
            DepartmentGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DepartmentGrid).BeginInit();
            SuspendLayout();
            // 
            // StudentsLabel
            // 
            StudentsLabel.AutoSize = true;
            StudentsLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentsLabel.ForeColor = Color.FromArgb(192, 0, 0);
            StudentsLabel.Location = new Point(226, 59);
            StudentsLabel.Name = "StudentsLabel";
            StudentsLabel.Size = new Size(301, 31);
            StudentsLabel.TabIndex = 9;
            StudentsLabel.Text = "All the ITI Current Sessions";
            // 
            // DepartmentGrid
            // 
            DepartmentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DepartmentGrid.Location = new Point(121, 117);
            DepartmentGrid.Name = "DepartmentGrid";
            DepartmentGrid.RowHeadersWidth = 51;
            DepartmentGrid.Size = new Size(542, 175);
            DepartmentGrid.TabIndex = 8;
            // 
            // GetSessions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StudentsLabel);
            Controls.Add(DepartmentGrid);
            Name = "GetSessions";
            Text = "GetSessions";
            ((System.ComponentModel.ISupportInitialize)DepartmentGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentsLabel;
        private DataGridView DepartmentGrid;
    }
}