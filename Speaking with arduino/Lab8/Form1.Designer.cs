
namespace Lab8
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
            this.xInput = new System.Windows.Forms.TextBox();
            this.yInput = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.returnedPointLbl = new System.Windows.Forms.Label();
            this.lockStateToolStripStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(208, 119);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(100, 22);
            this.xInput.TabIndex = 2;
            // 
            // yInput
            // 
            this.yInput.Location = new System.Drawing.Point(208, 153);
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(100, 22);
            this.yInput.TabIndex = 3;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(184, 227);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // returnedPointLbl
            // 
            this.returnedPointLbl.AutoSize = true;
            this.returnedPointLbl.Location = new System.Drawing.Point(429, 176);
            this.returnedPointLbl.Name = "returnedPointLbl";
            this.returnedPointLbl.Size = new System.Drawing.Size(46, 17);
            this.returnedPointLbl.TabIndex = 5;
            this.returnedPointLbl.Text = "label3";
            // 
            // lockStateToolStripStatusLabel
            // 
            this.lockStateToolStripStatusLabel.AutoSize = true;
            this.lockStateToolStripStatusLabel.Location = new System.Drawing.Point(12, 424);
            this.lockStateToolStripStatusLabel.Name = "lockStateToolStripStatusLabel";
            this.lockStateToolStripStatusLabel.Size = new System.Drawing.Size(46, 17);
            this.lockStateToolStripStatusLabel.TabIndex = 6;
            this.lockStateToolStripStatusLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lockStateToolStripStatusLabel);
            this.Controls.Add(this.returnedPointLbl);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label returnedPointLbl;
        private System.Windows.Forms.Label lockStateToolStripStatusLabel;
    }
}

