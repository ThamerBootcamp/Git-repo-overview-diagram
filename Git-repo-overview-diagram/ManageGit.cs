using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_repo_overview_diagram
{
    public class ManageGit
    {
        const int offset = 200;
        const int yOffset = offset / 2;
        const int shapeWidth = 300;
        List<GitShapes> digram = new List<GitShapes>();
        GitShapes currentShape;

        Point start = new Point(200, 700);
        
        public void init()
        {
            int offsetMultiplier = 1;
            int yMultiplier = 1;

            DigramStart startLine = new DigramStart(start.X, start.Y);
            digram.Add(startLine);

            Link link = new Link(start.X, start.Y + (startLine.rect.Height / 2), offset);
            digram.Add(link);
            
            int currentX = start.X+offset;

            //C:\Users\Thamer\source\repos\libgit2sharp_playground
            //C:\Users\Thamer\source\repos\UI-Project
            //c:/Users/Thamer/Desktop/Git/miniPaint
            using (var repo = new Repository(@"c:/Users/Thamer/Desktop/Git/miniPaint")) 
            {

                var commits = repo.Commits;
                var branches = repo.Branches;
                var head = repo.Head;

                for (int index = commits.Count()-1; index >= 0; index-- ,offsetMultiplier++)
                {
                    var commit = commits.ElementAt(index);
                    if (index == commits.Count() - 1)
                        currentX = start.X + offset;
                    else
                        currentX += shapeWidth + offset; 
                   
                    var currentY = start.Y  - startLine.rect.Height / 2;
                    //start.Y - (startLine.rect.Height / 2)
                    currentShape = new CommitDraw(commit.Id.ToString().Substring(0, 7), currentX, currentY, shapeWidth, shapeWidth);
                    digram.Add(currentShape);

                    yMultiplier = 1;
                    foreach (var branch in branches)
                    {
                        if (branch.IsRemote && branch.Tip == commit) 
                        {
                            //currentY -= yOffset - shapeWidth / 2;
                            currentShape = new BranchDraw("main", currentX, currentY - (yOffset + shapeWidth / 2) * yMultiplier, shapeWidth,shapeWidth/2);
                            digram.Add(currentShape);
                            link = new Link(currentX + shapeWidth/ 2, currentY - yOffset, 10, yOffset);
                           
                            //currentY-= -yOffset - shapeWidth ;
                            
                            digram.Add(link);
                            yMultiplier++; 
                            break;
                        }
                    }
                    if (head.Tip == commit)
                    {
                        //currentY -= start.Y - yOffset;
                        currentShape = new BranchDraw("Head", currentX, currentY-( yOffset  +shapeWidth / 2)*yMultiplier  , shapeWidth, shapeWidth / 2);
                        digram.Add(currentShape);
                        //yMultiplier++;

                        link = new Link(currentX + shapeWidth / 2, currentY -(yOffset* yMultiplier + shapeWidth/2)   , 10, yOffset);
                        digram.Add(link);
                    }

                    if (!(index == 0))
                    {
                        link = new Link(currentX + shapeWidth, start.Y + (startLine.rect.Height / 2), offset);
                        digram.Add(link);
                    }
                }
            }

            digram.Add(currentShape);
        }

        public List<GitShapes> getGitShapes() 
        {

            return digram;
        }
    }
}
