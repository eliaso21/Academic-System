namespace SchoolSystemProject.Forms.CourseSession
{
    partial class AddSession
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
            label7 = new Label();
            crstext = new TextBox();
            addBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            instext = new TextBox();
            titletext = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 296);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 72;
            label6.Text = "Instructor Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 250);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 69;
            label7.Text = "Course ID";
            // 
            // crstext
            // 
            crstext.Location = new Point(224, 243);
            crstext.Name = "crstext";
            crstext.Size = new Size(125, 27);
            crstext.TabIndex = 68;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Maroon;
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(583, 196);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 67;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 196);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 66;
            label4.Text = "Session Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 137);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 65;
            label3.Text = "Session Title";
            // 
            // instext
            // 
            instext.Location = new Point(224, 296);
            instext.Name = "instext";
            instext.Size = new Size(125, 27);
            instext.TabIndex = 64;
            // 
            // titletext
            // 
            titletext.Location = new Point(224, 130);
            titletext.Name = "titletext";
            titletext.Size = new Size(125, 27);
            titletext.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(296, 52);
            label1.Name = "label1";
            label1.Size = new Size(243, 38);
            label1.TabIndex = 62;
            label1.Text = "Add New Session";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(171, 191);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 73;
            // 
            // AddSession
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(crstext);
            Controls.Add(addBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(instext);
            Controls.Add(titletext);
            Controls.Add(label1);
            Name = "AddSession";
            Text = "AddSession";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label7;
        private TextBox crstext;
        private Button addBtn;
        private Label label4;
        private Label label3;
        private TextBox instext;
        private TextBox titletext;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}