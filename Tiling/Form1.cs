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
    public partial class Form1 : Form
    {
        public enum kind
        {
            colorful,
            empty
        }
        public Form1()
        {
            InitializeComponent();
        }
        public class myButton : Button
        {
            //meke a new object that inherit from button
            //it is kind of button
            public int x;
            public int y;
        }
        class Page : Form
        {
            // [] colors = { };
            
                



            public void tile_Click(object sender, EventArgs e)
            {
                myButton btn = (myButton)sender;//sender send information of btn that click on it
                // we cast it to btn to behave with it like btn.
                empty = new myButton();
                btn.Tag = kind.empty;
                empty = btn;
                Label l = new Label();
                l.Location = new Point(10, 250);
                this.Controls.Add(l);
                l.Text = empty.y + "," +empty.x;
                btn.BackColor = Color.Black;
                
                tiling(num, buttons,empty,Color.White);

                //if you click on one btn it's color change to black and on Lable='a'
                // on the page write it's row and culomn
            }

            public int num;
            public myButton empty;
            public myButton[,] buttons;

            public static object Aqua { get; private set; }
            public static object Aquamarine { get; private set; }

            public void make(int m)// a method to make board and buttons
            {
                buttons = new myButton[m, m];
                for (int j = 0;j < m; j++)
                {
                    for (int i = 0; i < m; i++)
                    {
                        //make a btn and define Name size of btn and location of it.
                        buttons[j, i] = new myButton();//buttons[culomn,row]
                        buttons[j, i].x =i+1;
                        buttons[j, i].y = j+1;
                        buttons[j, i].Size = new Size(30, 30);
                        buttons[j, i].Location = new Point((j) * 30, (i) * 30);
                        // point(culomn , row) *it's diffent with what we think!!
                        this.Controls.Add(buttons[j, i]);// to add to form
                        buttons[j, i].Click += tile_Click;
                        buttons[j, i].Tag = kind.colorful;
                        //all the btn has event of tile_Click
                        //if click on one btn tile_Click happend.
                    }
                }
            }
           

            public void draw(myButton[,] matris, Color c)
            {
                //draw btn that are colorful kind and 
                //change the kind of btn empty to colorful
                // to draw in another step
                for (int j = 0; j < 2; j++)
                    for (int i = 0; i < 2; i++)
                    {
                        {
                            if ((kind)matris[j, i].Tag == kind.colorful)
                            {
                                matris[j, i].BackColor = c;
                            }
                            else
                                matris[j, i].Tag = kind.colorful;
                        }
                    }
            }
            public void tiling(int n,myButton[,] matris, myButton empty,Color c)
            {
                //Color c = Color.Red;
                //string s = c.ToString();
                //switch (s)
                //{
                //    case "Red":
                //        c = Color.Yellow;
                //        break;
                //    case "Black":
                //        c = Color.White;
                //        break;
                //    case "White":
                //        c = Color.Red;
                //        break;
                //    case "Yellow":
                //        c = Color.Purple;
                //        break;
                //    default:
                //        c = Color.Red;
                //        break;
                //}

                if (n == 2)
                {
                     draw(matris,c);
                }
                else
                {
                    int m = (int)n / 2;
                    myButton[,] part1= new myButton[m, m];
                    myButton[,] part2 = new myButton[m, m];
                    myButton[,] part3 = new myButton[m, m];
                    myButton[,] part4 = new myButton[m, m];
                 
                    //copy part1
                    for(int j=0;j<m;j++)
                        for(int i = 0;i<m;i++ )
                        {
                             part1[j, i] = matris[j, i];
                          //   part1[j, i].BackColor = Color.Azure;//to show where is part1

                        }
                    int k = n / 2 ;
                    //copy part2
                    for (int j = 0; j < n / 2; j++)
                    {
                        for (int i = 0; i < n / 2; i++)
                        {
                            part2[j, i] = matris[k, i];
                         //   part2[j, i].BackColor = Color.Blue;//to show where is part2
                        }
                        k++;
                    }
                    //copy part3
                    for (int j = 0; j < n / 2; j++)
                    {
                        k = n / 2;
                        for (int i = 0 ; i < n/2 ; i++)
                        {
                           part3[j, i] = matris[j,k];
                          // part3[j,i].BackColor = Color.Yellow;
                            k++;
                        }
                    }
                    //copy part4
                    int y = n / 2;
                    for (int j = 0; j < n / 2; j++)
                    {
                        k = n / 2;
                        for (int i = 0; i < n / 2; i++)
                        {
                            part4[j, i] = matris[y, k];
                           // part4[j,i].BackColor = Color.Green;
                            k++;
                        }
                        y++;
                    }

                    myButton empty1;
                    myButton empty2;
                    myButton empty3;
                    myButton empty4;
                    //check part1 to set empty1
                    if(empty.x <= part1[m-1,m-1].x && empty.y <= part1[m-1,m-1].y)
                    {
                        empty1 = empty;
                    }
                    else
                    {
                        empty1 = part1[m-1, m-1];
                        empty1.Tag = kind.empty;
                    }
                    //check part2 to set empty2
                    if (empty.x <= part2[m - 1, m - 1].x && empty.y >= part2[0,0].y)
                    {
                        empty2 = empty;
                    }
                    else
                    {
                        empty2 = part2[0, m-1];
                        empty2.Tag = kind.empty;
                    }
                    //check part3 to set empty3
                    if (empty.x >= part3[0,0].x && empty.y <= part3[m-1,m-1].y)
                    {
                        empty3 = empty;
                    }
                    else
                    {
                        empty3 = part3[m-1, 0];
                        empty3.Tag = kind.empty;
                    }
                    //check part4 to set empty4
                    if (empty.x >= part4[0,0].x && empty.y > part4[0,0].y)
                    {
                        empty4 = empty;
                    }
                    else
                    {
                        empty4 = part4[0, 0];
                        empty4.Tag = kind.empty;
                    }

                    n = (int)n / 2;
                    tiling(n, part1,empty1,Color.Coral);
                    tiling(n, part2,empty2,Color.Blue);
                    tiling(n, part3,empty3,Color.Yellow);
                    tiling(n, part4,empty4, Color.Green);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }
     
        private void makebtn_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(powBox.Text);
            Page p = new Page();
            p.Show();
            p.num = (int)Math.Pow(2, n);
            p.make(p.num);
            
        }

        private void maxProbtn_Click(object sender, EventArgs e)
        {
            MaxProduct pm = new MaxProduct();
            pm.Show();
        }
    }
}
