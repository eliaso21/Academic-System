namespace SchoolSystemProject.Forms.Attendance
{
    partial class UpdateAttendance
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
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            notestext = new TextBox();
            grdtext = new TextBox();
            sstext = new TextBox();
            stdtext = new TextBox();
            updateBtn = new Button();
            searchTxt = new TextBox();
            searchBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 377);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 74;
            label4.Text = "Notes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 320);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 73;
            label5.Text = "Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 274);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 72;
            label3.Text = "Session ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 221);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 71;
            label2.Text = "Student ID";
            // 
            // notestext
            // 
            notestext.Location = new Point(206, 370);
            notestext.Name = "notestext";
            notestext.Size = new Size(125, 27);
            notestext.TabIndex = 70;
            // 
            // grdtext
            // 
            grdtext.Location = new Point(206, 313);
            grdtext.Name = "grdtext";
            grdtext.Size = new Size(125, 27);
            grdtext.TabIndex = 69;
            // 
            // sstext
            // 
            sstext.Location = new Point(206, 271);
            sstext.Name = "sstext";
            sstext.Size = new Size(125, 27);
            sstext.TabIndex = 68;
            // 
            // stdtext
            // 
            stdtext.Location = new Point(206, 221);
            stdtext.Name = "stdtext";
            stdtext.Size = new Size(125, 27);
            stdtext.TabIndex = 67;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Maroon;
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(542, 299);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 66;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(339, 100);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(125, 27);
            searchTxt.TabIndex = 65;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.Maroon;
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(355, 172);
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
            label1.Location = new Point(206, 25);
            label1.Name = "label1";
            label1.Size = new Size(379, 38);
            label1.TabIndex = 63;
            label1.Text = "Please Insert Attendance ID";
            // 
            // UpdateAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(notestext);
            Controls.Add(grdtext);
            Controls.Add(sstext);
            Controls.Add(stdtext);
            Controls.Add(updateBtn);
            Controls.Add(searchTxt);
            Controls.Add(searchBtn);
            Controls.Add(label1);
            Name = "UpdateAttendance";
            Text = "UpdateAttendance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox notestext;
        private TextBox grdtext;
        private TextBox sstext;
        private TextBox stdtext;
        private Button updateBtn;
        private TextBox searchTxt;
        private Button searchBtn;
        private Label label1;
    }
}