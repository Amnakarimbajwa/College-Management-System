namespace COLLEGEACTIVITY
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.admissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upgradeSemesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeachersInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "COLLEGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "MANAGEMENT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "SYSTEM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(466, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 247);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 22);
            this.textBox2.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(180, 171);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 37);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "username";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admissionToolStripMenuItem,
            this.feesToolStripMenuItem,
            this.studentDetailsToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitSystemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // admissionToolStripMenuItem
            // 
            this.admissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdmissionToolStripMenuItem,
            this.upgradeSemesterToolStripMenuItem});
            this.admissionToolStripMenuItem.Name = "admissionToolStripMenuItem";
            this.admissionToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.admissionToolStripMenuItem.Text = "Admission";
            // 
            // newAdmissionToolStripMenuItem
            // 
            this.newAdmissionToolStripMenuItem.Name = "newAdmissionToolStripMenuItem";
            this.newAdmissionToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.newAdmissionToolStripMenuItem.Text = "New Admission";
            this.newAdmissionToolStripMenuItem.Click += new System.EventHandler(this.newAdmissionToolStripMenuItem_Click);
            // 
            // upgradeSemesterToolStripMenuItem
            // 
            this.upgradeSemesterToolStripMenuItem.Name = "upgradeSemesterToolStripMenuItem";
            this.upgradeSemesterToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.upgradeSemesterToolStripMenuItem.Text = "Upgrade Semester";
            this.upgradeSemesterToolStripMenuItem.Click += new System.EventHandler(this.upgradeSemesterToolStripMenuItem_Click);
            // 
            // feesToolStripMenuItem
            // 
            this.feesToolStripMenuItem.Name = "feesToolStripMenuItem";
            this.feesToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.feesToolStripMenuItem.Text = "Fees";
            this.feesToolStripMenuItem.Click += new System.EventHandler(this.feesToolStripMenuItem_Click);
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStudentsToolStripMenuItem,
            this.individualDetailsToolStripMenuItem});
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            // 
            // searchStudentsToolStripMenuItem
            // 
            this.searchStudentsToolStripMenuItem.Name = "searchStudentsToolStripMenuItem";
            this.searchStudentsToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.searchStudentsToolStripMenuItem.Text = "Search Students";
            this.searchStudentsToolStripMenuItem.Click += new System.EventHandler(this.searchStudentsToolStripMenuItem_Click);
            // 
            // individualDetailsToolStripMenuItem
            // 
            this.individualDetailsToolStripMenuItem.Name = "individualDetailsToolStripMenuItem";
            this.individualDetailsToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.individualDetailsToolStripMenuItem.Text = "Individual Details";
            this.individualDetailsToolStripMenuItem.Click += new System.EventHandler(this.individualDetailsToolStripMenuItem_Click);
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeachersInformationToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.teachersToolStripMenuItem.Text = "Teachers";
            // 
            // addTeachersInformationToolStripMenuItem
            // 
            this.addTeachersInformationToolStripMenuItem.Name = "addTeachersInformationToolStripMenuItem";
            this.addTeachersInformationToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.addTeachersInformationToolStripMenuItem.Text = "Add Teachers Information";
            this.addTeachersInformationToolStripMenuItem.Click += new System.EventHandler(this.addTeachersInformationToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // exitSystemToolStripMenuItem
            // 
            this.exitSystemToolStripMenuItem.Name = "exitSystemToolStripMenuItem";
            this.exitSystemToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.exitSystemToolStripMenuItem.Text = "Exit System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COLLEGEACTIVITY.Properties.Resources.magdalene_college_library;
            this.ClientSize = new System.Drawing.Size(981, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem admissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upgradeSemesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeachersInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitSystemToolStripMenuItem;
    }
}

