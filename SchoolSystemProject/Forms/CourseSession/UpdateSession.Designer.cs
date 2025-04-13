namespace SchoolSystemProject.Forms.CourseSession
{
    partial class UpdateSession
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
            updateBtn = new Button();
            searchTxt = new TextBox();
            searchBtn = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            crstext = new TextBox();
            label4 = new Label();
            label3 = new Label();
            instext = new TextBox();
            titletext = new TextBox();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Maroon;
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(532, 305);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 66;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(329, 106);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(125, 27);
            searchTxt.TabIndex = 65;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.Maroon;
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(345, 178);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 64;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(217, 31);
            label1.Name = "label1";
            label1.Size = new Size(326, 38);
            label1.TabIndex = 63;
            label1.Text = "Please Insert Session ID";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(167, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 81;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 379);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 80;
            label6.Text = "Instructor Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 333);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 79;
            label7.Text = "Course ID";
            // 
            // crstext
            // 
            crstext.Location = new Point(220, 326);
            crstext.Name = "crstext";
            crstext.Size = new Size(125, 27);
            crstext.TabIndex = 78;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 279);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 77;
            label4.Text = "Session Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 220);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 76;
            label3.Text = "Session Title";
            // 
            // instext
            // 
            instext.Location = new Point(220, 379);
            instext.Name = "instext";
            instext.Size = new Size(125, 27);
            instext.TabIndex = 75;
            // 
            // titletext
            // 
            titletext.Location = new Point(220, 213);
            titletext.Name = "titletext";
            titletext.Size = new Size(125, 27);
            titletext.TabIndex = 74;
            // 
            // UpdateSession
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(crstext);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(instext);
            Controls.Add(titletext);
            Controls.Add(updateBtn);
            Controls.Add(searchTxt);
            Controls.Add(searchBtn);
            Controls.Add(label1);
            Name = "UpdateSession";
            Text = "UpdateSession";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button updateBtn;
        private TextBox searchTxt;
        private Button searchBtn;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label7;
        private TextBox crstext;
        private Label label4;
        private Label label3;
        private TextBox instext;
        private TextBox titletext;
    }
}