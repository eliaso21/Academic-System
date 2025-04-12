namespace SchoolSystemProject.Forms
{
    partial class GetStudentForm
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
            label1 = new Label();
            button1 = new Button();
            searchTxt = new TextBox();
            studentGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)studentGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(248, 45);
            label1.Name = "label1";
            label1.Size = new Size(332, 38);
            label1.TabIndex = 0;
            label1.Text = "Please Insert Student ID";
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.ForeColor = Color.White;
            button1.Location = new Point(376, 192);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(360, 120);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(125, 27);
            searchTxt.TabIndex = 2;
            // 
            // studentGrid
            // 
            studentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGrid.Location = new Point(211, 280);
            studentGrid.Name = "studentGrid";
            studentGrid.RowHeadersWidth = 51;
            studentGrid.Size = new Size(429, 56);
            studentGrid.TabIndex = 3;
            // 
            // GetStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(studentGrid);
            Controls.Add(searchTxt);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "GetStudentForm";
            Text = "GetStudentForm";
            ((System.ComponentModel.ISupportInitialize)studentGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox searchTxt;
        private DataGridView studentGrid;
    }
}