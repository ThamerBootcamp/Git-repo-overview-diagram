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

        Point start = new Point(200, 500);
        
        public void init()
        {
            int offsetMultiplier = 1;
            DigramStart startLine = new DigramStart(start.X, start.Y);
            digram.Add(startLine);

            Link link = new Link(start.X, start.Y + (startLine.rect.Height / 2), offset);
            digram.Add(link);
            
            int currentX = start.X+offset;

            for(int index =0; index < 3; index++ ,offsetMultiplier++)
            {
                if (index == 0)
                    currentX = start.X + offset;
                else
                    currentX += shapeWidth + offset; 
                
                currentShape = new CommitDraw("3f9ade", currentX, start.Y - (startLine.rect.Height / 2), shapeWidth, shapeWidth);
                digram.Add(currentShape);
                if (index ==1) // if branch points to it
                {
                    currentShape = new BranchDraw("main", currentX, start.Y  - yOffset - shapeWidth/2 - startLine.rect.Height/2, shapeWidth,shapeWidth/2);
                    digram.Add(currentShape);

                    link = new Link(currentX+shapeWidth/2 , start.Y - yOffset - (startLine.rect.Height / 2), 10, yOffset);
                    digram.Add(link);

                }

                if (!(index + 1 == 3))
                {
                    link = new Link(currentX + shapeWidth, start.Y + (startLine.rect.Height / 2), offset);
                    digram.Add(link);
                }
            }

            //currentShape = new Commit("679fe4", start.X+ shapeWidth + offset*2, start.Y - (startLine.rect.Height / 2));
            digram.Add(currentShape);
        }

        private void getBranches()
        {
            List<List<string>> remoteBranches = new List<List<string>>();

            //List<string> remoteBranches = new List<string>();
            List<string> commits = new List<string>();
            try
            {
                using (var repo = new Repository(@"c:/Users/Thamer/Desktop/Git/miniPaint"))
                {
                    foreach (var commit in repo.Commits)
                    {
                        commits.Add(commit.Id.ToString().Substring(0, 7));
                    }
     
                    foreach (var branch in repo.Branches)
                    {
                        if (branch.IsRemote)
                        {
                            //List<string>

                            Console.WriteLine("branch: " + branch.FriendlyName);
                            foreach (var commit in branch.Commits)
                            {
                                Console.WriteLine(
                                    $"{commit.Id.ToString().Substring(0, 7)} " +
                                    $"{commit.Author.When.ToLocalTime()} " +
                                    $"{commit.MessageShort} " +
                                    $"{commit.Author.Name}");

                            }
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                var res = MessageBox.Show(ex.ToString()) ;
            }

        }

        
        public List<GitShapes> getGitShapes() 
        {

            return digram;
        }
    }
}
/*
 
                Console.WriteLine("----branches----");

                    var branches = repo.Branches;
                    foreach (var b in branches)
                    {
                        Console.WriteLine(b.FriendlyName);
                    }
                    Console.WriteLine("----Head----");

                    var head = repo.Head;
                    Console.WriteLine(head.FriendlyName);

                    Console.WriteLine("----Commits----");
                    foreach (var commit in repo.Commits)
                    {
                        Console.WriteLine(
                            $"{commit.Id.ToString().Substring(0, 7)} " +
                            $"{commit.Author.When.ToLocalTime()} " +
                            $"{commit.MessageShort} " +
                            $"{commit.Author.Name}");
                    }

                    Console.WriteLine("---- latest commit----");

                    var lastCommit = repo.Head.Tip;
                    Console.WriteLine($"Commit Full ID: {lastCommit.Id}");
                    Console.WriteLine($"Message: {lastCommit.MessageShort}");
                    Console.WriteLine($"Author: {lastCommit.Author.Name}");
                    Console.WriteLine($"Time: {lastCommit.Author.When.ToLocalTime()}");
 */