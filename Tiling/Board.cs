using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiling
{
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
        }
        
        private void Board_Load(object sender, EventArgs e)
        {
            panel1.Show();

            Button btn = new Button();
            btn.Size = new Size(30, 30);
            btn.Location = new Point(5, 5);
            panel1.Controls.Add(btn);
            Button btn2 = new Button();
            btn2.Size = new Size(30, 30);
            btn2.Location = new Point(40, 5);
            panel1.Controls.Add(btn2);
        }
    }
}
