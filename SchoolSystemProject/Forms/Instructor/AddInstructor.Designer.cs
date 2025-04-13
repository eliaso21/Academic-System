namespace SchoolSystemProject.Forms.Instructor
{
    partial class AddInstructor
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
            label7 = new Label();
            phonetext = new TextBox();
            addBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            lnametext = new TextBox();
            fnametext = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            depttext = new TextBox();
            salarytext = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 237);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 57;
            label7.Text = "Phone";
            // 
            // phonetext
            // 
            phonetext.Location = new Point(208, 230);
            phonetext.Name = "phonetext";
            phonetext.Size = new Size(125, 27);
            phonetext.TabIndex = 56;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Maroon;
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(584, 217);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 55;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 183);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 54;
            label4.Text = "Instructor last_name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 124);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 53;
            label3.Text = "Instructor First_name";
            // 
            // lnametext
            // 
            lnametext.Location = new Point(208, 176);
            lnametext.Name = "lnametext";
            lnametext.Size = new Size(125, 27);
            lnametext.TabIndex = 52;
            // 
            // fnametext
            // 
            fnametext.Location = new Point(208, 117);
            fnametext.Name = "fnametext";
            fnametext.Size = new Size(125, 27);
            fnametext.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(280, 39);
            label1.Name = "label1";
            label1.Size = new Size(275, 38);
            label1.TabIndex = 50;
            label1.Text = "Add New Instructor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 342);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 61;
            label5.Text = "Department ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 283);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 60;
            label6.Text = "Salary";
            // 
            // depttext
            // 
            depttext.Location = new Point(208, 335);
            depttext.Name = "depttext";
            depttext.Size = new Size(125, 27);
            depttext.TabIndex = 59;
            // 
            // salarytext
            // 
            salarytext.Location = new Point(208, 276);
            salarytext.Name = "salarytext";
            salarytext.Size = new Size(125, 27);
            salarytext.TabIndex = 58;
            // 
            // AddInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(depttext);
            Controls.Add(salarytext);
            Controls.Add(label7);
            Controls.Add(phonetext);
            Controls.Add(addBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lnametext);
            Controls.Add(fnametext);
            Controls.Add(label1);
            Name = "AddInstructor";
            Text = "AddInstructor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox phonetext;
        private Button addBtn;
        private Label label4;
        private Label label3;
        private TextBox lnametext;
        private TextBox fnametext;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox depttext;
        private TextBox salarytext;
    }
}