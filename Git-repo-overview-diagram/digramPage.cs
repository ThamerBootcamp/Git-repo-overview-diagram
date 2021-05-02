using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMShapes;
namespace Git_repo_overview_diagram
{
    public partial class digramPage : UserControl
    {
        public List<GitShapes> shapes;
        public ManageGit gitRepo = new ManageGit();
        
        private float penSize = 4;
        public static Color penColor = System.Drawing.Color.Black; //System.Windows.Media.Color.FromRgb(0, 0, 0); 
        private System.Drawing.Drawing2D.DashStyle penStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        public digramPage()
        {
            InitializeComponent();
            gitRepo.init();
            
        }
        
        
        private void drawingBoard_Paint(object sender, PaintEventArgs e)
        {
            
            base.OnPaint(e);
            Graphics g = e.Graphics;
            shapes = gitRepo.getGitShapes();

            foreach (var shape in this.shapes)
                shape.draw(g);

            drawingBoard.Invalidate();

        }
    }
}
