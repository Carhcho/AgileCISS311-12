
namespace dropbox13
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adviseeNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currentAdvisorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adviseeIdTextBox = new System.Windows.Forms.TextBox();
            this.newAdvisorComboBox = new System.Windows.Forms.ComboBox();
            this.findButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.Controls.Add(this.newAdvisorComboBox);
            this.groupBox1.Controls.Add(this.adviseeIdTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.currentAdvisorLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.adviseeNameLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Advisor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Advisee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Advisee Name:";
            // 
            // adviseeNameLabel
            // 
            this.adviseeNameLabel.AutoSize = true;
            this.adviseeNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adviseeNameLabel.Location = new System.Drawing.Point(386, 189);
            this.adviseeNameLabel.Name = "adviseeNameLabel";
            this.adviseeNameLabel.Size = new System.Drawing.Size(2, 15);
            this.adviseeNameLabel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current Advisor:";
            // 
            // currentAdvisorLabel
            // 
            this.currentAdvisorLabel.AutoSize = true;
            this.currentAdvisorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentAdvisorLabel.Location = new System.Drawing.Point(386, 241);
            this.currentAdvisorLabel.Name = "currentAdvisorLabel";
            this.currentAdvisorLabel.Size = new System.Drawing.Size(2, 15);
            this.currentAdvisorLabel.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Select Advisor:";
            // 
            // adviseeIdTextBox
            // 
            this.adviseeIdTextBox.Location = new System.Drawing.Point(309, 111);
            this.adviseeIdTextBox.Name = "adviseeIdTextBox";
            this.adviseeIdTextBox.Size = new System.Drawing.Size(180, 20);
            this.adviseeIdTextBox.TabIndex = 6;
            // 
            // newAdvisorComboBox
            // 
            this.newAdvisorComboBox.Enabled = false;
            this.newAdvisorComboBox.FormattingEnabled = true;
            this.newAdvisorComboBox.Location = new System.Drawing.Point(309, 289);
            this.newAdvisorComboBox.Name = "newAdvisorComboBox";
            this.newAdvisorComboBox.Size = new System.Drawing.Size(180, 21);
            this.newAdvisorComboBox.TabIndex = 7;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(538, 108);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 8;
            this.findButton.Text = "&Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(156, 403);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(538, 403);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Cl&ose";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ComboBox newAdvisorComboBox;
        private System.Windows.Forms.TextBox adviseeIdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label currentAdvisorLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label adviseeNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
    }
}