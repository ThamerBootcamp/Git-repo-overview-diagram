
namespace Git_repo_overview_diagram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.digramPage1 = new Git_repo_overview_diagram.digramPage();
            this.SuspendLayout();
            // 
            // digramPage1
            // 
            this.digramPage1.AutoScroll = true;
            this.digramPage1.AutoSize = true;
            this.digramPage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.digramPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digramPage1.Location = new System.Drawing.Point(0, 0);
            this.digramPage1.MinimumSize = new System.Drawing.Size(720, 480);
            this.digramPage1.Name = "digramPage1";
            this.digramPage1.Size = new System.Drawing.Size(1894, 1009);
            this.digramPage1.TabIndex = 0;
            this.digramPage1.Load += new System.EventHandler(this.digramPage1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.digramPage1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private digramPage digramPage1;
    }
}

