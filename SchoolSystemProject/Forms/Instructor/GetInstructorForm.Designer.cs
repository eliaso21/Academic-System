namespace SchoolSystemProject.Forms.Instructor
{
    partial class GetInstructorForm
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
            deptGrid = new DataGridView();
            searchTxt = new TextBox();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)deptGrid).BeginInit();
            SuspendLayout();
            // 
            // deptGrid
            // 
            deptGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            deptGrid.Location = new Point(110, 265);
            deptGrid.Name = "deptGrid";
            deptGrid.RowHeadersWidth = 51;
            deptGrid.Size = new Size(553, 100);
            deptGrid.TabIndex = 15;
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(319, 120);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(125, 27);
            searchTxt.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.ForeColor = Color.White;
            button1.Location = new Point(335, 192);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(206, 44);
            label1.Name = "label1";
            label1.Size = new Size(358, 38);
            label1.TabIndex = 12;
            label1.Text = "Please Insert Instructor ID";
            // 
            // GetInstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deptGrid);
            Controls.Add(searchTxt);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "GetInstructorForm";
            Text = "GetInstructorForm";
            ((System.ComponentModel.ISupportInitialize)deptGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView deptGrid;
        private TextBox searchTxt;
        private Button button1;
        private Label label1;
    }
}