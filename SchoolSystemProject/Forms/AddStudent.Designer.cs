namespace SchoolSystemProject.Forms
{
    partial class AddStudent
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
            label1 = new Label();
            addBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            phonetext = new TextBox();
            lastntext = new TextBox();
            firstntext = new TextBox();
            idtext = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(274, 24);
            label1.Name = "label1";
            label1.Size = new Size(249, 38);
            label1.TabIndex = 7;
            label1.Text = "Add New Student";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Maroon;
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(544, 203);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 24;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 293);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 23;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 236);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 22;
            label5.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 190);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 21;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 137);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 20;
            label2.Text = "ID";
            // 
            // phonetext
            // 
            phonetext.Location = new Point(171, 286);
            phonetext.Name = "phonetext";
            phonetext.Size = new Size(125, 27);
            phonetext.TabIndex = 19;
            // 
            // lastntext
            // 
            lastntext.Location = new Point(171, 229);
            lastntext.Name = "lastntext";
            lastntext.Size = new Size(125, 27);
            lastntext.TabIndex = 18;
            // 
            // firstntext
            // 
            firstntext.Location = new Point(171, 187);
            firstntext.Name = "firstntext";
            firstntext.Size = new Size(125, 27);
            firstntext.TabIndex = 17;
            // 
            // idtext
            // 
            idtext.Location = new Point(171, 137);
            idtext.Name = "idtext";
            idtext.Size = new Size(125, 27);
            idtext.TabIndex = 16;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addBtn);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(phonetext);
            Controls.Add(lastntext);
            Controls.Add(firstntext);
            Controls.Add(idtext);
            Controls.Add(label1);
            Name = "AddStudent";
            Text = "AddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addBtn;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox phonetext;
        private TextBox lastntext;
        private TextBox firstntext;
        private TextBox idtext;
    }
}