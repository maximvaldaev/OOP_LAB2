namespace Лабораторная_работа__2
{
    partial class FormWorkWithImage
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.posMouseX = new System.Windows.Forms.ToolStripStatusLabel();
            this.posMouseY = new System.Windows.Forms.ToolStripStatusLabel();
            this.pathFile = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posMouseX,
            this.posMouseY,
            this.pathFile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // posMouseX
            // 
            this.posMouseX.Name = "posMouseX";
            this.posMouseX.Size = new System.Drawing.Size(69, 17);
            this.posMouseX.Text = "posMouseX";
            // 
            // posMouseY
            // 
            this.posMouseY.Name = "posMouseY";
            this.posMouseY.Size = new System.Drawing.Size(69, 17);
            this.posMouseY.Text = "posMouseY";
            // 
            // pathFile
            // 
            this.pathFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pathFile.Name = "pathFile";
            this.pathFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pathFile.Size = new System.Drawing.Size(647, 17);
            this.pathFile.Spring = true;
            this.pathFile.Text = "pathFile";
            // 
            // FormWorkWithImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormWorkWithImage";
            this.Text = "Работа с изображением";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel posMouseX;
        private System.Windows.Forms.ToolStripStatusLabel posMouseY;
        private System.Windows.Forms.ToolStripStatusLabel pathFile;

    }
}