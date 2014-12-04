using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing;

namespace CrossStitch
{
    public partial class Form1 : Form
    {
        Random random;

        int panelWidth;
        int panelHeight;

        int cellWidth;

        Stitch stitch;

        Color selectedColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            random = new Random();
            panelWidth = panelMain.Width;
            panelHeight = panelMain.Height;
            cellWidth = 10;
            selectedColor = Color.White;

            stitch = new Stitch(80, 80);
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            
            int x = coordinates.X / 10;
            int y = coordinates.Y / 10;

            Console.WriteLine(x + "," + y);
            stitch.stitchCells[x,y] = selectedColor;

            panelMain.Invalidate(); // call this to redraw
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            Render(e.Graphics);
        }

        private void Render(System.Drawing.Graphics g)
        {
            var darkGrey = new Pen(Color.FromArgb(255, Color.Black),1);
            var grey = new Pen(Color.FromArgb(85, Color.Black),1);

            using (g)
            {
                for (int sX = 0; sX < stitch.Width; sX++)
                {
                    for (int sY = 0; sY < stitch.Width; sY++)
                    {
                        g.FillRectangle(new SolidBrush(stitch.stitchCells[sX, sY]), (sX * cellWidth) + 1, (sY * cellWidth) + 1, 9, 9);
                    }
                }

                //g.FillRectangle(new SolidBrush(Color.Blue), 31, 21, 9, 9);

                for (int i = 0; i < 100; i++)
                {
                    //g.DrawRectangle(grey, new Rectangle(25, 25, 20, 20));
                    if (i % 10 != 0)
                    {
                        g.DrawLine(grey, i * cellWidth, 0, // main lines vertical
                            i * cellWidth, 800);
                        g.DrawLine(grey, 0, i * cellWidth, // main lines horizontal
                            800, i * cellWidth); 
                    }
                    else
                    {
                        g.DrawLine(darkGrey, i * cellWidth, 0, // interval lines vertical
                            i * cellWidth, 800);
                        g.DrawLine(darkGrey, 0, i * cellWidth, // interval lines horizontal
                            800, i * cellWidth); 
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;

            colorDialog.ShowHelp = false;

            colorDialog.Color = Color.Blue;

            if (colorDialog.ShowDialog() == DialogResult.OK)
                selectedColor = colorDialog.Color;

            panelColour1.BackColor = selectedColor;

        }

        private void panelColour1_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour1.BackColor;
        }

        private void panelColour2_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour2.BackColor;
        }

        private void panelColour3_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour3.BackColor;
        }

        private void panelColour4_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour4.BackColor;
        }
    }
}
