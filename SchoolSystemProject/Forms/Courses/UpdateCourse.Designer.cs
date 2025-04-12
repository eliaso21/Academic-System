namespace SchoolSystemProject.Forms.Courses
{
    partial class UpdateCourse
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
            label6 = new Label();
            updateBtn = new Button();
            searchTxt = new TextBox();
            searchBtn = new Button();
            label1 = new Label();
            label7 = new Label();
            instext = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            deptext = new TextBox();
            durationtext = new TextBox();
            nametext = new TextBox();
            idtext = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(428, 367);
            label6.Name = "label6";
            label6.Size = new Size(329, 31);
            label6.TabIndex = 28;
            label6.Text = "Course Updated Successfully!";
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Maroon;
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(544, 307);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 27;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(341, 108);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(125, 27);
            searchTxt.TabIndex = 18;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.Maroon;
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(357, 180);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 17;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(229, 33);
            label1.Name = "label1";
            label1.Size = new Size(318, 38);
            label1.TabIndex = 16;
            label1.Text = "Please Insert Course ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(81, 395);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 47;
            label7.Text = "Instructor ID";
            // 
            // instext
            // 
            instext.Location = new Point(219, 388);
            instext.Name = "instext";
            instext.Size = new Size(125, 27);
            instext.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 341);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 45;
            label4.Text = "Department ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 284);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 44;
            label5.Text = "Course Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 238);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 43;
            label3.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 185);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 42;
            label2.Text = "ID";
            // 
            // deptext
            // 
            deptext.Location = new Point(219, 334);
            deptext.Name = "deptext";
            deptext.Size = new Size(125, 27);
            deptext.TabIndex = 41;
            // 
            // durationtext
            // 
            durationtext.Location = new Point(219, 277);
            durationtext.Name = "durationtext";
            durationtext.Size = new Size(125, 27);
            durationtext.TabIndex = 40;
            // 
            // nametext
            // 
            nametext.Location = new Point(219, 235);
            nametext.Name = "nametext";
            nametext.Size = new Size(125, 27);
            nametext.TabIndex = 39;
            // 
            // idtext
            // 
            idtext.Location = new Point(219, 185);
            idtext.Name = "idtext";
            idtext.Size = new Size(125, 27);
            idtext.TabIndex = 38;
            // 
            // UpdateCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(instext);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(deptext);
            Controls.Add(durationtext);
            Controls.Add(nametext);
            Controls.Add(idtext);
            Controls.Add(label6);
            Controls.Add(updateBtn);
            Controls.Add(searchTxt);
            Controls.Add(searchBtn);
            Controls.Add(label1);
            Name = "UpdateCourse";
            Text = "UpdateCourse";
            //Load += UpdateCourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button updateBtn;
        private TextBox searchTxt;
        private Button searchBtn;
        private Label label1;
        private Label label7;
        private TextBox instext;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox deptext;
        private TextBox durationtext;
        private TextBox nametext;
        private TextBox idtext;
    }
}