namespace SchoolSystemProject.Forms.Courses
{
    partial class AddCourseForm
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
            addBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            deptext = new TextBox();
            durationtext = new TextBox();
            nametext = new TextBox();
            idtext = new TextBox();
            label1 = new Label();
            label7 = new Label();
            instext = new TextBox();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Maroon;
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(555, 222);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 34;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 288);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 33;
            label4.Text = "Department ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 231);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 32;
            label5.Text = "Course Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 185);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 31;
            label3.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 132);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 30;
            label2.Text = "ID";
            // 
            // deptext
            // 
            deptext.Location = new Point(201, 281);
            deptext.Name = "deptext";
            deptext.Size = new Size(125, 27);
            deptext.TabIndex = 29;
            // 
            // durationtext
            // 
            durationtext.Location = new Point(201, 224);
            durationtext.Name = "durationtext";
            durationtext.Size = new Size(125, 27);
            durationtext.TabIndex = 28;
            // 
            // nametext
            // 
            nametext.Location = new Point(201, 182);
            nametext.Name = "nametext";
            nametext.Size = new Size(125, 27);
            nametext.TabIndex = 27;
            // 
            // idtext
            // 
            idtext.Location = new Point(201, 132);
            idtext.Name = "idtext";
            idtext.Size = new Size(125, 27);
            idtext.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(304, 59);
            label1.Name = "label1";
            label1.Size = new Size(235, 38);
            label1.TabIndex = 25;
            label1.Text = "Add New Course";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 342);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 37;
            label7.Text = "Instructor ID";
            // 
            // instext
            // 
            instext.Location = new Point(201, 335);
            instext.Name = "instext";
            instext.Size = new Size(125, 27);
            instext.TabIndex = 35;
            // 
            // AddCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(instext);
            Controls.Add(addBtn);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(deptext);
            Controls.Add(durationtext);
            Controls.Add(nametext);
            Controls.Add(idtext);
            Controls.Add(label1);
            Name = "AddCourseForm";
            Text = "AddCourseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox deptext;
        private TextBox durationtext;
        private TextBox nametext;
        private TextBox idtext;
        private Label label1;
        private Label label7;
        private TextBox instext;
    }
}