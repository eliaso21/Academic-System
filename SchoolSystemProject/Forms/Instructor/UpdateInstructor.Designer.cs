namespace SchoolSystemProject.Forms.Instructor
{
    partial class UpdateInstructor
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
            deptext = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            phonetext = new TextBox();
            salarytext = new TextBox();
            lnametext = new TextBox();
            fnametext = new TextBox();
            updateBtn = new Button();
            searchTxt = new TextBox();
            searchBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 396);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 62;
            label7.Text = "Department ID";
            // 
            // deptext
            // 
            deptext.Location = new Point(200, 389);
            deptext.Name = "deptext";
            deptext.Size = new Size(125, 27);
            deptext.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 342);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 60;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 285);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 59;
            label5.Text = "Salary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 239);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 58;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 186);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 57;
            label2.Text = "First Name";
            // 
            // phonetext
            // 
            phonetext.Location = new Point(200, 335);
            phonetext.Name = "phonetext";
            phonetext.Size = new Size(125, 27);
            phonetext.TabIndex = 56;
            // 
            // salarytext
            // 
            salarytext.Location = new Point(200, 278);
            salarytext.Name = "salarytext";
            salarytext.Size = new Size(125, 27);
            salarytext.TabIndex = 55;
            // 
            // lnametext
            // 
            lnametext.Location = new Point(200, 236);
            lnametext.Name = "lnametext";
            lnametext.Size = new Size(125, 27);
            lnametext.TabIndex = 54;
            // 
            // fnametext
            // 
            fnametext.Location = new Point(200, 186);
            fnametext.Name = "fnametext";
            fnametext.Size = new Size(125, 27);
            fnametext.TabIndex = 53;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Maroon;
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(525, 308);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 51;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(322, 109);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(125, 27);
            searchTxt.TabIndex = 50;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.Maroon;
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(338, 181);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 49;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(210, 34);
            label1.Name = "label1";
            label1.Size = new Size(358, 38);
            label1.TabIndex = 48;
            label1.Text = "Please Insert Instructor ID";
            // 
            // UpdateInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(deptext);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(phonetext);
            Controls.Add(salarytext);
            Controls.Add(lnametext);
            Controls.Add(fnametext);
            Controls.Add(updateBtn);
            Controls.Add(searchTxt);
            Controls.Add(searchBtn);
            Controls.Add(label1);
            Name = "UpdateInstructor";
            Text = "UpdateInstructor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox deptext;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox phonetext;
        private TextBox salarytext;
        private TextBox lnametext;
        private TextBox fnametext;
        private Button updateBtn;
        private TextBox searchTxt;
        private Button searchBtn;
        private Label label1;
    }
}