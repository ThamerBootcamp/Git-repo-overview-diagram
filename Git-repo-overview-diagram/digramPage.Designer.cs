
namespace Git_repo_overview_diagram
{
    partial class digramPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawingBoard = new Git_repo_overview_diagram.DrawingBoard();
            this.SuspendLayout();
            // 
            // drawingBoard
            // 
            this.drawingBoard.AutoScroll = true;
            this.drawingBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drawingBoard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawingBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.drawingBoard.Location = new System.Drawing.Point(0, 0);
            this.drawingBoard.MinimumSize = new System.Drawing.Size(100, 100);
            this.drawingBoard.Name = "drawingBoard";
            this.drawingBoard.Size = new System.Drawing.Size(3000, 2000);
            this.drawingBoard.TabIndex = 0;
            this.drawingBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingBoard_Paint);
            // 
            // digramPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.drawingBoard);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "digramPage";
            this.Size = new System.Drawing.Size(3000, 2000);
            this.ResumeLayout(false);

        }

        #endregion

        private DrawingBoard drawingBoard;
    }
}
