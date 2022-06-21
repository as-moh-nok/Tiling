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
    public partial class MaxProduct : Form
    {
        public MaxProduct()
        {
            InitializeComponent();

        }
         int num;
        TextBox[] boxes = new TextBox[50];
       
        public void startbtn_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(numBox.Text);
           // TextBox[] boxes = new TextBox[num];

            for (int i=0;i<num;i++)
            {
                boxes[i] = new TextBox();
                boxes[i].Size = new Size(30, 30);
                boxes[i].Location = new Point(40*i, 200);
                this.Controls.Add(boxes[i]);
                writebtn_Click(sender, e);
                
                
                 
            }
            txt.Text = "عدد آرایه ها را وارد کنید";
            //dobtn_Click(sender, e);

        }

        private void dobtn_Click(object sender, EventArgs e)
        {
            
            int num = Convert.ToInt16(numBox.Text);
            int[] numlist = new int[num];
            for (int i = 0; i < num; i++)
            {
               // boxes[i].Text="5" ;

                numlist[i] = Convert.ToInt16(boxes[i].Text);
                //try
                //{
                //    numlist[i] = Convert.ToInt16(boxes[i].Text);
                //}
                //catch (Exception)
                //{

                //    throw;
                //}

            }
            int currentMax = numlist[0];
            int currentMin = numlist[0];
            int preMax = numlist[0];
            int preMin = numlist[0];
            int ans = numlist[0];

            for (int i = 0; i < num; i++)
            {
                currentMax = Math.Max(Math.Max(preMax * numlist[i], preMin * numlist[i]), numlist[i]);
                currentMin = Math.Min(Math.Min(preMax * numlist[i], preMin * numlist[i]), numlist[i]);
                ans = Math.Max(ans, currentMax);
                preMax = currentMax;
                preMin = currentMin;
            }
            ansBox.Text = "جواب:" + ans;

        }

        private void writebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
