namespace SchoolSystemProject.Forms
{
    partial class DeleteStudent
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
            searchTxt = new TextBox();
            DeleteBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(354, 122);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(125, 27);
            searchTxt.TabIndex = 8;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Maroon;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(370, 194);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 29);
            DeleteBtn.TabIndex = 7;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(242, 47);
            label1.Name = "label1";
            label1.Size = new Size(332, 38);
            label1.TabIndex = 6;
            label1.Text = "Please Insert Student ID";
            // 
            // DeleteStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchTxt);
            Controls.Add(DeleteBtn);
            Controls.Add(label1);
            Name = "DeleteStudent";
            Text = "DeleteStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTxt;
        private Button DeleteBtn;
        private Label label1;
    }
}