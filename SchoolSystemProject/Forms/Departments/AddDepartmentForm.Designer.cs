namespace SchoolSystemProject.Forms.Departments
{
    partial class AddDepartmentForm
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
            mngrtext = new TextBox();
            addBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            Locationtext = new TextBox();
            nametext = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 296);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 49;
            label7.Text = "Manager ID";
            // 
            // mngrtext
            // 
            mngrtext.Location = new Point(202, 289);
            mngrtext.Name = "mngrtext";
            mngrtext.Size = new Size(125, 27);
            mngrtext.TabIndex = 48;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Maroon;
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(578, 217);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 29);
            addBtn.TabIndex = 47;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 242);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 46;
            label4.Text = "Department Location";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 183);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 44;
            label3.Text = "Department Name";
            // 
            // Locationtext
            // 
            Locationtext.Location = new Point(202, 235);
            Locationtext.Name = "Locationtext";
            Locationtext.Size = new Size(125, 27);
            Locationtext.TabIndex = 42;
            // 
            // nametext
            // 
            nametext.Location = new Point(202, 176);
            nametext.Name = "nametext";
            nametext.Size = new Size(125, 27);
            nametext.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(274, 39);
            label1.Name = "label1";
            label1.Size = new Size(306, 38);
            label1.TabIndex = 38;
            label1.Text = "Add New Department";
            // 
            // AddDepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(mngrtext);
            Controls.Add(addBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Locationtext);
            Controls.Add(nametext);
            Controls.Add(label1);
            Name = "AddDepartmentForm";
            Text = "AddDepartmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox mngrtext;
        private Button addBtn;
        private Label label4;
        private Label label3;
        private TextBox Locationtext;
        private TextBox nametext;
        private Label label1;
    }
}