namespace SchoolSystemProject.Forms.Attendance
{
    partial class AddAttendance
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
            label5 = new Label();
            label6 = new Label();
            grdtext = new TextBox();
            sstext = new TextBox();
            addBtn = new Button();
            label4 = new Label();
            stdtext = new TextBox();
            label1 = new Label();
            label7 = new Label();
            notestext = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 272);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 73;
            label5.Text = "Grade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 213);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 72;
            label6.Text = "Session ID";
            // 
            // grdtext
            // 
            grdtext.Location = new Point(214, 265);
            grdtext.Name = "grdtext";
            grdtext.Size = new Size(125, 27);
            grdtext.TabIndex = 71;
            // 
            // sstext
            // 
            sstext.Location = new Point(214, 206);
            sstext.Name = "sstext";
            sstext.Size = new Size(125, 27);
            sstext.TabIndex = 70;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Maroon;
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(590, 225);
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
            label4.Location = new Point(43, 155);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 66;
            label4.Text = "Student ID";
            // 
            // stdtext
            // 
            stdtext.Location = new Point(214, 148);
            stdtext.Name = "stdtext";
            stdtext.Size = new Size(125, 27);
            stdtext.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(270, 46);
            label1.Name = "label1";
            label1.Size = new Size(296, 38);
            label1.TabIndex = 62;
            label1.Text = "Add New Attendance";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 331);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 75;
            label7.Text = "Notes";
            // 
            // notestext
            // 
            notestext.Location = new Point(214, 324);
            notestext.Name = "notestext";
            notestext.Size = new Size(125, 27);
            notestext.TabIndex = 74;
            // 
            // AddAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(notestext);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(grdtext);
            Controls.Add(sstext);
            Controls.Add(addBtn);
            Controls.Add(label4);
            Controls.Add(stdtext);
            Controls.Add(label1);
            Name = "AddAttendance";
            Text = "AddAttendance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label6;
        private TextBox grdtext;
        private TextBox sstext;
        private Button addBtn;
        private Label label4;
        private TextBox stdtext;
        private Label label1;
        private Label label7;
        private TextBox notestext;
    }
}