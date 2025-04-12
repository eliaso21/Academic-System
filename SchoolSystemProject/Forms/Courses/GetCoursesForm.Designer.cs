namespace SchoolSystemProject.Forms.Courses
{
    partial class GetCoursesForm
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
            CoursesGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CoursesGrid).BeginInit();
            SuspendLayout();
            // 
            // StudentsLabel
            // 
            StudentsLabel.AutoSize = true;
            StudentsLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentsLabel.ForeColor = Color.FromArgb(192, 0, 0);
            StudentsLabel.Location = new Point(248, 24);
            StudentsLabel.Name = "StudentsLabel";
            StudentsLabel.Size = new Size(294, 31);
            StudentsLabel.TabIndex = 3;
            StudentsLabel.Text = "All the ITI Current Courses";
            // 
            // CoursesGrid
            // 
            CoursesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoursesGrid.Location = new Point(78, 81);
            CoursesGrid.Name = "CoursesGrid";
            CoursesGrid.RowHeadersWidth = 51;
            CoursesGrid.Size = new Size(638, 347);
            CoursesGrid.TabIndex = 2;
            // 
            // GetCoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StudentsLabel);
            Controls.Add(CoursesGrid);
            Name = "GetCoursesForm";
            Text = "GetCoursesForm";
            ((System.ComponentModel.ISupportInitialize)CoursesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentsLabel;
        private DataGridView CoursesGrid;
    }
}