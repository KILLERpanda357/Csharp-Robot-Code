
namespace Lab_7
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
            this.sourcePictureBox = new System.Windows.Forms.PictureBox();
            this.contourPictureBox = new System.Windows.Forms.PictureBox();
            this.shapeCountLbl = new System.Windows.Forms.Label();
            this.contourLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contourPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sourcePictureBox
            // 
            this.sourcePictureBox.Location = new System.Drawing.Point(12, 12);
            this.sourcePictureBox.Name = "sourcePictureBox";
            this.sourcePictureBox.Size = new System.Drawing.Size(317, 210);
            this.sourcePictureBox.TabIndex = 0;
            this.sourcePictureBox.TabStop = false;
            // 
            // contourPictureBox
            // 
            this.contourPictureBox.Location = new System.Drawing.Point(356, 12);
            this.contourPictureBox.Name = "contourPictureBox";
            this.contourPictureBox.Size = new System.Drawing.Size(325, 210);
            this.contourPictureBox.TabIndex = 1;
            this.contourPictureBox.TabStop = false;
            // 
            // shapeCountLbl
            // 
            this.shapeCountLbl.AutoSize = true;
            this.shapeCountLbl.Location = new System.Drawing.Point(49, 328);
            this.shapeCountLbl.Name = "shapeCountLbl";
            this.shapeCountLbl.Size = new System.Drawing.Size(46, 17);
            this.shapeCountLbl.TabIndex = 2;
            this.shapeCountLbl.Text = "label1";
            // 
            // contourLbl
            // 
            this.contourLbl.AutoSize = true;
            this.contourLbl.Location = new System.Drawing.Point(353, 328);
            this.contourLbl.Name = "contourLbl";
            this.contourLbl.Size = new System.Drawing.Size(46, 17);
            this.contourLbl.TabIndex = 3;
            this.contourLbl.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contourLbl);
            this.Controls.Add(this.shapeCountLbl);
            this.Controls.Add(this.contourPictureBox);
            this.Controls.Add(this.sourcePictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contourPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourcePictureBox;
        private System.Windows.Forms.PictureBox contourPictureBox;
        private System.Windows.Forms.Label shapeCountLbl;
        private System.Windows.Forms.Label contourLbl;
        private System.Windows.Forms.Label label1;
    }
}

