using System;

namespace COLLEGEACTIVITY
{
    partial class upgradesemester
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxTo = new System.Windows.Forms.ComboBox();
            this.ComboBoxFrom = new System.Windows.Forms.ComboBox();
            this.txtto = new System.Windows.Forms.Label();
            this.txtfrom = new System.Windows.Forms.Label();
            this.btnUpgrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::COLLEGEACTIVITY.Properties.Resources.th__1_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(298, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select semester for old students Admission";
            // 
            // ComboBoxTo
            // 
            this.ComboBoxTo.FormattingEnabled = true;
            this.ComboBoxTo.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th"});
            this.ComboBoxTo.Location = new System.Drawing.Point(322, 410);
            this.ComboBoxTo.Name = "ComboBoxTo";
            this.ComboBoxTo.Size = new System.Drawing.Size(208, 30);
            this.ComboBoxTo.TabIndex = 2;
            this.ComboBoxTo.Text = ".....select....";
            // 
            // ComboBoxFrom
            // 
            this.ComboBoxFrom.FormattingEnabled = true;
            this.ComboBoxFrom.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th"});
            this.ComboBoxFrom.Location = new System.Drawing.Point(322, 335);
            this.ComboBoxFrom.Name = "ComboBoxFrom";
            this.ComboBoxFrom.Size = new System.Drawing.Size(208, 30);
            this.ComboBoxFrom.TabIndex = 3;
            this.ComboBoxFrom.Text = "....select...";
            // 
            // txtto
            // 
            this.txtto.AutoSize = true;
            this.txtto.Location = new System.Drawing.Point(217, 418);
            this.txtto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(42, 22);
            this.txtto.TabIndex = 4;
            this.txtto.Text = "To:";
            // 
            // txtfrom
            // 
            this.txtfrom.AutoSize = true;
            this.txtfrom.Location = new System.Drawing.Point(217, 338);
            this.txtfrom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(71, 22);
            this.txtfrom.TabIndex = 5;
            this.txtfrom.Text = "From:";
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Location = new System.Drawing.Point(341, 493);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(143, 43);
            this.btnUpgrade.TabIndex = 6;
            this.btnUpgrade.Text = "UPGRADE";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // upgradesemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 645);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.ComboBoxFrom);
            this.Controls.Add(this.ComboBoxTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "upgradesemester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "upgradesemester";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxTo;
        private System.Windows.Forms.ComboBox ComboBoxFrom;
        private System.Windows.Forms.Label txtto;
        private System.Windows.Forms.Label txtfrom;
        private System.Windows.Forms.Button btnUpgrade;
    }
}