namespace SchoolSystemProject.Forms
{
    partial class UpdateStudent
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
            searchBtn = new Button();
            label1 = new Label();
            idtext = new TextBox();
            firstntext = new TextBox();
            lastntext = new TextBox();
            phonetext = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            updateBtn = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(351, 106);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(125, 27);
            searchTxt.TabIndex = 5;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.Maroon;
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(367, 178);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 4;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(239, 31);
            label1.Name = "label1";
            label1.Size = new Size(332, 38);
            label1.TabIndex = 3;
            label1.Text = "Please Insert Student ID";
            // 
            // idtext
            // 
            idtext.Location = new Point(181, 239);
            idtext.Name = "idtext";
            idtext.Size = new Size(125, 27);
            idtext.TabIndex = 6;
            // 
            // firstntext
            // 
            firstntext.Location = new Point(181, 289);
            firstntext.Name = "firstntext";
            firstntext.Size = new Size(125, 27);
            firstntext.TabIndex = 7;
            // 
            // lastntext
            // 
            lastntext.Location = new Point(181, 331);
            lastntext.Name = "lastntext";
            lastntext.Size = new Size(125, 27);
            lastntext.TabIndex = 8;
            // 
            // phonetext
            // 
            phonetext.Location = new Point(181, 388);
            phonetext.Name = "phonetext";
            phonetext.Size = new Size(125, 27);
            phonetext.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 239);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 10;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 292);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 11;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 395);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 13;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 338);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 12;
            label5.Text = "Last Name";
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Maroon;
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(554, 305);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 29);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(438, 365);
            label6.Name = "label6";
            label6.Size = new Size(340, 31);
            label6.TabIndex = 15;
            label6.Text = "Student Updated Successfully!";
            // 
            // UpdateStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(updateBtn);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(phonetext);
            Controls.Add(lastntext);
            Controls.Add(firstntext);
            Controls.Add(idtext);
            Controls.Add(searchTxt);
            Controls.Add(searchBtn);
            Controls.Add(label1);
            Name = "UpdateStudent";
            Text = "UpdateStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTxt;
        private Button searchBtn;
        private Label label1;
        private TextBox idtext;
        private TextBox firstntext;
        private TextBox lastntext;
        private TextBox phonetext;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button updateBtn;
        private Label label6;
    }
}