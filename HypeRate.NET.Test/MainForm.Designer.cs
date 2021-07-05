
namespace HypeRate.NET.Test
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UnsubscribeButton = new System.Windows.Forms.Button();
            this.SubscribeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SessionIDInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HRLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UnsubscribeButton);
            this.groupBox1.Controls.Add(this.SubscribeButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SessionIDInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // UnsubscribeButton
            // 
            this.UnsubscribeButton.Location = new System.Drawing.Point(6, 97);
            this.UnsubscribeButton.Name = "UnsubscribeButton";
            this.UnsubscribeButton.Size = new System.Drawing.Size(360, 23);
            this.UnsubscribeButton.TabIndex = 5;
            this.UnsubscribeButton.TabStop = false;
            this.UnsubscribeButton.Text = "Unsubscribe";
            this.UnsubscribeButton.UseVisualStyleBackColor = true;
            this.UnsubscribeButton.Click += new System.EventHandler(this.UnsubscribeButton_Click);
            // 
            // SubscribeButton
            // 
            this.SubscribeButton.Location = new System.Drawing.Point(6, 68);
            this.SubscribeButton.Name = "SubscribeButton";
            this.SubscribeButton.Size = new System.Drawing.Size(360, 23);
            this.SubscribeButton.TabIndex = 4;
            this.SubscribeButton.TabStop = false;
            this.SubscribeButton.Text = "Subscribe";
            this.SubscribeButton.UseVisualStyleBackColor = true;
            this.SubscribeButton.Click += new System.EventHandler(this.SubscribeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Session ID (string):";
            // 
            // SessionIDInput
            // 
            this.SessionIDInput.Location = new System.Drawing.Point(6, 42);
            this.SessionIDInput.Name = "SessionIDInput";
            this.SessionIDInput.Size = new System.Drawing.Size(360, 20);
            this.SessionIDInput.TabIndex = 0;
            this.SessionIDInput.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HRLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // HRLabel
            // 
            this.HRLabel.AutoSize = true;
            this.HRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRLabel.ForeColor = System.Drawing.Color.Red;
            this.HRLabel.Location = new System.Drawing.Point(6, 41);
            this.HRLabel.Name = "HRLabel";
            this.HRLabel.Size = new System.Drawing.Size(24, 25);
            this.HRLabel.TabIndex = 9;
            this.HRLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "HR (int):";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 259);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "HypeRate.NET.Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UnsubscribeButton;
        private System.Windows.Forms.Button SubscribeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SessionIDInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label HRLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

