using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_repo_overview_diagram
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Git_repo_overview_diagram.digramPage DigramPage { get { return digramPage1; } }
        public Form1()
        {
            InitializeComponent();
            digramPage1.shapes = new List<GitShapes>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            digramPage1.Show();
        }
    }
}
