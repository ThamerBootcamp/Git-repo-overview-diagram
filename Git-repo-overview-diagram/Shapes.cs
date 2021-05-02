using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMShapes
{
    public abstract class Shape
    {
        public System.Drawing.Rectangle rect;
        public System.Drawing.Rectangle Top;
        public System.Drawing.Rectangle Left;
        public System.Drawing.Rectangle Right;
        public System.Drawing.Rectangle Down;
        public Brush brush;
        public Pen pen;
        public int selectOffset = 10;
        public int DotW = 8;
        public int DotH = 8;
        public Point Start;
        public Point End;

        public abstract void draw(Graphics g, bool isActive = false);
        public bool IsInside(Point p)
        {
            return (p.X >= rect.X &&
                p.X <= (rect.X + rect.Width) &&
                p.Y >= rect.Y &&
                p.Y <= (rect.Y + rect.Height));
        }
    }
    public class Circle : Shape
    {
        public Circle()
        {
            Brush brush = Brushes.Black ;
            this.brush = brush;
            this.pen= new Pen(this.brush, 4);
        }
        public override void draw(Graphics g, bool isActive)
        {

            g.DrawEllipse(this.pen, this.rect);
            if (isActive)
            {
                Pen p = new Pen(Brushes.Gray, 2);
                Pen smallRrectP = new Pen(Brushes.Red, 3);

                Brush fillBrush = Brushes.Red;
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                Rectangle selectRect = new Rectangle(rect.X - selectOffset, rect.Y - selectOffset, rect.Width + (2 * selectOffset), rect.Height + (2 * selectOffset));

                g.DrawRectangle(p, selectRect);


                System.Drawing.Rectangle centerDot = new System.Drawing.Rectangle((rect.X + rect.Width / 2) - DotW / 2, rect.Y + (rect.Height / 2) - DotH / 2, DotW, DotH);

                g.FillEllipse(fillBrush, centerDot);  //(start.X +(width - 10)/2, start.Y+ ( height+ 0)/2, 10, 10)); //center point

                this.Top = new Rectangle((selectRect.X - DotW / 2) + selectRect.Width / 2, selectRect.Y - DotH / 2, DotW, DotH);
                g.FillRectangle(fillBrush, Top); //Top

                this.Left = new Rectangle((selectRect.X - DotW / 2), (selectRect.Y - DotH / 2) + selectRect.Height / 2, DotW, DotH);
                g.FillRectangle(fillBrush, (selectRect.X - DotW / 2), (selectRect.Y - DotH / 2) + selectRect.Height / 2, DotW, DotH); //Left

                this.Right = new Rectangle((selectRect.X - DotW / 2) + selectRect.Width, (selectRect.Y - DotH / 2) + selectRect.Height / 2, DotW, DotH);
                g.FillRectangle(fillBrush, Right); //Ritght

                this.Down = new Rectangle((selectRect.X - DotW / 2) + selectRect.Width / 2, (selectRect.Y - DotH / 2) + selectRect.Height, DotW, DotH);
                g.FillRectangle(fillBrush, Down); //Down                                                                                                                                   

            }
        }

    }
    public class SRectangle : Shape
    {
        public SRectangle()
        {
            Brush brush = Brushes.Black;
            this.brush = brush;
            this.pen = new Pen(this.brush, 4);
        }
        public override void draw(Graphics g, bool isActive)
        {

            g.DrawRectangle(this.pen, this.rect);
            if (isActive)
            {
                Pen p = new Pen(Brushes.Gray, 2);
                Pen smallRrectP = new Pen(Brushes.Red, 3);

                Brush fillBrush = Brushes.Red;
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                Rectangle selectRect = new Rectangle(rect.X - selectOffset, rect.Y - selectOffset, rect.Width + (2 * selectOffset), rect.Height + (2 * selectOffset));

                g.DrawRectangle(p, selectRect);



                System.Drawing.Rectangle centerDot = new System.Drawing.Rectangle((rect.X + rect.Width / 2) - DotW / 2, rect.Y + (rect.Height / 2) - DotH / 2, DotW, DotH);

                g.FillEllipse(fillBrush, centerDot);  //(start.X +(width - 10)/2, start.Y+ ( height+ 0)/2, 10, 10)); //center point

                this.Top = new Rectangle((selectRect.X - DotW / 2) + selectRect.Width / 2, selectRect.Y - DotH / 2, DotW, DotH);
                g.FillRectangle(fillBrush, Top); //Top

                this.Left = new Rectangle((selectRect.X - DotW / 2), (selectRect.Y - DotH / 2) + selectRect.Height / 2, DotW, DotH);
                g.FillRectangle(fillBrush, (selectRect.X - DotW / 2), (selectRect.Y - DotH / 2) + selectRect.Height / 2, DotW, DotH); //Left

                this.Right = new Rectangle((selectRect.X - DotW / 2) + selectRect.Width, (selectRect.Y - DotH / 2) + selectRect.Height / 2, DotW, DotH);
                g.FillRectangle(fillBrush, Right); //Ritght

                this.Down = new Rectangle((selectRect.X - DotW / 2) + selectRect.Width / 2, (selectRect.Y - DotH / 2) + selectRect.Height, DotW, DotH);
                g.FillRectangle(fillBrush, Down); //Down                                                                                                                                   

            }
        }
    }
    public class Line : Shape
    {
        public Line()
        {
            Brush brush = Brushes.Black;
            this.brush = brush;
            this.pen = new Pen(this.brush, 4);
        }
        public override void draw(Graphics g, bool isActive)
        {
            g.DrawLine(this.pen, this.Start, this.End);
            if (isActive)
            {
                Pen p = new Pen(Brushes.Gray, 2);
                Pen smallRrectP = new Pen(Brushes.Red, 3);

                Brush fillBrush = Brushes.Red;
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                Rectangle selectRect = new Rectangle(rect.X - selectOffset, rect.Y - selectOffset, rect.Width + (2 * selectOffset), rect.Height + (2 * selectOffset));

                g.DrawRectangle(p, selectRect);



                System.Drawing.Rectangle centerDot = new System.Drawing.Rectangle((rect.X + rect.Width / 2) - DotW / 2, rect.Y + (rect.Height / 2) - DotH / 2, DotW, DotH);

                g.FillEllipse(fillBrush, centerDot);  //(start.X +(width - 10)/2, start.Y+ ( height+ 0)/2, 10, 10)); //center point

                this.Top = new Rectangle((selectRect.X - DotW / 2) + selectRect.Width / 2, selectRect.Y - DotH / 2, DotW, DotH);
                g.FillRectangle(fillBrush, Top); //Top

                this.Left = new Rectangle((selectRect.X - DotW / 2), (selectRect.Y - DotH / 2) + selectRect.Height / 2, DotW, DotH);
                g.FillRectangle(fillBrush, (selectRect.X - DotW / 2), (selectRect.Y - DotH / 2) + selectRect.Height / 2, DotW, DotH); //Left

                this.Right = new Rectangle((selectRect.X - DotW / 2) + selectRect.Width, (selectRect.Y - DotH / 2) + selectRect.Height / 2, DotW, DotH);
                g.FillRectangle(fillBrush, Right); //Ritght

                this.Down = new Rectangle((selectRect.X - DotW / 2) + selectRect.Width / 2, (selectRect.Y - DotH / 2) + selectRect.Height, DotW, DotH);
                g.FillRectangle(fillBrush, Down); //Down                                                                                                                                   

            }
        }
    }
}
