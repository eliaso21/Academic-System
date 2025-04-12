namespace SchoolSystemProject.Forms
{
    partial class FirstPage
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
            StudentsGrid = new DataGridView();
            StudentsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).BeginInit();
            SuspendLayout();
            // 
            // StudentsGrid
            // 
            StudentsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsGrid.Location = new Point(12, 12);
            StudentsGrid.Name = "StudentsGrid";
            StudentsGrid.RowHeadersWidth = 51;
            StudentsGrid.Size = new Size(439, 330);
            StudentsGrid.TabIndex = 0;
            // 
            // StudentsLabel
            // 
            StudentsLabel.AutoSize = true;
            StudentsLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentsLabel.ForeColor = Color.FromArgb(192, 0, 0);
            StudentsLabel.Location = new Point(474, 161);
            StudentsLabel.Name = "StudentsLabel";
            StudentsLabel.Size = new Size(305, 31);
            StudentsLabel.TabIndex = 1;
            StudentsLabel.Text = "All the ITI Current Students";
            // 
            // FirstPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StudentsLabel);
            Controls.Add(StudentsGrid);
            Name = "FirstPage";
            Text = "FirstPage";
            ((System.ComponentModel.ISupportInitialize)StudentsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StudentsGrid;
        private Label StudentsLabel;
    }
}