
namespace WindowsFormsApp1.Week5
{
    partial class Image_Processing_to_Black_and_White
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleThresoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryInvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaptivrThresoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guassianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.simpleThresoldToolStripMenuItem,
            this.adaptivrThresoldToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // simpleThresoldToolStripMenuItem
            // 
            this.simpleThresoldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.binaryInvertToolStripMenuItem,
            this.oTSuToolStripMenuItem});
            this.simpleThresoldToolStripMenuItem.Name = "simpleThresoldToolStripMenuItem";
            this.simpleThresoldToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.simpleThresoldToolStripMenuItem.Text = "Simple Thresold";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.binaryToolStripMenuItem.Text = "Binary";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // binaryInvertToolStripMenuItem
            // 
            this.binaryInvertToolStripMenuItem.Name = "binaryInvertToolStripMenuItem";
            this.binaryInvertToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.binaryInvertToolStripMenuItem.Text = "Binary Invert";
            this.binaryInvertToolStripMenuItem.Click += new System.EventHandler(this.binaryInvertToolStripMenuItem_Click);
            // 
            // oTSuToolStripMenuItem
            // 
            this.oTSuToolStripMenuItem.Name = "oTSuToolStripMenuItem";
            this.oTSuToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.oTSuToolStripMenuItem.Text = "OT\'Su";
            this.oTSuToolStripMenuItem.Click += new System.EventHandler(this.oTSuToolStripMenuItem_Click);
            // 
            // adaptivrThresoldToolStripMenuItem
            // 
            this.adaptivrThresoldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guassianToolStripMenuItem,
            this.meanToolStripMenuItem});
            this.adaptivrThresoldToolStripMenuItem.Name = "adaptivrThresoldToolStripMenuItem";
            this.adaptivrThresoldToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaptivrThresoldToolStripMenuItem.Text = "Adaptive Thresold";
            // 
            // guassianToolStripMenuItem
            // 
            this.guassianToolStripMenuItem.Name = "guassianToolStripMenuItem";
            this.guassianToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.guassianToolStripMenuItem.Text = "Guassian";
            this.guassianToolStripMenuItem.Click += new System.EventHandler(this.guassianToolStripMenuItem_Click);
            // 
            // meanToolStripMenuItem
            // 
            this.meanToolStripMenuItem.Name = "meanToolStripMenuItem";
            this.meanToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.meanToolStripMenuItem.Text = "Mean";
            this.meanToolStripMenuItem.Click += new System.EventHandler(this.meanToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 325);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(567, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 325);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Image_Processing_to_Black_and_White
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 462);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Image_Processing_to_Black_and_White";
            this.Text = "Image_Processing_to_Black_and_White";
            this.Load += new System.EventHandler(this.Image_Processing_to_Black_and_White_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleThresoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryInvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTSuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaptivrThresoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guassianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}