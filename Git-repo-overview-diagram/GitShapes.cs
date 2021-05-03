using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMShapes;

namespace Git_repo_overview_diagram
{
    public abstract class GitShapes : Shape
    {
       
    }
    /*
                 Shape cir = new Circle();
            cir.rect = new Rectangle(0, 0, 500, 500);
            temp.Add(cir);
     */
    public class CommitDraw : GitShapes
    {
        private string commitId;
        public CommitDraw(string commitID ,int x, int y, int width = 300, int height = 300)
        {
            this.commitId = commitID;
            this.rect.X = x;
            this.rect.Y = y;
            this.rect.Width = width;
            this.rect.Height = height;
            this.pen = new Pen(Color.Black, 3);
        }
        public CommitDraw(string commitID ,Pen pen,int x, int y, int width = 300, int height = 300)
        {
            this.rect.X = x;
            this.rect.Y = y;
            this.rect.Width = width;
            this.rect.Height = height;
            this.pen = pen;
        }
        public override void draw(Graphics g, bool isActive = false)
        {
            g.DrawEllipse(this.pen,this.rect);
            Font font = new Font("Times New Roman", 12.0f);
            g.DrawString("Commit: " + commitId, font, Brushes.Black,new Point(this.rect.Left + this.rect.Width/8, this.rect.Bottom));
        }
    }

    public class DigramStart : GitShapes
    {
     
        public DigramStart(int x, int y, int width = 10, int height = 150)
        {
            this.rect.X = x;
            this.rect.Y = y;
            this.rect.Width = width;
            this.rect.Height = height;
            this.brush = Brushes.Black;
            this.pen = new Pen(this.brush, 3);
        }
        public DigramStart(Pen pen, int x, int y, int width = 10, int height = 150)
        {
            this.rect.X = x;
            this.rect.Y = y;
            this.rect.Width = width;
            this.rect.Height = height;
            this.pen = pen;
            this.brush =pen.Brush;
        }
        public override void draw(Graphics g, bool isActive = false)
        {
            g.FillRectangle(this.pen.Brush, this.rect);

        }
    }

    public class Link : GitShapes
    {
        public Link(int x, int y, int width = 150, int height = 10)
        {
            this.rect.X = x;
            this.rect.Y = y;
            this.rect.Width = width;
            this.rect.Height = height;
            this.brush = Brushes.Black;
            this.pen = new Pen(this.brush, 3);
        }
        public Link(Pen pen, int x, int y, int width = 150, int height = 10)
        {
            this.rect.X = x;
            this.rect.Y = y;
            this.rect.Width = width;
            this.rect.Height = height;
            this.pen = pen;
            this.brush = pen.Brush;
        }
        public override void draw(Graphics g, bool isActive = false)
        {
            g.FillRectangle(this.pen.Brush, this.rect);

        }
    }
    public class BranchDraw : GitShapes
    {
        private string name;
        public BranchDraw(string name, int x, int y, int width = 300, int height = 150)
        {
            this.name = name;
            this.rect.X = x;
            this.rect.Y = y;
            this.rect.Width = width;
            this.rect.Height = height;
            this.pen = new Pen(Color.Black, 3);
        }
        public BranchDraw(string commitID, Pen pen, int x, int y, int width = 300, int height = 150)
        {
            this.rect.X = x;
            this.rect.Y = y;
            this.rect.Width = width;
            this.rect.Height = height;
            this.pen = pen;
        }
        public override void draw(Graphics g, bool isActive = false)
        {
            g.DrawRectangle(this.pen, this.rect);
            Font font = new Font("Times New Roman", 12.0f);
            g.DrawString( name, font, Brushes.Black, new Point(this.rect.Left + this.rect.Width / 3, this.rect.Top+ this.rect.Height/3));
        }
    }
}
