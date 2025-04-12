namespace SchoolSystemProject.Forms.Departments
{
    partial class UpdateDepartment
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
            mngrtext = new TextBox();
            locationtext = new TextBox();
            nametext = new TextBox();
            updateBtn = new Button();
            searchTxt = new TextBox();
            searchBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 342);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 60;
            label4.Text = "Manager ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 285);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 59;
            label5.Text = "Department Location";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 239);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 58;
            label3.Text = "Department Name";
            // 
            // mngrtext
            // 
            mngrtext.Location = new Point(200, 335);
            mngrtext.Name = "mngrtext";
            mngrtext.Size = new Size(125, 27);
            mngrtext.TabIndex = 56;
            // 
            // locationtext
            // 
            locationtext.Location = new Point(200, 278);
            locationtext.Name = "locationtext";
            locationtext.Size = new Size(125, 27);
            locationtext.TabIndex = 55;
            // 
            // nametext
            // 
            nametext.Location = new Point(200, 236);
            nametext.Name = "nametext";
            nametext.Size = new Size(125, 27);
            nametext.TabIndex = 54;
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
            label1.Location = new Point(188, 32);
            label1.Name = "label1";
            label1.Size = new Size(389, 38);
            label1.TabIndex = 48;
            label1.Text = "Please Insert Department ID";
            // 
            // UpdateDepartment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(mngrtext);
            Controls.Add(locationtext);
            Controls.Add(nametext);
            Controls.Add(updateBtn);
            Controls.Add(searchTxt);
            Controls.Add(searchBtn);
            Controls.Add(label1);
            Name = "UpdateDepartment";
            Text = "UpdateDepartment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private Label label3;
        private TextBox mngrtext;
        private TextBox locationtext;
        private TextBox nametext;
        private Button updateBtn;
        private TextBox searchTxt;
        private Button searchBtn;
        private Label label1;
    }
}